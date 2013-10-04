using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Media;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace GalleryWPF
{
    public class Gallery : List<GalleryImage>
    {
        private Grid _grid;

        public event EventHandler ImageClicked;

        private double _rows;
        private double _cols;
        private double _margin = 5;
        private int _clickedImageIndex;

        public int ClickedIndex { get { return _clickedImageIndex; } }

        public event EventHandler OnAdd;

        public Grid Grid { get { return _grid; } }

        public Gallery(Grid grid)
        {
            _grid = grid;
            _cols = _grid.Width / (GalleryImage.PREVIEW_SIZE);
            _rows = _grid.Height / (GalleryImage.PREVIEW_SIZE);
        }

        public void SetRowsNCols()
        {
            _cols = _grid.Width / (GalleryImage.PREVIEW_SIZE) -1;
            _rows = _grid.Height / (GalleryImage.PREVIEW_SIZE) -1;

            _grid.RowDefinitions.Clear();
            _grid.ColumnDefinitions.Clear();

            for (int i = 0; i < _rows; i++)
            {
                _grid.RowDefinitions.Add(new RowDefinition());
            }

            for (int i = 0; i < _cols; i++)
            {
                _grid.ColumnDefinitions.Add(new ColumnDefinition());
            }            
        }



        public new void Add(GalleryImage i)
        {
            base.Add(i);
            if(OnAdd != null)
            {
                OnAdd(this, EventArgs.Empty);
            }
        }        

        public void ShowInGrid()
        {
            StackPanel sp;
            int k = 0;

            SetRowsNCols();
            _grid.Children.Clear();
            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _cols  && k < this.Count; j++, k++)
                {
                    sp = GalleryImage.MakeGalleryImage(this[k], _margin, "hi");
                    
                    _img.Add(sp);

                    Grid.SetRow(sp, i);
                    Grid.SetColumn(sp, j);

                    _grid.Children.Add(sp);
                }
            }
        }

        List<StackPanel> _img = new List<StackPanel>();

        private void AddHandlers(List<StackPanel> panels, System.Windows.Input.MouseButtonEventHandler handler)
        {
            foreach(StackPanel panel in panels)
            {
                panel.MouseLeftButtonDown += handler;
            }
        }



        private void ImageClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            GalleryImage i = sender as GalleryImage;

            _clickedImageIndex = this.IndexOf(i);

            if(ImageClicked != null)
            {
                ImageClicked(this, EventArgs.Empty);
            }
        }
    }
}