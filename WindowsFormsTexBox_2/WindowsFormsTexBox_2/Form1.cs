﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsTexBox_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtclave.MaxLength = 10;
            txtclave.PasswordChar = '*';
        }

        private void btnverificar_Click(object sender, EventArgs e)
        {
          
          MessageBox.Show(txtclave.Text);
            
        }
    }
}
