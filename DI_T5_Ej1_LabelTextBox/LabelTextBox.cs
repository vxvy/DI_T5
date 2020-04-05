using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DI_T5_Ej1_LabelTextBox
{
    public enum ePosicion
    {
        IZQUIERDA, DERECHA
    }

    /*
    Ejercicio 1:

       a) Prueba lo anterior  poniendo en la aplicación  
    de prueba un botón que fuerce el cambio de la posición y 
    que aparezca el valor del enumerado en la barra de título del formulario
    pero cuando se produce el cambio de posición. 

       b) Haz lo mismo con la propiedad Separacion creando un evento 
    que se lance cuando esta propiedad cambie y haz una prueba de funcionamiento.

       c) Haz que el evento KeyUp del LabelTextbox 
    sea lanzado cuando suceda un evento KeyUp de txt. 
    Haz prueba de funcionamiento.

       d) Finalmente crea un evento en LabelTextbox denominado TxtChanged 
    el cual sea lanzado cuando suceda el evento TextChanged del textbox interno.

       e) Haz una nueva propiedad de LabelTextbox denominada PswChr 
    que enlace con la propiedad PasswordChar del Textbox interno. 

       (Nota: Si acabas este ejercicio puedes hacer el 3)
        */

    [DefaultProperty("TextLbl"), DefaultEvent("Load")]
    public partial class LabelTextBox : UserControl
    {
        public LabelTextBox()
        {
            InitializeComponent();
            TextLbl = Name;
            TextTxt = "";
            recolocar();
        }

        [Category("Appearance")]
        [Description("Texto asociado a la Label del control")]
        public string TextLbl
        {
            set
            {
                lbl.Text = value;
                recolocar();
            }
            get
            {
                return lbl.Text;
            }
        }
        [Category("Appearance")]
        [Description("Texto asociado al TextBox del control")]
        public string TextTxt
        {
            set
            {
                txt.Text = value;
            }
            get
            {
                return txt.Text;
            }
        }
        private ePosicion posicionEtiqueta = ePosicion.IZQUIERDA;
        [Category("CatLabelTextBox")]
        [Description("DERECHA o IZQUIERDA")]
        public ePosicion PosicionEtiqueta
        {
            set
            {
                if (Enum.IsDefined(typeof(ePosicion), value))
                {
                    posicionEtiqueta = value;
                    
                    recolocar();
                }
                else
                {
                    throw new InvalidEnumArgumentException(); // Este error dónde aparece?
                }
            }
            get
            {
                return posicionEtiqueta;
            }
        }
        private int separacion = 0;
        [Category("CatLabelTextBox")]
        [Description("Píxels de separación entre Label y Textbox")]
        public int Separacion {
            set {
                if (value >= 0) {
                    separacion = value;
                    SeparacionTactica?.Invoke(this, EventArgs.Empty); //Apartado 2
                    recolocar();
                }
                else {
                    throw new ArgumentOutOfRangeException();
                }
            }
            get {
                return separacion;
            }
        }
        //Apartado 2
        [Category("La propiedad cambió")]
        [Description("Se lanza cuando la propiedad Posición cambia")]
        public event System.EventHandler SeparacionTactica;

        private void recolocar()
        {
            switch (posicionEtiqueta)
            {
                case ePosicion.DERECHA:
                    //Establecemos posición del componente txt
                    txt.Location = new Point(0, 0);
                    //Establecemos ancho del Textbox (la label tiene ancho fijo)
                    txt.Width = this.Width - lbl.Width - Separacion;
                    //Establecemos posición del componente lbl
                    lbl.Location = new Point(txt.Width + Separacion, 0);
                    //Establecemos altura del componente
                    this.Height = Math.Max(txt.Height, lbl.Height);
                    break;
                case ePosicion.IZQUIERDA:
                    lbl.Location = new Point(0, 0);
                    txt.Location = new Point(lbl.Width + Separacion, 0);
                    txt.Width = this.Width - lbl.Width - Separacion;
                    this.Height = Math.Max(txt.Height, lbl.Height);
                    break;
            }
        }
        // Esta función has de enlazarla con el evento SizeChanged.
        // Sería necesario también tener en cuenta otros eventos como FontChanged
        // que aquí nos saltamos.
        private void LabelTextBox_SizeChanged(object sender, EventArgs e)
        {
            recolocar();
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);
        }
        //Apartado 3
        private void txt_KeyUp(object sender, KeyEventArgs e)
        {
            this.OnKeyUp(e);
        }
        //Apartado 4
        public event System.EventHandler TexterinoChanged;
        private void txt_TextChanged(object sender, EventArgs e)
        {
            TexterinoChanged?.Invoke(this,EventArgs.Empty);
        }
        //Apartado 5
        
        [Category("CatLabelTextBox")]
        [Description("Cosas que pasan")]
        public char PswChar
        {
            set
            {

                txt.PasswordChar = value;
            }
            get
            {
                return txt.PasswordChar;
            }
        }

    }
}