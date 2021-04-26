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
    public partial class Ordenar_y_Reordenar : Form
    {
        public Ordenar_y_Reordenar()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalcular_Click_1(object sender, EventArgs e)
        {
            int x1 = int.Parse(txtN1.Text);
            int x2 = int.Parse(txtN2.Text);
            int x3 = int.Parse(txtN3.Text);
            int x4 = int.Parse(txtN4.Text);
            float x1F = float.Parse(txtNF1.Text);
            float x2F = float.Parse(txtNF2.Text);
            float x3F = float.Parse(txtNF3.Text);
            float x4F = float.Parse(txtNF4.Text);
            Operacion ObjO = new Operacion();
            ObjO.Ordenar(x1, x2, x3, x4);
            ObjO.Ordenar(x1F, x2F, x3F, x4F);
            var Ordenar = ObjO.Arreglo1;
            foreach (var item in Ordenar)
            {
                listBox2.Items.Add(item);
            }

            var Ordenar2 = ObjO.Arreglo21;
            foreach (var item in Ordenar2)
            {
                listBox1.Items.Add(item);
            }
        }
    }
}
