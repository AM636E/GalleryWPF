using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace GalleryWPF
{
    class GalleryImage
    {
        public const int PREVIEW_SIZE = 150;

        private Image _image;

        public static int Width { get { return PREVIEW_SIZE; } }
        public static int Height { get { return PREVIEW_SIZE; } } 

        public Image Image { get { return _image; } }

        public GalleryImage(string path)
        {
            _image = new Image();
            _image.Source = BitMapImageFromPath(path);
            _image.Width = PREVIEW_SIZE;
            _image.Height = PREVIEW_SIZE;
        }

        public BitmapImage BitMapImageFromPath(string path)
        {
            return new BitmapImage(new Uri(path));
        }
    }
}
