using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HW_C_Sharp_Extension_method
{
    public static class IntExtensions
    {
        public static bool ParityCheck(this int el)
        {
            return el % 2 == 0;
        }
    }
}
