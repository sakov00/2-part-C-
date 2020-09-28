using Microsoft.ApplicationInsights.Extensibility.Implementation;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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

namespace Sakov.laba12
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Add_Apartment_Click(object sender, RoutedEventArgs e)
        {
            using (ApartmentContext db1 = new ApartmentContext())
            {
                using (var transaction = db1.Database.BeginTransaction())
                {
                    try
                    {
                        var adresses = db1.Adresses;
                        Adress adress1 = new Adress();
                        foreach (Adress adr in adresses)
                        {
                            if (TextBox_AddApartment.Text == adr.City)
                                adress1 = adr;
                        }
                        if (adress1 != null)
                        {

                            Apartment apart1 = new Apartment(int.Parse(Area.Text), int.Parse(CountRoom.Text), DateTime.Parse(YearsBuilder.Text), TypeMaterial.Text, int.Parse(Floor.Text), adress1);
                            db1.Apartments.Add(apart1);
                            db1.SaveChanges();
                            transaction.Commit();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        transaction.Rollback();
                    }
                }
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            using (ApartmentContext db1 = new ApartmentContext())
            {
                var apartment = db1.Apartments;
                foreach (Apartment apart in apartment)
                {
                    if (int.Parse(TextBox_DeleteId.Text) == apart.Id)
                        db1.Entry(apart).State = EntityState.Deleted;
                }
                db1.SaveChanges();
            }
        }

        private void Add_Adress_Click(object sender, RoutedEventArgs e)
        {
            using (ApartmentContext db1 = new ApartmentContext())
            {
                    Adress adress1 = new Adress(Country.Text, Town.Text);
                    db1.Adresses.Add(adress1);
                    db1.SaveChanges();
            }

        }

        private void Add_Changes_Click(object sender, RoutedEventArgs e)
        {
            using (ApartmentContext db1 = new ApartmentContext())
            {
                var apartment = db1.Apartments;
                foreach (Apartment apart in apartment)
                {
                    if (int.Parse(TextBox_ChangeApartment.Text) == apart.Id)
                    {
                        apart.Area = int.Parse(Area.Text);
                        apart.CountRoom = int.Parse(CountRoom.Text);
                        apart.YearsBuilder = DateTime.Parse(YearsBuilder.Text);
                        apart.TypeMaterial = TypeMaterial.Text;
                        apart.Floor = int.Parse(Floor.Text);
                        db1.Entry(apart).State = EntityState.Modified;
                    }

                }
                db1.SaveChanges();
            }
        }

        private void Search_for_Area_Click(object sender, RoutedEventArgs e)
        {
            using (ApartmentContext db1 = new ApartmentContext())
            {
                var apartment = db1.Apartments.Where(p => p.Area.ToString() == Search_for_Area_text.Text);
                foreach (Apartment apart in apartment)
                {
                        MessageBox.Show(apart.ToString());
                }
            }
        }

        private void Search_for_City_Click(object sender, RoutedEventArgs e)
        {
            using (ApartmentContext db1 = new ApartmentContext())
            {
                var adress = db1.Adresses.First(p => p.City == Search_for_City_text.Text);
                var apartment = db1.Apartments.Where(p => p.Adress.Id == adress.Id);
                foreach (Apartment apart in apartment)
                {
                    MessageBox.Show(apart.ToString());
                }
            }
        }

        private void Refresh_Click(object sender, RoutedEventArgs e)
        {
            using (ApartmentContext db1 = new ApartmentContext())
            {
                List<Apartment> kak1 = new List<Apartment>();
                List<Adress> kak2 = new List<Adress>();
                var adresses = db1.Adresses;
                foreach (Adress adr in adresses)
                {
                    kak2.Add(adr);
                }
                var apartment = db1.Apartments;
                foreach (Apartment apart in apartment)
                {
                    kak1.Add(apart);
                }
                DataApartment.ItemsSource = kak1;
                DataAdress.ItemsSource = kak2;
            }
        }

        private void Sort_For_Area_Click(object sender, RoutedEventArgs e)
        {
            using (ApartmentContext db1 = new ApartmentContext())
            {
                List<Apartment> kak1 = new List<Apartment>();
                List<Adress> kak2 = new List<Adress>();
                var adresses = db1.Adresses;
                foreach (Adress adr in adresses)
                {
                    kak2.Add(adr);
                }
                var apartment = db1.Apartments.OrderByDescending(p => p.Area);
                foreach (Apartment apart in apartment)
                {
                    kak1.Add(apart);
                }
                DataApartment.ItemsSource = kak1;
                DataAdress.ItemsSource = kak2;
            }
        }
    }
}
