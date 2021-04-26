using System;

namespace WindowsForm02P4U2
{
    public class Vector
    {
        private int[] numeros;
        Random rd = new Random();

        public int[] Numeros { get => numeros; set => numeros = value; }

        public void CalcularVector(int Tamaño)
        {
            Numeros = new int[Tamaño];
            for (int i = 0; i < Tamaño; i++)
            {
                Numeros[i] = rd.Next(-300, 300);
            }
        }

        public void CalcularVector(ref int a, ref int b, ref int c)
        {
            a = 0;
            b = 0;
            c = 0;
            for (int i = 0; i < 300; i++)
            {
                if (Numeros[i] == 0)
                {
                    a++;
                }
                if (Numeros[i] < 0)
                {
                    b++;
                }
                if (Numeros[i] > 0)
                {
                    c++;
                }
            }

        }
        public void CalcularVector(ref int sumNeg, ref int sumPos)
        {
            sumNeg = 0;
            sumPos = 0;
            for (int i = 0; i < Numeros.Length; i++)
            {
                if (Numeros[i] > 0)
                {
                    sumPos = sumPos + Numeros[i];
                }
                else
                {
                    sumNeg = sumNeg + Numeros[i];
                }
            }
        }
    }
}
