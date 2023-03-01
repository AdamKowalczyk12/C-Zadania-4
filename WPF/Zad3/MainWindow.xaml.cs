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

namespace Zad3
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void txtBok_TextChanged(object sender, TextChangedEventArgs e)
        {
            double bok;
            if (double.TryParse(txtBok.Text, out bok) && bok >= 0)
            {
                txtPowierzchnia.Text = Math.Pow(bok, 2.0).ToString();
                labelBlad.Content = "";
                labelBlad.Background = Brushes.Transparent;
                txtObwod.Text = (bok * 4).ToString();
            }
            else
            {
                labelBlad.Content = "błąd";
                labelBlad.Background = Brushes.Gray;

            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            txtBok.Text = String.Empty;
            txtObwod.Text = String.Empty;
            txtPowierzchnia.Text = String.Empty;
            labelBlad.Content = String.Empty;
            labelBlad.Background = Brushes.Transparent;
        }

        private void btnRysuj_Click(object sender, RoutedEventArgs e)
        {
            double bok;
            if (double.TryParse(txtBok.Text, out bok) && bok <= 380) // Większy się nie zmieści w zadanym oknie
            {
                rectangle1.Height = bok;
                rectangle1.Width = bok;
                SolidColorBrush color = (SolidColorBrush)new
                BrushConverter().ConvertFromString(cmbKolory.Text); // konweresja koloru z typu string na wymagany
                rectangle1.Stroke = color; // przypisanie wybranego koloru dla konturu
                rectangle1.Fill = color; // przypisanie wybranego koloru dla wypełnienia
                rectangle1.Opacity = cbOpacity.IsChecked.Value ? 0.5 : 1; // IsChecked.Value jest typu bool
                                                                          // (jeśli true, to dajemy wartość Opacity na 50%, w przeciwnym razie 100%)
            }
            else
            {
                labelBlad.Content = "Brak danych lub zbyt duży bok";
            }
        }

        private void RadioButton_Checked_Hidden(object sender, RoutedEventArgs e)
        {
            rectangle1.Visibility = Visibility.Hidden;
        }

        private void RadioButton_Checked_Visible(object sender, RoutedEventArgs e)
        {
            rectangle1.Visibility = Visibility.Visible;
        }

        private void cmbKolory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void cbOpacity_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}