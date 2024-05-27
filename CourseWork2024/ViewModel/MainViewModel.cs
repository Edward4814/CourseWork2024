using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using CourseWork2024.Commands;
using CourseWork2024.Model;
using Microsoft.EntityFrameworkCore;


namespace CourseWork2024.ViewModel
{
    public class MainViewModel
    {
        public ObservableCollection<Note> Notes { get; set; }

        public ICommand ShowWindowCommand { get; set; }

        public MainViewModel()
        {
            Notes = NoteManager.GetNotes();
            ShowWindowCommand = new RelayCommand(ShowWindow, CanShowWindow);
        }

        private bool CanShowWindow(object obj)
        {
            return true;
        }

        private void ShowWindow(object obj)
        {
            Create_Note create_Note = new Create_Note();
            create_Note.Show();
        }
    }
}
