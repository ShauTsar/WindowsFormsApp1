using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);
            int d1 = 7;
            int d2 = 15;
            int d3 = 20;
            int n1 = 20000;
            int n2 = 40000;
            int n3 = 60000;
            if (x > n3 && y > d3)
                textBox3.Text = "Вы можете выбрать 3 путевки";
            else if (x < n3 && x > n1)
                textBox3.Text = "Можете выбрать 2 предложенных путевки";
            else if(x>n1)
                textBox3.Text = "Вы можете позволить себе 1 путевку";
            else
                textBox3.Text = "Вам ничего не подходит";


        }
    }
}
