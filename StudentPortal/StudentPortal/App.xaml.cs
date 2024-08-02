using System.Configuration;
using System.Data;
using System.Windows;
using StudentPortal.Data;

namespace StudentPortal
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            InitializeDatabase();
        }

        private void InitializeDatabase()
        {
            using (var context = new StudentPortalDbContext())
            {
                context.Database.EnsureCreated();
            }
        }
    }

}
