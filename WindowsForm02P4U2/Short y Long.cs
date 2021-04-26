using System;
using System.Windows.Forms;

namespace WindowsForm02P4U2
{
    public partial class Short_y_Long : Form
    {
        public Short_y_Long()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            lstV1.Items.Clear();
            lstV2.Items.Clear();
            Mayor ObjM = new Mayor();
            short Vector1 = 20;
            long Vector2 = 20;
            ObjM.CalculaMayor(Vector1);
            ObjM.CalculaMayor(Vector2);

            //imprimir vector 1
            var arreglo1 = ObjM.V1;
            var arreglo2 = ObjM.V2;
            foreach (var item in arreglo1)
            {
                lstV1.Items.Add(item);
            }
            lblEMV1.Text = "Elemento mayor vector 1 posicion[" + ObjM.pos + "]";
            foreach (var item1 in arreglo2)
            {
                lstV2.Items.Add(item1);
            }
            lblEMV2.Text = "Elemento mayor vector 2 posicion[" + ObjM.pos1 + "]";

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
