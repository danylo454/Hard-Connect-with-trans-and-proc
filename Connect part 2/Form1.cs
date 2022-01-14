using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connect_part_2
{
    public partial class Homework : Form
    {
       
        public Homework()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = Queries.ShowAllStationery(textBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = Queries.ShowAllTypeStationery(textBox1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = Queries.ShowAllManager(textBox1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = Queries.ShowMaxCountStationery(textBox1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = Queries.ShowMinCountStationery(textBox1);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = Queries.ShowMaxPriceStationery(textBox1);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = Queries.ShowMinPriceStationery(textBox1);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string text = textBox2.Text;
            textBox1.Text = Queries.SearchBytype(text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string text = textBox3.Text;
            textBox1.Text = Queries.SearchManager(text);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string text = textBox4.Text;
            textBox1.Text = Queries.SearchFirma(text);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string text = textBox4.Text;
            textBox1.Text = Queries.lastBoughStaff(text);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string text = textBox4.Text;
            textBox1.Text = Queries.AvgCountType(text);
        }
    }
}
