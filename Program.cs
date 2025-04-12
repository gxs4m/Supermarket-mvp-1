using Supermarket_mvp_1._Repositories;
using Supermarket_mvp_1.Models;
using Supermarket_mvp_1.Presenter;
using Supermarket_mvp_1.Properties;
using Supermarket_mvp_1.Views;

namespace Supermarket_mvp_1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            string sqlConnectionString = Settings.Default.SqlConnection;
            IPayModeView view = new PayModelView();
            IPayModeRepository repository = new PayModeRepository(sqlConnectionString);
            new PayModePresenter(view, repository);
            Application.Run((Form) view);
        }
    }
}