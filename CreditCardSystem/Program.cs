using DevExpress.Skins;
using DevExpress.UserSkins;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CreditCardSystem
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Ensure the database folder exists
            if (!System.IO.Directory.Exists(Defaults.DatabaseFolderPath))
            {
                System.IO.Directory.CreateDirectory(Defaults.DatabaseFolderPath);
            }

            if (!File.Exists(Defaults.DatabasePath))
            {
                using (MainDbContext context = new())
                {
                    context.Database.Migrate();
                }
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
