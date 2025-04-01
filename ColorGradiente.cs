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
    public partial class ColorGradiente : Form
    {
        public static Color color1;
        public static Color color2;
        DialogResult result;
        public ColorGradiente()
        {
            InitializeComponent();
            CHB_ACEPTAR1.Checked= true;
        }

        private void colorPicker_MouseMove(object sender, MouseEventArgs e)
        {
            //Inicio
            Bitmap pixelData = (Bitmap)colorPicker.Image;
            Color hoveredColor = pixelData.GetPixel(e.X, e.Y);
            R_Label.Text = hoveredColor.R.ToString();
            G_Label.Text = hoveredColor.G.ToString();
            B_Label.Text = hoveredColor.B.ToString();
            showColor_Panel.BackColor = hoveredColor;
            //FIN
        }

        private void colorPicker_MouseDown(object sender, MouseEventArgs e)
        {
            //INICIO
            Bitmap pixelData = (Bitmap)colorPicker.Image;
            Color selectedColor = pixelData.GetPixel(e.X, e.Y);
            R_Label.Text = selectedColor.R.ToString();
            G_Label.Text = selectedColor.G.ToString();
            B_Label.Text = selectedColor.B.ToString();
            if (CHB_ACEPTAR1.Checked)
            {
                panelColor1.BackColor = selectedColor;
                color1 = selectedColor;
            }
            else if (CHB_ACEPTAR2.Checked)
            {
                panelColor2.BackColor = selectedColor;
                color2 = selectedColor;
            }
            else
                MessageBox.Show("Seleccione uno de los check boxes para guardar el color.");
            //FIN
        }

        private void BTN_CONFIRMAR_Click(object sender, EventArgs e)
        {
            //INICIO
            if (!color1.IsEmpty && !color2.IsEmpty)
            {
                this.Hide();
                result = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Seleccione ambos colores para editar la imagen. Si desea regresar, presione cancelar.");
            }
            //FIN
        }

        private void CHB_ACEPTAR1_CheckedChanged(object sender, EventArgs e)
        {
            //INICIO
            if (CHB_ACEPTAR1.Checked)
                CHB_ACEPTAR2.Checked = false;
            //FIN
        }

        private void CHB_ACEPTAR2_CheckedChanged(object sender, EventArgs e)
        {
            //INICIO
            if (CHB_ACEPTAR2.Checked)
                CHB_ACEPTAR1.Checked = false;
            //FIN
        }

        private void BTN_CANCELAR_Click(object sender, EventArgs e)
        {
            this.Close();
            result = DialogResult.Cancel;
        }
    }
}
