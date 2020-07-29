using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEntriesGUI
{
    public partial class Form1 : Form
    {
        public int num;
        public void setNum(int num) { this.num = num; }
        public int getNum() { return num; }


        public Form1()
        {
            
            InitializeComponent();

            //Init Instance of the Random class:
            Random rnd = new Random();

            //Select a randomly generated number between 1 - 20:
            setNum(rnd.Next(1, 21));
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int guess = Convert.ToInt16(textBox1.Text);
            rate(guess, getNum());
        }

        public void rate(int guess, int num)
        {
            if (guess < num) label2.Text = "Too Low!";
            else
                if (guess > num) label2.Text = "Too High!";
            else
                label2.Text = "*** Congrats! You Have Guessed Correctly! ***";
        }
    }
}
