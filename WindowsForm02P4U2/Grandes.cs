using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm02P4U2
{
    public partial class Grandes : Form
    {
        public Grandes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Operacion1 ObjO = new Operacion1();
            int x=0;
            long x1 = 0;
            int x2 = 0;
            int a = 10;
            int b = 4;
            int c = 15;
            int d = 35;
            int i = 23;
            int f = 10;
            int g = 12;
            int h = 18;
            ObjO.Grande(a,b, ref x);
            ObjO.Grande(c,d,i, ref x1);
            ObjO.Grande(f,g,h, ref x2);
            lblA.Text = "10+4= "+x;
            lblB.Text = "15+35+23= "+x1;
            lblC.Text = "10+12+18= "+x;

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
