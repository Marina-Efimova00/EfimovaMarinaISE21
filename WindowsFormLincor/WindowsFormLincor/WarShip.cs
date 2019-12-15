using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormLincor
{
    public class WarShip : Vehicle
    {
        protected const int linWidth = 100;
        protected const int linHeight = 60;
        public LincorCount Count { private set; get; }
        private int toolType;
        public WarShip(int maxSpeed, float weight, Color mainColor, LincorCount lincorCount)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            Count = lincorCount;
            toolType = new Random().Next(3);
        }
        public override void MoveTransport(Direction direction)
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
        public override void DrawLincor(Graphics g)
        {
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
            Pen greenPen = new Pen(Color.Gray, 2);
            SolidBrush blueBrush2 = new SolidBrush(Color.DarkGreen);
            SolidBrush blueBrush3 = new SolidBrush(Color.White);
            g.FillEllipse(blueBrush3, _startPosX + 20, _startPosY + 37, 5, 5);
            g.FillEllipse(blueBrush3, _startPosX + 35, _startPosY + 37, 5, 5);
            g.FillEllipse(blueBrush3, _startPosX + 55, _startPosY + 37, 5, 5);
            g.FillEllipse(blueBrush3, _startPosX + 70, _startPosY + 37, 5, 5);
            ITool dt;
            switch (toolType)
            {
                case 0:
                    dt = new DrawTool(Count, MainColor, Color.Yellow, (int)_startPosX, (int)_startPosY);
                    break;
                case 1:
                    dt = new DrawTool2(Count, MainColor, Color.Yellow, (int)_startPosX, (int)_startPosY);
                    break;
                case 2:
                    dt = new DrawTool3(Count, MainColor, Color.Yellow, (int)_startPosX, (int)_startPosY);
                    break;
                default:
                    dt = new DrawTool3(Count, MainColor, Color.Yellow, (int)_startPosX, (int)_startPosY);
                    break;
            }
            dt.DrawLin(g);
        }
    }
}
