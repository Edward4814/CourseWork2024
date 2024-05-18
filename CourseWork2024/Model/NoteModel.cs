using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Windows.Controls.Primitives;

namespace CourseWork2024.Model
{
    internal class NoteContext : DbContext //class to setup work with SQlite
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data source = notes.db");
        }
        public DbSet<Note> Notes { get; set; }
    }
    internal class Note
    {
        [Key]
        public int Id { get; set; }
        public string? Title { get; set; }
        public DateTime Date { get; set; }
        public string? Description { get; set; }


        static public void SaveNote(string title, string description, DateTime date)
        {
            Note note = new() { Title = title, Description = description, Date = date};
            using NoteContext context = new();
            context.Notes.Add(note);
            context.SaveChanges();
        }
    }
}
