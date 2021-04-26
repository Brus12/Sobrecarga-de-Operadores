
namespace WindowsForm02P4U2
{
    partial class _300_Numeros_Vector
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
            this.btnCalc = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCero = new System.Windows.Forms.Label();
            this.lblTNeg = new System.Windows.Forms.Label();
            this.lblTPos = new System.Windows.Forms.Label();
            this.lblSNeg = new System.Windows.Forms.Label();
            this.lblSPos = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total de ceros";
            // 
            // btnCalc
            // 
            this.btnCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.Location = new System.Drawing.Point(237, 77);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 36);
            this.btnCalc.TabIndex = 1;
            this.btnCalc.Text = "Calcular";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total de positivos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total de negativos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(298, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Suma de negativos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(304, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Suma de positivos";
            // 
            // lblCero
            // 
            this.lblCero.AutoSize = true;
            this.lblCero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCero.Location = new System.Drawing.Point(185, 130);
            this.lblCero.Name = "lblCero";
            this.lblCero.Size = new System.Drawing.Size(32, 17);
            this.lblCero.TabIndex = 5;
            this.lblCero.Text = "___";
            // 
            // lblTNeg
            // 
            this.lblTNeg.AutoSize = true;
            this.lblTNeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTNeg.Location = new System.Drawing.Point(185, 165);
            this.lblTNeg.Name = "lblTNeg";
            this.lblTNeg.Size = new System.Drawing.Size(32, 17);
            this.lblTNeg.TabIndex = 6;
            this.lblTNeg.Text = "___";
            // 
            // lblTPos
            // 
            this.lblTPos.AutoSize = true;
            this.lblTPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTPos.Location = new System.Drawing.Point(185, 197);
            this.lblTPos.Name = "lblTPos";
            this.lblTPos.Size = new System.Drawing.Size(32, 17);
            this.lblTPos.TabIndex = 7;
            this.lblTPos.Text = "___";
            // 
            // lblSNeg
            // 
            this.lblSNeg.AutoSize = true;
            this.lblSNeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSNeg.Location = new System.Drawing.Point(433, 130);
            this.lblSNeg.Name = "lblSNeg";
            this.lblSNeg.Size = new System.Drawing.Size(32, 17);
            this.lblSNeg.TabIndex = 8;
            this.lblSNeg.Text = "___";
            // 
            // lblSPos
            // 
            this.lblSPos.AutoSize = true;
            this.lblSPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSPos.Location = new System.Drawing.Point(433, 165);
            this.lblSPos.Name = "lblSPos";
            this.lblSPos.Size = new System.Drawing.Size(32, 17);
            this.lblSPos.TabIndex = 9;
            this.lblSPos.Text = "___";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(490, 44);
            this.label6.TabIndex = 10;
            this.label6.Text = "300 Numeros en un vector";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(484, 97);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 199);
            this.listBox1.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(521, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Vector";
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(230, 259);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(82, 37);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // _300_Numeros_Vector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 312);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblSPos);
            this.Controls.Add(this.lblSNeg);
            this.Controls.Add(this.lblTPos);
            this.Controls.Add(this.lblTNeg);
            this.Controls.Add(this.lblCero);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.label1);
            this.Name = "_300_Numeros_Vector";
            this.Text = "_300_Numeros_Vector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCero;
        private System.Windows.Forms.Label lblTNeg;
        private System.Windows.Forms.Label lblTPos;
        private System.Windows.Forms.Label lblSNeg;
        private System.Windows.Forms.Label lblSPos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSalir;
    }
}