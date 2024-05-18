using System.Windows;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using CourseWork2024.Model;

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
        }

        private void CreateNoteButton_Click(object sender, RoutedEventArgs e) //Метод для створення нотатки, та заванження її в базу данних
        {
            try  //Перевірка полів Title та Date на заповнення
            {
                if (TitleTextBox.Text == "")
                {
                    throw new Exception("Title cannot be empty");
                }
                if(DatePickerTextBox.SelectedDate == null)
                {
                    throw new Exception("Date cannot be empty");
                }
                Note.SaveNote(TitleTextBox.Text, DescriptionTextBox.Text, DatePickerTextBox.SelectedDate.Value.Date);

                MessageBoxResult rl = MessageBox.Show("Note Created Successfully", "Note Created", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                if (rl == MessageBoxResult.OK)
                {
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }
    }
}
