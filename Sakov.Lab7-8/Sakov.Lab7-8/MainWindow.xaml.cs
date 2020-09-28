using System;
using System.Collections.Generic;
using System.ComponentModel;
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


namespace Sakov.Lab7_8
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private BindingList<Task> ListTask;
        public MainWindow()
        {
            try
            {
                InitializeComponent();
                SizeChanged += Window_SizeChanged;
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ListTask = new BindingList<Task>();
        }

        private void AddTask_Click(object sender, RoutedEventArgs e)
        {

            Task GeneralTask = new Task(calendarTask.SelectedDate.GetValueOrDefault(), comboBoxPeriod.Text, int.Parse(textBoxPriority.Text), textBoxName.Text, comboBoxCategory.Text, comboBoxStatus.Text);
            ListTask.Add(GeneralTask);
            DataGridTask.ItemsSource = ListTask;
        }

        private void DeleteTask_Click(object sender, RoutedEventArgs e)
        {
            ListTask.RemoveAt(int.Parse(textBoxDelete.Text));
        }

        private void ButtonSearch_ForCategory_Click(object sender, RoutedEventArgs e)
        {
            BindingList<Task> ListTaskSearch=new BindingList<Task>();
            for (int i = 0; i < ListTask.Count(); i++)
            {
                if (ListTask.ElementAt(i).Category == comboBoxSearchForCategory.Text)
                    ListTaskSearch.Add(ListTask.ElementAt(i));
            }
            DataGridTask.ItemsSource = ListTaskSearch;
        }

        private void ButtonSearch_ForPriority_Click(object sender, RoutedEventArgs e)
        {
            string boom = "";
            for (int i = 0; i < ListTask.Count(); i++)
            {
                if (ListTask.ElementAt(i).Priority == int.Parse(TextSearch_ForPriority.Text))
                    boom += ListTask.ElementAt(i).ToString();
            }
            MessageBox.Show(boom);
        }

        private void ButtonSearch_ForDay_Click(object sender, RoutedEventArgs e)
        {
            string boom = "";
            for (int i = 0; i < ListTask.Count(); i++)
            {
                if (ListTask.ElementAt(i).DateTimeTask.Day == int.Parse(TextSearchForDay.Text))
                    boom += ListTask.ElementAt(i).ToString();
            }
            MessageBox.Show(boom);
        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
                label.Width = ActualWidth / 10;
                label_Copy.Width = ActualWidth / 10;
                label_Copy1.Width = ActualWidth / 10;
                label_Copy2.Width = ActualWidth / 10;
                label_Copy3.Width = ActualWidth / 10;

                label.Height = ActualHeight / 10;
                label_Copy.Height = ActualHeight / 10;
                label_Copy1.Height = ActualHeight / 10;
                label_Copy2.Height = ActualHeight / 10;
                label_Copy3.Height = ActualHeight / 10;

                label.Height = ActualHeight / 10;
                label_Copy.Height = ActualHeight / 10;
                label_Copy1.Height = ActualHeight / 10;
                label_Copy2.Height = ActualHeight / 10;
                label_Copy3.Height = ActualHeight / 10;

                label.FontSize = ActualHeight/30;
                label_Copy.FontSize = ActualHeight / 30;
                label_Copy1.FontSize = ActualHeight / 30;
                label_Copy2.FontSize = ActualHeight / 30;
                label_Copy3.FontSize = ActualHeight / 30;

            DeleteTask.Width = ActualWidth / 10;
                AddTask.Width = ActualWidth / 10;
                Search.Width = ActualWidth / 10;
                ButtonSearch_ForCategory.Width = ActualWidth / 10;
                ButtonSearch_ForPriority.Width = ActualWidth / 10;
                ButtonSearch_ForDay.Width = ActualWidth / 10;

                DeleteTask.Height = ActualHeight / 20;
                AddTask.Height = ActualHeight / 20;
                Search.Height = ActualHeight / 20;
                ButtonSearch_ForCategory.Height = ActualHeight /20;
                ButtonSearch_ForPriority.Height = ActualHeight / 20;
                ButtonSearch_ForDay.Height = ActualHeight / 20;

                TextSearch_ForPriority.Width = ActualWidth / 10;
                TextSearchForDay.Width = ActualWidth / 10;
                textBoxDelete.Width = ActualWidth / 10;
                textBoxName.Width = ActualWidth / 10;
                textBoxPriority.Width = ActualWidth / 10;

                TextSearch_ForPriority.Height = ActualHeight / 20;
                TextSearchForDay.Height = ActualHeight / 20;
                textBoxDelete.Height = ActualHeight / 20;
                textBoxName.Height = ActualHeight / 20;
                textBoxPriority.Height = ActualHeight / 20;

                comboBoxPeriod.Width = ActualWidth / 10;
                comboBoxCategory.Width = ActualWidth / 10;
                comboBoxStatus.Width = ActualWidth / 10;
                comboBoxSearchForCategory.Width = ActualWidth / 10;

                comboBoxPeriod.Height = ActualHeight / 20;
                comboBoxCategory.Height = ActualHeight / 20;
                comboBoxStatus.Height = ActualHeight / 20;
                comboBoxSearchForCategory.Height = ActualHeight / 20;

                DataGridColumnName.Width= ActualWidth / 10;
                DataGridColumnPriority.Width= ActualWidth / 10;
                DataGridColumnPeriodicity.Width= ActualWidth / 10;
                DataGridColumnCategory.Width= ActualWidth / 10;
                DataGridColumnStatus.Width= ActualWidth / 10;
                DataGridColumnDateTimeTask.Width= ActualWidth / 10;
        }
        private void lbl1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Label lbl = (Label)sender;
            DragDrop.DoDragDrop(lbl, lbl.Content, DragDropEffects.Copy);
        }

        private void txtTarget_Drop(object sender, DragEventArgs e)
        {
            Resources["buttonBrush"] = new SolidColorBrush(Colors.LimeGreen);
            ((TextBlock)sender).Text = (string)e.Data.GetData(DataFormats.Text);
            if (txtTarget.Text == "Russian" || txtTarget.Text == "Русский")
            {
                Background = new SolidColorBrush(Colors.Red);
                label.Content = (string)FindResource("Name_rus");
                label_Copy.Content = (string)FindResource("Priority_rus");
                label_Copy1.Content = (string)FindResource("Period_rus");
                label_Copy2.Content = (string)FindResource("Category_rus");
                label_Copy3.Content = (string)FindResource("Status_rus");

                lbl2.Content = (string)FindResource("Russian_rus");
                lbl1.Content = (string)FindResource("English_rus");

                DeleteTask.Content = (string)FindResource("Delete_rus");
                AddTask.Content = (string)FindResource("Add_Task_rus");
                Search.Content = (string)FindResource("Search_rus");
                ButtonSearch_ForCategory.Content = (string)FindResource("SearchForCategory_rus");
                ButtonSearch_ForPriority.Content = (string)FindResource("SearchForPriority_rus");
                ButtonSearch_ForDay.Content = (string)FindResource("SearchForDay_rus");

                TextBlockCategory1.Text = (string)FindResource("Name_eng");
                TextBlockCategory2.Text = (string)FindResource("House_rus");
                TextBlockCategory3.Text = (string)FindResource("Friends_rus");
                TextBlockCategory4.Text = (string)FindResource("Study_rus");
                TextBlockCategory5.Text = (string)FindResource("Courses_rus");
                TextBlockCategory6.Text = (string)FindResource("Rest_rus");


                TextBlockCategory1_2.Text = (string)FindResource("Work_rus");
                TextBlockCategory2_2.Text = (string)FindResource("House_rus");
                TextBlockCategory3_2.Text = (string)FindResource("Friends_rus");
                TextBlockCategory4_2.Text = (string)FindResource("Study_rus");
                TextBlockCategory5_2.Text = (string)FindResource("Courses_rus");
                TextBlockCategory6_2.Text = (string)FindResource("Rest_rus");

                TextBlockStatus1.Text = (string)FindResource("Done_rus");
                TextBlockStatus2.Text = (string)FindResource("Failed_rus");
                TextBlockStatus3.Text = (string)FindResource("Transferred_rus");

                TextBlockPeriod1.Text = (string)FindResource("Single_Entry_rus");
                TextBlockPeriod2.Text = (string)FindResource("Weekly_rus");
                TextBlockPeriod3.Text = (string)FindResource("Monthly_rus");
                TextBlockPeriod4.Text = (string)FindResource("Annual_rus");

                DataGridColumnName.HeaderStyle = (Style)FindResource("TextColumn1_rus");
                DataGridColumnPriority.HeaderStyle = (Style)FindResource("TextColumn2_rus");
                DataGridColumnPeriodicity.HeaderStyle = (Style)FindResource("TextColumn3_rus");
                DataGridColumnCategory.HeaderStyle = (Style)FindResource("TextColumn4_rus");
                DataGridColumnStatus.HeaderStyle = (Style)FindResource("TextColumn5_rus");
                DataGridColumnDateTimeTask.HeaderStyle = (Style)FindResource("TextColumn6_rus");

            }
            else if (txtTarget.Text == "English" || txtTarget.Text == "Английский")
            {
                Background = new SolidColorBrush(Colors.Blue);
                label.Content = (string)FindResource("Name_eng");
                label_Copy.Content = (string)FindResource("Priority_eng");
                label_Copy1.Content = (string)FindResource("Period_eng");
                label_Copy2.Content = (string)FindResource("Category_eng");
                label_Copy3.Content = (string)FindResource("Status_eng");

                lbl2.Content = (string)FindResource("Russian_eng");
                lbl1.Content = (string)FindResource("English_eng");

                DeleteTask.Content = (string)FindResource("Delete_eng");
                AddTask.Content = (string)FindResource("Add_Task_eng");
                Search.Content = (string)FindResource("Search_eng");
                ButtonSearch_ForCategory.Content = (string)FindResource("SearchForCategory_eng");
                ButtonSearch_ForPriority.Content = (string)FindResource("SearchForPriority_eng");
                ButtonSearch_ForDay.Content = (string)FindResource("SearchForDay_eng");

                TextBlockCategory1.Text = (string)FindResource("Work_eng");
                TextBlockCategory2.Text = (string)FindResource("House_eng");
                TextBlockCategory3.Text = (string)FindResource("Friends_eng");
                TextBlockCategory4.Text = (string)FindResource("Study_eng");
                TextBlockCategory5.Text = (string)FindResource("Courses_eng");
                TextBlockCategory6.Text = (string)FindResource("Rest_eng");

                TextBlockCategory1_2.Text = (string)FindResource("Work_eng");
                TextBlockCategory2_2.Text = (string)FindResource("House_eng");
                TextBlockCategory3_2.Text = (string)FindResource("Friends_eng");
                TextBlockCategory4_2.Text = (string)FindResource("Study_eng");
                TextBlockCategory5_2.Text = (string)FindResource("Courses_eng");
                TextBlockCategory6_2.Text = (string)FindResource("Rest_eng");

                TextBlockStatus1.Text = (string)FindResource("Done_eng");
                TextBlockStatus2.Text = (string)FindResource("Failed_eng");
                TextBlockStatus3.Text = (string)FindResource("Transferred_eng");

                TextBlockPeriod1.Text = (string)FindResource("Single_Entry_eng");
                TextBlockPeriod2.Text = (string)FindResource("Weekly_eng");
                TextBlockPeriod3.Text = (string)FindResource("Monthly_eng");
                TextBlockPeriod4.Text = (string)FindResource("Annual_eng");


                DataGridColumnName.HeaderStyle = (Style)FindResource("TextColumn1_eng");
                DataGridColumnPriority.HeaderStyle = (Style)FindResource("TextColumn2_eng");
                DataGridColumnPeriodicity.HeaderStyle = (Style)FindResource("TextColumn3_eng");
                DataGridColumnCategory.HeaderStyle = (Style)FindResource("TextColumn4_eng");
                DataGridColumnStatus.HeaderStyle = (Style)FindResource("TextColumn5_eng");
                DataGridColumnDateTimeTask.HeaderStyle = (Style)FindResource("TextColumn6_eng");


            }
        }

        private void Button_Refresh_Click(object sender, RoutedEventArgs e)
        {
            DataGridTask.ItemsSource = ListTask;
        }
        private void Button_Background1_Click(object sender, RoutedEventArgs e)
        {
            Style = (Style)FindResource("Back1");
        }
        private void Button_Background2_Click(object sender, RoutedEventArgs e)
        {
            Style = (Style)FindResource("Back2");
        }
        private void Button_Background3_Click(object sender, RoutedEventArgs e)
        {
            Style = (Style)FindResource("Back3");
        }
        private void Exit_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Close();
        }
    }
    public class WindowCommands
    {
        static WindowCommands()
        {
            Exit = new RoutedCommand("Exit", typeof(MainWindow));
        }
        public static RoutedCommand Exit { get; set; }
    }
}
