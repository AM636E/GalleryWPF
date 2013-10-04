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

        public PreviewPage(Gallery gallery,double width, double height)
            :this()
        {
            this.Width = width;
            this.Height = height;

            this.Loaded += PreviewPage_Loaded;

            _previewGrid.Width = this.Width ;
            _previewGrid.Height = this.Height;

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

            this.SizeChanged += PreviewPage_SizeChanged;
            this._gallery.ImageClicked += _gallery_ImageClicked;
        }

        void _gallery_ImageClicked(object sender, EventArgs e)
        {
            MessageBox.Show(_gallery.ClickedIndex.ToString());
        }

        public PreviewPage(Window owner, Gallery gallery, double width, double height)
        :this(gallery, width, height)
        {
            owner.SizeChanged += PreviewPage_SizeChanged;
        }

        private void PreviewPage_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if(sender is Window)
            {
                Window window = sender as Window;
                this.Width = window.Width;
                this.Height = window.Height;
                _previewGrid.Width = this.Width ;
                _previewGrid.Height = this.Height ;
            }
            _gallery.ShowInGrid();
        }

        private void PreviewPage_Loaded(object sender, RoutedEventArgs e)
        {
        }
    }
}
