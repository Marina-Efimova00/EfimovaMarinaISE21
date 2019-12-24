using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormLincor
{
    public class DockNotFoundException : Exception
    {
        public DockNotFoundException(int i) : base("Не найден линкор по месту " + i)
        { }
    }
}
