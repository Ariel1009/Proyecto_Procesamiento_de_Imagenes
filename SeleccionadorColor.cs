using Emgu.CV;
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
    public partial class SeleccionadorColor : Form
    {
        public Color color;
        DialogResult result;
        public SeleccionadorColor()
        {
            InitializeComponent();
        }

        private void colorPicker_MouseMove(object sender, MouseEventArgs e)
        {
            Bitmap pixelData = (Bitmap)colorPicker.Image;
            Color hoveredColor = pixelData.GetPixel(e.X, e.Y);
            R_Label.Text = hoveredColor.R.ToString();
            G_Label.Text = hoveredColor.G.ToString();
            B_Label.Text = hoveredColor.B.ToString();
            showColor_Panel.BackColor = hoveredColor;
        }

        private void colorPicker_MouseDown(object sender, MouseEventArgs e)
        {
            Bitmap pixelData = (Bitmap)colorPicker.Image;
            Color selectedColor = pixelData.GetPixel(e.X, e.Y);
            R_Label.Text = selectedColor.R.ToString();
            G_Label.Text = selectedColor.G.ToString();
            B_Label.Text = selectedColor.B.ToString();
            panelColor.BackColor = selectedColor;
            color = selectedColor;
        }

        private void BTN_ACEPTAR_Click(object sender, EventArgs e)
        {
            if (!color.IsEmpty)
            {
                this.Hide();
                result = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Seleccione un color para editar la imagen. Si desea regresar, presione cancelar.");
            }
        }

        private void BTN_CANCELAR_Click(object sender, EventArgs e)
        {
            this.Close();
            result = DialogResult.Cancel;
        }

        private void SeleccionadorColor_Load(object sender, EventArgs e)
        {

        }
    }
}
