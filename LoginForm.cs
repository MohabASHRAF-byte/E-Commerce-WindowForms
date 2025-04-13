using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace SWProject
{
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }
            
            User loggedInUser = AuthenticateUser(username, password);
            if (loggedInUser != null)
            {
                LoggedInUser.CurrentUser = loggedInUser;
                
                Forms.mainForm.showForm();
                this.Hide(); // Hide login form
            }
        }

        private User AuthenticateUser(string username, string password)
        {
            string query = "SELECT * FROM users WHERE username=:username AND password=:password";
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = DatabaseHelper.conn;
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("username", txtUsername.Text);
            cmd.Parameters.Add("password", txtPassword.Text);
            OracleDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                if (Convert.ToInt32(rd["is_active"]) == 0)
                {
                    MessageBox.Show("Your account is has not been activated yet");
                    return null;
                }
                User user = new User
                {
                    UserId = Convert.ToInt32(rd["user_id"]),
                    Username = rd["username"].ToString(),
                    UserRole = Convert.ToInt32(rd["user_role"])
                };

                return user;
            }
            MessageBox.Show("Username or password are incorrect");
            return null;
        }

        private void loginMenuReturn_Click(object sender, EventArgs e)
        {
            Forms.homePage.Show();
            this.Hide();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Forms.homePage.Close();
        }


        public void load()
        {
            txtPassword.Text = "";
            txtUsername.Text = "";
        }

        public void showForm()
        {
            load();
            this.Show();
        }
    }

}
