namespace WindowsFormsRadioButton_1
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
            this.lblnumero1 = new System.Windows.Forms.Label();
            this.lblnumero2 = new System.Windows.Forms.Label();
            this.txtnumero1 = new System.Windows.Forms.TextBox();
            this.txtnumero2 = new System.Windows.Forms.TextBox();
            this.rdbopcion1 = new System.Windows.Forms.RadioButton();
            this.rdbopcion2 = new System.Windows.Forms.RadioButton();
            this.rdbopcion3 = new System.Windows.Forms.RadioButton();
            this.rdbopcion4 = new System.Windows.Forms.RadioButton();
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.lblresultado = new System.Windows.Forms.Label();
            this.btncalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblnumero1
            // 
            this.lblnumero1.AutoSize = true;
            this.lblnumero1.Location = new System.Drawing.Point(58, 45);
            this.lblnumero1.Name = "lblnumero1";
            this.lblnumero1.Size = new System.Drawing.Size(53, 13);
            this.lblnumero1.TabIndex = 0;
            this.lblnumero1.Text = "Numero 1";
            // 
            // lblnumero2
            // 
            this.lblnumero2.AutoSize = true;
            this.lblnumero2.Location = new System.Drawing.Point(58, 77);
            this.lblnumero2.Name = "lblnumero2";
            this.lblnumero2.Size = new System.Drawing.Size(53, 13);
            this.lblnumero2.TabIndex = 1;
            this.lblnumero2.Text = "Numero 2";
            // 
            // txtnumero1
            // 
            this.txtnumero1.Location = new System.Drawing.Point(138, 37);
            this.txtnumero1.Name = "txtnumero1";
            this.txtnumero1.Size = new System.Drawing.Size(100, 20);
            this.txtnumero1.TabIndex = 2;
            // 
            // txtnumero2
            // 
            this.txtnumero2.Location = new System.Drawing.Point(138, 77);
            this.txtnumero2.Name = "txtnumero2";
            this.txtnumero2.Size = new System.Drawing.Size(100, 20);
            this.txtnumero2.TabIndex = 3;
            // 
            // rdbopcion1
            // 
            this.rdbopcion1.AutoSize = true;
            this.rdbopcion1.Location = new System.Drawing.Point(61, 161);
            this.rdbopcion1.Name = "rdbopcion1";
            this.rdbopcion1.Size = new System.Drawing.Size(55, 17);
            this.rdbopcion1.TabIndex = 4;
            this.rdbopcion1.TabStop = true;
            this.rdbopcion1.Text = "Sumar";
            this.rdbopcion1.UseVisualStyleBackColor = true;
            // 
            // rdbopcion2
            // 
            this.rdbopcion2.AutoSize = true;
            this.rdbopcion2.Location = new System.Drawing.Point(173, 161);
            this.rdbopcion2.Name = "rdbopcion2";
            this.rdbopcion2.Size = new System.Drawing.Size(56, 17);
            this.rdbopcion2.TabIndex = 5;
            this.rdbopcion2.TabStop = true;
            this.rdbopcion2.Text = "Restar";
            this.rdbopcion2.UseVisualStyleBackColor = true;
            // 
            // rdbopcion3
            // 
            this.rdbopcion3.AutoSize = true;
            this.rdbopcion3.Location = new System.Drawing.Point(61, 204);
            this.rdbopcion3.Name = "rdbopcion3";
            this.rdbopcion3.Size = new System.Drawing.Size(72, 17);
            this.rdbopcion3.TabIndex = 6;
            this.rdbopcion3.TabStop = true;
            this.rdbopcion3.Text = "Multiplicar";
            this.rdbopcion3.UseVisualStyleBackColor = true;
            // 
            // rdbopcion4
            // 
            this.rdbopcion4.AutoSize = true;
            this.rdbopcion4.Location = new System.Drawing.Point(173, 204);
            this.rdbopcion4.Name = "rdbopcion4";
            this.rdbopcion4.Size = new System.Drawing.Size(54, 17);
            this.rdbopcion4.TabIndex = 7;
            this.rdbopcion4.TabStop = true;
            this.rdbopcion4.Text = "Dividir";
            this.rdbopcion4.UseVisualStyleBackColor = true;
            // 
            // txtresultado
            // 
            this.txtresultado.Enabled = false;
            this.txtresultado.Location = new System.Drawing.Point(138, 115);
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.Size = new System.Drawing.Size(100, 20);
            this.txtresultado.TabIndex = 8;
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Location = new System.Drawing.Point(61, 115);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(55, 13);
            this.lblresultado.TabIndex = 9;
            this.lblresultado.Text = "Resultado";
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(112, 227);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 10;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.rdbopcion4);
            this.Controls.Add(this.rdbopcion3);
            this.Controls.Add(this.rdbopcion2);
            this.Controls.Add(this.rdbopcion1);
            this.Controls.Add(this.txtnumero2);
            this.Controls.Add(this.txtnumero1);
            this.Controls.Add(this.lblnumero2);
            this.Controls.Add(this.lblnumero1);
            this.Name = "Form1";
            this.Text = "Programa Operaciones";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnumero1;
        private System.Windows.Forms.Label lblnumero2;
        private System.Windows.Forms.TextBox txtnumero1;
        private System.Windows.Forms.TextBox txtnumero2;
        private System.Windows.Forms.RadioButton rdbopcion1;
        private System.Windows.Forms.RadioButton rdbopcion2;
        private System.Windows.Forms.RadioButton rdbopcion3;
        private System.Windows.Forms.RadioButton rdbopcion4;
        private System.Windows.Forms.TextBox txtresultado;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.Button btncalcular;
    }
}

