﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Insta_giris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(tbKadi.Text== "Egemen" && txSif.Text== "1234") {

                Form2 frn2 = new Form2();
                frn2.Show();
                this.Hide();
                }
                else
                {
                    MessageBox.Show("BILGILAR hATALI", "Basarisiz", MessageBoxButtons.OK) ;
                }
            }
            catch
            {

            }
        }
    }
}
