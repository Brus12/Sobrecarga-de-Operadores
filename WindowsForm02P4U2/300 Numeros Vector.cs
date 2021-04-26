using System;
using System.Windows.Forms;

namespace WindowsForm02P4U2
{
    public partial class _300_Numeros_Vector : Form
    {
        public _300_Numeros_Vector()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int Tamaño = 300;

            int a = 0, b = 0, c = 0, sumNeg = 0, sumPos = 0;
            Vector ObjV = new Vector();
            ObjV.CalcularVector(Tamaño);
            ObjV.CalcularVector(ref a, ref b, ref c);
            ObjV.CalcularVector(ref sumNeg, ref sumPos);
            lblCero.Text = Convert.ToString(a);
            lblTNeg.Text = Convert.ToString(b);
            lblTPos.Text = Convert.ToString(c);
            lblSNeg.Text = Convert.ToString(sumNeg);
            lblSPos.Text = Convert.ToString(sumPos);
            listBox1.Items.Clear();
            var matriz = ObjV.Numeros;
            foreach (var item in matriz)
            {
                listBox1.Items.Add(item);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
