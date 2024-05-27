using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork2024.Model
{
    public class CRUDOpsModel
    {
        public static void Create(Note obj)
        {
            using (NoteContext context = new NoteContext())
            {
                context.Add(obj);
                context.SaveChanges();
            }
        }

        public static void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public static List<Note> Read()
        {
            using (NoteContext context = new NoteContext())
            {
                return context.Notes.ToList();
            }
        }

        public static void Update(int id, Note obj)
        {
            throw new NotImplementedException();
        }
    }
}
