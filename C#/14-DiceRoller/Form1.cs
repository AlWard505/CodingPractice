using System;
using System.Windows.Forms;

namespace _14_DiceRoller
{


    public partial class Form1 : Form
    {
        Random rollD4 = new Random();
        Random rollD6 = new Random();
        Random rollD8 = new Random();
        Random rollD10 = new Random();
        Random rollD12 = new Random();
        Random rollD20 = new Random();
        Random rollCustom = new Random();
        int roll = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            for (int i = 1; i <= Convert.ToInt32(numericUpDown1.Value); i++)
            {
                roll += rollD4.Next(1, 5);
            }
            label9.Text = ("You rolled a " + roll);
            roll = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            for (int i = 1; i <= Convert.ToInt32(numericUpDown9.Value); i++)
            {
                roll += rollD6.Next(1, 7);
            }
            label9.Text = ("You rolled a " + roll);
            roll = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= Convert.ToInt32(numericUpDown2.Value); i++)
            {
                roll += rollD4.Next(1, 9);
            }
            label9.Text = ("You rolled a " + roll);
            roll = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= Convert.ToInt32(numericUpDown3.Value); i++)
            {
                roll += rollD4.Next(1, 11);
            }
            label9.Text = ("You rolled a " + roll);
            roll = 0;
        }

        private void D20_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= Convert.ToInt32(numericUpDown5.Value); i++)
            {
                roll += rollD4.Next(1, 21);
            }
            label9.Text = ("You rolled a " + roll);
            roll = 0;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown7_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void D12_Click(object sender, EventArgs e)
        {

        }

        private void D12_Click_1(object sender, EventArgs e)
        {
            for (int i = 1; i <= Convert.ToInt32(numericUpDown4.Value); i++)
            {
                roll += rollD4.Next(1, 13);
            }
            label9.Text = ("You rolled a " + roll);
            roll = 0;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            for (int i = 1; i <= Convert.ToInt32(numericUpDown6.Value); i++)
            {
                roll += rollD4.Next(1, 101);
            }
            label9.Text = ("You rolled a " + roll);
            roll = 0;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            for (int i = 1; i <= Convert.ToInt32(numericUpDown8.Value); i++)
            {
                roll += rollD4.Next(1, Convert.ToInt32(numericUpDown7.Value) + 1);
            }
            label9.Text = ("You rolled a " + roll);
            roll = 0;
        }


    }
}
