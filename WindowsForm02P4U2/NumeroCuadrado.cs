using System;

namespace WindowsForm02P4U2
{
    public class NumeroCuadrado
    {
        public void Cuadrado(ref int res, int intNum)
        {
            res = (int)Math.Pow(intNum, 2);

        }

        public void Cuadrado(ref double res, double dblNum)
        {
            res = (double)Math.Pow(dblNum, 2);

        }


    }
}
