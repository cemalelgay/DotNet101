﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _23FormlarArasiGecis
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string mesaj;
        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = "Form1'den Gelen Mesaj: " + mesaj;
        }
    }
}
