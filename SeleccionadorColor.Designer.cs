namespace Procesamiento_IMG_Proy
{
    partial class SeleccionadorColor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeleccionadorColor));
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            colorPicker = new PictureBox();
            panelColor = new Panel();
            showColor_Panel = new Panel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            BTN_CANCELAR = new Button();
            BTN_ACEPTAR = new Button();
            R_Label = new Label();
            G_Label = new Label();
            B_Label = new Label();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)colorPicker).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(53, 86, 112);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(756, 144);
            panel3.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(157, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 36F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(283, 45);
            label1.Name = "label1";
            label1.Size = new Size(236, 57);
            label1.TabIndex = 1;
            label1.Text = "LightTrap";
            // 
            // colorPicker
            // 
            colorPicker.Image = (Image)resources.GetObject("colorPicker.Image");
            colorPicker.Location = new Point(150, 153);
            colorPicker.Name = "colorPicker";
            colorPicker.Size = new Size(334, 220);
            colorPicker.SizeMode = PictureBoxSizeMode.AutoSize;
            colorPicker.TabIndex = 6;
            colorPicker.TabStop = false;
            colorPicker.MouseDown += colorPicker_MouseDown;
            colorPicker.MouseMove += colorPicker_MouseMove;
            // 
            // panelColor
            // 
            panelColor.BackColor = Color.FromArgb(53, 86, 112);
            panelColor.Location = new Point(513, 271);
            panelColor.Name = "panelColor";
            panelColor.Size = new Size(222, 100);
            panelColor.TabIndex = 7;
            // 
            // showColor_Panel
            // 
            showColor_Panel.BackColor = Color.White;
            showColor_Panel.Location = new Point(534, 192);
            showColor_Panel.Name = "showColor_Panel";
            showColor_Panel.Size = new Size(144, 64);
            showColor_Panel.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(534, 169);
            label2.Name = "label2";
            label2.Size = new Size(137, 20);
            label2.TabIndex = 9;
            label2.Text = "Muestra de Color";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(684, 192);
            label3.Name = "label3";
            label3.Size = new Size(22, 20);
            label3.TabIndex = 10;
            label3.Text = "R:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(682, 212);
            label4.Name = "label4";
            label4.Size = new Size(26, 20);
            label4.TabIndex = 11;
            label4.Text = "G:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(684, 232);
            label5.Name = "label5";
            label5.Size = new Size(22, 20);
            label5.TabIndex = 12;
            label5.Text = "B:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(53, 86, 112);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(BTN_CANCELAR);
            panel1.Controls.Add(BTN_ACEPTAR);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 144);
            panel1.Name = "panel1";
            panel1.Size = new Size(144, 249);
            panel1.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(12, 208);
            label8.Name = "label8";
            label8.Size = new Size(117, 16);
            label8.TabIndex = 4;
            label8.Text = "----------------------";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(14, 9);
            label7.Name = "label7";
            label7.Size = new Size(117, 16);
            label7.TabIndex = 3;
            label7.Text = "----------------------";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(14, 112);
            label6.Name = "label6";
            label6.Size = new Size(117, 16);
            label6.TabIndex = 2;
            label6.Text = "----------------------";
            // 
            // BTN_CANCELAR
            // 
            BTN_CANCELAR.FlatAppearance.BorderSize = 0;
            BTN_CANCELAR.FlatAppearance.MouseOverBackColor = Color.FromArgb(67, 108, 140);
            BTN_CANCELAR.FlatStyle = FlatStyle.Flat;
            BTN_CANCELAR.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BTN_CANCELAR.ForeColor = Color.White;
            BTN_CANCELAR.Location = new Point(12, 142);
            BTN_CANCELAR.Name = "BTN_CANCELAR";
            BTN_CANCELAR.Size = new Size(119, 63);
            BTN_CANCELAR.TabIndex = 1;
            BTN_CANCELAR.Text = "Cancelar";
            BTN_CANCELAR.UseVisualStyleBackColor = true;
            BTN_CANCELAR.Click += BTN_CANCELAR_Click;
            // 
            // BTN_ACEPTAR
            // 
            BTN_ACEPTAR.FlatAppearance.BorderSize = 0;
            BTN_ACEPTAR.FlatAppearance.MouseOverBackColor = Color.FromArgb(67, 108, 140);
            BTN_ACEPTAR.FlatStyle = FlatStyle.Flat;
            BTN_ACEPTAR.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BTN_ACEPTAR.ForeColor = Color.White;
            BTN_ACEPTAR.Location = new Point(12, 37);
            BTN_ACEPTAR.Name = "BTN_ACEPTAR";
            BTN_ACEPTAR.Size = new Size(119, 63);
            BTN_ACEPTAR.TabIndex = 0;
            BTN_ACEPTAR.Text = "Aceptar";
            BTN_ACEPTAR.UseVisualStyleBackColor = true;
            BTN_ACEPTAR.Click += BTN_ACEPTAR_Click;
            // 
            // R_Label
            // 
            R_Label.AutoSize = true;
            R_Label.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            R_Label.ForeColor = Color.White;
            R_Label.Location = new Point(708, 192);
            R_Label.Name = "R_Label";
            R_Label.Size = new Size(36, 20);
            R_Label.TabIndex = 14;
            R_Label.Text = "???";
            // 
            // G_Label
            // 
            G_Label.AutoSize = true;
            G_Label.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            G_Label.ForeColor = Color.White;
            G_Label.Location = new Point(708, 212);
            G_Label.Name = "G_Label";
            G_Label.Size = new Size(36, 20);
            G_Label.TabIndex = 15;
            G_Label.Text = "???";
            // 
            // B_Label
            // 
            B_Label.AutoSize = true;
            B_Label.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            B_Label.ForeColor = Color.White;
            B_Label.Location = new Point(708, 232);
            B_Label.Name = "B_Label";
            B_Label.Size = new Size(36, 20);
            B_Label.TabIndex = 16;
            B_Label.Text = "???";
            // 
            // SeleccionadorColor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(67, 108, 140);
            ClientSize = new Size(756, 393);
            Controls.Add(B_Label);
            Controls.Add(G_Label);
            Controls.Add(R_Label);
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(showColor_Panel);
            Controls.Add(panelColor);
            Controls.Add(colorPicker);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SeleccionadorColor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SeleccionadorColor";
            Load += SeleccionadorColor_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)colorPicker).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel3;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox colorPicker;
        private Panel panelColor;
        private Panel showColor_Panel;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Panel panel1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Button BTN_CANCELAR;
        private Button BTN_ACEPTAR;
        private Label R_Label;
        private Label G_Label;
        private Label B_Label;
    }
}