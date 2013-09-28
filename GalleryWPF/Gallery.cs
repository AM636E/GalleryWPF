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
            _cols = _grid.Width / (150 + _margin);
            _rows = _grid.Height / (150 + _margin);
        }

        public void ShowInGrid()
        {
            Image curr;
            int k = 0;
            for (var i = 0; i < _rows && k < this.Count; i++)
            {
                _grid.RowDefinitions.Add(new RowDefinition());
                for (var j = 0; j < _cols && k < this.Count; j++, k++)
                {
                    _grid.ColumnDefinitions.Add(new ColumnDefinition());
                    curr = this[k].Image;

                    Grid.SetRow(curr, i);                                                          
                    Grid.SetColumn(curr, j);   
                    _grid.Children.Add(curr);                                                       
                }
            }                                                                                      
                                                                                                   
            for (var i = 0; i <2; i++)                                                   
            {       
                                                                          
                                                              
            }                                                                                      
        }
    }
}