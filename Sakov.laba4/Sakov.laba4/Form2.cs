using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sakov.laba4
{
    public partial class Form2 : Form
    {
        List<int> list1 = new List<int>();

        public Form2()
        {
            InitializeComponent();
        }
        private void SortUp(object sender, EventArgs e)
        {
            int count = list1.Count()-1;
            var sortedList = from u in list1
                             orderby u 
                              select u;
            int[] mas=new int[255];
            int j = 0;

            for (int i = count; i >= 0; i--)
            {
                mas[j] = sortedList.ElementAt(i);
                j++;
            }
            count = list1.Count();
            list1.Clear();
            for (int i = 0; i < count; i++)
            {
                list1.Add(mas[i]);
            }
        }
        private void Generation(object sender, EventArgs e)
        {
            int count;
          bool k=  int.TryParse(textBox1.Text, out count);
            if (!k)
                MessageBox.Show("Вы ввели неверное значение, введите значение");
            else
            {
                count = int.Parse(textBox1.Text);
                if (count > Byte.MaxValue)
                    MessageBox.Show("значения не сгенерированы");
                else
                {
                    Random rnd = new Random();
                    for (int i = 0; i < count; i++)
                    {
                        int value = rnd.Next(0, 200);
                        list1.Add(value);
                    }
                }
            }
        }
        private void SortDown(object sender, EventArgs e)
        {
            list1.Sort();
        }
        private void OutPutGeneralList(object sender, EventArgs e)
        {
            for (int i = 0; i < list1.Count; i++)
            {
                textBox2.Text = textBox2.Text + "рандомное значение=";
                textBox2.Text += list1.ElementAt(i).ToString() + "\r\n";
            }
        }
        private void OutPutSortList(object sender, EventArgs e)
        {
            for (int i = 0; i < list1.Count; i++)
            {
                textBox3.Text = textBox3.Text + "рандомное значение=";
                textBox3.Text += list1.ElementAt(i).ToString() + "\r\n";
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (list1.Count == 0)
            {
                MessageBox.Show("Список пуст");
            }
            else
            {
                int sortedList = (from u in list1
                                  orderby u
                                  select u).Max();

                MessageBox.Show(sortedList.ToString());
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (list1.Count == 0)
            {
                MessageBox.Show("Список пуст");
            }
            else
            {
                int sortedList = (from u in list1
                                  where u%2==0
                                  select u).Count();

                MessageBox.Show(sortedList.ToString());
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (list1.Count == 0)
            {
                MessageBox.Show("Список пуст");
            }
            else
            {
                int sortedList = (from u in list1
                                  orderby u
                                  select u).Min();

                MessageBox.Show(sortedList.ToString());
            }
        }
    }
}
