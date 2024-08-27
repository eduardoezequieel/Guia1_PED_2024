namespace Guia1
{
    partial class Ejemplo2
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtEspaciado = new System.Windows.Forms.TextBox();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.btnDibujar = new System.Windows.Forms.Button();
            this.areaDibujo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.areaDibujo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Espaciado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Color";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(119, 102);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(125, 20);
            this.txtCantidad.TabIndex = 3;
            // 
            // txtEspaciado
            // 
            this.txtEspaciado.Location = new System.Drawing.Point(119, 135);
            this.txtEspaciado.Name = "txtEspaciado";
            this.txtEspaciado.Size = new System.Drawing.Size(125, 20);
            this.txtEspaciado.TabIndex = 4;
            // 
            // cmbColor
            // 
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Items.AddRange(new object[] {
            "Amarillo",
            "Rojo",
            "Azul",
            "Negro"});
            this.cmbColor.Location = new System.Drawing.Point(119, 168);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(125, 21);
            this.cmbColor.TabIndex = 5;
            // 
            // btnDibujar
            // 
            this.btnDibujar.Location = new System.Drawing.Point(80, 222);
            this.btnDibujar.Name = "btnDibujar";
            this.btnDibujar.Size = new System.Drawing.Size(125, 35);
            this.btnDibujar.TabIndex = 6;
            this.btnDibujar.Text = "Dibujar lineas";
            this.btnDibujar.UseVisualStyleBackColor = true;
            this.btnDibujar.Click += new System.EventHandler(this.btnDibujar_Click);
            // 
            // areaDibujo
            // 
            this.areaDibujo.BackColor = System.Drawing.SystemColors.HighlightText;
            this.areaDibujo.Location = new System.Drawing.Point(292, 12);
            this.areaDibujo.Name = "areaDibujo";
            this.areaDibujo.Size = new System.Drawing.Size(390, 333);
            this.areaDibujo.TabIndex = 7;
            this.areaDibujo.TabStop = false;
            this.areaDibujo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.areaDibujo_MouseClick);
            // 
            // Ejemplo2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 357);
            this.Controls.Add(this.areaDibujo);
            this.Controls.Add(this.btnDibujar);
            this.Controls.Add(this.cmbColor);
            this.Controls.Add(this.txtEspaciado);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Ejemplo2";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.areaDibujo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtEspaciado;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.Button btnDibujar;
        private System.Windows.Forms.PictureBox areaDibujo;
    }
}