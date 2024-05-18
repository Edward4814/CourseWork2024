using Microsoft.EntityFrameworkCore.Infrastructure;
using System.Windows;



namespace CourseWork2024
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e) //Створення бази данних у разі її відсутності
        {
            DatabaseFacade facade = new(new Model.NoteContext());
            //facade.EnsureDeleted();
            facade.EnsureCreated();
        }
    }

}
