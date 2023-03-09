using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Wpf_day1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

                    //switch(((RadioButton) sender).Content.ToString())

        private void Change_Color(object sender, RoutedEventArgs e)
        {
            switch (((RadioButton)sender).Content.ToString())
            {
                case "Red":

                    InkCan.DefaultDrawingAttributes.Color = Colors.Red;
                    break;

                case "Green":

                    InkCan.DefaultDrawingAttributes.Color = Colors.Green;
                    break;

                case "Blue":

                    InkCan.DefaultDrawingAttributes.Color = Colors.Blue;
                    break;
            }
        }

        private void Change_Mode(object sender, RoutedEventArgs e)
        {
            switch (((RadioButton)sender).Content.ToString())
            {
                case "Ink":

                    InkCan.EditingMode = InkCanvasEditingMode.Ink;
                    break;

                case "Select":

                    InkCan.EditingMode = InkCanvasEditingMode.Select;
                    break;

                case "Erase":

                    InkCan.EditingMode = InkCanvasEditingMode.EraseByPoint;
                    break;

                case "Erase by strock":

                    InkCan.EditingMode = InkCanvasEditingMode.EraseByStroke;
                    break;
            }
        }

        private void drawing_shapes(object sender, RoutedEventArgs e)
        {
            switch (((RadioButton)sender).Content.ToString())
            {
                case "Elipse":

                    InkCan.DefaultDrawingAttributes.StylusTip = StylusTip.Ellipse;
                    break;

                case "Rectangle":

                    InkCan.DefaultDrawingAttributes.StylusTip = StylusTip.Rectangle;
                    break;


            }

        }

        private void brush_size(object sender, RoutedEventArgs e)
        {
            switch (((RadioButton)sender).Content.ToString())
            {
                case "small":

                    InkCan.DefaultDrawingAttributes.Width = 10;
                    InkCan.DefaultDrawingAttributes.Height = 10;
                    break;

                case "normal":

                    InkCan.DefaultDrawingAttributes.Width = 30;
                    InkCan.DefaultDrawingAttributes.Height = 30;
                    break;

                case "large":

                    InkCan.DefaultDrawingAttributes.Width = 60;
                    InkCan.DefaultDrawingAttributes.Height = 60;
                    break;
            }
            
        }

        private void neww (object sender, RoutedEventArgs e)
        {
            InkCan.Strokes.Clear();

        }

        private void save(object sender, RoutedEventArgs e)
        {
           
        }
        private void load(object sender, RoutedEventArgs e)
        {

        }
        private void copy(object sender, RoutedEventArgs e)
        {
            InkCan.CopySelection();
        }
        private void cut(object sender, RoutedEventArgs e)
        {
            InkCan.CutSelection();

        }
        private void paste(object sender, RoutedEventArgs e)
        {
            InkCan.Paste();


        }
    }
}
