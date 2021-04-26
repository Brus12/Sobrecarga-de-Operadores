using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsForm02P4U2
{
    public class Operacion
    {
        private int[] Arreglo;
        private float[] Arreglo2;
        public int[] Arreglo1 { get => Arreglo; set => Arreglo = value; }
        public float[] Arreglo21 { get => Arreglo2; set => Arreglo2 = value; }

        public void Ordenar(int x1, int x2, int x3, int x4)
        {
            Arreglo = new int[4] { x1, x2, x3, x4 };
            Array.Sort(Arreglo);
        }
        public void Ordenar(float x1F, float x2F, float x3F, float x4F)
        {
            Arreglo21 = new float[4] { x1F, x2F, x3F, x4F };
            Array.Reverse(Arreglo21);
        }
    }
}