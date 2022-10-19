namespace WindowsApp
{
    partial class PracticaVariablesEIf
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
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.txtNota3 = new System.Windows.Forms.TextBox();
            this.txtNota4 = new System.Windows.Forms.TextBox();
            this.lblNota1 = new System.Windows.Forms.Label();
            this.lblNota2 = new System.Windows.Forms.Label();
            this.lblNota3 = new System.Windows.Forms.Label();
            this.lblNota4 = new System.Windows.Forms.Label();
            this.btnPromediar = new System.Windows.Forms.Button();
            this.btnMayorNota = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNota1
            // 
            this.txtNota1.Location = new System.Drawing.Point(290, 67);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(100, 22);
            this.txtNota1.TabIndex = 0;
            // 
            // txtNota2
            // 
            this.txtNota2.Location = new System.Drawing.Point(290, 119);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(100, 22);
            this.txtNota2.TabIndex = 1;
            // 
            // txtNota3
            // 
            this.txtNota3.Location = new System.Drawing.Point(290, 170);
            this.txtNota3.Name = "txtNota3";
            this.txtNota3.Size = new System.Drawing.Size(100, 22);
            this.txtNota3.TabIndex = 2;
            // 
            // txtNota4
            // 
            this.txtNota4.Location = new System.Drawing.Point(290, 222);
            this.txtNota4.Name = "txtNota4";
            this.txtNota4.Size = new System.Drawing.Size(100, 22);
            this.txtNota4.TabIndex = 3;
            // 
            // lblNota1
            // 
            this.lblNota1.AutoSize = true;
            this.lblNota1.Location = new System.Drawing.Point(209, 73);
            this.lblNota1.Name = "lblNota1";
            this.lblNota1.Size = new System.Drawing.Size(49, 16);
            this.lblNota1.TabIndex = 4;
            this.lblNota1.Text = "Nota 1:";
            // 
            // lblNota2
            // 
            this.lblNota2.AutoSize = true;
            this.lblNota2.Location = new System.Drawing.Point(209, 119);
            this.lblNota2.Name = "lblNota2";
            this.lblNota2.Size = new System.Drawing.Size(49, 16);
            this.lblNota2.TabIndex = 5;
            this.lblNota2.Text = "Nota 2:";
            // 
            // lblNota3
            // 
            this.lblNota3.AutoSize = true;
            this.lblNota3.Location = new System.Drawing.Point(209, 170);
            this.lblNota3.Name = "lblNota3";
            this.lblNota3.Size = new System.Drawing.Size(49, 16);
            this.lblNota3.TabIndex = 6;
            this.lblNota3.Text = "Nota 3:";
            // 
            // lblNota4
            // 
            this.lblNota4.AutoSize = true;
            this.lblNota4.Location = new System.Drawing.Point(209, 228);
            this.lblNota4.Name = "lblNota4";
            this.lblNota4.Size = new System.Drawing.Size(49, 16);
            this.lblNota4.TabIndex = 7;
            this.lblNota4.Text = "Nota 4:";
            this.lblNota4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnPromediar
            // 
            this.btnPromediar.Location = new System.Drawing.Point(290, 356);
            this.btnPromediar.Name = "btnPromediar";
            this.btnPromediar.Size = new System.Drawing.Size(142, 46);
            this.btnPromediar.TabIndex = 8;
            this.btnPromediar.Text = "Promediar Notas";
            this.btnPromediar.UseVisualStyleBackColor = true;
            this.btnPromediar.Click += new System.EventHandler(this.btnPromediar_Click);
            // 
            // btnMayorNota
            // 
            this.btnMayorNota.Location = new System.Drawing.Point(290, 293);
            this.btnMayorNota.Name = "btnMayorNota";
            this.btnMayorNota.Size = new System.Drawing.Size(142, 43);
            this.btnMayorNota.TabIndex = 9;
            this.btnMayorNota.Text = "Buscar Mayor Nota";
            this.btnMayorNota.UseVisualStyleBackColor = true;
            this.btnMayorNota.Click += new System.EventHandler(this.btnMayorNota_Click);
            // 
            // PracticaVariablesEIf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMayorNota);
            this.Controls.Add(this.btnPromediar);
            this.Controls.Add(this.lblNota4);
            this.Controls.Add(this.lblNota3);
            this.Controls.Add(this.lblNota2);
            this.Controls.Add(this.lblNota1);
            this.Controls.Add(this.txtNota4);
            this.Controls.Add(this.txtNota3);
            this.Controls.Add(this.txtNota2);
            this.Controls.Add(this.txtNota1);
            this.Name = "PracticaVariablesEIf";
            this.Text = "PracticaVariablesEIf";
            this.Load += new System.EventHandler(this.PracticaVariablesEIf_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNota1;
        private System.Windows.Forms.TextBox txtNota2;
        private System.Windows.Forms.TextBox txtNota3;
        private System.Windows.Forms.TextBox txtNota4;
        private System.Windows.Forms.Label lblNota1;
        private System.Windows.Forms.Label lblNota2;
        private System.Windows.Forms.Label lblNota3;
        private System.Windows.Forms.Label lblNota4;
        private System.Windows.Forms.Button btnPromediar;
        private System.Windows.Forms.Button btnMayorNota;
    }
}