using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormLincor
{
    class DrawToolRectangle : ITool
    {
        public float startPosX;
        public float startPosY;
        public DrawToolRectangle(float posX, float posY)
        {
            startPosX = posX;
            startPosY = posY;
        }
        public void DrawLin(Graphics g,LincorCount count)
        {
            SolidBrush greenBrush = new SolidBrush(Color.DarkGreen);
            Pen greenPen = new Pen(Color.FromArgb(255, 13, 99, 0), 2);
            int n = (int)count;
            g.FillRectangle(greenBrush, startPosX + 60, startPosY + 20, 10, 16);
            g.DrawLine(greenPen, startPosX + 68, startPosY + 28, startPosX + 77, startPosY + 22);
            if (n >= 2)
            {
                g.FillRectangle(greenBrush, startPosX + 75, startPosY + 20, 10, 16);
                g.DrawLine(greenPen, startPosX + 83, startPosY + 28, startPosX + 90, startPosY + 22);
            }
        }
    }
}
