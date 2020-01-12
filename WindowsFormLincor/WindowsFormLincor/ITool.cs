using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormLincor
{
    interface ITool
    {
        void DrawLin(Graphics g,LincorCount count);
    }
}
