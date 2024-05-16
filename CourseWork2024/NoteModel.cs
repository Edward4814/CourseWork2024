using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourseWork2024
{
    internal class NoteContext : DbContext
    {
        public DbSet<Note> Notes { get; set; }
        public string DbPath { get; }
        public NoteContext()
        {
            DbPath = "notes.db";
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data source = {DbPath}");
        }
    }
    internal class Note
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string id { get; set; }
        public string title { get; set; }
        public DateTime date { get; set; }
        public string description { get; set; }
    }
}
