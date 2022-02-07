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

namespace Composition
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

       

        private void Button_staus_OnClick(object sender, RoutedEventArgs e)
        {
            Button_staus.Content = Label_status.Content;
        }

        private void Button_name_OnClick(object sender, RoutedEventArgs e)
        {
            Button_name_1.Content = "Это 3 трока 3 столбец!!!";
        }
    }
}