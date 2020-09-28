using Newtonsoft.Json;
using Sakov.laba5.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Sakov.laba5
{
    public partial class Form1 : Form
    {
        bool CheckedForm = true;
        private Adress adress = new Adress();
        private Apartment apartment = new Apartment();
        private List<Apartment> apartments = new List<Apartment>();
        private static string REGEX_FOR_TEXT="^[A-Z][a-z]+$";
        private static string REGEX_FOR_INT = "^[1-9][0-9]*$";
        private Validate validate = new Validate();
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            CheckedForm = true;
            Checked();
            if (CheckedForm)
            {
            CheckedBox();
            apartment.Adress = adress;
            Adress adress1 = new Adress();
            Apartment apartment1 = new Apartment();
            apartment1.Adress = adress1;
            apartment1.Clone(apartment, apartment.Adress);
                apartments.Add(apartment1);
                textBox1.Text += apartment.ToString();
            }
        }
        private bool Checked()
        {
            if (checkBox4.Checked && checkBox5.Checked|| !checkBox4.Checked && !checkBox5.Checked)
            {
                MessageBox.Show("не может быть выбрано оба в поле кухня");
                CheckedForm = false;
            }
            if (checkBox2.Checked && checkBox1.Checked|| !checkBox2.Checked && !checkBox1.Checked)
            {
                MessageBox.Show("не может быть выбрано оба в поле зал");
                CheckedForm = false;
            }
            if (checkBox6.Checked && checkBox3.Checked|| !checkBox6.Checked && !checkBox3.Checked)
            {
                MessageBox.Show("не может быть выбрано оба в поле спальная");
                CheckedForm = false;
            }
            if (checkBox8.Checked && checkBox7.Checked|| !checkBox8.Checked && !checkBox7.Checked)
            {
                MessageBox.Show("не может быть выбрано оба в поле ванная");
                CheckedForm = false;
            }
            if (textBox2.BackColor == Color.Red || textBox3.BackColor == Color.Red || textBox4.BackColor == Color.Red
                || textBox5.BackColor == Color.Red || textBox6.BackColor == Color.Red || textBox7.BackColor == Color.Red)
            {
                MessageBox.Show("не верно введён адрес");
                CheckedForm = false;
            }
            return CheckedForm;
        }
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if(validate.validate(REGEX_FOR_TEXT, textBox2.Text))
            {
                textBox2.BackColor = Color.Green;
                adress.Country = textBox2.Text;
            }
            else
            {
                textBox2.BackColor = Color.Red;
                CheckedForm = false;
            }
            
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (validate.validate(REGEX_FOR_TEXT, textBox3.Text))
            {
                textBox3.BackColor = Color.Green;
                adress.Town = textBox3.Text;
            }
            else
            {
                textBox3.BackColor = Color.Red;
                CheckedForm = false;
            }
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (validate.validate(REGEX_FOR_TEXT, textBox4.Text))
            {
                textBox4.BackColor = Color.Green;
                adress.Street = textBox4.Text;
            }
            else
            {
                textBox4.BackColor = Color.Red;
                CheckedForm = false;
            }

        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (validate.validate(REGEX_FOR_INT, textBox5.Text))
            {
                textBox5.BackColor = Color.Green;
                adress.House = int.Parse(textBox5.Text);
            }
            else
            {
                textBox5.BackColor = Color.Red;
                CheckedForm = false;

            }
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (validate.validate(REGEX_FOR_INT, textBox6.Text))
            {
                textBox6.BackColor = Color.Green;
                adress.Corps = int.Parse(textBox6.Text);
            }
            else
            {
                textBox6.BackColor = Color.Red;
                CheckedForm = false;

            }
        }
        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (validate.validate(REGEX_FOR_INT, textBox7.Text))
            {
                textBox7.BackColor = Color.Green;
                adress.NumberApartment = int.Parse(textBox7.Text);
            }
            else
            {
                textBox7.BackColor = Color.Red;
                CheckedForm = false;

            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            apartment.CountRoom = trackBar1.Value;
            label18.Text = trackBar1.Value.ToString();
        }
        public void CheckedBox()
        {
            
            bool KitchenTrue=false;
            if (checkBox5.Checked == true)
                KitchenTrue = false;
            else if (checkBox4.Checked==true)
                KitchenTrue = true;
            apartment.Kitchen = KitchenTrue;

            bool HallTrue = checkBox2.Checked;
            if (checkBox1.Checked == true)
                HallTrue = false;
            apartment.Hall = HallTrue;

            bool BedroomTrue = checkBox6.Checked;
            if (checkBox3.Checked == true)
                BedroomTrue = false;
            apartment.Bedroom = BedroomTrue;

            bool BathroomTrue = checkBox8.Checked;
            if (checkBox7.Checked == true)
                BathroomTrue = false;
            apartment.Bathroom = BathroomTrue;

        }
        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            apartment.Floor = (int)numericUpDown3.Value;
        }
        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (validate.validate(REGEX_FOR_TEXT, maskedTextBox1.Text))
            {
                apartment.TypeMaterial = maskedTextBox1.Text;
            }
            else
            {
                CheckedForm = false;
                MessageBox.Show("тип материала введён неверно");
            }
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            apartment.YearsBuilder = dateTimePicker1.Value;
        }
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            apartment.Area = (int)numericUpDown2.Value;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 FormTwo = new Form2();
            for (int i=0; i< apartments.Count; i++)
            {
                Adress adress1 = new Adress();
                Apartment apartment1 = new Apartment();
                apartment1.Adress = adress1;
                apartment1.Clone(apartments.ElementAt(i), apartment.Adress);
                FormTwo.apartments.Add(apartment1);
            }

            FormTwo.Show();

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

            using (StreamWriter fs = new StreamWriter("user" + ".xml", false, Encoding.Default))
            {
                    fs.Write(JsonConvert.SerializeObject(apartments, Formatting.Indented));
            }
            using (StreamReader sr = new StreamReader("user" + ".xml"))
            {
                string str = sr.ReadToEnd();
                MessageBox.Show(str);
            }
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Version 1.0 Creator Sakov Evgeni Vladimirovich");
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void сортировкаПоПлощадиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            int count = apartments.Count() - 1;
            var sortedList = from u in apartments
                             orderby u.Area
                             select u;
            Apartment[] mas = new Apartment[255];
            int j = 0;

            for (int i = count; i >= 0; i--)
            {
                mas[j] = sortedList.ElementAt(i);
                j++;
            }
            count = apartments.Count();
            apartments.Clear();
            for (int i = 0; i < count; i++)
            {
                textBox1.Text += mas[i].ToString() + "\n";
                apartments.Add(mas[i]);
            }
        }

        private void сортировкаПоКолвуКомнатToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            int count = apartments.Count() - 1;
            var sortedList = from u in apartments
                             orderby u.CountRoom
                             select u;
            Apartment[] mas = new Apartment[255];
            int j = 0;

            for (int i = count; i >= 0; i--)
            {
                mas[j] = sortedList.ElementAt(i);
                j++;
            }
            count = apartments.Count();
            apartments.Clear();
            for (int i = 0; i < count; i++)
            {
                textBox1.Text += mas[i].ToString() + "\n";
                apartments.Add(mas[i]);
            }
        }

        private void сортировкаПоЭтажуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            int count = apartments.Count() - 1;
            var sortedList = from u in apartments
                             orderby u.Floor
                             select u;
            Apartment[] mas = new Apartment[255];
            int j = 0;

            for (int i = count; i >= 0; i--)
            {
                mas[j] = sortedList.ElementAt(i);
                j++;
            }
            count = apartments.Count();
            apartments.Clear();
            for (int i = 0; i < count; i++)
            {
                textBox1.Text += mas[i].ToString() + "\n";
                apartments.Add(mas[i]);
            }
        }
    }
}
