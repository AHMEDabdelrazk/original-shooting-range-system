﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace third
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            button3.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form7.ActiveForm.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Hide();
            button3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Hide();
            button1.Show();
        }
    }
}
