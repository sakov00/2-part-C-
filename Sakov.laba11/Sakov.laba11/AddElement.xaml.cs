using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Configuration;

namespace Sakov.laba11
{
    /// <summary>
    /// Логика взаимодействия для AddElement.xaml
    /// </summary>
    public partial class AddElement : Window
    {
        public static string connectionString = ConfigurationManager.ConnectionStrings["Connection"].ToString();
        public AddElement()
        {
            InitializeComponent();
        }
        private void RegisterUsers_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            int Id_Adress = rnd.Next(0, 100000);
            string AddApartment = $"INSERT INTO Apartment (Metres, Value_Rooms, Year_Building, Type_Material, Floor,Id,Id_Adress) VALUES ({int.Parse(Metres.Text)}, {int.Parse(Value_Rooms.Text)}, '{DateTime.Parse(Year_Building.Text)}', '{Type_Material.Text}',{int.Parse(Floor.Text)},{rnd.Next(0, 100000)},{Id_Adress})";
            string AddAdress = $"INSERT INTO Adress (Country, City, Street, House,Corpus,Number,Id_Adress) VALUES ('{Country.Text}', '{City.Text}', '{Street.Text}', {int.Parse(House.Text)},{int.Parse(Corpus.Text)},{int.Parse(Number.Text)},{Id_Adress})";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                SqlCommand command = connection.CreateCommand();
                command.Transaction = transaction;
                try
                {
                command.CommandText = AddAdress;
                command.ExecuteNonQuery();
                command.CommandText = AddApartment;
                command.ExecuteNonQuery();
                transaction.Commit();
                MessageBox.Show("Данные добавлены в базу данных");
                Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    transaction.Rollback();
                }
            }
        }
        private void OutPut_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Two_Add_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            int Id_Adress = rnd.Next(0, 100000);
            int Id_Adress2 = rnd.Next(0, 100000);
            string MEM1= $"INSERT INTO Apartment (id,Type_Material,Id_Adress) VALUES ({rnd.Next(0, 100000)},'Hi',{Id_Adress2})";
            string AddApartment = $"INSERT INTO Apartment (Metres, Value_Rooms, Year_Building, Type_Material, Floor,Id,Id_Adress) VALUES ({int.Parse(Metres.Text)}, {int.Parse(Value_Rooms.Text)}, '{DateTime.Parse(Year_Building.Text)}', '{Type_Material.Text}',{int.Parse(Floor.Text)},{rnd.Next(0, 100000)},{Id_Adress});{MEM1}";
            
            string MEM2 = $"INSERT INTO Adress (Id_Adress) VALUES ({Id_Adress2})";
            string AddAdress = $"INSERT INTO Adress (Country, City, Street, House,Corpus,Number,Id_Adress) VALUES ('{Country.Text}', '{City.Text}', '{Street.Text}', {int.Parse(House.Text)},{int.Parse(Corpus.Text)},{int.Parse(Number.Text)},{Id_Adress});{MEM2}";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                SqlCommand command = connection.CreateCommand();
                command.Transaction = transaction;
                try
                {
                    command.CommandText = AddAdress;
                    command.ExecuteNonQuery();
                    command.CommandText = AddApartment;
                    command.ExecuteNonQuery();
                    transaction.Commit();
                    MessageBox.Show("Данные добавлены в базу данных");
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    transaction.Rollback();
                }
            }
        }
    }
}
