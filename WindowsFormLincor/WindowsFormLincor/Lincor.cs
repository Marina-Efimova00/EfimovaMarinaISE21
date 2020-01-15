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
        public LincorCount Count { private set; get; }
        private int lincorType;
        public Lincor(int maxSpeed, float weight, Color mainColor, Color dopColor, LincorCount lincorCount) : base(maxSpeed, weight, mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            Count = lincorCount;
            lincorType = new Random().Next(3);
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
            g.DrawLine(greenPen, _startPosX + 68, _startPosY + 28, _startPosX + 77, _startPosY + 22);
            g.DrawLine(greenPen, _startPosX + 83, _startPosY + 28, _startPosX + 90, _startPosY + 22);
            ITool dtool;
            switch (lincorType)
            {
                case 0:
                    dtool = new DrawToolSquare(Count, (int)_startPosX, (int)_startPosY);
                    break;
                case 1:
                    dtool = new DrawToolCircle(Count, (int)_startPosX, (int)_startPosY);
                    break;
                case 2:
                    dtool = new DrawToolRectangle(Count, (int)_startPosX, (int)_startPosY);
                    break;
                default:
                    dtool = new DrawToolRectangle(Count,  (int)_startPosX, (int)_startPosY);
                    break;
            }
            dtool.DrawLin(g);
        }
         public void SetDopColor(Color color)
        {
            DopColor = color;
        }
        public void SetLincorType(int type)
        {
            lincorType = type;
        }
    }
}

