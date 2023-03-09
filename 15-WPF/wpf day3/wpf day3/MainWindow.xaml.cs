using System;
using System.Collections.Generic;
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

namespace wpf_day3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Student> Students { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            Students = new List<Student>()
            {
                new Student(){Name="manar",Id=10,Image="girl.jpg",Age=23,Grade=50},
                new Student(){Name="sara",Id=20,Image="girl.jpg",Age=22,Grade=60},
                new Student(){Name="maryam",Id=30,Image="girl.jpg", Age=23,Grade=70},




            };
            lst.ItemsSource = Students;
        }
    }
}
