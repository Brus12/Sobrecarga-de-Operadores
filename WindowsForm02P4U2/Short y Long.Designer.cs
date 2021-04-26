
namespace WindowsForm02P4U2
{
    partial class Short_y_Long
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
            this.lblEMV2 = new System.Windows.Forms.Label();
            this.lblEMV1 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstV2 = new System.Windows.Forms.ListBox();
            this.lstV1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEMV2
            // 
            this.lblEMV2.AutoSize = true;
            this.lblEMV2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEMV2.Location = new System.Drawing.Point(34, 255);
            this.lblEMV2.Name = "lblEMV2";
            this.lblEMV2.Size = new System.Drawing.Size(12, 17);
            this.lblEMV2.TabIndex = 15;
            this.lblEMV2.Text = ".";
            // 
            // lblEMV1
            // 
            this.lblEMV1.AutoSize = true;
            this.lblEMV1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEMV1.Location = new System.Drawing.Point(34, 217);
            this.lblEMV1.Name = "lblEMV1";
            this.lblEMV1.Size = new System.Drawing.Size(12, 17);
            this.lblEMV1.TabIndex = 14;
            this.lblEMV1.Text = ".";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(401, 146);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(86, 40);
            this.btnCerrar.TabIndex = 13;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click_1);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.Location = new System.Drawing.Point(401, 97);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(86, 41);
            this.btnMostrar.TabIndex = 12;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(279, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Vector 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Vector 1";
            // 
            // lstV2
            // 
            this.lstV2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstV2.FormattingEnabled = true;
            this.lstV2.ItemHeight = 16;
            this.lstV2.Location = new System.Drawing.Point(247, 92);
            this.lstV2.Name = "lstV2";
            this.lstV2.Size = new System.Drawing.Size(120, 116);
            this.lstV2.TabIndex = 9;
            // 
            // lstV1
            // 
            this.lstV1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstV1.FormattingEnabled = true;
            this.lstV1.ItemHeight = 16;
            this.lstV1.Location = new System.Drawing.Point(38, 92);
            this.lstV1.Name = "lstV1";
            this.lstV1.Size = new System.Drawing.Size(120, 116);
            this.lstV1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(129, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Short y Long";
            // 
            // Short_y_Long
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 332);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblEMV2);
            this.Controls.Add(this.lblEMV1);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstV2);
            this.Controls.Add(this.lstV1);
            this.Name = "Short_y_Long";
            this.Text = "Short_y_Long";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEMV2;
        private System.Windows.Forms.Label lblEMV1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstV2;
        private System.Windows.Forms.ListBox lstV1;
        private System.Windows.Forms.Label label3;
    }
}