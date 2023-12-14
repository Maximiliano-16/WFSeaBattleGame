using System;
using System.Drawing;
//using WFSeaBattleGame.Game.Players.Enemy;
using WFSeaBattleGame.Game;
using WFSeaBattleGame;

namespace WFSeaBattleGame
{
    public class Enemy : Player
    {
        private readonly User _user;
        private readonly EnemyTimer _attackTimer;
        private readonly EnemyAI _enemyAI;
        private int _xToAttack = 0;
        private int _yToAttack = 0;
        public bool MarkMoves { get; set; } = true;

        public Enemy(GameForm gameForm, User user) : base(gameForm)
        {
            const int enemyMarkingOffset = 380;
            _markingOffset = enemyMarkingOffset;
            _user = user;
            Map = new MapButton[_mapSize, _mapSize];
            _attackTimer = new EnemyTimer(this, _mapController, gameForm);
            _enemyAI = new EnemyAI(this, _mapController);
        }

        public override void DeclareField()
        {
            _mapController.CreateMap(Map, _markingOffset);
            foreach (MapButton shipButton in Map)
            {
                shipButton.Click += new EventHandler(Button_Click);
                shipButton.TextChanged += new EventHandler(_gameForm.ShipButton_TextChanged);
            }
        }

        public void StartAttack()
        {
            _gameForm.SetComputerMovesToolStripsEnables(enable: false);
            _attackTimer.Start();
            _attackTimer.ResetTicks();
            _gameForm.SetLabelComputerMoveVisibility(visible: true);
        }

        public void ContinueTheAttack()
        {
            _enemyAI.SetAttackCoordinates(ref _xToAttack, ref _yToAttack);
            MapButton buttonToAttack = _user.Map[_xToAttack, _yToAttack];
            if (buttonToAttack.IsShot)
            {
                if (_enemyAI.HorizontalityDefined)
                    _enemyAI.ChangeDefinedAttackSide = true;
                if (_enemyAI.FoundUserShip)
                {
                    ContinueTheAttack();
                    return;
                }
            }
            Attack(buttonToAttack);
        }

        private void Attack(MapButton buttonToAttack)
        {
            buttonToAttack.Shoot();
            if (MarkMoves) buttonToAttack.BackColor = Color.DarkRed;
            if (!buttonToAttack.IsShipPart)
            {
                if (_enemyAI.HorizontalityDefined)
                    _enemyAI.ChangeDefinedAttackSide = true;
                _attackTimer.Stop();
                return;
            }
            if (_enemyAI.FoundUserShip) _enemyAI.HorizontalityDefined = true;
            _enemyAI.FoundUserShip = true;
            buttonToAttack.ShipPart.TakeDamage();
            _user.ShipDecksAlive--;
            if (buttonToAttack.ShipPart.IsDead())
            {
                buttonToAttack.ShipPart.Death();
                _enemyAI.ResetVariables();
                if (_user.CheckDeath()) return;
            }
            else _enemyAI.SetButtonsAroundButtonToAttack(buttonToAttack, _user.Map);
            StartAttack();
        }

        public void FinishGame()
        {
            foreach (MapButton button in Map)
            {
                if (button.IsShipPart) button.BackColor = Color.Red;
                button.Enabled = false;
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            _user.Attack(sender);
        }
    }
}