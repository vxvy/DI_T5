using DI_T5_Ej1_LabelTextBox;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DI_T5_Ej1_Form
{
    public partial class DI_T5_Ej1_Form : Form
    {
        public int Separacion;
        public DI_T5_Ej1_Form()
        {
            InitializeComponent();
            this.Separacion = labelTextBox.Separacion;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (labelTextBox.PosicionEtiqueta == ePosicion.DERECHA)
            {
                labelTextBox.PosicionEtiqueta = ePosicion.IZQUIERDA;
            }
            else
            {
                labelTextBox.PosicionEtiqueta = ePosicion.DERECHA;
            }

            this.Text = labelTextBox.PosicionEtiqueta.ToString();// en evento cambiaPosicion
        }

        private void labelTextBox_SeparacionTactica(object sender, EventArgs e)
        {
            if (labelTextBox.Separacion != this.Separacion)
            {
                this.Text = "Nueva separación: " + labelTextBox.Separacion;
            }
            this.Separacion = labelTextBox.Separacion;// en evento cambiaSeparaci{on
        }

        private void buttonKFC_Click(object sender, EventArgs e)
        {
            if (labelTextBox.Separacion < 40)
            {
                labelTextBox.Separacion += 10;
            }
            else if(labelTextBox.Separacion >= 40)
            {
                labelTextBox.Separacion -= 10;
            }
        }

        private void labelTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            label1.Visible = !label1.Visible;
        }

        private void labelTextBox_TexterinoChanged(object sender, EventArgs e)
        {
            LabelTextBox aux = (LabelTextBox)sender;
            label2.Text = aux.TextTxt;
        }
    }
}