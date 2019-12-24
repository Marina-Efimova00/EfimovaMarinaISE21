using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormLincor
{
    class Lincor : WarShip
    {
        public Color DopColor { private set; get; }
        /// Количество иллюменаторов 
        public int CountWindow { private set; get; }
        ///Количество орудий 
        public int Weapons { private set; get; }
        ///Количество кругов  дыма
        public int Smoke { private set; get; }
        public Lincor(int maxSpeed, float weight, Color mainColor, Color dopColor): base(maxSpeed, weight, mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
        }
        public Lincor(string info) : base(info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 4)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                DopColor = Color.FromName(strs[3]);
            }
        }
        public override void DrawLincor(Graphics g)
        {
            base.DrawLincor(g);
            SolidBrush blueBrush1 = new SolidBrush(Color.Green);
            g.FillRectangle(blueBrush1, _startPosX + 25, _startPosY + 25, 5, 10);
            g.FillRectangle(blueBrush1, _startPosX + 40, _startPosY + 20, 5, 15);
            Pen pen = new Pen(MainColor);
            g.DrawRectangle(pen, _startPosX + 25, _startPosY + 25, 5, 10);
            g.DrawRectangle(pen, _startPosX + 40, _startPosY + 20, 5, 15);
            Pen pen1 = new Pen(DopColor, 3);
            g.DrawEllipse(pen1, _startPosX + 30, _startPosY + 6, 7, 7);
            g.DrawEllipse(pen1, _startPosX + 20, _startPosY + 5, 5, 5);
            g.DrawEllipse(pen1, _startPosX + 10, _startPosY + 4, 5, 5);
            g.DrawEllipse(pen1, _startPosX, _startPosY, 5, 5);
            Pen greenPen = new Pen(Color.Black, 2);
            SolidBrush blueBrush2 = new SolidBrush(DopColor);
            g.FillRectangle(blueBrush2, _startPosX + 60, _startPosY + 27, 10, 8);
            g.DrawLine(greenPen, _startPosX + 68, _startPosY + 28, _startPosX + 77, _startPosY + 22);
            g.FillRectangle(blueBrush2, _startPosX + 75, _startPosY + 27, 10, 8);
            g.DrawLine(greenPen, _startPosX + 83, _startPosY + 28, _startPosX + 90, _startPosY + 22);
        }
         public void SetDopColor(Color color)
        {
            DopColor = color;
        }
        public override string ToString()
        {
            return base.ToString() + ";" + DopColor.Name;
        }
        public int CompareTo(Lincor other)
        {
            var res = (this is WarShip).CompareTo(other is WarShip);
            if (res != 0)
            {
                return res;
            }
            if (DopColor != other.DopColor)
            {
                DopColor.Name.CompareTo(other.DopColor.Name);
            }
            return 0;
        }
        public bool Equals(Lincor other)
        {
            var res = (this as WarShip).Equals(other as Lincor);
            if (!res)
            {
                return res;
            }
            if (GetType().Name != other.GetType().Name)
            {
                return false;
            }
            if (DopColor != other.DopColor)
            {
                return false;
            }
            return true;
        }
        public override bool Equals(Object obj)
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
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}

