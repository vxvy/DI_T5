namespace DI_T5_Ej2_Form
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.etiquetaAviso1 = new DI_T5_Ej2_EtiquetaAviso.EtiquetaAviso();
            this.SuspendLayout();
            // 
            // etiquetaAviso1
            // 
            this.etiquetaAviso1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiquetaAviso1.GradColor1 = System.Drawing.SystemColors.HotTrack;
            this.etiquetaAviso1.GradColor2 = System.Drawing.Color.White;
            this.etiquetaAviso1.HabilitarGradiente = true;
            this.etiquetaAviso1.ImgMarca = global::DI_T5_Ej2_Form.Properties.Resources.wallhaven_49q928;
            this.etiquetaAviso1.Location = new System.Drawing.Point(33, 38);
            this.etiquetaAviso1.Marca = DI_T5_Ej2_EtiquetaAviso.eMarca.Imagen;
            this.etiquetaAviso1.Name = "etiquetaAviso1";
            this.etiquetaAviso1.Size = new System.Drawing.Size(876, 294);
            this.etiquetaAviso1.TabIndex = 0;
            this.etiquetaAviso1.TamanyoMarcaX = 285;
            this.etiquetaAviso1.Text = "etiquetaAviso1";
            this.etiquetaAviso1.ClicaLaMarca += new System.Windows.Forms.MouseEventHandler(this.etiquetaAviso1_ClicaLaMarca);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 446);
            this.Controls.Add(this.etiquetaAviso1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "DI_T5_Ej2";
            this.ResumeLayout(false);

        }

        #endregion

        private DI_T5_Ej2_EtiquetaAviso.EtiquetaAviso etiquetaAviso1;
    }
}

