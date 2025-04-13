using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace SWProject
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Forms.addGalleryForm = new AddGallery();
            Forms.adminReportForm = new AdminReport();
            Forms.artsListForm = new ArtsList();
            Forms.cartForm = new CartForm();
            Forms.homePage = new HomePage();
            Forms.loginForm = new LoginForm();
            Forms.mainForm = new MainForm();
            Forms.registerForm = new RegisterForm();
            Forms.userManagement = new UserManagement();

            Application.Run(Forms.homePage);
        }
    }

    public static class DatabaseHelper
    {
        public static string ordb = "Data source=orcl; User Id=scott; Password=tiger;";
        public static OracleConnection conn = new OracleConnection(ordb);
    }

    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public int UserRole { get; set; }
        // Add more properties as needed
    }

    // Define the LoggedInUser class to manage the currently logged-in user
    public static class LoggedInUser
    {
        public static User CurrentUser { get; set; }
    }

    public static class Forms
    {
        public static AddGallery addGalleryForm;
        public static AdminReport adminReportForm;
        public static ArtsList artsListForm;
        public static CartForm cartForm;
        public static HomePage homePage;
        public static LoginForm loginForm;
        public static MainForm mainForm;
        public static RegisterForm registerForm;
        public static UserManagement userManagement;
    }
}
