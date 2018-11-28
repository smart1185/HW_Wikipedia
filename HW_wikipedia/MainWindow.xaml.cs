using HW_wikipedia.Pages;
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

namespace HW_wikipedia
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static Frame mf { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            mf = MainFrame;

            MainFrame.Source = new Uri("Pages/Page1.xaml", UriKind.RelativeOrAbsolute);
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            RubPage rp = new RubPage();
            MainFrame.NavigationService.Navigate(rp);
        }
    }
}
