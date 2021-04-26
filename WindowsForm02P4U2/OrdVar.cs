using System;

namespace WindowsForm02P4U2
{
    public class OrdVar
    {
        private int[] Enteros;
        private int[] EnterosOrd;
        private double[] Decimales;
        private double[] DecimalesOrd;


        int n = 0;
        Random r = new Random();

        public int[] Enteros1 { get => Enteros; set => Enteros = value; }
        public int[] EnterosOrd1 { get => EnterosOrd; set => EnterosOrd = value; }
        public double[] Decimales1 { get => Decimales; set => Decimales = value; }
        public double[] DecimalesOrd1 { get => DecimalesOrd; set => DecimalesOrd = value; }

        public void Ordenar(int M)
        {
            Enteros1 = new int[M];
            for (int i = 0; i < M; i++)
            {
                Enteros1[i] = r.Next(1, 200);
            }
            Decimales1 = new double[M];
            for (int i = 0; i < M; i++)
            {
                Decimales1[i] = (double)r.NextDouble();
            }
            n = M;
        }

        public void Ordenar()
        {
            int aux;
            EnterosOrd = new int[n];
            for (int i = 0; i < n; i++)
            {
                EnterosOrd[i] = Enteros[i];
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (EnterosOrd[j + 1] < EnterosOrd[j])
                    {
                        aux = EnterosOrd[j + 1];
                        EnterosOrd[j + 1] = EnterosOrd[j];
                        EnterosOrd[j] = aux;
                    }
                }
            }
            double aux2;
            DecimalesOrd = new double[n];
            for (int i = 0; i < n; i++)
            {
                DecimalesOrd[i] = Decimales[i];
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (DecimalesOrd[j + 1] < DecimalesOrd[j])
                    {
                        aux2 = DecimalesOrd[j + 1];
                        DecimalesOrd[j + 1] = DecimalesOrd[j];
                        DecimalesOrd[j] = aux2;
                    }
                }
            }
        }
    }
}
