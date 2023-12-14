using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using WFSeaBattleGame.Game;

namespace WFSeaBattleGame.Game
{
    // класс корабля 
    public class Ship
    {
        private int _size;
        public List<MapButton> ShipDecks { get; set; } // палубы корабля
        public List<MapButton> MarkedDeckParts { get; set; } = new List<MapButton>(); // клетку вокруг корабля

        public Ship(List<MapButton> shipParts)
        {
            _size = shipParts.Count;
            ShipDecks = shipParts;
        }
        // получение урона
        public void TakeDamage()
        {
            if (_size != 0) _size--;
        }
        // проверка на уничтожение корабля
        public bool IsDead()
        {
            return _size == 0;
        }
        // После уничтожения корабля
        public void Death()
        {
            foreach (MapButton shipDeck in ShipDecks)
            {
                shipDeck.BackColor = Color.Red; // меняем цвет клеток поля
            }
            // отмечаем клетки вокруг корабля
            foreach (MapButton button in MarkedDeckParts)
            {
                if (button.IsShipPart) continue;
                button.IsShot = true;
                button.Text = MapButton.SymbolShotCell;
                button.Enabled = false;
            }
        }
    }
}