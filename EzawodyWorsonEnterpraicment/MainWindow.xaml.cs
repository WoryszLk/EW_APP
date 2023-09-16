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
using System.Windows.Media.Animation;
using EzawodyWorsonEnterpraicment.Animations;

namespace EzawodyWorsonEnterpraicment
{ 
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private bool VisibilityOfColumn2 = false;
        private bool VisibilityOfColumn3 = false;
        private bool VisibilityOfColumn4 = false;

        private void ShowColumnButton_Click(object sender, RoutedEventArgs e)
        {
            if (!VisibilityOfColumn2 || !VisibilityOfColumn4)
            {
                // Showing 3rd column and hiding 2nd and 4th
                GridColumn2.Visibility = Visibility.Visible;
                GridColumn3.Visibility = Visibility.Collapsed;
                GridColumn4.Visibility = Visibility.Collapsed;
                VisibilityOfColumn2 = true;
                VisibilityOfColumn3 = false;
                VisibilityOfColumn4 = false;
            }
            else
            {
                // Hiding the 2nd column
                GridColumn2.Visibility = Visibility.Collapsed;
                VisibilityOfColumn2 = false;
            }
        }

        private void ShowColumnButton_Click2(object sender, RoutedEventArgs e)
        {
            if (!VisibilityOfColumn3 || !VisibilityOfColumn4)
            {
                // Showing 3rd column and hiding 2nd and 4th
                GridColumn3.Visibility = Visibility.Visible;
                GridColumn2.Visibility = Visibility.Collapsed;
                GridColumn4.Visibility = Visibility.Collapsed;
                VisibilityOfColumn3 = true;
                VisibilityOfColumn2 = false;
                VisibilityOfColumn4 = false;
            }
            else
            {
                // Hiding the 3rd column
                GridColumn3.Visibility = Visibility.Collapsed;
                VisibilityOfColumn3 = false;
            }
        }

        private void ShowColumnButton_Click3(object sender, RoutedEventArgs e)
        {
            if (!VisibilityOfColumn4)
            {
                // Showing 4th column and hiding 2nd and 3rd
                GridColumn4.Visibility = Visibility.Visible;
                GridColumn2.Visibility = Visibility.Collapsed;
                GridColumn3.Visibility = Visibility.Collapsed;
                VisibilityOfColumn2 = false;
                VisibilityOfColumn3 = false;
                VisibilityOfColumn4 = true;
            }
            else
            {
                // Hiding the 4th column
                GridColumn4.Visibility = Visibility.Collapsed;
                VisibilityOfColumn4 = false;
            }
        }

        private void ShowColumnButton_Click4(object sender, RoutedEventArgs e)
        {
            GridColumn2.Visibility = Visibility.Collapsed;
            GridColumn3.Visibility = Visibility.Collapsed;
            GridColumn4.Visibility = Visibility.Collapsed;
        }


    }
}

