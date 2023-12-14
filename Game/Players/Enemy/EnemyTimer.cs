using System;
using System.Windows.Forms;
using WFSeaBattleGame;

namespace WFSeaBattleGame
{
    public class EnemyTimer : Timer
    {
        private readonly Enemy _enemy;
        private readonly MapController _fieldController;
        private readonly GameForm _gameForm;
        private int _timerTicks = 0;

        public EnemyTimer(Enemy enemy, MapController fieldController, GameForm gameForm)
        {
            const int minimalTimerInterval = 1;
            Interval = minimalTimerInterval;
            Tick += new EventHandler(Timer_Tick);
            _enemy = enemy;
            _fieldController = fieldController;
            _gameForm = gameForm;
        }

        public void ResetTicks()
        {
            _timerTicks = 0;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            const int computerMovesSpeedCount = 4;
            int tickAmountFromSpeed = ((computerMovesSpeedCount - GameForm.UnitSign
                - _gameForm.GetComputerMoveSpeedSelectedIndex())
                * _fieldController.ButtonSize) + GameForm.UnitSign;
            if (_timerTicks == tickAmountFromSpeed)
            {
                _gameForm.SetLabelComputerMoveVisibility(visible: false);
                _enemy.ContinueTheAttack();
                _gameForm.SetComputerMovesToolStripsEnables(enable: true);
            }
            _timerTicks++;
        }
    }
}