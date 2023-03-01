using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace Zad5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitBinding();
        }

        public void InitBinding()
        {
            // utwórz obiekt na podstawie klasy osoba i wykorzystaj go
            // jako źródło danych dla utworzonego Grid'a (DataContext)
            gridInformacjeOsoba.DataContext = new Osoba(1, "Jan", "Kowalski", 34);
        }

        private void BtnOdczytaj_Click(object sender, RoutedEventArgs e)
        {
            var openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == true)
            {
                gridInformacjeOsoba.DataContext = ReadOsobaFromCsv(openFileDialog.FileName);
                // po kliknięciu przycisku do pola txtOsoba należy przypisać
                // wynik zwracany przez metodę Osoba.ToString()
                txtOsoba.Text = gridInformacjeOsoba.DataContext.ToString();
            }
        }

        private void BtnZapisz_Click(object sender, RoutedEventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();

            if (saveFileDialog.ShowDialog() == true)
            {
                 SaveOsobaToCsv(saveFileDialog.FileName, (Osoba)gridInformacjeOsoba.DataContext);
            }
        }

        private void SaveOsobaToCsv(string csvFileName, Osoba osoba)
        {
            File.WriteAllText(csvFileName, $"{osoba.ID};{osoba.Imie};{osoba.Nazwisko};{osoba.Wiek}");
        }

        private Osoba ReadOsobaFromCsv(string csvFileName)
        {
            var firstLine = File.ReadLines(csvFileName).First();
            var dataFromFirstLine = firstLine.Split(';', StringSplitOptions.TrimEntries);

            return new Osoba(
                int.Parse(dataFromFirstLine[0]),
                dataFromFirstLine[1],
                dataFromFirstLine[2],
                int.Parse(dataFromFirstLine[3]));
        }

        private IEnumerable<Osoba> ReadOsobyFromCsv(string csvFileName)
        {
            var listOdOsoba = new List<Osoba>();
            foreach (var line in File.ReadLines(csvFileName))
            {
                var lineData = line.Split(';', StringSplitOptions.TrimEntries);
                listOdOsoba.Add( 
                    new Osoba(
                        int.Parse(lineData[0]),
                        lineData[1],
                        lineData[2],
                        int.Parse(lineData[3])
                        ));
            }

            return listOdOsoba;

            return File.ReadLines(csvFileName).Select(line =>
            {
                var lineData = line.Split(';', StringSplitOptions.TrimEntries);
                return new Osoba(
                        int.Parse(lineData[0]),
                        lineData[1],
                        lineData[2],
                        int.Parse(lineData[3])
                        );
            });
        }
    }
}