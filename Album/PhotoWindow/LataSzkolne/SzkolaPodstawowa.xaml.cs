using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Windows.Shapes;

namespace Album.PhotoWindow.LataSzkolne
{
    /// <summary>
    /// Interaction logic for SzkolaPodstawowa.xaml
    /// </summary>
    public partial class SzkolaPodstawowa : Window
    {
        List<ImagePath> images = new List<ImagePath>();
        string root = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        public SzkolaPodstawowa()
        {
            InitializeComponent();
        }
        private void OnClosing(object sender, CancelEventArgs e)
        {

            e.Cancel = true;

            Visibility = Visibility.Hidden;


        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var files = Directory.GetFiles(System.IO.Path.Combine(root, "Images\\LataSzkolne\\SzkolaPodstawowa"), "*.*");

            foreach (var file in files)
            {
                ImagePath id = new ImagePath()
                {
                    Path = file,
                    FileName = System.IO.Path.GetFileName(file),

                };
                images.Add(id);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ImageList.ItemsSource = images;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = "Image jpeg(*.jpg)|*.jpg|Image png(*.png)|*.png";
            ofd.DefaultExt = ".jpeg";

            // Process open file dialog box results 
            if (ofd.ShowDialog() == true)
            {
                var filename = ofd.FileName; // Get the filename from absolute path
                var file = System.IO.Path.GetFullPath(ofd.FileName);

                var filename2 = file.Substring(file.LastIndexOf("\\") + 1);
                string _finalPath = System.IO.Path.Combine(root, "Images\\LataSzkolne\\SzkolaPodstawowa").ToString(); //it is the destination folder path e.g,C:\Users\Neha\Pictures\11-03-2014
                if (Directory.Exists(_finalPath))
                {

                    _finalPath = System.IO.Path.Combine(_finalPath, filename2);

                    System.IO.File.Copy(file, _finalPath, true);
                }

            }
        }
    }
}
