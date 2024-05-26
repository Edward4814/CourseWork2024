using System.Windows;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using CourseWork2024.Model;
using CourseWork2024.ViewModel;

namespace CourseWork2024
{
    /// <summary>
    /// Interaction logic for Create_Note.xaml
    /// </summary>
    public partial class Create_Note : Window
    {
        public Create_Note()
        {
            InitializeComponent();
            AddNoteViewModel addNoteViewModel = new AddNoteViewModel();
            this.DataContext = addNoteViewModel;
        }
    }
}
