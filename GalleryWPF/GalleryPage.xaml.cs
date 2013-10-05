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
    /// Interaction logic for GalleryPage.xaml
    /// </summary>
    public partial class GalleryPage : Page
    {
        Gallery _gallery;

        public GalleryPage()
        {
            InitializeComponent();
        }

        public GalleryPage(Gallery gallery)
         :this()
        {
            _gallery = gallery;
            _gallery.Grid = _galleryGrid;
            this.Loaded += GalleryPage_Loaded;
        }

        public GalleryPage(Gallery gallery, double width, double height)
            : this()
        {
            this.Width = width;
            this.Height = height;

            this.Loaded += GalleryPage_Loaded;

            _galleryGrid.Width = this.Width;
            _galleryGrid.Height = this.Height;

            _gallery = gallery;

            _gallery.Grid = _galleryGrid;
            _left.Click += MoveImage(+1);
            _right.Click += MoveImage(-1);
       }

        RoutedEventHandler MoveImage(int way)
        {
            return delegate(object sender, RoutedEventArgs e)
            {
                _gallery.MoveImage(way);
                _prevImage.Source = _gallery.GetImage(-1);
                _showedImage.Source = _gallery.CurrImage;
                _nextImage.Source = _gallery.GetImage(1);
            };
        }
        void GalleryPage_Loaded(object sender, RoutedEventArgs e)
        {
            _prevImage.Source = _gallery.GetImage(-1);
            _showedImage.Source = _gallery.CurrImage;
            _nextImage.Source = _gallery.GetImage(1);
        }

        private void PreviewPage_SizeChanged(object sender, SizeChangedEventArgs e)
        {
           
        }

        private void _left_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
