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
        public static int PREVIEW_SIZE { get { return 250; } }

        private string _path;
        private string _label;
        private int _rate;

        public string Path { get { return _path;  } }

        public GalleryImage(string path)
        {
            _path = path;
        }

        public GalleryImage(string path, string label): 
            this( path )
        {
            _label = label;
        }

        public GalleryImage(string path, string label, int rate)
        :this(path, label)
        {
            _rate = rate;
        }

        public static BitmapImage GetBitmapImageFromPath(string path)
        {
            return new BitmapImage(new Uri(path));
        }

        public static StackPanel MakeGalleryImage(
            GalleryImage im,
            double margin,
            string label
        )
        {
            Image i = new Image();            
            i.Source = GalleryImage.GetBitmapImageFromPath(im.Path);
            i.Width = i.Height = 200;
           
            StackPanel sp = new StackPanel();
            sp.Width = sp.Height = PREVIEW_SIZE;
            i.Margin = new Thickness(margin);

            sp.Style = (Style)sp.FindResource("StackPanelStyle");

            sp.Children.Add(i);

            TextBlock tx = new TextBlock();
            Border b = new Border();
            sp.Children.Add(b);

            tx.TextAlignment = TextAlignment.Center;
            tx.Text = label;
            sp.Children.Add(tx);

            return sp;
        }
    }
}
