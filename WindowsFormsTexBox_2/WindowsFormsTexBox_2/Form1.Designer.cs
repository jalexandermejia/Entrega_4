namespace WindowsFormsTexBox_2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblclave = new System.Windows.Forms.Label();
            this.txtclave = new System.Windows.Forms.TextBox();
            this.btnverificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblclave
            // 
            this.lblclave.AutoSize = true;
            this.lblclave.Location = new System.Drawing.Point(28, 40);
            this.lblclave.Name = "lblclave";
            this.lblclave.Size = new System.Drawing.Size(34, 13);
            this.lblclave.TabIndex = 0;
            this.lblclave.Text = "Clave";
            // 
            // txtclave
            // 
            this.txtclave.Location = new System.Drawing.Point(107, 40);
            this.txtclave.MaxLength = 10;
            this.txtclave.Name = "txtclave";
            this.txtclave.Size = new System.Drawing.Size(100, 20);
            this.txtclave.TabIndex = 1;
            // 
            // btnverificar
            // 
            this.btnverificar.Location = new System.Drawing.Point(98, 102);
            this.btnverificar.Name = "btnverificar";
            this.btnverificar.Size = new System.Drawing.Size(109, 23);
            this.btnverificar.TabIndex = 2;
            this.btnverificar.Text = "Verificar clave";
            this.btnverificar.UseVisualStyleBackColor = true;
            this.btnverificar.Click += new System.EventHandler(this.btnverificar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnverificar);
            this.Controls.Add(this.txtclave);
            this.Controls.Add(this.lblclave);
            this.Name = "Form1";
            this.Text = "Verificar Clave";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblclave;
        private System.Windows.Forms.TextBox txtclave;
        private System.Windows.Forms.Button btnverificar;
    }
}

