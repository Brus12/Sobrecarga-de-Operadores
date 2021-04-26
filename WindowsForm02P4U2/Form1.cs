using System;
using System.Windows.Forms;

namespace WindowsForm02P4U2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cboSeleccionar.SelectedIndex = 0;
        }

        private void btnEjec_Click(object sender, EventArgs e)
        {
            Form fmr = null;
            switch (cboSeleccionar.SelectedIndex)
            {
                case 0:
                    fmr = new Short_y_Long();

                    break;
                case 1:
                    fmr = new Numero_Cuadrado();
                    break;
                case 2:
                    fmr = new _300_Numeros_Vector();
                    break;
                case 3:
                    fmr = new Lista_Numeros_Decimales_y_Enteros();
                    break;
                case 4:
                    fmr = new Ordenar_y_Reordenar() ;
                    break;
                case 5:
                    fmr = new Grandes();
                    break;
                case 6:
                    fmr = new Escuela_Buenaventura();
                    break;
                default:
                    break;
            }
            Hide();
            fmr?.ShowDialog();
            Show();
            fmr.Dispose();
        }
    }
}
