using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsRadioButton_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            float numero1, numero2, suma, resta, producto, division;
            }

        private void Form1_Load(object sender, EventArgs e)
        {
float numero1, numero2, suma, resta, producto, division;
            numero1 = float.Parse(txtnumero1.Text);
            numero2 = float.Parse(txtnumero2.Text);
            suma = numero1 + numero2;
            resta = numero1 - numero2;
            producto = numero1 * numero2;
            division = numero1 / numero2;
            if(rdbopcion1.Checked==true)
            {    
            txtresultado.Text = suma.ToString();
            }
            if (rdbopcion2.Checked == true)
            {
                txtresultado.Text = suma.ToString();
            }
            if (rdbopcion3.Checked == true)
            {
                txtresultado.Text = suma.ToString();
            }
            if (rdbopcion4.Checked == true)
            {
                txtresultado.Text = suma.ToString();
            }

        }
        }
    }

