using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TigApp.Services;
using TigApp.Views;
using TigApp.Services.Data;
using System.IO;

namespace TigApp
{
    public partial class App : Application
    {
        static WorkDatabase database;

        public static WorkDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new WorkDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Works.db3"));
                }
                return database;
            }
        }

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
