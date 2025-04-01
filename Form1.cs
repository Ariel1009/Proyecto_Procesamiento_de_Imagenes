using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Procesamiento_IMG_Proy
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
  
        }

        

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BTN_IMGS_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            this.Hide();
            form2.ShowDialog();
            this.Close();
        }

        private void BTN_SALIR_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void BTN_VIDEO_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();

            this.Hide();
            form3.ShowDialog();
            this.Close();
        }
    }
}