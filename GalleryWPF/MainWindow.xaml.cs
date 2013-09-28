using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GalleryWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Gallery _gallery;
        Grid _grid;
        public MainWindow()
        {
            InitializeComponent();

            GalleryImage gi = new GalleryImage(@"D:\GitHub\HTML_CSS_JAVASCRIPT\task3\memory_puzzle\images\2.jpg");


            _grid = new Grid();
            _grid.Width = this.Width;
            _grid.Height = this.Height;

           this.AddChild(_grid);

            _gallery = new Gallery(_grid);

            _gallery.Add(new GalleryImage(@"D:\GitHub\HTML_CSS_JAVASCRIPT\task3\memory_puzzle\images\2.jpg"));
            _gallery.Add(new GalleryImage(@"D:\GitHub\HTML_CSS_JAVASCRIPT\task3\memory_puzzle\images\2.jpg"));
            _gallery.Add(new GalleryImage(@"D:\GitHub\HTML_CSS_JAVASCRIPT\task3\memory_puzzle\images\2.jpg"));
            _gallery.Add(new GalleryImage(@"D:\GitHub\HTML_CSS_JAVASCRIPT\task3\memory_puzzle\images\2.jpg"));
            _gallery.Add(new GalleryImage(@"D:\GitHub\HTML_CSS_JAVASCRIPT\task3\memory_puzzle\images\2.jpg"));
            _gallery.Add(new GalleryImage(@"D:\GitHub\HTML_CSS_JAVASCRIPT\task3\memory_puzzle\images\2.jpg"));
            _gallery.Add(new GalleryImage(@"D:\GitHub\HTML_CSS_JAVASCRIPT\task3\memory_puzzle\images\2.jpg"));
            _gallery.Add(new GalleryImage(@"D:\GitHub\HTML_CSS_JAVASCRIPT\task3\memory_puzzle\images\2.jpg"));
            _gallery.Add(new GalleryImage(@"D:\GitHub\HTML_CSS_JAVASCRIPT\task3\memory_puzzle\images\2.jpg"));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello");
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello");
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Image_ImageFailed(object sender, ExceptionRoutedEventArgs e)
        {
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _gallery.ShowInGrid();
        }
    }
}
