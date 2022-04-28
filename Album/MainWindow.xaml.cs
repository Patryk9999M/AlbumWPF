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
using System.IO;
using Microsoft.Win32;
using Album.PhotoWindow.Dziecinstwo;
using System.ComponentModel;
using Album.PhotoWindow.DorosleZycie;
using Album.PhotoWindow.LataSzkolne;
using Album.PhotoWindow.Rozne;

namespace Album
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Narodziny narodziny = new();
        PierwszeKroki pierwszeKroki = new();

        Malzenstwo malzenstwo = new();
        Praca praca = new();
        Rodzina rodzina = new();

        Przedszkole przedszkole = new();
        SzkolaPodstawowa szkolaPodstawowa = new();
        SzkolaSrednia szkolaSrednia = new();
        Studia studia = new();

        Imprezy imprezy = new();
        Inne inne= new();
        Wycieczki wycieczki = new();
       

        public MainWindow()
        {
            InitializeComponent();
        }

       

        private void exitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void OnClosing(object sender, CancelEventArgs e)
        {


            e.Cancel = true;
            Application.Current.Shutdown();

        }

        private void childhoodButton_Click(object sender, RoutedEventArgs e)
        {
            if (childhoodComboBox.SelectedIndex == 0)
            {
                narodziny.Show();
            }

            if (childhoodComboBox.SelectedIndex == 1)
            {
                pierwszeKroki.Show();
            }
        }

        private void schoolButton_Click(object sender, RoutedEventArgs e)
        {
            if (schoolComboBox.SelectedIndex == 0)
            {
                przedszkole.Show();
            }

            if (schoolComboBox.SelectedIndex == 1)
            {
                szkolaPodstawowa.Show();
            }
            if (schoolComboBox.SelectedIndex == 2)
            {
                szkolaSrednia.Show();
            }

            if (schoolComboBox.SelectedIndex == 3)
            {
                studia.Show();
            }
        }

        private void adultButton_Click(object sender, RoutedEventArgs e)
        {
            if (adultComboBox.SelectedIndex == 0)
            {
                malzenstwo.Show();
            }

            if (adultComboBox.SelectedIndex == 1)
            {
                rodzina.Show();
            }
            if (adultComboBox.SelectedIndex == 2)
            {
               praca.Show();
            }
        }

        private void miscButton_Click(object sender, RoutedEventArgs e)
        {
            if (miscComboBox.SelectedIndex == 0)
            {
                imprezy.Show();
            }

            if (miscComboBox.SelectedIndex == 1)
            {
                wycieczki.Show();
            }
            if (miscComboBox.SelectedIndex == 2)
            {
                inne.Show();
            }
        }
    }
}
