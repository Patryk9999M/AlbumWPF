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

namespace Album.PhotoWindow.Rozne
{
    /// <summary>
    /// Interaction logic for Imprezy.xaml
    /// </summary>
    public partial class Imprezy : Window
    {
        List<ImagePath> images = new List<ImagePath>();
        string root = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        public Imprezy()
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
            AddImages();
            ImageList.ItemsSource = images;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CopyImages();
            ImageList.ItemsSource = null;

            images.Clear();
            AddImages();
            

            ImageList.ItemsSource = images;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            MessageBox.Show(ImageList.SelectedItems);

            File.Delete(@"E:\\Programowanie\\Album\\bin\\Debug\net5.0-windows\\Images\\Rozne\\Imprezy\\977913.jpg");

        }

        void AddImages()
        {
            var files = Directory.GetFiles(System.IO.Path.Combine(root, "Images\\Rozne\\Imprezy"), "*.*");

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

        void CopyImages()
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
                string _finalPath = System.IO.Path.Combine(root, "Images\\Rozne\\Imprezy").ToString(); //it is the destination folder path e.g,C:\Users\Neha\Pictures\11-03-2014
                if (Directory.Exists(_finalPath))
                {

                    _finalPath = System.IO.Path.Combine(_finalPath, filename2);

                    System.IO.File.Copy(file, _finalPath, true);
                }

            }
        }
        
    }
}
