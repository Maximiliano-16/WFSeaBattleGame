using System.Collections.Generic;
using System.Drawing;
//using WFSeaBattleGame.Game.Players.Enemy;
//using WFSeaBattleGame.Game.Players;
using WFSeaBattleGame.Game;
using WFSeaBattleGame;
using System;

namespace WFSeaBattleGame
{
    public class User : Player
    {
        private Enemy _enemy;

        public User(GameForm gameForm) : base(gameForm)
        {
            const int userMarkingOffset = 0;
            _markingOffset = userMarkingOffset;
        }

        public void SetEnemy(Enemy enemy)
        {
            _enemy = enemy;
        }

        public void SetShip(MapButton senderShipButton)
        {
            List<Point> shipCoordinates = GetShipCoordinates(size: _gameForm.ChosenSize,
                senderShipButton.X, senderShipButton.Y,
                isHorizontal: _gameForm.IsSelectedShipHorizontal, randomShip: false);

            Ship newPlayerShip = DeclareShip(shipCoordinates);
            foreach (MapButton shipPart in newPlayerShip.ShipDecks)
                shipPart.BackColor = Color.Blue;

            foreach (var shipButton in newPlayerShip.ShipDecks)
                shipButton.Enabled = false;
            foreach (var shipButton in newPlayerShip.MarkedDeckParts)
                shipButton.Enabled = false;
        }

        public void UnableField()
        {
            foreach (MapButton button in Map)
                button.Enabled = false;
        }

        public void Attack(object sender)
        {
            bool canMove = !_gameForm.ComputerMovingLabelVisible;
            if (!canMove) return;
            _gameForm.SetFocus();
            MapButton senderButton = sender as MapButton;
            senderButton.Enabled = false;
            senderButton.Shoot();
            if (!senderButton.IsShipPart)
            {
                _gameForm.SetLabelStatus(GameForm.DefaultStatus,
                    GameForm.DefaultStatusColor);
                if (!_enemy.CheckDeath() && !CheckDeath()) _enemy.StartAttack();
                return;
            }
            senderButton.ShipPart.TakeDamage();
            _enemy.ShipDecksAlive--;
            _gameForm.SetLabelStatus("Подбит", Color.DarkRed);
            if (senderButton.ShipPart.IsDead())
            {
                _gameForm.SetLabelStatus("Убит", Color.Red);
                senderButton.ShipPart.Death();
            }
            _enemy.CheckDeath();
        }
    }
}