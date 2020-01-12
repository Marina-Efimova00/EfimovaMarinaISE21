using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormLincor
{
    class Lincor
    {
        private float _startPosX;
        private float _startPosY;
        private int _pictureWidth;
        private int _pictureHeight;
        private const int linWidth = 100;
        private const int linHeight = 60;
        public int MaxSpeed { private set; get; }
        public float Weight { private set; get; }
        public Color MainColor { private set; get; }
        public Color DopColor { private set; get; }
        public LincorCount Count { private get; set; }
        /// Количество иллюменаторов 
        public int CountWindow { private set; get; }
        ///Количество орудий 
        public int Weapons { private set; get; }
        ///Количество кругов  дыма
        public int Smoke { private set; get; }
        public Lincor(int maxSpeed, float weight, Color mainColor, Color dopColor, LincorCount lincorCount)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            Count = lincorCount;
        }
        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }
        public void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - linWidth)
                    {
                        _startPosX += step;
                    }
                    break;
                case Direction.Left:
                    if (_startPosX - step > 0)
                    {
                        _startPosX -= step;
                    }
                    break;
                case Direction.Up:
                    if (_startPosY - step > 0)
                    {
                        _startPosY -= step;
                    }
                    break;
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - linHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }
        public void DrawLincor(Graphics g)
        {
            DrawTool dt = new DrawTool(Count,(int)_startPosX, (int)_startPosY);
            dt.DrawLin(g);
            SolidBrush blueBrush = new SolidBrush(MainColor);
            Point point1 = new Point((int)_startPosX + 10, (int)_startPosY + 35);
            Point point2 = new Point((int)_startPosX + 110, (int)_startPosY + 35);
            Point point3 = new Point((int)_startPosX + 100, (int)_startPosY + 50);
            Point point4 = new Point((int)_startPosX + 20, (int)_startPosY + 50);
            Point point5 = new Point((int)_startPosX + 10, (int)_startPosY + 35);
            Point[] curvePoint = { point1, point2, point3, point4, point5 };
            g.FillPolygon(blueBrush, curvePoint);
            SolidBrush blueBrush1 = new SolidBrush(Color.Green);
            g.FillRectangle(blueBrush1, _startPosX + 30, _startPosY + 15, 10, 20);
            Pen pen = new Pen(MainColor);
            g.DrawRectangle(pen, _startPosX + 30, _startPosY + 15, 10, 20);
            Pen greenPen = new Pen(Color.FromArgb(255, 13, 99, 0), 2);
            SolidBrush blueBrush2 = new SolidBrush(Color.DarkGreen);
            SolidBrush blueBrush3 = new SolidBrush(Color.White);
            g.FillEllipse(blueBrush3, _startPosX + 20, _startPosY + 37, 5, 5);
            g.FillEllipse(blueBrush3, _startPosX + 35, _startPosY + 37, 5, 5);
            g.FillEllipse(blueBrush3, _startPosX + 55, _startPosY + 37, 5, 5);
            g.FillEllipse(blueBrush3, _startPosX + 70, _startPosY + 37, 5, 5);
            g.FillRectangle(blueBrush1, _startPosX + 25, _startPosY + 25, 5, 10);
            g.FillRectangle(blueBrush1, _startPosX + 40, _startPosY + 20, 5, 15);
            g.DrawRectangle(pen, _startPosX + 25, _startPosY + 25, 5, 10);
            g.DrawRectangle(pen, _startPosX + 40, _startPosY + 20, 5, 15);
            Pen pen1 = new Pen(Color.FromArgb(255, 194, 196, 196), 3);
            g.DrawEllipse(pen1, _startPosX + 30, _startPosY + 6, 7, 7);
            g.DrawEllipse(pen1, _startPosX + 20, _startPosY + 5, 5, 5);
            g.DrawEllipse(pen1, _startPosX + 10, _startPosY + 4, 5, 5);
            g.DrawEllipse(pen1, _startPosX, _startPosY, 5, 5);
        }
    }
}

