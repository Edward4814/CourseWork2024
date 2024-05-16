using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CourseWork2024
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

        void AddNoteButton_Click(object sender, RoutedEventArgs e)
        {
            Window window = new Create_Note();
            window.Show();
        }
        void PrevButton_Click(object sender, RoutedEventArgs e)
        {
        }
        void NextButton_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}