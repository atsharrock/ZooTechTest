using System.Windows;

namespace ZooSimTechTest
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
