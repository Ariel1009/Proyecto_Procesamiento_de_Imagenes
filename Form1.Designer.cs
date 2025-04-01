namespace Procesamiento_IMG_Proy
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BTN_IMGS = new System.Windows.Forms.Button();
            this.BTN_SALIR = new System.Windows.Forms.Button();
            this.BTN_VIDEO = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Imagenes PNG|*.png|Imagenes BitMap|*-bmp|Imagenes JPG|*.jpg|Imagenes JPEG|*.jpeg";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-933, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(689, 415);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // BTN_IMGS
            // 
            this.BTN_IMGS.BackColor = System.Drawing.Color.LightCyan;
            this.BTN_IMGS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BTN_IMGS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_IMGS.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTN_IMGS.ForeColor = System.Drawing.Color.Black;
            this.BTN_IMGS.Image = ((System.Drawing.Image)(resources.GetObject("BTN_IMGS.Image")));
            this.BTN_IMGS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_IMGS.Location = new System.Drawing.Point(120, 213);
            this.BTN_IMGS.Name = "BTN_IMGS";
            this.BTN_IMGS.Size = new System.Drawing.Size(173, 40);
            this.BTN_IMGS.TabIndex = 2;
            this.BTN_IMGS.Text = "Imagenes";
            this.BTN_IMGS.UseVisualStyleBackColor = false;
            this.BTN_IMGS.Click += new System.EventHandler(this.BTN_IMGS_Click);
            // 
            // BTN_SALIR
            // 
            this.BTN_SALIR.BackColor = System.Drawing.Color.LightCyan;
            this.BTN_SALIR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BTN_SALIR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_SALIR.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTN_SALIR.ForeColor = System.Drawing.Color.Black;
            this.BTN_SALIR.Image = ((System.Drawing.Image)(resources.GetObject("BTN_SALIR.Image")));
            this.BTN_SALIR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_SALIR.Location = new System.Drawing.Point(86, 346);
            this.BTN_SALIR.Name = "BTN_SALIR";
            this.BTN_SALIR.Size = new System.Drawing.Size(232, 40);
            this.BTN_SALIR.TabIndex = 3;
            this.BTN_SALIR.Text = "Salir";
            this.BTN_SALIR.UseVisualStyleBackColor = false;
            this.BTN_SALIR.Click += new System.EventHandler(this.BTN_SALIR_Click);
            // 
            // BTN_VIDEO
            // 
            this.BTN_VIDEO.BackColor = System.Drawing.Color.LightCyan;
            this.BTN_VIDEO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BTN_VIDEO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_VIDEO.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTN_VIDEO.ForeColor = System.Drawing.Color.Black;
            this.BTN_VIDEO.Image = ((System.Drawing.Image)(resources.GetObject("BTN_VIDEO.Image")));
            this.BTN_VIDEO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_VIDEO.Location = new System.Drawing.Point(105, 282);
            this.BTN_VIDEO.Name = "BTN_VIDEO";
            this.BTN_VIDEO.Size = new System.Drawing.Size(202, 40);
            this.BTN_VIDEO.TabIndex = 4;
            this.BTN_VIDEO.Text = "Video";
            this.BTN_VIDEO.UseVisualStyleBackColor = false;
            this.BTN_VIDEO.Click += new System.EventHandler(this.BTN_VIDEO_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(148, 35);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(120, 120);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(114, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = ".: Bienvenido :.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(120)))), ((int)(((byte)(156)))));
            this.ClientSize = new System.Drawing.Size(404, 441);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.BTN_VIDEO);
            this.Controls.Add(this.BTN_SALIR);
            this.Controls.Add(this.BTN_IMGS);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "-";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private PictureBox pictureBox1;
        private Button BTN_IMGS;
        private Button BTN_SALIR;
        private Button BTN_VIDEO;
        private PictureBox pictureBox2;
        private Label label1;
    }
}