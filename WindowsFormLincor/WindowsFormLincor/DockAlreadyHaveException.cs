using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormLincor
{
    class DockAlreadyHaveException : Exception
    {
        public DockAlreadyHaveException() : base("В доках уже есть такой линкор")
        { }
    }
}
