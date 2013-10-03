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
    public class GalleryImage
    {
        public static int PREVIEW_SIZE { get { return 250; } }

        private string _path;
        private string _label;
        private int _rate;
        private int _index;

        public int Index { get { return _index; } set { _index = value;  } }

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

            Border b = new Border();
            b.BorderBrush = new SolidColorBrush(System.Windows.Media.Colors.White);
            StackPanel sp = new StackPanel();
            sp.Children.Add(b);
            sp.Width = sp.Height = PREVIEW_SIZE;
            i.Margin = new Thickness(margin);

            sp.Children.Add(i);

            TextBlock tx = new TextBlock();

            tx.TextAlignment = TextAlignment.Center;
            tx.Text = label;
            sp.Children.Add(tx);

            return sp;
        }
    }
}
