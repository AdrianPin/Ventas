namespace Ventas1
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
            this.Procesar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Procesar
            // 
            this.Procesar.Location = new System.Drawing.Point(85, 130);
            this.Procesar.Name = "Procesar";
            this.Procesar.Size = new System.Drawing.Size(118, 51);
            this.Procesar.TabIndex = 0;
            this.Procesar.Text = "Procesar";
            this.Procesar.UseVisualStyleBackColor = true;
            this.Procesar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.Procesar);
            this.Name = "Form1";
            this.Text = "Procesar";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Procesar;
    }
}

