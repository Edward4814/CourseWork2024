using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork2024.Model
{
    public class NoteManager
    {
        public static ObservableCollection<Note> _dbNotes;

        public static ObservableCollection<Note> GetNotes()
        {
            _dbNotes = new ObservableCollection<Note>(CRUDOpsModel.Read());
            return _dbNotes;
        }

        public static void AddNote(Note note)
        {
            _dbNotes.Add(note);
        }
    }
}
