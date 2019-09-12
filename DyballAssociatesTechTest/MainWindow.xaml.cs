using System;
using System.Collections;
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
using System.Windows.Threading;



namespace DyballAssociatesTechTest
{
    public partial class MainWindow : Window
    {

        private readonly Zoo _zoo;

        public MainWindow()
        {
            InitializeComponent();
            _zoo = new Zoo();
            DataContext = _zoo;
        }

        private void FeedButton_Click(object sender, RoutedEventArgs e)
        {
            Feeding.Feed(_zoo.Monkeys);
            Feeding.Feed(_zoo.Giraffes);
            Feeding.Feed(_zoo.Elephants);
        }
        
        
    }
}
