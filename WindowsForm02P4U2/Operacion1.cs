using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsForm02P4U2
{
    public class Operacion1
    {
        public void Grande(int a, int b, ref int x)
        {
            x = a+b;
        }

        public void Grande(int c, int d, int i, ref long x1)
        {
            x1 = c+d+i;
        }

        public void Grande(int f, int g, int h, ref int x2)
        {
            x2 = f + g + g + h;
        }
    }
}