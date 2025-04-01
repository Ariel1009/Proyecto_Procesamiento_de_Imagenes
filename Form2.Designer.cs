namespace Procesamiento_IMG_Proy
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTN_HISTOGRAMA = new System.Windows.Forms.Button();
            this.BTN_FOTO = new System.Windows.Forms.Button();
            this.Panel_Filtros = new System.Windows.Forms.Panel();
            this.BTN_GRADIENTE = new System.Windows.Forms.Button();
            this.BTN_SALT = new System.Windows.Forms.Button();
            this.BTN_MIDPOINT = new System.Windows.Forms.Button();
            this.BTN_GAUSSIAN = new System.Windows.Forms.Button();
            this.BTN_QPhillips = new System.Windows.Forms.Button();
            this.BTN_CONTRASTE = new System.Windows.Forms.Button();
            this.BTN_MOSAICO = new System.Windows.Forms.Button();
            this.BTN_NEGATIVO = new System.Windows.Forms.Button();
            this.BTN_FCOLOREAR = new System.Windows.Forms.Button();
            this.BTN_FILTROS = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_BACK = new System.Windows.Forms.Button();
            this.BTN_BAJARIMG = new System.Windows.Forms.Button();
            this.BTN_SUBIRIMG = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.PB_IMAGES = new System.Windows.Forms.PictureBox();
            this.CB_Dispositivos = new System.Windows.Forms.ComboBox();
            this.BTN_ACTIVARCAM = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Bright_Slide = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BTN_DESCCAM = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.BTN_RESET = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.Panel_Filtros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_IMAGES)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bright_Slide)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(148)))), ((int)(((byte)(168)))));
            this.panel1.Controls.Add(this.BTN_HISTOGRAMA);
            this.panel1.Controls.Add(this.BTN_FOTO);
            this.panel1.Controls.Add(this.Panel_Filtros);
            this.panel1.Controls.Add(this.BTN_FILTROS);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BTN_BACK);
            this.panel1.Controls.Add(this.BTN_BAJARIMG);
            this.panel1.Controls.Add(this.BTN_SUBIRIMG);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(139, 666);
            this.panel1.TabIndex = 0;
            // 
            // BTN_HISTOGRAMA
            // 
            this.BTN_HISTOGRAMA.FlatAppearance.BorderSize = 0;
            this.BTN_HISTOGRAMA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(185)))), ((int)(((byte)(211)))));
            this.BTN_HISTOGRAMA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_HISTOGRAMA.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTN_HISTOGRAMA.ForeColor = System.Drawing.Color.White;
            this.BTN_HISTOGRAMA.Image = ((System.Drawing.Image)(resources.GetObject("BTN_HISTOGRAMA.Image")));
            this.BTN_HISTOGRAMA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_HISTOGRAMA.Location = new System.Drawing.Point(6, 197);
            this.BTN_HISTOGRAMA.Name = "BTN_HISTOGRAMA";
            this.BTN_HISTOGRAMA.Size = new System.Drawing.Size(121, 32);
            this.BTN_HISTOGRAMA.TabIndex = 7;
            this.BTN_HISTOGRAMA.Text = "Histograma";
            this.BTN_HISTOGRAMA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_HISTOGRAMA.UseVisualStyleBackColor = true;
            this.BTN_HISTOGRAMA.Click += new System.EventHandler(this.BTN_HISTOGRAMA_Click);
            // 
            // BTN_FOTO
            // 
            this.BTN_FOTO.FlatAppearance.BorderSize = 0;
            this.BTN_FOTO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(185)))), ((int)(((byte)(211)))));
            this.BTN_FOTO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_FOTO.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTN_FOTO.ForeColor = System.Drawing.Color.White;
            this.BTN_FOTO.Image = ((System.Drawing.Image)(resources.GetObject("BTN_FOTO.Image")));
            this.BTN_FOTO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_FOTO.Location = new System.Drawing.Point(3, 159);
            this.BTN_FOTO.Name = "BTN_FOTO";
            this.BTN_FOTO.Size = new System.Drawing.Size(121, 32);
            this.BTN_FOTO.TabIndex = 6;
            this.BTN_FOTO.Text = "Foto";
            this.BTN_FOTO.UseVisualStyleBackColor = true;
            this.BTN_FOTO.Click += new System.EventHandler(this.BTN_FOTO_Click);
            // 
            // Panel_Filtros
            // 
            this.Panel_Filtros.Controls.Add(this.BTN_GRADIENTE);
            this.Panel_Filtros.Controls.Add(this.BTN_SALT);
            this.Panel_Filtros.Controls.Add(this.BTN_MIDPOINT);
            this.Panel_Filtros.Controls.Add(this.BTN_GAUSSIAN);
            this.Panel_Filtros.Controls.Add(this.BTN_QPhillips);
            this.Panel_Filtros.Controls.Add(this.BTN_CONTRASTE);
            this.Panel_Filtros.Controls.Add(this.BTN_MOSAICO);
            this.Panel_Filtros.Controls.Add(this.BTN_NEGATIVO);
            this.Panel_Filtros.Controls.Add(this.BTN_FCOLOREAR);
            this.Panel_Filtros.Location = new System.Drawing.Point(23, 270);
            this.Panel_Filtros.Name = "Panel_Filtros";
            this.Panel_Filtros.Size = new System.Drawing.Size(113, 385);
            this.Panel_Filtros.TabIndex = 5;
            this.Panel_Filtros.Visible = false;
            // 
            // BTN_GRADIENTE
            // 
            this.BTN_GRADIENTE.FlatAppearance.BorderSize = 0;
            this.BTN_GRADIENTE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(185)))), ((int)(((byte)(211)))));
            this.BTN_GRADIENTE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_GRADIENTE.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTN_GRADIENTE.ForeColor = System.Drawing.Color.White;
            this.BTN_GRADIENTE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_GRADIENTE.Location = new System.Drawing.Point(3, 42);
            this.BTN_GRADIENTE.Name = "BTN_GRADIENTE";
            this.BTN_GRADIENTE.Size = new System.Drawing.Size(107, 32);
            this.BTN_GRADIENTE.TabIndex = 15;
            this.BTN_GRADIENTE.Text = "Gradiente";
            this.BTN_GRADIENTE.UseVisualStyleBackColor = true;
            this.BTN_GRADIENTE.Click += new System.EventHandler(this.BTN_GRADIENTE_Click);
            // 
            // BTN_SALT
            // 
            this.BTN_SALT.FlatAppearance.BorderSize = 0;
            this.BTN_SALT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(185)))), ((int)(((byte)(211)))));
            this.BTN_SALT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_SALT.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTN_SALT.ForeColor = System.Drawing.Color.White;
            this.BTN_SALT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_SALT.Location = new System.Drawing.Point(3, 326);
            this.BTN_SALT.Name = "BTN_SALT";
            this.BTN_SALT.Size = new System.Drawing.Size(107, 51);
            this.BTN_SALT.TabIndex = 14;
            this.BTN_SALT.Text = "Salt and Pepper";
            this.BTN_SALT.UseVisualStyleBackColor = true;
            this.BTN_SALT.Click += new System.EventHandler(this.BTN_SALT_Click);
            // 
            // BTN_MIDPOINT
            // 
            this.BTN_MIDPOINT.FlatAppearance.BorderSize = 0;
            this.BTN_MIDPOINT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(185)))), ((int)(((byte)(211)))));
            this.BTN_MIDPOINT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_MIDPOINT.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTN_MIDPOINT.ForeColor = System.Drawing.Color.White;
            this.BTN_MIDPOINT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_MIDPOINT.Location = new System.Drawing.Point(3, 288);
            this.BTN_MIDPOINT.Name = "BTN_MIDPOINT";
            this.BTN_MIDPOINT.Size = new System.Drawing.Size(107, 32);
            this.BTN_MIDPOINT.TabIndex = 13;
            this.BTN_MIDPOINT.Text = "Otsu";
            this.BTN_MIDPOINT.UseVisualStyleBackColor = true;
            this.BTN_MIDPOINT.Click += new System.EventHandler(this.BTN_MIDPOINT_Click);
            // 
            // BTN_GAUSSIAN
            // 
            this.BTN_GAUSSIAN.FlatAppearance.BorderSize = 0;
            this.BTN_GAUSSIAN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(185)))), ((int)(((byte)(211)))));
            this.BTN_GAUSSIAN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_GAUSSIAN.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTN_GAUSSIAN.ForeColor = System.Drawing.Color.White;
            this.BTN_GAUSSIAN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_GAUSSIAN.Location = new System.Drawing.Point(3, 232);
            this.BTN_GAUSSIAN.Name = "BTN_GAUSSIAN";
            this.BTN_GAUSSIAN.Size = new System.Drawing.Size(107, 50);
            this.BTN_GAUSSIAN.TabIndex = 12;
            this.BTN_GAUSSIAN.Text = "Gaussian Noise";
            this.BTN_GAUSSIAN.UseVisualStyleBackColor = true;
            this.BTN_GAUSSIAN.Click += new System.EventHandler(this.BTN_GAUSSIAN_Click);
            // 
            // BTN_QPhillips
            // 
            this.BTN_QPhillips.FlatAppearance.BorderSize = 0;
            this.BTN_QPhillips.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(185)))), ((int)(((byte)(211)))));
            this.BTN_QPhillips.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_QPhillips.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTN_QPhillips.ForeColor = System.Drawing.Color.White;
            this.BTN_QPhillips.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_QPhillips.Location = new System.Drawing.Point(3, 194);
            this.BTN_QPhillips.Name = "BTN_QPhillips";
            this.BTN_QPhillips.Size = new System.Drawing.Size(107, 32);
            this.BTN_QPhillips.TabIndex = 11;
            this.BTN_QPhillips.Text = "Dilatacion";
            this.BTN_QPhillips.UseVisualStyleBackColor = true;
            this.BTN_QPhillips.Click += new System.EventHandler(this.BTN_QPhillips_Click);
            // 
            // BTN_CONTRASTE
            // 
            this.BTN_CONTRASTE.FlatAppearance.BorderSize = 0;
            this.BTN_CONTRASTE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(185)))), ((int)(((byte)(211)))));
            this.BTN_CONTRASTE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_CONTRASTE.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTN_CONTRASTE.ForeColor = System.Drawing.Color.White;
            this.BTN_CONTRASTE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_CONTRASTE.Location = new System.Drawing.Point(3, 156);
            this.BTN_CONTRASTE.Name = "BTN_CONTRASTE";
            this.BTN_CONTRASTE.Size = new System.Drawing.Size(107, 32);
            this.BTN_CONTRASTE.TabIndex = 10;
            this.BTN_CONTRASTE.Text = "Contraste";
            this.BTN_CONTRASTE.UseVisualStyleBackColor = true;
            this.BTN_CONTRASTE.Click += new System.EventHandler(this.BTN_CONTRASTE_Click);
            // 
            // BTN_MOSAICO
            // 
            this.BTN_MOSAICO.FlatAppearance.BorderSize = 0;
            this.BTN_MOSAICO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(185)))), ((int)(((byte)(211)))));
            this.BTN_MOSAICO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_MOSAICO.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTN_MOSAICO.ForeColor = System.Drawing.Color.White;
            this.BTN_MOSAICO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_MOSAICO.Location = new System.Drawing.Point(3, 118);
            this.BTN_MOSAICO.Name = "BTN_MOSAICO";
            this.BTN_MOSAICO.Size = new System.Drawing.Size(107, 32);
            this.BTN_MOSAICO.TabIndex = 9;
            this.BTN_MOSAICO.Text = "Mosaico";
            this.BTN_MOSAICO.UseVisualStyleBackColor = true;
            this.BTN_MOSAICO.Click += new System.EventHandler(this.BTN_MOSAICO_Click);
            // 
            // BTN_NEGATIVO
            // 
            this.BTN_NEGATIVO.FlatAppearance.BorderSize = 0;
            this.BTN_NEGATIVO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(185)))), ((int)(((byte)(211)))));
            this.BTN_NEGATIVO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_NEGATIVO.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTN_NEGATIVO.ForeColor = System.Drawing.Color.White;
            this.BTN_NEGATIVO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_NEGATIVO.Location = new System.Drawing.Point(3, 80);
            this.BTN_NEGATIVO.Name = "BTN_NEGATIVO";
            this.BTN_NEGATIVO.Size = new System.Drawing.Size(107, 32);
            this.BTN_NEGATIVO.TabIndex = 8;
            this.BTN_NEGATIVO.Text = "Negativo";
            this.BTN_NEGATIVO.UseVisualStyleBackColor = true;
            this.BTN_NEGATIVO.Click += new System.EventHandler(this.BTN_NEGATIVO_Click);
            // 
            // BTN_FCOLOREAR
            // 
            this.BTN_FCOLOREAR.FlatAppearance.BorderSize = 0;
            this.BTN_FCOLOREAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(185)))), ((int)(((byte)(211)))));
            this.BTN_FCOLOREAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_FCOLOREAR.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTN_FCOLOREAR.ForeColor = System.Drawing.Color.White;
            this.BTN_FCOLOREAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_FCOLOREAR.Location = new System.Drawing.Point(3, 4);
            this.BTN_FCOLOREAR.Name = "BTN_FCOLOREAR";
            this.BTN_FCOLOREAR.Size = new System.Drawing.Size(107, 32);
            this.BTN_FCOLOREAR.TabIndex = 6;
            this.BTN_FCOLOREAR.Text = "Colorear";
            this.BTN_FCOLOREAR.UseVisualStyleBackColor = true;
            this.BTN_FCOLOREAR.Click += new System.EventHandler(this.BTN_FCOLOREAR_Click);
            // 
            // BTN_FILTROS
            // 
            this.BTN_FILTROS.FlatAppearance.BorderSize = 0;
            this.BTN_FILTROS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(185)))), ((int)(((byte)(211)))));
            this.BTN_FILTROS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_FILTROS.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTN_FILTROS.ForeColor = System.Drawing.Color.White;
            this.BTN_FILTROS.Image = ((System.Drawing.Image)(resources.GetObject("BTN_FILTROS.Image")));
            this.BTN_FILTROS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_FILTROS.Location = new System.Drawing.Point(6, 236);
            this.BTN_FILTROS.Name = "BTN_FILTROS";
            this.BTN_FILTROS.Size = new System.Drawing.Size(121, 32);
            this.BTN_FILTROS.TabIndex = 4;
            this.BTN_FILTROS.Text = "Filtros";
            this.BTN_FILTROS.UseVisualStyleBackColor = true;
            this.BTN_FILTROS.Click += new System.EventHandler(this.BTN_FILTROS_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "------------------";
            // 
            // BTN_BACK
            // 
            this.BTN_BACK.FlatAppearance.BorderSize = 0;
            this.BTN_BACK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(185)))), ((int)(((byte)(211)))));
            this.BTN_BACK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_BACK.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTN_BACK.ForeColor = System.Drawing.Color.White;
            this.BTN_BACK.Image = ((System.Drawing.Image)(resources.GetObject("BTN_BACK.Image")));
            this.BTN_BACK.Location = new System.Drawing.Point(6, 12);
            this.BTN_BACK.Name = "BTN_BACK";
            this.BTN_BACK.Size = new System.Drawing.Size(121, 43);
            this.BTN_BACK.TabIndex = 2;
            this.BTN_BACK.UseVisualStyleBackColor = true;
            this.BTN_BACK.Click += new System.EventHandler(this.BTN_BACK_Click);
            // 
            // BTN_BAJARIMG
            // 
            this.BTN_BAJARIMG.FlatAppearance.BorderSize = 0;
            this.BTN_BAJARIMG.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(185)))), ((int)(((byte)(211)))));
            this.BTN_BAJARIMG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_BAJARIMG.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTN_BAJARIMG.ForeColor = System.Drawing.Color.White;
            this.BTN_BAJARIMG.Image = ((System.Drawing.Image)(resources.GetObject("BTN_BAJARIMG.Image")));
            this.BTN_BAJARIMG.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_BAJARIMG.Location = new System.Drawing.Point(3, 121);
            this.BTN_BAJARIMG.Name = "BTN_BAJARIMG";
            this.BTN_BAJARIMG.Size = new System.Drawing.Size(121, 32);
            this.BTN_BAJARIMG.TabIndex = 1;
            this.BTN_BAJARIMG.Text = "Descargar";
            this.BTN_BAJARIMG.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_BAJARIMG.UseVisualStyleBackColor = true;
            this.BTN_BAJARIMG.Click += new System.EventHandler(this.BTN_BAJARIMG_Click);
            // 
            // BTN_SUBIRIMG
            // 
            this.BTN_SUBIRIMG.FlatAppearance.BorderSize = 0;
            this.BTN_SUBIRIMG.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(185)))), ((int)(((byte)(211)))));
            this.BTN_SUBIRIMG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_SUBIRIMG.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTN_SUBIRIMG.ForeColor = System.Drawing.Color.White;
            this.BTN_SUBIRIMG.Image = ((System.Drawing.Image)(resources.GetObject("BTN_SUBIRIMG.Image")));
            this.BTN_SUBIRIMG.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_SUBIRIMG.Location = new System.Drawing.Point(3, 83);
            this.BTN_SUBIRIMG.Name = "BTN_SUBIRIMG";
            this.BTN_SUBIRIMG.Size = new System.Drawing.Size(124, 32);
            this.BTN_SUBIRIMG.TabIndex = 0;
            this.BTN_SUBIRIMG.Text = "Subir";
            this.BTN_SUBIRIMG.UseVisualStyleBackColor = true;
            this.BTN_SUBIRIMG.Click += new System.EventHandler(this.BTN_SUBIRIMG_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Imagenes PNG|* .png| Imagenes JPG|* .jpg| Imagenes JPEG| * .jpeg";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Imágenes PNG|*.png";
            // 
            // PB_IMAGES
            // 
            this.PB_IMAGES.Location = new System.Drawing.Point(6, 22);
            this.PB_IMAGES.Name = "PB_IMAGES";
            this.PB_IMAGES.Size = new System.Drawing.Size(658, 502);
            this.PB_IMAGES.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_IMAGES.TabIndex = 1;
            this.PB_IMAGES.TabStop = false;
            // 
            // CB_Dispositivos
            // 
            this.CB_Dispositivos.FormattingEnabled = true;
            this.CB_Dispositivos.Location = new System.Drawing.Point(272, 33);
            this.CB_Dispositivos.Name = "CB_Dispositivos";
            this.CB_Dispositivos.Size = new System.Drawing.Size(658, 23);
            this.CB_Dispositivos.TabIndex = 2;
            // 
            // BTN_ACTIVARCAM
            // 
            this.BTN_ACTIVARCAM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(148)))), ((int)(((byte)(168)))));
            this.BTN_ACTIVARCAM.FlatAppearance.BorderSize = 0;
            this.BTN_ACTIVARCAM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(148)))), ((int)(((byte)(168)))));
            this.BTN_ACTIVARCAM.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTN_ACTIVARCAM.ForeColor = System.Drawing.Color.White;
            this.BTN_ACTIVARCAM.Image = ((System.Drawing.Image)(resources.GetObject("BTN_ACTIVARCAM.Image")));
            this.BTN_ACTIVARCAM.Location = new System.Drawing.Point(154, 27);
            this.BTN_ACTIVARCAM.Name = "BTN_ACTIVARCAM";
            this.BTN_ACTIVARCAM.Size = new System.Drawing.Size(112, 37);
            this.BTN_ACTIVARCAM.TabIndex = 8;
            this.BTN_ACTIVARCAM.UseVisualStyleBackColor = false;
            this.BTN_ACTIVARCAM.Click += new System.EventHandler(this.BTN_ACTIVARCAM_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(207, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Brillo";
            // 
            // Bright_Slide
            // 
            this.Bright_Slide.Location = new System.Drawing.Point(210, 167);
            this.Bright_Slide.Maximum = 100;
            this.Bright_Slide.Minimum = 10;
            this.Bright_Slide.Name = "Bright_Slide";
            this.Bright_Slide.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.Bright_Slide.Size = new System.Drawing.Size(45, 443);
            this.Bright_Slide.TabIndex = 10;
            this.Bright_Slide.TickStyle = System.Windows.Forms.TickStyle.None;
            this.Bright_Slide.Value = 10;
            this.Bright_Slide.ValueChanged += new System.EventHandler(this.Bright_Slide_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PB_IMAGES);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(290, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(675, 530);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Imagen";
            // 
            // BTN_DESCCAM
            // 
            this.BTN_DESCCAM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(148)))), ((int)(((byte)(168)))));
            this.BTN_DESCCAM.FlatAppearance.BorderSize = 0;
            this.BTN_DESCCAM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(148)))), ((int)(((byte)(168)))));
            this.BTN_DESCCAM.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTN_DESCCAM.ForeColor = System.Drawing.Color.White;
            this.BTN_DESCCAM.Image = ((System.Drawing.Image)(resources.GetObject("BTN_DESCCAM.Image")));
            this.BTN_DESCCAM.Location = new System.Drawing.Point(936, 27);
            this.BTN_DESCCAM.Name = "BTN_DESCCAM";
            this.BTN_DESCCAM.Size = new System.Drawing.Size(112, 37);
            this.BTN_DESCCAM.TabIndex = 12;
            this.BTN_DESCCAM.UseVisualStyleBackColor = false;
            this.BTN_DESCCAM.Click += new System.EventHandler(this.BTN_DESCCAM_Click);
            // 
            // BTN_RESET
            // 
            this.BTN_RESET.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(148)))), ((int)(((byte)(168)))));
            this.BTN_RESET.FlatAppearance.BorderSize = 0;
            this.BTN_RESET.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(148)))), ((int)(((byte)(168)))));
            this.BTN_RESET.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTN_RESET.ForeColor = System.Drawing.Color.White;
            this.BTN_RESET.Image = ((System.Drawing.Image)(resources.GetObject("BTN_RESET.Image")));
            this.BTN_RESET.Location = new System.Drawing.Point(981, 603);
            this.BTN_RESET.Name = "BTN_RESET";
            this.BTN_RESET.Size = new System.Drawing.Size(69, 51);
            this.BTN_RESET.TabIndex = 14;
            this.BTN_RESET.UseVisualStyleBackColor = false;
            this.BTN_RESET.Click += new System.EventHandler(this.BTN_RESET_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(185)))), ((int)(((byte)(211)))));
            this.ClientSize = new System.Drawing.Size(1061, 666);
            this.Controls.Add(this.BTN_RESET);
            this.Controls.Add(this.BTN_DESCCAM);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Bright_Slide);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BTN_ACTIVARCAM);
            this.Controls.Add(this.CB_Dispositivos);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "LightTrap - Modo Imagenes";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form2_Paint);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Panel_Filtros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PB_IMAGES)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bright_Slide)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Button BTN_SUBIRIMG;
        private Button BTN_FILTROS;
        private Label label1;
        private Button BTN_BACK;
        private Button BTN_BAJARIMG;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private Panel Panel_Filtros;
        private Button BTN_FCOLOREAR;
        private PictureBox PB_IMAGES;
        private Button BTN_FOTO;
        private Button BTN_HISTOGRAMA;
        private ComboBox CB_Dispositivos;
        private Button BTN_ACTIVARCAM;
        private Label label2;
        private TrackBar Bright_Slide;
        private GroupBox groupBox1;
        private Button BTN_DESCCAM;
        private ColorDialog colorDialog1;
        private Button BTN_SALT;
        private Button BTN_MIDPOINT;
        private Button BTN_GAUSSIAN;
        private Button BTN_QPhillips;
        private Button BTN_CONTRASTE;
        private Button BTN_MOSAICO;
        private Button BTN_NEGATIVO;
        private Button BTN_GRADIENTE;
        private Button BTN_RESET;
    }
}