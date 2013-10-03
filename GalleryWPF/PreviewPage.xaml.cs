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
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class PreviewPage : Page
    {
        public Grid GrMain { get { return _previewGrid; } }
        Gallery _gallery;
        public PreviewPage()
        {
            InitializeComponent();
        }

        public PreviewPage(Gallery gallery)
            :this()
        {
            this.Loaded += PreviewPage_Loaded;

            _previewGrid.Width = this.Width - 20;
            _previewGrid.Height = this.Height - 20;

            GalleryPage gp = new GalleryPage();

            _gallery = new Gallery(_previewGrid);
            
            _gallery.Add(new GalleryImage(@"D:\GitHub\HTML_CSS_JAVASCRIPT\task3\memory_puzzle\images\2.jpg"));
            _gallery.Add(new GalleryImage(@"D:\GitHub\HTML_CSS_JAVASCRIPT\task3\memory_puzzle\images\2.jpg"));
            _gallery.Add(new GalleryImage(@"D:\GitHub\HTML_CSS_JAVASCRIPT\task3\memory_puzzle\images\2.jpg"));
            _gallery.Add(new GalleryImage(@"D:\GitHub\HTML_CSS_JAVASCRIPT\task3\memory_puzzle\images\2.jpg"));
            _gallery.Add(new GalleryImage(@"D:\GitHub\HTML_CSS_JAVASCRIPT\task3\memory_puzzle\images\2.jpg"));
            _gallery.Add(new GalleryImage(@"D:\GitHub\HTML_CSS_JAVASCRIPT\task3\memory_puzzle\images\2.jpg"));
            _gallery.Add(new GalleryImage(@"D:\GitHub\HTML_CSS_JAVASCRIPT\task3\memory_puzzle\images\2.jpg"));
            _gallery.Add(new GalleryImage(@"D:\GitHub\HTML_CSS_JAVASCRIPT\task3\memory_puzzle\images\2.jpg"));
            _gallery.Add(new GalleryImage(@"D:\GitHub\HTML_CSS_JAVASCRIPT\task3\memory_puzzle\images\2.jpg"));

            GalleryPage galpage = new GalleryPage();

            this.NavigationService.Navigate(galpage);
        }

        private void PreviewPage_Loaded(object sender, RoutedEventArgs e)
        {
            _gallery.ShowInGrid();
        }
    }
}
