using System;
using System.Windows.Forms;

namespace WindowsForm02P4U2
{
    public partial class Lista_Numeros_Decimales_y_Enteros : Form
    {
        public Lista_Numeros_Decimales_y_Enteros()
        {
            InitializeComponent();
        }

        private void Lista_Numeros_Decimales_y_Enteros_Load(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int M = int.Parse(txtMax.Text);
            OrdVar ORD = new OrdVar();
            ORD.Ordenar(M);
            ORD.Ordenar();
            var Ent = ORD.Enteros1;
            var EntO = ORD.EnterosOrd1;
            var Dec = ORD.Decimales1;
            var DecO = ORD.DecimalesOrd1;
            foreach (var item in Ent)
            {
                lstEnteros.Items.Add(item);
            }
            foreach (var item in EntO)
            {
                lstEnterosO.Items.Add(item);
            }
            foreach (var item in Dec)
            {
                lstDeci.Items.Add(item);
            }
            foreach (var item in DecO)
            {
                lstDeciO.Items.Add(item);
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
