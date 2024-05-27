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
    public class Note
    {
        [Key]
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
    }
}
