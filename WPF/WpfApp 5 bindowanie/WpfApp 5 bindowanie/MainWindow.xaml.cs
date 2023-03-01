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

namespace WpfApp_5_bindowanie
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Person> ListOfPersons = null;
        private List<string> Genders { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            InitBinding();
        }
        private void InitBinding()
        {
            ListOfPersons = new List<Person>();
            ListOfPersons.Add(new Person(1, "Adam", "Kowalski", 24, "Mężczyzna"));
            ListOfPersons.Add(new Person(2, "Jan", "Kowalski", 23, "Mężczyzna"));
            ListOfPersons.Add(new Person(3, "Agnieszka", "Kowalczyk", 28, "Kobieta"));
            ListOfPersons.Add(new Person(4, "Janusz", "Abacki", 25, "Mężczyzna"));
            ourGrid.ItemsSource = ListOfPersons;
            Genders = new List<string>();
            Genders.Add("Mężczyzna");
            Genders.Add("Kobieta");
            ourGrid.ItemsSource = ListOfPersons;
            Gender.ItemsSource = Genders;
        }
    }
}
