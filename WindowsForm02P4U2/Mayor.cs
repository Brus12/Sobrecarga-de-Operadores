using System;

namespace WindowsForm02P4U2
{
    public class Mayor
    {
        private short[] v1;
        private long[] v2;
        Random rd = new Random();
        public int may = 0, may1 = 0, pos = 0, pos1 = 0;

        public short[] V1 { get => v1; set => v1 = value; }
        public long[] V2 { get => v2; set => v2 = value; }

        public void CalculaMayor(short Vector1)
        {
            V1 = new short[Vector1];
            for (int i = 0; i < Vector1; i++)
            {
                V1[i] = (short)rd.Next(1, 150);
                if (V1[i] > may)
                {
                    may = V1[i];
                    pos = i;
                }
            }

        }

        public void CalculaMayor(long Vector2)
        {
            V2 = new long[Vector2];
            for (int i = 0; i < Vector2; i++)
            {
                V2[i] = (long)rd.Next(1, 150);
                if (V2[i] > may1)
                {
                    may1 = (int)V2[i];
                    pos1 = i;
                }
            }
        }
    }
}
