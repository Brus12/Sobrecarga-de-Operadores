using System;
using System.Windows.Forms;

namespace WindowsForm02P4U2
{
    public partial class Numero_Cuadrado : Form
    {
        public Numero_Cuadrado()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int intNum = int.Parse(txtNum.Text);
            double dblNum = Convert.ToDouble(txtNum.Text);

            NumeroCuadrado ObjNum = new NumeroCuadrado();
            int Res = 0;
            double Res2 = 0;
            ObjNum.Cuadrado(ref Res, intNum);
            lblInt.Text = $"El cuadrado del numero {intNum} es {Res} (Tipo de dato: Int)";
            ObjNum.Cuadrado(ref Res2, dblNum);
            lblDouble.Text = $"El cuadrado del numero {dblNum}.00 es {Res2} (Tipo de dato: Double)";



        }

        private void button1_Click(object sender, EventArgs e)
        {
            int intNum = int.Parse(txtNum.Text);
            double dblNum = Convert.ToDouble(txtNum2.Text);

            NumeroCuadrado ObjNum = new NumeroCuadrado();
            int Res = 0;
            double Res2 = 0;
            ObjNum.Cuadrado(ref Res, intNum);
            lblInt.Text = $"El cuadrado del numero {intNum} es {Res} (Tipo de dato: Int)";
            ObjNum.Cuadrado(ref Res2, dblNum);
            lblDouble.Text = $"El cuadrado del numero {dblNum} es {Res2} (Tipo de dato: Double)";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
