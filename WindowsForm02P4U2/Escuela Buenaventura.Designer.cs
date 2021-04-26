
namespace WindowsForm02P4U2
{
    partial class Escuela_Buenaventura
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btbIngresa = new System.Windows.Forms.Button();
            this.lstApellidos = new System.Windows.Forms.ListBox();
            this.lstNombres = new System.Windows.Forms.ListBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cboSeleccion = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(335, 224);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 32;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(424, 343);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(25, 13);
            this.lblTotal.TabIndex = 31;
            this.lblTotal.Text = "___";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(395, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Total de registros";
            // 
            // btnMostrar
            // 
            this.btnMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.Location = new System.Drawing.Point(335, 165);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 29;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btbIngresa
            // 
            this.btbIngresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbIngresa.Location = new System.Drawing.Point(335, 102);
            this.btbIngresa.Name = "btbIngresa";
            this.btbIngresa.Size = new System.Drawing.Size(75, 29);
            this.btbIngresa.TabIndex = 28;
            this.btbIngresa.Text = "Ingresar";
            this.btbIngresa.UseVisualStyleBackColor = true;
            this.btbIngresa.Click += new System.EventHandler(this.btbIngresa_Click);
            // 
            // lstApellidos
            // 
            this.lstApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstApellidos.FormattingEnabled = true;
            this.lstApellidos.ItemHeight = 16;
            this.lstApellidos.Location = new System.Drawing.Point(255, 302);
            this.lstApellidos.Name = "lstApellidos";
            this.lstApellidos.Size = new System.Drawing.Size(107, 132);
            this.lstApellidos.TabIndex = 27;
            // 
            // lstNombres
            // 
            this.lstNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstNombres.FormattingEnabled = true;
            this.lstNombres.ItemHeight = 16;
            this.lstNombres.Location = new System.Drawing.Point(88, 302);
            this.lstNombres.Name = "lstNombres";
            this.lstNombres.Size = new System.Drawing.Size(107, 132);
            this.lstNombres.TabIndex = 26;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(128, 193);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(149, 23);
            this.txtTelefono.TabIndex = 25;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(128, 139);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(149, 23);
            this.txtNombre.TabIndex = 24;
            // 
            // cboSeleccion
            // 
            this.cboSeleccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSeleccion.FormattingEnabled = true;
            this.cboSeleccion.Items.AddRange(new object[] {
            "Alumno",
            "Maestro"});
            this.cboSeleccion.Location = new System.Drawing.Point(128, 84);
            this.cboSeleccion.Name = "cboSeleccion";
            this.cboSeleccion.Size = new System.Drawing.Size(149, 24);
            this.cboSeleccion.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(273, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Telefono";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.Location = new System.Drawing.Point(108, 268);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(58, 17);
            this.Nombre.TabIndex = 21;
            this.Nombre.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Ingresa Telefono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Ingresa Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Alumno/Maestro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(201, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Escuela \"Buenaventura\"";
            // 
            // Escuela_Buenaventura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btbIngresa);
            this.Controls.Add(this.lstApellidos);
            this.Controls.Add(this.lstNombres);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.cboSeleccion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Escuela_Buenaventura";
            this.Text = "Escuela_Buenaventura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btbIngresa;
        private System.Windows.Forms.ListBox lstApellidos;
        private System.Windows.Forms.ListBox lstNombres;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cboSeleccion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}