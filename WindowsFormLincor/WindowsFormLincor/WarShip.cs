using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormLincor
{
    public class WarShip : Vehicle, IComparable<WarShip>, IEquatable<WarShip>
    {
        protected const int linWidth = 100;
        protected const int linHeight = 60;
        public WarShip(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }
        public WarShip(string info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 3)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
            }
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
        }
        public override string ToString()
        {
            return MaxSpeed + ";" + Weight + ";" + MainColor.Name;
        }
        public int CompareTo(WarShip other)
        {
            if (other == null)
            {
                return 1;
            }
            if (MaxSpeed != other.MaxSpeed)
            {
                return MaxSpeed.CompareTo(other.MaxSpeed);
            }
            if (Weight != other.Weight)
            {
                return Weight.CompareTo(other.Weight);
            }
            if (MainColor != other.MainColor)
            {
                MainColor.Name.CompareTo(other.MainColor.Name);
            }
            return 0;
        }        public bool Equals(WarShip other)
        {
            if (other == null)
            {
                return false;
            }
            if (GetType().Name != other.GetType().Name)
            {
                return false;
            }
            if (MaxSpeed != other.MaxSpeed)
            {
                return false;
            }
            if (Weight != other.Weight)
            {
                return false;
            }
            if (MainColor != other.MainColor)
            {
                return false;
            }
            return true;
        }        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is WarShip linObj))
            {
                return false;
            }
            else
            {
                return Equals(linObj);
            }
        }        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
