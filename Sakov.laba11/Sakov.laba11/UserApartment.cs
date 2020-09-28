using System;
using System.Collections.Generic;
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
    /// Выполните шаги 1a или 1b, а затем 2, чтобы использовать этот пользовательский элемент управления в файле XAML.
    ///
    /// Шаг 1a. Использование пользовательского элемента управления в файле XAML, существующем в текущем проекте.
    /// Добавьте атрибут XmlNamespace в корневой элемент файла разметки, где он 
    /// будет использоваться:
    ///
    ///     xmlns:MyNamespace="clr-namespace:Sakov.laba11"
    ///
    ///
    /// Шаг 1б. Использование пользовательского элемента управления в файле XAML, существующем в другом проекте.
    /// Добавьте атрибут XmlNamespace в корневой элемент файла разметки, где он 
    /// будет использоваться:
    ///
    ///     xmlns:MyNamespace="clr-namespace:Sakov.laba11;assembly=Sakov.laba11"
    ///
    /// Потребуется также добавить ссылку из проекта, в котором находится файл XAML,
    /// на данный проект и пересобрать во избежание ошибок компиляции:
    ///
    ///     Щелкните правой кнопкой мыши нужный проект в обозревателе решений и выберите
    ///     "Добавить ссылку"->"Проекты"->[Поиск и выбор проекта]
    ///
    ///
    /// Шаг 2)
    /// Теперь можно использовать элемент управления в файле XAML.
    ///
    ///     <MyNamespace:UserApartment/>
    ///
    /// </summary>
    public class UserApartment : TextBox
    {
        public static readonly DependencyProperty Metres_Property;
        public static readonly DependencyProperty Value_Rooms_Property;
        public static readonly DependencyProperty Year_Building_Property;
        public static readonly DependencyProperty Type_Material_Property;
        public static readonly DependencyProperty Floor_Property;
        public static readonly DependencyProperty Id_Adress_Property;
        public static readonly DependencyProperty Id_Property;
        static UserApartment()
        {
            Metres_Property = DependencyProperty.Register("Metres", typeof(int), typeof(TextBox));
            Value_Rooms_Property = DependencyProperty.Register("Value_Rooms", typeof(int), typeof(TextBox));
            Year_Building_Property = DependencyProperty.Register("Year_Building", typeof(DateTime), typeof(TextBox));
            Type_Material_Property = DependencyProperty.Register("Type_Material", typeof(string), typeof(TextBox));
            Floor_Property = DependencyProperty.Register("Floor", typeof(int), typeof(TextBox));
            Id_Adress_Property = DependencyProperty.Register("Id_Adress", typeof(int), typeof(TextBox));
            Id_Property = DependencyProperty.Register("Id", typeof(int), typeof(TextBox));
        }
        public int Metres
        {
            get { return (int)GetValue(Metres_Property); }
            set { SetValue(Metres_Property, value); }
        }
        public int Value_Rooms
        {
            get { return (int)GetValue(Value_Rooms_Property); }
            set { SetValue(Value_Rooms_Property, value); }
        }
        public DateTime Year_Building
        {
            get { return (DateTime)GetValue(Year_Building_Property); }
            set { SetValue(Year_Building_Property, value); }
        }
        public string Type_Material
        {
            get { return (string)GetValue(Type_Material_Property); }
            set { SetValue(Type_Material_Property, value); }
        }
        public int Floor
        {
            get { return (int)GetValue(Floor_Property); }
            set { SetValue(Floor_Property, value); }
        }
        public int Id_Adress
        {
            get { return (int)GetValue(Id_Adress_Property); }
            set { SetValue(Id_Adress_Property, value); }
        }
        public int Id
        {
            get { return (int)GetValue(Id_Property); }
            set { SetValue(Id_Property, value); }
        }
        
    }
}
