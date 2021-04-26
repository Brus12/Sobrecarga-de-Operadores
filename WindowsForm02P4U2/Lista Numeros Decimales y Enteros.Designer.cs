
namespace WindowsForm02P4U2
{
    partial class Lista_Numeros_Decimales_y_Enteros
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lstDeciO = new System.Windows.Forms.ListBox();
            this.lstDeci = new System.Windows.Forms.ListBox();
            this.lstEnterosO = new System.Windows.Forms.ListBox();
            this.lstEnteros = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ordenar lista de números decimales y enteros";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lista de Números Enteros";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(433, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(240, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Lista Ordenada de Números Enteros";
            // 
            // btnCalc
            // 
            this.btnCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.Location = new System.Drawing.Point(297, 357);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(100, 43);
            this.btnCalc.TabIndex = 5;
            this.btnCalc.Text = "Calcular";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // txtMax
            // 
            this.txtMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMax.Location = new System.Drawing.Point(297, 90);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(100, 23);
            this.txtMax.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(104, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Numero de datos a ingresar:";
            // 
            // lstDeciO
            // 
            this.lstDeciO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDeciO.FormattingEnabled = true;
            this.lstDeciO.ItemHeight = 16;
            this.lstDeciO.Location = new System.Drawing.Point(487, 316);
            this.lstDeciO.Name = "lstDeciO";
            this.lstDeciO.Size = new System.Drawing.Size(120, 84);
            this.lstDeciO.TabIndex = 29;
            // 
            // lstDeci
            // 
            this.lstDeci.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDeci.FormattingEnabled = true;
            this.lstDeci.ItemHeight = 16;
            this.lstDeci.Location = new System.Drawing.Point(84, 325);
            this.lstDeci.Name = "lstDeci";
            this.lstDeci.Size = new System.Drawing.Size(120, 84);
            this.lstDeci.TabIndex = 28;
            // 
            // lstEnterosO
            // 
            this.lstEnterosO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstEnterosO.FormattingEnabled = true;
            this.lstEnterosO.ItemHeight = 16;
            this.lstEnterosO.Location = new System.Drawing.Point(487, 165);
            this.lstEnterosO.Name = "lstEnterosO";
            this.lstEnterosO.Size = new System.Drawing.Size(120, 84);
            this.lstEnterosO.TabIndex = 27;
            // 
            // lstEnteros
            // 
            this.lstEnteros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstEnteros.FormattingEnabled = true;
            this.lstEnteros.ItemHeight = 16;
            this.lstEnteros.Location = new System.Drawing.Point(84, 165);
            this.lstEnteros.Name = "lstEnteros";
            this.lstEnteros.Size = new System.Drawing.Size(120, 84);
            this.lstEnteros.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(433, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(256, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "Lista Ordenada de Números Decimales";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "Lista de Números Decimales";
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(297, 270);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 43);
            this.btnSalir.TabIndex = 30;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Lista_Numeros_Decimales_y_Enteros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 462);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lstDeciO);
            this.Controls.Add(this.lstDeci);
            this.Controls.Add(this.lstEnterosO);
            this.Controls.Add(this.lstEnteros);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Lista_Numeros_Decimales_y_Enteros";
            this.Text = "Lista_Numeros_Decimales_y_Enteros";
            this.Load += new System.EventHandler(this.Lista_Numeros_Decimales_y_Enteros_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lstDeciO;
        private System.Windows.Forms.ListBox lstDeci;
        private System.Windows.Forms.ListBox lstEnterosO;
        private System.Windows.Forms.ListBox lstEnteros;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSalir;
    }
}