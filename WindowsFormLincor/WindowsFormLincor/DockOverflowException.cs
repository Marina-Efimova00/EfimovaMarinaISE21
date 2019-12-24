using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormLincor
{
    public class DockOverflowException : Exception
    {
        public DockOverflowException() : base("В доках нет свободных мест")
        { }
    }
}
