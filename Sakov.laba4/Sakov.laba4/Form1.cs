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
    public partial class Form1 : Form
    {

        public string str="";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void SaveSTR(object sender, EventArgs e)
        {
            str = textBox1.Text;
        }
        private void DeleteSymbol(object sender, EventArgs e)
        {
            if(str=="")
                MessageBox.Show("Строка пуста");
            else
            {
                char[] ch = new char[20];
                for (int i = 0; i < str.Length; i++)
                {
                    ch[i] = str[i];
                }
                for (int k = int.Parse(textBox1.Text); k < str.Length; k++)
                {
                    ch[k] = ch[k + 1];
                }
                str = new string(ch);
            }
        }
        private void OutPutSymbol(object sender, EventArgs e)
        {
            if (str == "")
                MessageBox.Show("Строка пуста");
            else
            {
                char[] ch = new char[2];
                int k = int.Parse(textBox1.Text);
                for (int i = 0; i < str.Length; i++)
                {
                    if (i == k)
                    {
                        ch[0] = str[k];
                        string kak2 = new string(ch);
                        MessageBox.Show(kak2);
                    }
                }
            }        
        }
        private void LengthStr(object sender, EventArgs e)
        {
            if (str == "")
                MessageBox.Show("Строка пуста");
            else
            {
                int Length = str.Length;
                string k = Length.ToString();
                MessageBox.Show(k);
            }

        }
        private void CountGl(object sender, EventArgs e)
        {
            if (str == "")
                MessageBox.Show("Строка пуста");
            else
            {
                int count = 0;
                string sogl = "АаЕеЁёУуЫыЯяИиОоЮюЭэ";
                for (int i = 0; i < str.Length; ++i)
                {
                    for (int j = 0; j < sogl.Length; ++j)
                    {
                        if (str[i] == sogl[j])
                        {
                            count++;
                            break;
                        }
                    }
                }

                string k = count.ToString();
                MessageBox.Show(k);
            }
        }
        private void CountSgl(object sender, EventArgs e)
        {
            if (str == "")
                MessageBox.Show("Строка пуста");
            else
            {
                int count = 0;
                string sogl = "ЙйЦцКкНнГгШшЩщЗзХхФфВвПпРрЛлДдЖжЧчСсМмТтБб";
                for (int i = 0; i < str.Length; ++i)
                {

                    if (sogl.Contains(str[i]))
                    {
                        count++;
                    }
                    for (int j = 0; j < sogl.Length; ++j)
                    {
                        if (str[i] == sogl[j])
                        {
                            count++;
                            break;
                        }
                    }
                }

                string k = count.ToString();
                MessageBox.Show(k);
            }
        }
        private void CountSentence(object sender, EventArgs e)
        {
            if (str == "")
                MessageBox.Show("Строка пуста");
            else
            {
                int count = 0;

                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] == '.'|| str[i] == '!'||str[i] == '?' || str[i] == ';')
                    {
                        count++;
                    }
                }

                string k = count.ToString();
                MessageBox.Show(k);
            }
        }
        private void CountWord(object sender, EventArgs e)
        {
            if (str == "")
                MessageBox.Show("Строка пуста");
            else
            {
                int count = 1;

                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] == ' ')
                    {
                        count++;
                    }
                }

                string k = count.ToString();
                MessageBox.Show(k);
            }
        }
        private void OutPut(object sender, EventArgs e)
        {
            if (str == "")
                MessageBox.Show("Строка пуста");
            else
            {
                MessageBox.Show(str);
            }
        }
        private void Replace(object sender, EventArgs e)
        {
            if (str == "")
                MessageBox.Show("Строка пуста");
            else
            {
                str = str.Replace(textBox1.Text, textBox2.Text);
                MessageBox.Show(str);
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }
    }
}
