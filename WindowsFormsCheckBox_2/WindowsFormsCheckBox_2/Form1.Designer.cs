namespace WindowsFormsCheckBox_2
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
            this.chkcolor1 = new System.Windows.Forms.CheckBox();
            this.lblcolor1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chkcolor2 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // chkcolor1
            // 
            this.chkcolor1.AutoSize = true;
            this.chkcolor1.Location = new System.Drawing.Point(48, 34);
            this.chkcolor1.Name = "chkcolor1";
            this.chkcolor1.Size = new System.Drawing.Size(59, 17);
            this.chkcolor1.TabIndex = 0;
            this.chkcolor1.Text = "Color 1";
            this.chkcolor1.UseVisualStyleBackColor = true;
            // 
            // lblcolor1
            // 
            this.lblcolor1.AutoSize = true;
            this.lblcolor1.Location = new System.Drawing.Point(146, 36);
            this.lblcolor1.Name = "lblcolor1";
            this.lblcolor1.Size = new System.Drawing.Size(0, 13);
            this.lblcolor1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(135, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // chkcolor2
            // 
            this.chkcolor2.AutoSize = true;
            this.chkcolor2.Location = new System.Drawing.Point(52, 97);
            this.chkcolor2.Name = "chkcolor2";
            this.chkcolor2.Size = new System.Drawing.Size(59, 17);
            this.chkcolor2.TabIndex = 3;
            this.chkcolor2.Text = "Color 2";
            this.chkcolor2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.chkcolor2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblcolor1);
            this.Controls.Add(this.chkcolor1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkcolor1;
        private System.Windows.Forms.Label lblcolor1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkcolor2;

    }
}

