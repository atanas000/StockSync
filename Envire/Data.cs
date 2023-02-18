using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaterialSkin;
using MaterialSkin.Controls;
using System.IO;

namespace Envire
{
    public static class FillSettingsFile
    {
        public static string server;
        public static string port;
        public static string username;
        public static string password;
        public static string db;
        public static string UIThemeStr;
        public static string UILanguage;

        public static bool FileIsEmpty;

        public static MaterialSkinManager.Themes UITheme;
        public static ColorScheme UIColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

        public static void ReadFile()
        {
            using (StreamReader sr = new StreamReader("Settings.txt"))
            {
                server = sr.ReadLine();
                port = sr.ReadLine();
                db = sr.ReadLine();
                username = sr.ReadLine();
                password = sr.ReadLine();
                UIThemeStr = sr.ReadLine();
                UILanguage= sr.ReadLine();
            }


            if (UIThemeStr == "Light")
            {
                UITheme = MaterialSkinManager.Themes.LIGHT;
            }
            else if (UIThemeStr == "Dark")
            {
                UITheme = MaterialSkinManager.Themes.DARK;
            }
        }

    }
    public static class Data
    {
        //DB Connection String
        public static string conn = $"server={FillSettingsFile.server};port={FillSettingsFile.port};uid={FillSettingsFile.username};pwd={FillSettingsFile.password};database={FillSettingsFile.db}";
    }
    public static class LogData
    {
        //Logged user data
        public static string FirstName;
        public static string MiddleName;
        public static string LastName;

        public static string Position;
        public static string Email;
        public static string Username;
        public static string Password;
    }
    public static class TempData
    {
        public static string CancelOrderNumber;
        public static string CurrentOrderNumber;
        public static string ProductEditID;
        public static string UserEditID;
    }

    public static class CartTempData
    {
        public static string ProductID;
        public static int Quantity;
        public static double Sum;
    }
}