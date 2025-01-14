using System;
using Bileterie.Data;
using System.IO;


namespace Bileterie
{
    public partial class App : Application
    {
        static SpectacolDatabase database;
        public static SpectacolDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new
                   SpectacolDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.
                   LocalApplicationData), "Spectacol.db3"));
                }
                return database;
            }
        }

        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
