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
    public partial class Escuela_Buenaventura : Form
    {
        public Escuela_Buenaventura()
        {
            InitializeComponent();
            cboSeleccion.SelectedIndex = 0;

        }
        Buenaventura ObjB = new Buenaventura();

        private void btbIngresa_Click(object sender, EventArgs e)
        {
            string nom, tel;
            long tel1;
            if (cboSeleccion.SelectedItem == "Maestro")
            {
                nom = txtNombre.Text;
                tel = txtTelefono.Text;
                ObjB.Datos(nom, tel);
            }
            if (cboSeleccion.SelectedItem == "Alumno")
            {
                nom = txtNombre.Text;
                tel1 = long.Parse(txtTelefono.Text);
                ObjB.Datos(nom, tel1);

            }
            txtNombre.Text = "";
            txtTelefono.Text = "";
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            var NombresP = ObjB.NombreP;
            var TelefonoP = ObjB.TelefonoP;
            var NombresA = ObjB.NombreA;
            var TelefonoA = ObjB.TelefonoA;
            foreach (var item in NombresP)
            {
                lstNombres.Items.Add("Docente " + item);
            }
            foreach (var item in TelefonoP)
            {
                lstApellidos.Items.Add(item);
            }
            foreach (var item in NombresA)
            {
                lstNombres.Items.Add("Alumno " + item);
            }
            foreach (var item in TelefonoA)
            {
                lstApellidos.Items.Add(item);
            }
            lblTotal.Text = ObjB.contTotal.ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
