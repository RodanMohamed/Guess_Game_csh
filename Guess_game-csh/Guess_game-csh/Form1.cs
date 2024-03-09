using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guess_game_csh
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtguess.Focus();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            int input;
            int.TryParse(txtguess.Text, out input);
            listBox1.Items.Add(input);
            txtguess.Focus();
            if (input > correctnum)
            { MessageBox.Show("your number is greater than the true number"); }
            else if (input < correctnum)
            { MessageBox.Show("yornumber is less than the  true nuumber"); }
            else
                MessageBox.Show("******congrateyoulations*****");
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnnewgame_Click(object sender, EventArgs e)
        {
            Random guess = new Random();
            correctnum = guess.Next(0, 100);
            txtguess.Visible = true;
            textBox1.Text = correctnum.ToString();

        }
        public int correctnum { get; set; }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
