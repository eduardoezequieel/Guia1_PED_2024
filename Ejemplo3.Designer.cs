namespace Guia1
{
    partial class Ejemplo3
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
            this.components = new System.ComponentModel.Container();
            this.timermov = new System.Windows.Forms.Timer(this.components);
            this.drawArea = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFinish = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.drawArea)).BeginInit();
            this.btnStart.SuspendLayout();
            this.btnFinish.SuspendLayout();
            this.SuspendLayout();
            // 
            // timermov
            // 
            this.timermov.Tick += new System.EventHandler(this.timermov_Tick);
            // 
            // drawArea
            // 
            this.drawArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(209)))), ((int)(((byte)(73)))));
            this.drawArea.Location = new System.Drawing.Point(14, 53);
            this.drawArea.Name = "drawArea";
            this.drawArea.Size = new System.Drawing.Size(900, 500);
            this.drawArea.TabIndex = 0;
            this.drawArea.TabStop = false;
            this.drawArea.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(209)))), ((int)(((byte)(73)))));
            this.btnStart.Controls.Add(this.label1);
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.Location = new System.Drawing.Point(316, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(141, 34);
            this.btnStart.TabIndex = 1;
            this.btnStart.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnStart_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Iniciar";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(209)))), ((int)(((byte)(73)))));
            this.btnFinish.Controls.Add(this.label2);
            this.btnFinish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinish.Location = new System.Drawing.Point(463, 12);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(141, 34);
            this.btnFinish.TabIndex = 2;
            this.btnFinish.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnFinish_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Finalizar";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Ejemplo3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(138)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(926, 567);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.drawArea);
            this.Name = "Ejemplo3";
            this.Text = "Ejemplo3";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Ejemplo3_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.drawArea)).EndInit();
            this.btnStart.ResumeLayout(false);
            this.btnStart.PerformLayout();
            this.btnFinish.ResumeLayout(false);
            this.btnFinish.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timermov;
        private System.Windows.Forms.PictureBox drawArea;
        private System.Windows.Forms.Panel btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel btnFinish;
        private System.Windows.Forms.Label label2;
    }
}