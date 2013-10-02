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
    class Gallery : List<GalleryImage>
    {
        private Grid _grid;

        private double _rows;
        private double _cols;
        private double _margin = 10;

        public Grid Grid { get { return _grid; } }

        public Gallery(Grid grid)
        {

            _grid = grid;
            _grid.ShowGridLines = true;
            _cols = _grid.Width / (GalleryImage.PREVIEW_SIZE);
            _rows = _grid.Height / (GalleryImage.PREVIEW_SIZE);
        }

        public void SetRowsNCols()
        {
            for (int i = 0; i < _rows; i++)
            {
                _grid.RowDefinitions.Add(new RowDefinition());
            }

            for (int i = 0; i < _cols; i++)
            {
                _grid.ColumnDefinitions.Add(new ColumnDefinition());
            }
        }

        public void ShowInGrid()
        {
            StackPanel sp;
            int k = 0;

            SetRowsNCols();

            for (int i = 0; i < _rows && k < this.Count; i++)
            {
                for (int j = 0; j < _cols && k < this.Count; j++, k++)
                {
                    sp = GalleryImage.MakeGalleryImage(this[k], _margin, "hi");

                    Grid.SetRow(sp, i);
                    Grid.SetColumn(sp, j);

                    _grid.Children.Add(sp);
                }
            }
        }
    }
}