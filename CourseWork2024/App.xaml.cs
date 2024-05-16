using System.Configuration;
using System.Data;
using System.Windows;
using CourseWork2024;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Sqlite;
namespace CourseWork2024
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            DatabaseFacade facade = new DatabaseFacade(new NoteContext());
            facade.EnsureCreated();
            base.OnStartup(e);
        }
    }

}
