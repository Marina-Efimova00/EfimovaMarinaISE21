using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormLincor
{
    class DrawToolCircle: ITool
    {
        public LincorCount Count { private set; get; }
        public int startPosX;
        public int startPosY;
        public DrawToolCircle(LincorCount linCount, int posX, int posY)
        {
            Count = linCount;
            startPosX = posX;
            startPosY = posY;
        }
        private int CountToInt(LincorCount linCount)
        {
            return (int)linCount + 1;
        }
        public void DrawLin(Graphics g)
        {
            SolidBrush blueBrush2 = new SolidBrush(Color.DarkGreen);
            Pen greenPen = new Pen(Color.FromArgb(255, 13, 99, 0), 2);
            int n = CountToInt(Count);
            g.FillEllipse(blueBrush2, startPosX + 60, startPosY + 27, 10, 8);
            g.DrawLine(greenPen, startPosX + 68, startPosY + 28, startPosX + 77, startPosY + 22);
            if (n >= 2)
            {
                g.FillEllipse(blueBrush2, startPosX + 75, startPosY + 27, 10, 8);
                g.DrawLine(greenPen, startPosX + 83, startPosY + 28, startPosX + 90, startPosY + 22);
            }
        }
    }
}
