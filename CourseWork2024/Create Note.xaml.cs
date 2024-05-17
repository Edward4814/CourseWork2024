﻿using System.Windows;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

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
            Note note = new Note();
            try
            {
                if (TitleTextBox.Text == "")
                {
                    throw new Exception("Title cannot be empty");
                }
                if(DatePickerTextBox.SelectedDate == null)
                {
                    throw new Exception("Date cannot be empty");
                }
                note.Title = TitleTextBox.Text;
                note.Description = DescriptionTextBox.Text;
                note.Date = DatePickerTextBox.SelectedDate.Value.Date;

                using (NoteContext context = new NoteContext())
                {
                    context.Notes.Add(note);
                    context.SaveChanges();
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }
    }
}
