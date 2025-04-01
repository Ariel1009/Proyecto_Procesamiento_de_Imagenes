namespace Procesamiento_IMG_Proy
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.P_HistoRojo = new System.Windows.Forms.Panel();
            this.P_HistoVerde = new System.Windows.Forms.Panel();
            this.P_HistoAzul = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(129, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(265, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 57);
            this.label1.TabIndex = 1;
            this.label1.Text = "LightTrap";
            // 
            // P_HistoRojo
            // 
            this.P_HistoRojo.Location = new System.Drawing.Point(24, 168);
            this.P_HistoRojo.Name = "P_HistoRojo";
            this.P_HistoRojo.Size = new System.Drawing.Size(266, 188);
            this.P_HistoRojo.TabIndex = 2;
            this.P_HistoRojo.Paint += new System.Windows.Forms.PaintEventHandler(this.P_HistoRojo_Paint);
            // 
            // P_HistoVerde
            // 
            this.P_HistoVerde.Location = new System.Drawing.Point(311, 168);
            this.P_HistoVerde.Name = "P_HistoVerde";
            this.P_HistoVerde.Size = new System.Drawing.Size(266, 188);
            this.P_HistoVerde.TabIndex = 3;
            this.P_HistoVerde.Paint += new System.Windows.Forms.PaintEventHandler(this.P_HistoVerde_Paint);
            // 
            // P_HistoAzul
            // 
            this.P_HistoAzul.Location = new System.Drawing.Point(151, 375);
            this.P_HistoAzul.Name = "P_HistoAzul";
            this.P_HistoAzul.Size = new System.Drawing.Size(266, 188);
            this.P_HistoAzul.TabIndex = 4;
            this.P_HistoAzul.Paint += new System.Windows.Forms.PaintEventHandler(this.P_HistoAzul_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(86)))), ((int)(((byte)(112)))));
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(603, 144);
            this.panel3.TabIndex = 4;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(108)))), ((int)(((byte)(140)))));
            this.ClientSize = new System.Drawing.Size(603, 583);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.P_HistoAzul);
            this.Controls.Add(this.P_HistoVerde);
            this.Controls.Add(this.P_HistoRojo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.Text = "LightTrap - Histograma";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Panel P_HistoRojo;
        private Panel P_HistoVerde;
        private Panel P_HistoAzul;
        private Panel panel3;
    }
}