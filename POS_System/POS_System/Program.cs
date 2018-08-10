using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_System
{

    static class Program
    {
        public static string developerName="RaresTech.com Muhammad Nawaz-03041596991";
        public static string StoreName = "RaresTech";
        public static string StorePhone = "0304-1596991";
        public static string StoreAddress = "Arif Road \n Sahiwal";
        static string path = Path.GetFullPath(Environment.CurrentDirectory);
        static string name = "POS_DATABASE.mdf";
        public static string CS = @"Data Source=|DataDirectory|\Database_POS.sdf";//@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\POS_Database.mdf;Integrated Security=True";//"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + path+@"\"+name+ ";Integrated Security=True";
        /// <summary>//Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="C:\Users\Muhammad Nawaz\source\repos\POS_System\POS_System\POS.mdf";Integrated Security=True;Connect Timeout=30
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
