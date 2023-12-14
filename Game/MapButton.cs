using System.Windows.Forms;
using System.Drawing;
using WFSeaBattleGame;

namespace WFSeaBattleGame.Game
{
    // класс одной клеточки поля 
    public class MapButton : Button
    {
        private const string SymbolDamagedShip = "X"; // символ подбитого корабля
        public const string SymbolShotCell = "."; // символ простреленной клетки
        private bool _marked = false;
        public bool IsShipPart { get; set; } = false; // является ли клетка частью корабля
        public bool IsShot { get; set; } = false; // является ли клетка простреленной
        public Ship ShipPart { get; set; } // часть корабля
        public int X { get; set; } // координата X
        public int Y { get; set; } // Координата Y

        public MapButton(int x, int y)
        {
            X = x;
            Y = y;
        }
        // выстрел по клетке
        public void Shoot()
        {
            IsShot = true;
            Text = IsShipPart ? SymbolDamagedShip : SymbolShotCell;
        }
        // можно ли создать корабль
        public bool CanMakeShip()
        {
            return (!IsShipPart && !_marked);
        }
        //  отметка клеток
        public void Mark(Ship shipPart)
        {
            _marked = true;
            shipPart.MarkedDeckParts.Add(this);
        }
        // очистка клеток от меток
        public void RefreshMarking(bool mark)
        {
            if (!IsShipPart)
            {
                GameForm.ButtonColorToStandart(this);
                return;
            }
            if (IsShot)
            {
                if (ShipPart.IsDead()) { BackColor = Color.Red; }
                else
                {
                    if (mark) { BackColor = Color.DarkRed; }
                    else { BackColor = Color.Blue; }
                }
            }
        }
    }
}