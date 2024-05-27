using CourseWork2024.Commands;
using CourseWork2024.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CourseWork2024.ViewModel
{
    public class AddNoteViewModel
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public ICommand AddNoteCommand { get; set; }

        public AddNoteViewModel()
        {
            AddNoteCommand = new RelayCommand(AddNote, CanAddNote);
        }

        private bool CanAddNote(object obj)
        {
            return true;
        }

        private void AddNote(object obj)
        {
            Note note = new Note() { Title = Title, Description = Description };
            NoteManager.AddNote(note);
            CRUDOpsModel.Create(note);
        }
    }
}
