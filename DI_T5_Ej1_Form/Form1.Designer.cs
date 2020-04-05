namespace DI_T5_Ej1_Form
{
    partial class DI_T5_Ej1_Form
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DI_T5_Ej1_Form));
            this.buttonKFC = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.etiquetaAviso1 = new DI_T5_Ej2_EtiquetaAviso.EtiquetaAviso();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTextBox = new DI_T5_Ej1_LabelTextBox.LabelTextBox();
            this.SuspendLayout();
            // 
            // buttonKFC
            // 
            this.buttonKFC.Location = new System.Drawing.Point(386, 57);
            this.buttonKFC.Name = "buttonKFC";
            this.buttonKFC.Size = new System.Drawing.Size(160, 23);
            this.buttonKFC.TabIndex = 1;
            this.buttonKFC.Text = "TEST SEPARA";
            this.buttonKFC.UseVisualStyleBackColor = true;
            this.buttonKFC.Click += new System.EventHandler(this.buttonKFC_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(386, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "CAMBIO POSICION";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button1_Click);
            // 
            // etiquetaAviso1
            // 
            this.etiquetaAviso1.Location = new System.Drawing.Point(0, 0);
            this.etiquetaAviso1.Name = "etiquetaAviso1";
            this.etiquetaAviso1.Size = new System.Drawing.Size(0, 0);
            this.etiquetaAviso1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(100, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Key UP!";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(100, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 5;
            // 
            // labelTextBox
            // 
            this.labelTextBox.Location = new System.Drawing.Point(12, 12);
            this.labelTextBox.Name = "labelTextBox";
            this.labelTextBox.PosicionEtiqueta = DI_T5_Ej1_LabelTextBox.ePosicion.IZQUIERDA;
            this.labelTextBox.PswChar = '0';
            this.labelTextBox.Separacion = 0;
            this.labelTextBox.Size = new System.Drawing.Size(183, 22);
            this.labelTextBox.TabIndex = 2;
            this.labelTextBox.TextLbl = "LabelTextBox";
            this.labelTextBox.TextTxt = "";
            this.labelTextBox.SeparacionTactica += new System.EventHandler(this.labelTextBox_SeparacionTactica);
            this.labelTextBox.TexterinoChanged += new System.EventHandler(this.labelTextBox_TexterinoChanged);
            this.labelTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.labelTextBox_KeyUp);
            // 
            // DI_T5_Ej1_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 102);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTextBox);
            this.Controls.Add(this.etiquetaAviso1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonKFC);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DI_T5_Ej1_Form";
            this.Text = "DI_T5_Ej1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonKFC;
        private DI_T5_Ej2_EtiquetaAviso.EtiquetaAviso etiquetaAviso1;
        private DI_T5_Ej1_LabelTextBox.LabelTextBox labelTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

