﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShowingUserMessages
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
                throw new NotImplementedException();
            }
            catch(NotImplementedException notImp)
            {
                //Steps: 4 - 5:


                DialogResult result =
                    MessageBox.Show("Proceed?", notImp.Message,
                    MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                textBox1.Text = result.ToString();
                if (result == DialogResult.Yes) label1.Text = "Proceeding...";
                if (result == DialogResult.No) label1.Text = "Stopping...";


            }
        }
    }
}
