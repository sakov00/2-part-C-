using System;
using System.Collections.Generic;
using System.Configuration;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Sakov.laba11
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static string connectionString = ConfigurationManager.ConnectionStrings["Connection"].ToString();
        List<UserApartment> List = new List<UserApartment>();
        public MainWindow()
        {
            InitializeComponent();
        }


        private void Add_Apartment_Click(object sender, RoutedEventArgs e)
        {
            AddElement task1 = new AddElement();
            task1.Show();
        }

        private void Delete_Apartment_Click(object sender, RoutedEventArgs e)
        {
            string Delete = $"DELETE  FROM Apartment WHERE Id={int.Parse(Delete_For_Id.Text)}";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                SqlCommand command = connection.CreateCommand();
                command.Transaction = transaction;
                try
                {
                    command.CommandText = Delete;
                    command.ExecuteNonQuery();
                    transaction.Commit();
                    MessageBox.Show("Данные удалены из базы данных");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    transaction.Rollback();
                }
            }
        }

        private void Modify_Apartment_Click(object sender, RoutedEventArgs e)
        {
            string Update = $"UPDATE Apartment SET {What_Atribut_Change.Text}={Value_Change.Text} WHERE Id={int.Parse(What_Change.Text)}";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                SqlCommand command = connection.CreateCommand();
                command.Transaction = transaction;
                try
                {
                    command.CommandText = Update;
                    command.ExecuteNonQuery();
                    transaction.Commit();
                    MessageBox.Show("Данные изменены в базе данных");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    transaction.Rollback();
                }
            }
        }

        private void Refresh_Click(object sender, RoutedEventArgs e)
        {
            List.Clear();
            ApartmentsGrid.ItemsSource = null;
            string sqlExpression = "SELECT * FROM Apartment";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows) // если есть данные
                {
                    while (reader.Read()) // построчно считываем данные
                    {
                        List.Add(new UserApartment
                        {
                            Metres = (int)reader.GetValue(2),
                            Value_Rooms = (int)reader.GetValue(3),
                            Year_Building = (DateTime)reader.GetValue(4),
                            Type_Material = (string)reader.GetValue(5),
                            Floor = (int)reader.GetValue(6),
                            Id = (int)reader.GetValue(0),
                            Id_Adress = (int)reader.GetValue(1)
                        });
                    }
                }
                reader.Close();
            }
            ApartmentsGrid.ItemsSource = List;
        }

        private void Sort_Click(object sender, RoutedEventArgs e)
        {
            List.Clear();
            ApartmentsGrid.ItemsSource = null;
            string Sort = $"Select * From Apartment ORDER BY {Sort_For_Atribute.Text} DESC";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandText = Sort;
                SqlDataReader reader = command.ExecuteReader();
              if (reader.HasRows) // если есть данные
                {
                    while (reader.Read()) // построчно считываем данные
                    {
                        List.Add(new UserApartment
                        {
                            Metres = (int)reader.GetValue(2),
                            Value_Rooms = (int)reader.GetValue(3),
                            Year_Building = (DateTime)reader.GetValue(4),
                            Type_Material = (string)reader.GetValue(5),
                            Floor = (int)reader.GetValue(6),
                            Id = (int)reader.GetValue(0),
                            Id_Adress = (int)reader.GetValue(1)
                        });
                    }
                }
                reader.Close();
            }
            ApartmentsGrid.ItemsSource = List;
        }
    }
}


