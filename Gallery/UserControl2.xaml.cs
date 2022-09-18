using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for UserControl2.xaml
    /// </summary>
    public partial class UserControl2 : UserControl
    {
        //public ObservableCollection<UserControl1> Photos { get; set; }
        //public BitmapImage Img
        //{
        //    get { return (BitmapImage)GetValue(ImgProperty); }
        //    set { SetValue(ImgProperty, value); }
        //}

        //// Using a DependencyProperty as the backing store for Img.  This enables animation, styling, binding, etc...
        //public static readonly DependencyProperty ImgProperty =
        //    DependencyProperty.Register("Img", typeof(BitmapImage), typeof(UserControl2));


        //public UserControl2()
        //{
        //    InitializeComponent();

        //    this.DataContext = this;
        //}

        //private void BackButton_Click(object sender, RoutedEventArgs e)
        //{

        //    this.Visibility = Visibility.Collapsed;
        //}

        //private void PrevBtn_Click(object sender, RoutedEventArgs e)
        //{

        //    //MessageBox.Show($"{this.Parent.GetType()}");
        //}

        public ObservableCollection<Image> Photos { get; set; }


        public Image Img1
        {
            get { return (Image)GetValue(Img1Property); }
            set { SetValue(Img1Property, value); }
        }

        // Using a DependencyProperty as the backing store for Img1.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty Img1Property =
            DependencyProperty.Register("Img1", typeof(Image), typeof(UserControl2));


        //public BitmapImage Img
        //{
        //    get { return (BitmapImage)GetValue(ImgProperty); }
        //    set { SetValue(ImgProperty, value); }
        //}

        //// Using a DependencyProperty as the backing store for Img.  This enables animation, styling, binding, etc...
        //public static readonly DependencyProperty ImgProperty =
        //    DependencyProperty.Register("Img", typeof(BitmapImage), typeof(UserControl2));


        public UserControl2()
        {
            InitializeComponent();
           
            this.DataContext = this;
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {

            this.Visibility = Visibility.Collapsed;
        }

        private void PrevBtn_Click(object sender, RoutedEventArgs e)
        {

            int index = Photos.IndexOf(Img1);
            if(index > 0)
            {
                Img1 = Photos[index - 1];
            }
            //Img1 = null;
        }

        private void NextBtn_Click(object sender, RoutedEventArgs e)
        {
            int index = Photos.IndexOf(Img1);
            
            if (index < Photos.Count-1)
            {
                Img1 = Photos[index + 1];
            }
        }
    }
}
