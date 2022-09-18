using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Gallery
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //public ObservableCollection<UserControl1> Photos { get; set; }
        //public MainWindow()
        //{
        //    InitializeComponent();
        //    this.DataContext = this;
        //    Photos = new ObservableCollection<UserControl1>();
        //}
        //private void AddFile_MenuItem_Click(object sender, RoutedEventArgs e)
        //{
        //    OpenFileDialog op = new OpenFileDialog();
        //    op.Title = "Select a picture";
        //    op.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
        //      "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
        //      "Portable Network Graphic (*.png)|*.png";
        //    if (op.ShowDialog() == true)
        //    {
        //        UserControl userControl = new UserControl();

        //        //.Source = new BitmapImage(new Uri(op.FileName));
        //    }
        //}

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    OpenFileDialog op = new OpenFileDialog();
        //    op.Title = "Select a picture";
        //    op.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
        //      "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
        //      "Portable Network Graphic (*.png)|*.png";
        //    if (op.ShowDialog() == true)
        //    {
        //        if(op.CheckFileExists == true)
        //        {
        //            UserControl1 userControl1 = new UserControl1();
        //            userControl1.MouseEnter += UserControl1_MouseEnter;
        //            userControl1.MouseLeave += UserControl1_MouseLeave;
        //            userControl1.MouseUp += UserControl1_MouseUp;
        //            userControl1.Width = 200;
        //            userControl1.Height = 200;
        //            userControl1.img.Source = new BitmapImage(new Uri(op.FileName));
        //            Photos.Add(userControl1);

        //        }

        //    }
        //}

        //private void UserControl1_MouseUp(object sender, MouseButtonEventArgs e)
        //{
        //    var sender2 = sender as UserControl1;
        //    UserControl2 userControl2 = new UserControl2();
        //    userControl2.Img = new BitmapImage(new Uri(sender2.img.Source.ToString()));
        //    userControl2.Photos = Photos;
        //    MainGrid.Children.Add(userControl2);
        //}

        //private void UserControl1_MouseLeave(object sender, MouseEventArgs e)
        //{
        //    var sender2 = sender as UserControl1;
        //    sender2.BorderBrush = null;

        //}

        //private void UserControl1_MouseEnter(object sender, MouseEventArgs e)
        //{
        //    var sender2 = sender as UserControl1;
        //    sender2.BorderThickness = new Thickness(1.5);
        //    sender2.BorderBrush = Brushes.Blue;
        //}

        public ObservableCollection<Image> Photos { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            Photos = new ObservableCollection<Image>();
        }
        private void AddFile_MenuItem_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Select a picture";
            op.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
              "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
              "Portable Network Graphic (*.png)|*.png";
            if (op.ShowDialog() == true)
            {
                UserControl userControl = new UserControl();

                //.Source = new BitmapImage(new Uri(op.FileName));
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Select a picture";
            op.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
              "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
              "Portable Network Graphic (*.png)|*.png";
            if (op.ShowDialog() == true)
            {
                if (op.CheckFileExists == true)
                {

                    Image newPhoto = new Image();
                    newPhoto.Source = new BitmapImage(new Uri(op.FileName));
                    newPhoto.Height = 200;
                    newPhoto.Width = 200;
                    Photos.Add(newPhoto);

                }

            }
        }
        private void MainListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var photo = MainListBox.SelectedItem as Image;

            UserControl2 userControl2 = new UserControl2();
            //userControl2.Img = new BitmapImage(new Uri(photo.Source.ToString()));
            userControl2.Img1 = photo;
            userControl2.Photos = Photos;
            MainGrid.Children.Add(userControl2);
        }
    }
}
