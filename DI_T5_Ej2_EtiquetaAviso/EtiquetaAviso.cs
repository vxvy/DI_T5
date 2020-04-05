using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DI_T5_Ej2_EtiquetaAviso
{

    /**Toma el ejemplo EtiquetaAviso visto en teoría y realízalo de forma que se le añadan las siguientes
características:
• Que pueda tener de forma opcional un fondo de gradiente entre dos colores. Establece los
colores inicial y final del gradiente así como una booleana que indique si hay o no gradiente
como nuevas propiedades.
• El enumerado eMarca tendrá una constante más denominada Imagen de forma que si se
selecciona se colocará en la posición de la marca la imagen indicada en la propiedad
imagenMarca.
• Crea un evento denominado ClickEnMarca que será lanzado cuando el usuario pulsa el
ratón pero solo en la zona donde está la marca (salvo que sea Nada).
        */
    public enum eMarca
    {
        Nada,
        Cruz,
        Circulo,
        Imagen
    }
    public partial class EtiquetaAviso : Control
    {
        public EtiquetaAviso()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            int grosor = 0; //Grosor de las líneas de dibujo
            int offsetX = 0; //Desplazamiento a la derecha del texto
            int offsetY = 0; //Desplazamiento hacia abajo del texto
                             //Esta propiedad provoca mejoras en la apariencia o en la eficiencia
                             // a la hora de dibujar

            if (HabilitarGradiente) {
                LinearGradientBrush lgb = new LinearGradientBrush(new PointF(0, 0), new PointF(this.Width, this.Height), GradColor1, GradColor2);
                g.FillRectangle(lgb, 0, 0, this.Width, this.Height);
                lgb.Dispose();
            }

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            //Dependiendo del valor de la propiedad marca dibujamos una
            //Cruz o un Círculo
            switch (Marca)
            {
                case eMarca.Circulo:
                    grosor = 20;
                    g.DrawEllipse(new Pen(Color.Green, grosor), grosor, grosor, this.Font.Height, this.Font.Height);
                    offsetX = this.Font.Height + grosor;
                    offsetY = grosor;
                    break;
                case eMarca.Cruz:
                    grosor = 5;
                    Pen lapiz = new Pen(Color.Red, grosor);
                    g.DrawLine(lapiz, grosor, grosor, this.Font.Height, this.Font.Height);
                    g.DrawLine(lapiz, this.Font.Height, grosor, grosor, this.Font.Height);
                    offsetX = this.Font.Height + grosor;
                    offsetY = grosor / 2;
                    //Es recomendable liberar recursos de dibujo pues se
                    //pueden realizar muchos y cogen memoria
                    lapiz.Dispose();
                    break;
                case eMarca.Imagen:
                    if (ImgMarca != null)
                    {
                        grosor = this.FontHeight * 2;
                        g.DrawImage(ImgMarca, 0 + this.Font.Height, 0 + grosor / 2, grosor, grosor);
                        offsetX = this.Font.Height;
                        offsetY = grosor / 2;
                    }
                    break;
            }
            TamanyoMarcaX = offsetX + grosor;

            //Finalmente pintamos el Texto; desplazado si fuera necesario
            SolidBrush b = new SolidBrush(this.ForeColor);
            g.DrawString(this.Text, this.Font, b, offsetX + grosor, offsetY);
            Size tam = g.MeasureString(this.Text, this.Font).ToSize();
            this.Size = new Size(tam.Width + offsetX + grosor, tam.Height + offsetY * 2);
            b.Dispose();
        }

        [Category("aCustom")]
        [Description("Elige qué quieres que se muestre")]
        private eMarca marca = eMarca.Nada;
        public eMarca Marca
        {
            set
            {
                marca = value;
                this.Refresh();
            }
            get { return marca; }
        }

        //==========================
        //Nuevas propiedades
        //==========================

        [Category("aCustom")]
        [Description("Elige si hay o no gradiente")]
        private bool habilitarGradiente;
        public bool HabilitarGradiente
        {
            set
            {
                habilitarGradiente = value;
                this.Refresh();
            }
            get
            {
                return habilitarGradiente;
            }
        }

        [Category("aCustom")]
        [Description("Color1 del gradiente")]
        private Color gradColor1 = Color.White;
        public Color GradColor1
        {
            set
            {
                gradColor1 = value;
                this.Refresh();
            }
            get
            {
                return gradColor1;
            }
        }

        [Category("aCustom")]
        [Description("Color2 del gradiente")]
        private Color gradColor2 = Color.DarkRed;
        public Color GradColor2
        {
            set
            {
                gradColor2 = value;
                this.Refresh();
            }
            get
            {
                return gradColor2;
            }
        }

        [Category("aCustom")]
        [Description("Imagen que aparecerá en el sitio de la marca")]
        private Bitmap imgMarca;
        public Bitmap ImgMarca
        {
            set
            {
                imgMarca = value;
                this.Refresh();
            }
            get
            {
                return imgMarca;
            }
        }

        public int TamanyoMarcaX{ set; get; }

        [Category("aCustomEvent")]
        [Description("This is maybe an event")]
        public event MouseEventHandler ClicaLaMarca;

        private void EtiquetaAviso_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Location.X < TamanyoMarcaX)
            {
                ClicaLaMarca?.Invoke(this, e);
            }
        }
    }
}
