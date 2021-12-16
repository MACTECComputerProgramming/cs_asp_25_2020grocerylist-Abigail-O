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

namespace _025_Challenge
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
        ////variables
        //string[] i = new string[10];
        //int[] vs = new int[10];

        //get number of items

        //get item names and prices stored in background

        //enter item and price into result

        private void numOfItems_Click(object sender, RoutedEventArgs e)
        {
            int num=int.Parse(numberBox.Text);
            label1.Content = num;
            label1.Opacity=0;
            finalButton1.Visibility = Visibility.Visible;
            finalButton2.Visibility = Visibility.Hidden;
            finalButton3.Visibility = Visibility.Hidden;
            finalButton4.Visibility = Visibility.Hidden;
            finalButton5.Visibility = Visibility.Hidden;
            finalButton6.Visibility = Visibility.Hidden;
            finalButton7.Visibility = Visibility.Hidden;
            finalButton8.Visibility = Visibility.Hidden;
            finalButton9.Visibility = Visibility.Hidden;
            finalButton10.Visibility = Visibility.Hidden;

        }

        string one, two, three, four, five, six, seven, eight, nine, ten;
        double a, b, c, d, f, g, h, j, k, m;

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            one = box1.Text;
            a = double.Parse(box2.Text);
            box1.Text = " ";
            box2.Text = " ";
            finalButton1.Visibility = Visibility.Hidden;
            finalButton2.Visibility = Visibility.Visible;
            finalButton3.Visibility = Visibility.Hidden;
            finalButton4.Visibility = Visibility.Hidden;
            finalButton5.Visibility = Visibility.Hidden;
            finalButton6.Visibility = Visibility.Hidden;
            finalButton7.Visibility = Visibility.Hidden;
            finalButton8.Visibility = Visibility.Hidden;
            finalButton9.Visibility = Visibility.Hidden;
            finalButton10.Visibility = Visibility.Hidden;
        }
        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            two = box1.Text;
            b = double.Parse(box2.Text);
            box1.Text = " ";
            box2.Text = " ";
            finalButton1.Visibility = Visibility.Hidden;
            finalButton2.Visibility = Visibility.Hidden;
            finalButton3.Visibility = Visibility.Visible;
            finalButton4.Visibility = Visibility.Hidden;
            finalButton5.Visibility = Visibility.Hidden;
            finalButton6.Visibility = Visibility.Hidden;
            finalButton7.Visibility = Visibility.Hidden;
            finalButton8.Visibility = Visibility.Hidden;
            finalButton9.Visibility = Visibility.Hidden;
            finalButton10.Visibility = Visibility.Hidden;
        }
        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            three = box1.Text;
            c = double.Parse(box2.Text);
            box1.Text = " ";
            box2.Text = " ";
            finalButton1.Visibility = Visibility.Hidden;
            finalButton2.Visibility = Visibility.Hidden;
            finalButton3.Visibility = Visibility.Hidden;
            finalButton4.Visibility = Visibility.Visible;
            finalButton5.Visibility = Visibility.Hidden;
            finalButton6.Visibility = Visibility.Hidden;
            finalButton7.Visibility = Visibility.Hidden;
            finalButton8.Visibility = Visibility.Hidden;
            finalButton9.Visibility = Visibility.Hidden;
            finalButton10.Visibility = Visibility.Hidden;
        }
        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            four = box1.Text;
            d = double.Parse(box2.Text);
            box1.Text = " ";
            box2.Text = " ";
            finalButton1.Visibility = Visibility.Hidden;
            finalButton2.Visibility = Visibility.Hidden;
            finalButton3.Visibility = Visibility.Hidden;
            finalButton4.Visibility = Visibility.Hidden;
            finalButton5.Visibility = Visibility.Visible;
            finalButton6.Visibility = Visibility.Hidden;
            finalButton7.Visibility = Visibility.Hidden;
            finalButton8.Visibility = Visibility.Hidden;
            finalButton9.Visibility = Visibility.Hidden;
            finalButton10.Visibility = Visibility.Hidden;
        }
        private void Button_Click5(object sender, RoutedEventArgs e)
        {
            five = box1.Text;
            f = double.Parse(box2.Text);
            box1.Text = " ";
            box2.Text = " ";
            finalButton1.Visibility = Visibility.Hidden;
            finalButton2.Visibility = Visibility.Hidden;
            finalButton3.Visibility = Visibility.Hidden;
            finalButton4.Visibility = Visibility.Hidden;
            finalButton5.Visibility = Visibility.Hidden;
            finalButton6.Visibility = Visibility.Visible;
            finalButton7.Visibility = Visibility.Hidden;
            finalButton8.Visibility = Visibility.Hidden;
            finalButton9.Visibility = Visibility.Hidden;
            finalButton10.Visibility = Visibility.Hidden;
        }
        private void Button_Click6(object sender, RoutedEventArgs e)
        {
            six = box1.Text;
            g = double.Parse(box2.Text);
            box1.Text = " ";
            box2.Text = " ";
            finalButton1.Visibility = Visibility.Hidden;
            finalButton2.Visibility = Visibility.Hidden;
            finalButton3.Visibility = Visibility.Hidden;
            finalButton4.Visibility = Visibility.Hidden;
            finalButton5.Visibility = Visibility.Hidden;
            finalButton6.Visibility = Visibility.Hidden;
            finalButton7.Visibility = Visibility.Visible;
            finalButton8.Visibility = Visibility.Hidden;
            finalButton9.Visibility = Visibility.Hidden;
            finalButton10.Visibility = Visibility.Hidden;
        }
        private void Button_Click7(object sender, RoutedEventArgs e)
        {
            seven = box1.Text;
            h = double.Parse(box2.Text);
            box1.Text = " ";
            box2.Text = " ";
            finalButton1.Visibility = Visibility.Hidden;
            finalButton2.Visibility = Visibility.Hidden;
            finalButton3.Visibility = Visibility.Hidden;
            finalButton4.Visibility = Visibility.Hidden;
            finalButton5.Visibility = Visibility.Hidden;
            finalButton6.Visibility = Visibility.Hidden;
            finalButton7.Visibility = Visibility.Hidden;
            finalButton8.Visibility = Visibility.Visible;
            finalButton9.Visibility = Visibility.Hidden;
            finalButton10.Visibility = Visibility.Hidden;
        }
        private void Button_Click8(object sender, RoutedEventArgs e)
        {
            eight = box1.Text;
            j = double.Parse(box2.Text);
            box1.Text = " ";
            box2.Text = " ";
            finalButton1.Visibility = Visibility.Hidden;
            finalButton2.Visibility = Visibility.Hidden;
            finalButton3.Visibility = Visibility.Hidden;
            finalButton4.Visibility = Visibility.Hidden;
            finalButton5.Visibility = Visibility.Hidden;
            finalButton6.Visibility = Visibility.Hidden;
            finalButton7.Visibility = Visibility.Hidden;
            finalButton8.Visibility = Visibility.Hidden;
            finalButton9.Visibility = Visibility.Visible;
            finalButton10.Visibility = Visibility.Hidden;
        }
        private void Button_Click9(object sender, RoutedEventArgs e)
        {
            nine = box1.Text;
            k = double.Parse(box2.Text);
            box1.Text = " ";
            box2.Text = " ";
            finalButton1.Visibility = Visibility.Hidden;
            finalButton2.Visibility = Visibility.Hidden;
            finalButton3.Visibility = Visibility.Hidden;
            finalButton4.Visibility = Visibility.Hidden;
            finalButton5.Visibility = Visibility.Hidden;
            finalButton6.Visibility = Visibility.Hidden;
            finalButton7.Visibility = Visibility.Hidden;
            finalButton8.Visibility = Visibility.Hidden;
            finalButton9.Visibility = Visibility.Hidden;
            finalButton10.Visibility = Visibility.Visible;
     
        }
        private void Button_Click10(object sender, RoutedEventArgs e)
        {
            ten = box1.Text;
            m = double.Parse(box2.Text);
            box1.Text = " ";
            box2.Text = " ";
            finalButton1.Visibility = Visibility.Hidden;
            finalButton2.Visibility = Visibility.Hidden;
            finalButton3.Visibility = Visibility.Hidden;
            finalButton4.Visibility = Visibility.Hidden;
            finalButton5.Visibility = Visibility.Hidden;
            finalButton6.Visibility = Visibility.Hidden;
            finalButton7.Visibility = Visibility.Hidden;
            finalButton8.Visibility = Visibility.Hidden;
            finalButton9.Visibility = Visibility.Hidden;
            finalButton10.Visibility = Visibility.Hidden;
            
        }
        private void enterResults_Click(object sender, RoutedEventArgs e)
        {
            result.Content = one + a + two + b + three + c + four + d + five + f + six + g + seven + h + eight + j + nine + k + ten + m;
            finalButton1.Visibility = Visibility.Visible;
        }


        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    int i=int.Parse(box2.Text);
        //    //Storing value in an array
        //    vs[i] = Convert.ToInt32(Console.ReadLine());
        //    //Printing the value on console
        //    Console.WriteLine("you entered {0}", vs[i]);
        //    Console.ReadLine();
        //    //shows how many items are saved
        //    saved.Content = vs.Length.ToString();
        //}

    }
}
