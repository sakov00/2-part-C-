using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sakov.laba5
{
    public partial class Form2 : Form
    {
        public List<Apartment> apartments=new List<Apartment>();
        public List<Apartment> SearchApart;

        public Form2()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            SearchApart = apartments.FindAll(value => value.CountRoom == int.Parse(textBox4.Text));
            for (int i = 0; i < SearchApart.Count; i++)
                textBox1.Text += SearchApart.ElementAt(i).ToString() + "\n";

        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            SearchApart = apartments.FindAll(value => value.YearsBuilder.Year == int.Parse(textBox5.Text));
            for (int i = 0; i < SearchApart.Count; i++)
                textBox1.Text += SearchApart.ElementAt(i).ToString() + "\n";

        }
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            SearchApart = apartments.FindAll(value => value.Adress.Street == textBox2.Text);
            for (int i = 0; i < SearchApart.Count; i++)
                textBox1.Text += SearchApart.ElementAt(i).ToString() + "\n";

        }
        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            SearchApart = apartments.FindAll(value => value.Adress.Town == textBox3.Text);
            for (int i = 0; i < SearchApart.Count; i++)  
                textBox1.Text += SearchApart.ElementAt(i).ToString() + "\n";
            }
        }
    }

