using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormLincor
{
    class DrawTool3 : ITool
    {
        public LincorCount Count { private set; get; }
        public Color MainColor { private set; get; }
        public Color DopColor { private set; get; }
        public int x;
        public int y;
        public DrawTool3(LincorCount linCount, Color mainColor, Color dopColor, int posX, int posY)
        {
            MainColor = mainColor;
            DopColor = dopColor;
            Count = linCount;
            x = posX;
            y = posY;
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
            g.FillRectangle(blueBrush2, x + 60, y + 20, 10, 16);
            g.DrawLine(greenPen, x + 68, y + 28, x + 77, y + 22);
            if (n >= 2)
            {
                g.FillRectangle(blueBrush2, x + 75, y + 20, 10, 16);
                g.DrawLine(greenPen, x + 83, y + 28, x + 90, y + 22);
            }
        }
    }
}
