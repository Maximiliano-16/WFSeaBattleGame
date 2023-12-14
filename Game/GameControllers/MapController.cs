using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;
using WFSeaBattleGame.Game;
using WFSeaBattleGame;

namespace WFSeaBattleGame
{
    // класс отвечающий за создание и контроль поля
    public class MapController
    {
        public const int MapSize = 10; // размер поля
        private int _startX; // Начальная координата X
        private int _startY; // Начальна координата Y
        private const string EnglishAlphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"; // алфавит
        private const int UnitSign = GameForm.UnitSign; // Поле для 1        
        private readonly GameForm _gameForm; // основная форма игры
        private List<Point> _pointsAround; // координаты вокруг
        
        public int ZeroCoordinate { get; } = 0; // нулевая координата
        public int ButtonSize { get; } = 30; // размер кнопки поля
        public MapController(GameForm gameForm)
        {
            _gameForm = gameForm;
        }
        // создание игрового поля
        public void CreateMap(MapButton[,] map, int offset)
        {
            const int margin = 50;
            for (int y = 0; y < MapSize; y++)
            {
                for (int x = 0; x < MapSize; x++)
                {
                    int xMargin = margin + offset;
                    map[x, y] = new MapButton(x, y)
                    {
                        Location = new Point(x * ButtonSize + xMargin, y * ButtonSize + margin),
                        Size = new Size(ButtonSize, ButtonSize)
                    };
                    _gameForm.Controls.Add(map[x, y]);
                }
                AddMapEdges(y, offset);
            }
        }
        // удаление поля и освобождение рессурсов
        public void ClearField(MapButton[,] map)
        {
            foreach (MapButton button in map)
                button?.Dispose();
        }
        // являются ли кординаты частью поля
        public bool AreCoordinatesInsideMap(int coordinateX, int coordinateY)
        {
            return IsCoordinateInsideMap(coordinateX) && IsCoordinateInsideMap(coordinateY);
        }
        // является ли кордината частью поля
        public bool IsCoordinateInsideMap(int coordinate)
        {
            return coordinate >= ZeroCoordinate && coordinate < MapSize;
        }
        // получаем точки вокруг координат X и Y
        public List<Point> GetPointsAround(int coordinateX, int coordinateY)
        {
            int lastPoint = MapSize - UnitSign;
            _pointsAround = new List<Point>();
            _startX = coordinateX;
            _startY = coordinateY;
            ProcessCoordinate(lastPoint, isCoordinateX: true);
            ProcessCoordinate(lastPoint, isCoordinateX: false);
            return _pointsAround;
        }
        // Добавляем точки вокруг указанной координаты
        private void ProcessCoordinate(int lastCoordinate, bool isCoordinateX)
        {
            int currentCoordinate = isCoordinateX ? _startX : _startY;
            if (currentCoordinate > ZeroCoordinate)
                ProcessSpecificCoordinates(lastCoordinate, isCoordinateX, moveDownLeft: true);
            if (currentCoordinate < lastCoordinate)
                ProcessSpecificCoordinates(lastCoordinate, isCoordinateX, moveDownLeft: false);
        }
        // Добавляем точки вокруг указанной координаты c учётом смещения
        private void ProcessSpecificCoordinates(int lastCoordinate, bool isCoordinateX, bool moveDownLeft)
        {
            int x = _startX;
            int y = _startY;
            int offsetCoordinate = 0;
            if (isCoordinateX) { offsetCoordinate = x; }
            else { offsetCoordinate = y; }
            if (moveDownLeft) { offsetCoordinate += -UnitSign; }
            else { offsetCoordinate += UnitSign; }
            if (!isCoordinateX)
            {
                _pointsAround.Add(new Point(x, offsetCoordinate));
                return;
            }
            _pointsAround.Add(new Point(offsetCoordinate, y));
            if (y > ZeroCoordinate)
                _pointsAround.Add(new Point(offsetCoordinate, y - UnitSign));
            if (y < lastCoordinate)
                _pointsAround.Add(new Point(offsetCoordinate, y + UnitSign));
        }
        // Добавляем метки по краю карты
        private void AddMapEdges(int coord, int offset)
        {
            int btnSize = ButtonSize;
            int doubleBtnSize = btnSize * 2;
            int coordinateOffset = btnSize * coord;
            Label letterLabel = new Label
            {
                Location = new Point(doubleBtnSize + offset + coordinateOffset, btnSize),
                Text = Convert.ToString(EnglishAlphabet[coord]),
                AutoSize = true
            };
            Label numLabel = new Label
            {
                Location = new Point(btnSize + offset, doubleBtnSize + coordinateOffset),
                Text = Convert.ToString(coord + GameForm.UnitSign),
                AutoSize = true
            };
            _gameForm.Controls.Add(numLabel);
            _gameForm.Controls.Add(letterLabel);
        }
    }
}