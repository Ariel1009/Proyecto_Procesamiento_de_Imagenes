namespace Procesamiento_IMG_Proy
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BTN_PAUSE = new System.Windows.Forms.PictureBox();
            this.BTN_STOP = new System.Windows.Forms.PictureBox();
            this.BTN_PLAY = new System.Windows.Forms.PictureBox();
            this.PB_IMAGES = new System.Windows.Forms.PictureBox();
            this.BTN_ACTIVARCAM = new System.Windows.Forms.Button();
            this.CB_Dispositivos = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Panel_Filtros = new System.Windows.Forms.Panel();
            this.BTN_ABERRACION = new System.Windows.Forms.Button();
            this.BTN_SALT = new System.Windows.Forms.Button();
            this.BTN_OTSU = new System.Windows.Forms.Button();
            this.BTN_MIRROR = new System.Windows.Forms.Button();
            this.BTN_GAMMA = new System.Windows.Forms.Button();
            this.BTN_CONTRASTE = new System.Windows.Forms.Button();
            this.BTN_MOSAICO = new System.Windows.Forms.Button();
            this.BTN_NEGATIVO = new System.Windows.Forms.Button();
            this.BTN_HISTOEQ = new System.Windows.Forms.Button();
            this.BTN_FDILATACION = new System.Windows.Forms.Button();
            this.BTN_FILTROS = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_BACK = new System.Windows.Forms.Button();
            this.BTN_SUBIRIMG = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.BTN_STOPCAM = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BTN_PAUSE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTN_STOP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTN_PLAY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_IMAGES)).BeginInit();
            this.panel1.SuspendLayout();
            this.Panel_Filtros.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BTN_PAUSE);
            this.groupBox1.Controls.Add(this.BTN_STOP);
            this.groupBox1.Controls.Add(this.BTN_PLAY);
            this.groupBox1.Controls.Add(this.PB_IMAGES);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(228, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 530);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Video";
            // 
            // BTN_PAUSE
            // 
            this.BTN_PAUSE.Image = ((System.Drawing.Image)(resources.GetObject("BTN_PAUSE.Image")));
            this.BTN_PAUSE.Location = new System.Drawing.Point(485, 450);
            this.BTN_PAUSE.Name = "BTN_PAUSE";
            this.BTN_PAUSE.Size = new System.Drawing.Size(60, 60);
            this.BTN_PAUSE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.BTN_PAUSE.TabIndex = 4;
            this.BTN_PAUSE.TabStop = false;
            this.BTN_PAUSE.Click += new System.EventHandler(this.BTN_PAUSE_Click);
            // 
            // BTN_STOP
            // 
            this.BTN_STOP.Image = ((System.Drawing.Image)(resources.GetObject("BTN_STOP.Image")));
            this.BTN_STOP.Location = new System.Drawing.Point(237, 450);
            this.BTN_STOP.Name = "BTN_STOP";
            this.BTN_STOP.Size = new System.Drawing.Size(60, 60);
            this.BTN_STOP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.BTN_STOP.TabIndex = 3;
            this.BTN_STOP.TabStop = false;
            this.BTN_STOP.Click += new System.EventHandler(this.BTN_STOP_Click);
            // 
            // BTN_PLAY
            // 
            this.BTN_PLAY.Image = ((System.Drawing.Image)(resources.GetObject("BTN_PLAY.Image")));
            this.BTN_PLAY.Location = new System.Drawing.Point(362, 450);
            this.BTN_PLAY.Name = "BTN_PLAY";
            this.BTN_PLAY.Size = new System.Drawing.Size(60, 60);
            this.BTN_PLAY.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.BTN_PLAY.TabIndex = 2;
            this.BTN_PLAY.TabStop = false;
            this.BTN_PLAY.Click += new System.EventHandler(this.BTN_PLAY_Click);
            // 
            // PB_IMAGES
            // 
            this.PB_IMAGES.Location = new System.Drawing.Point(6, 22);
            this.PB_IMAGES.Name = "PB_IMAGES";
            this.PB_IMAGES.Size = new System.Drawing.Size(764, 412);
            this.PB_IMAGES.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_IMAGES.TabIndex = 1;
            this.PB_IMAGES.TabStop = false;
            // 
            // BTN_ACTIVARCAM
            // 
            this.BTN_ACTIVARCAM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.BTN_ACTIVARCAM.FlatAppearance.BorderSize = 0;
            this.BTN_ACTIVARCAM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.BTN_ACTIVARCAM.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTN_ACTIVARCAM.ForeColor = System.Drawing.Color.White;
            this.BTN_ACTIVARCAM.Image = ((System.Drawing.Image)(resources.GetObject("BTN_ACTIVARCAM.Image")));
            this.BTN_ACTIVARCAM.Location = new System.Drawing.Point(159, 6);
            this.BTN_ACTIVARCAM.Name = "BTN_ACTIVARCAM";
            this.BTN_ACTIVARCAM.Size = new System.Drawing.Size(112, 37);
            this.BTN_ACTIVARCAM.TabIndex = 14;
            this.BTN_ACTIVARCAM.UseVisualStyleBackColor = false;
            this.BTN_ACTIVARCAM.Click += new System.EventHandler(this.BTN_ACTIVARCAM_Click);
            // 
            // CB_Dispositivos
            // 
            this.CB_Dispositivos.FormattingEnabled = true;
            this.CB_Dispositivos.Location = new System.Drawing.Point(277, 12);
            this.CB_Dispositivos.Name = "CB_Dispositivos";
            this.CB_Dispositivos.Size = new System.Drawing.Size(658, 23);
            this.CB_Dispositivos.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.panel1.Controls.Add(this.Panel_Filtros);
            this.panel1.Controls.Add(this.BTN_FILTROS);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BTN_BACK);
            this.panel1.Controls.Add(this.BTN_SUBIRIMG);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(139, 597);
            this.panel1.TabIndex = 12;
            // 
            // Panel_Filtros
            // 
            this.Panel_Filtros.Controls.Add(this.BTN_ABERRACION);
            this.Panel_Filtros.Controls.Add(this.BTN_SALT);
            this.Panel_Filtros.Controls.Add(this.BTN_OTSU);
            this.Panel_Filtros.Controls.Add(this.BTN_MIRROR);
            this.Panel_Filtros.Controls.Add(this.BTN_GAMMA);
            this.Panel_Filtros.Controls.Add(this.BTN_CONTRASTE);
            this.Panel_Filtros.Controls.Add(this.BTN_MOSAICO);
            this.Panel_Filtros.Controls.Add(this.BTN_NEGATIVO);
            this.Panel_Filtros.Controls.Add(this.BTN_HISTOEQ);
            this.Panel_Filtros.Controls.Add(this.BTN_FDILATACION);
            this.Panel_Filtros.Location = new System.Drawing.Point(14, 157);
            this.Panel_Filtros.Name = "Panel_Filtros";
            this.Panel_Filtros.Size = new System.Drawing.Size(113, 429);
            this.Panel_Filtros.TabIndex = 9;
            this.Panel_Filtros.Visible = false;
            // 
            // BTN_ABERRACION
            // 
            this.BTN_ABERRACION.FlatAppearance.BorderSize = 0;
            this.BTN_ABERRACION.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(185)))), ((int)(((byte)(211)))));
            this.BTN_ABERRACION.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_ABERRACION.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTN_ABERRACION.ForeColor = System.Drawing.Color.White;
            this.BTN_ABERRACION.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_ABERRACION.Location = new System.Drawing.Point(3, 194);
            this.BTN_ABERRACION.Name = "BTN_ABERRACION";
            this.BTN_ABERRACION.Size = new System.Drawing.Size(107, 32);
            this.BTN_ABERRACION.TabIndex = 15;
            this.BTN_ABERRACION.Text = "A.Cromatica";
            this.BTN_ABERRACION.UseVisualStyleBackColor = true;
            this.BTN_ABERRACION.Click += new System.EventHandler(this.BTN_ABERRACION_Click);
            // 
            // BTN_SALT
            // 
            this.BTN_SALT.FlatAppearance.BorderSize = 0;
            this.BTN_SALT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(185)))), ((int)(((byte)(211)))));
            this.BTN_SALT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_SALT.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTN_SALT.ForeColor = System.Drawing.Color.White;
            this.BTN_SALT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_SALT.Location = new System.Drawing.Point(3, 364);
            this.BTN_SALT.Name = "BTN_SALT";
            this.BTN_SALT.Size = new System.Drawing.Size(107, 51);
            this.BTN_SALT.TabIndex = 14;
            this.BTN_SALT.Text = "Salt and Pepper";
            this.BTN_SALT.UseVisualStyleBackColor = true;
            this.BTN_SALT.Click += new System.EventHandler(this.BTN_SALT_Click);
            // 
            // BTN_OTSU
            // 
            this.BTN_OTSU.FlatAppearance.BorderSize = 0;
            this.BTN_OTSU.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(185)))), ((int)(((byte)(211)))));
            this.BTN_OTSU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_OTSU.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTN_OTSU.ForeColor = System.Drawing.Color.White;
            this.BTN_OTSU.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_OTSU.Location = new System.Drawing.Point(3, 326);
            this.BTN_OTSU.Name = "BTN_OTSU";
            this.BTN_OTSU.Size = new System.Drawing.Size(107, 32);
            this.BTN_OTSU.TabIndex = 13;
            this.BTN_OTSU.Text = "Otsu";
            this.BTN_OTSU.UseVisualStyleBackColor = true;
            this.BTN_OTSU.Click += new System.EventHandler(this.BTN_OTSU_Click);
            // 
            // BTN_MIRROR
            // 
            this.BTN_MIRROR.FlatAppearance.BorderSize = 0;
            this.BTN_MIRROR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(185)))), ((int)(((byte)(211)))));
            this.BTN_MIRROR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_MIRROR.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTN_MIRROR.ForeColor = System.Drawing.Color.White;
            this.BTN_MIRROR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_MIRROR.Location = new System.Drawing.Point(3, 270);
            this.BTN_MIRROR.Name = "BTN_MIRROR";
            this.BTN_MIRROR.Size = new System.Drawing.Size(107, 50);
            this.BTN_MIRROR.TabIndex = 12;
            this.BTN_MIRROR.Text = "Mirror";
            this.BTN_MIRROR.UseVisualStyleBackColor = true;
            this.BTN_MIRROR.Click += new System.EventHandler(this.BTN_MIRROR_Click);
            // 
            // BTN_GAMMA
            // 
            this.BTN_GAMMA.FlatAppearance.BorderSize = 0;
            this.BTN_GAMMA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(185)))), ((int)(((byte)(211)))));
            this.BTN_GAMMA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_GAMMA.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTN_GAMMA.ForeColor = System.Drawing.Color.White;
            this.BTN_GAMMA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_GAMMA.Location = new System.Drawing.Point(3, 232);
            this.BTN_GAMMA.Name = "BTN_GAMMA";
            this.BTN_GAMMA.Size = new System.Drawing.Size(107, 32);
            this.BTN_GAMMA.TabIndex = 11;
            this.BTN_GAMMA.Text = "Gamma";
            this.BTN_GAMMA.UseVisualStyleBackColor = true;
            this.BTN_GAMMA.Click += new System.EventHandler(this.BTN_GAMMA_Click);
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
            // BTN_HISTOEQ
            // 
            this.BTN_HISTOEQ.FlatAppearance.BorderSize = 0;
            this.BTN_HISTOEQ.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(185)))), ((int)(((byte)(211)))));
            this.BTN_HISTOEQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_HISTOEQ.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTN_HISTOEQ.ForeColor = System.Drawing.Color.White;
            this.BTN_HISTOEQ.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_HISTOEQ.Location = new System.Drawing.Point(3, 42);
            this.BTN_HISTOEQ.Name = "BTN_HISTOEQ";
            this.BTN_HISTOEQ.Size = new System.Drawing.Size(107, 32);
            this.BTN_HISTOEQ.TabIndex = 7;
            this.BTN_HISTOEQ.Text = "HistoEQ";
            this.BTN_HISTOEQ.UseVisualStyleBackColor = true;
            this.BTN_HISTOEQ.Click += new System.EventHandler(this.BTN_HISTOEQ_Click);
            // 
            // BTN_FDILATACION
            // 
            this.BTN_FDILATACION.FlatAppearance.BorderSize = 0;
            this.BTN_FDILATACION.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(185)))), ((int)(((byte)(211)))));
            this.BTN_FDILATACION.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_FDILATACION.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTN_FDILATACION.ForeColor = System.Drawing.Color.White;
            this.BTN_FDILATACION.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_FDILATACION.Location = new System.Drawing.Point(3, 4);
            this.BTN_FDILATACION.Name = "BTN_FDILATACION";
            this.BTN_FDILATACION.Size = new System.Drawing.Size(107, 32);
            this.BTN_FDILATACION.TabIndex = 6;
            this.BTN_FDILATACION.Text = "Dilatacion";
            this.BTN_FDILATACION.UseVisualStyleBackColor = true;
            this.BTN_FDILATACION.Click += new System.EventHandler(this.BTN_FDILATACION_Click);
            // 
            // BTN_FILTROS
            // 
            this.BTN_FILTROS.FlatAppearance.BorderSize = 0;
            this.BTN_FILTROS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.BTN_FILTROS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_FILTROS.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTN_FILTROS.ForeColor = System.Drawing.Color.White;
            this.BTN_FILTROS.Image = ((System.Drawing.Image)(resources.GetObject("BTN_FILTROS.Image")));
            this.BTN_FILTROS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_FILTROS.Location = new System.Drawing.Point(6, 119);
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
            this.BTN_BACK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
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
            // BTN_SUBIRIMG
            // 
            this.BTN_SUBIRIMG.FlatAppearance.BorderSize = 0;
            this.BTN_SUBIRIMG.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
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
            // 
            // BTN_STOPCAM
            // 
            this.BTN_STOPCAM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.BTN_STOPCAM.FlatAppearance.BorderSize = 0;
            this.BTN_STOPCAM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.BTN_STOPCAM.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTN_STOPCAM.ForeColor = System.Drawing.Color.White;
            this.BTN_STOPCAM.Image = ((System.Drawing.Image)(resources.GetObject("BTN_STOPCAM.Image")));
            this.BTN_STOPCAM.Location = new System.Drawing.Point(941, 6);
            this.BTN_STOPCAM.Name = "BTN_STOPCAM";
            this.BTN_STOPCAM.Size = new System.Drawing.Size(112, 37);
            this.BTN_STOPCAM.TabIndex = 18;
            this.BTN_STOPCAM.UseVisualStyleBackColor = false;
            this.BTN_STOPCAM.Click += new System.EventHandler(this.BTN_STOPCAM_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.ClientSize = new System.Drawing.Size(1067, 597);
            this.Controls.Add(this.BTN_STOPCAM);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BTN_ACTIVARCAM);
            this.Controls.Add(this.CB_Dispositivos);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "LightTrap - Modo Videos";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BTN_PAUSE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTN_STOP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTN_PLAY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_IMAGES)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Panel_Filtros.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private PictureBox PB_IMAGES;
        private Button BTN_ACTIVARCAM;
        private ComboBox CB_Dispositivos;
        private Panel panel1;
        private Button BTN_FILTROS;
        private Label label1;
        private Button BTN_BACK;
        private Button BTN_SUBIRIMG;
        private PictureBox BTN_PAUSE;
        private PictureBox BTN_STOP;
        private PictureBox BTN_PLAY;
        private OpenFileDialog openFileDialog1;
        private Panel Panel_Filtros;
        private Button BTN_SALT;
        private Button BTN_OTSU;
        private Button BTN_MIRROR;
        private Button BTN_GAMMA;
        private Button BTN_CONTRASTE;
        private Button BTN_MOSAICO;
        private Button BTN_NEGATIVO;
        private Button BTN_HISTOEQ;
        private Button BTN_FDILATACION;
        private Button BTN_ABERRACION;
        private Button BTN_STOPCAM;
    }
}