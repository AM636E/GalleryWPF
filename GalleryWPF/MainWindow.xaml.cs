﻿using System;
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
        ResourceDictionary _styles = new ResourceDictionary();
        

        public MainWindow()
        {
            InitializeComponent();

            this.Width = this.Height = 1200;
        }

        private void MainWindow_SizeChanged(Object sender, EventArgs args)
        {

        }

        private void Image_ImageFailed(object sender, ExceptionRoutedEventArgs e)
        {
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            PreviewPage p = new PreviewPage(this, _gallery, this.Width, this.Height);

            _mainFrame.NavigationService.Navigate(p);
        }

        private void textBlock1_SourceUpdated(object sender, DataTransferEventArgs e)
        {

        }

        private void button1_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
