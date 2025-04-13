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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            string username = usernameInp.Text;
            string password = passwordInp.Text;
            string passwordConfirmation = confirmPasswordInp.Text;
            string role = "";
            if(roleInp.SelectedItem != null)
            {
                role = roleInp.SelectedItem.ToString();
            }

            // Validate username and password
            string missingValues = "";

            int cnt = 0;
            if (string.IsNullOrEmpty(username))
            {
                missingValues += "username";
                cnt++;
            }
            if (string.IsNullOrEmpty(password))
            {
                if (cnt > 0) missingValues += ", ";
                missingValues += "password";
                cnt++;
            }
            if (string.IsNullOrEmpty(passwordConfirmation))
            {
                if (cnt > 0) missingValues += ", ";
                missingValues += "confirm password";
                cnt++;
            }
            if (string.IsNullOrEmpty(role))
            {
                if (cnt > 0) missingValues += ", ";
                missingValues += "role";
                cnt++;
            }
           
            if(cnt > 0)
            {
                MessageBox.Show("Please enter " + missingValues + " fields.");
                return;
            }

            if(password != passwordConfirmation)
            {
                MessageBox.Show("Passwords does not match.");
                return;
            }
            
            RegisterUser(username, password, role); // Assuming default role for new users
            
        }

        public bool RegisterUser(string username, string password, string userRole)
        {
            string query = "INSERT INTO users (user_id, username, password, user_role, is_active) " +
                           "VALUES (user_id_seq.NEXTVAL, :username, :password, :role, 0)";

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = DatabaseHelper.conn;
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("username", username);
            cmd.Parameters.Add("password", password);
            if(userRole == "User") cmd.Parameters.Add("role", 1);
            if(userRole == "Artist") cmd.Parameters.Add("role", 2);
        
            var response = cmd.ExecuteNonQuery();
            if(response > 0)
            {
                MessageBox.Show("Your account is under review try to login after 24 hours");
                Forms.homePage.Show();
                this.Hide();
                return true;
            }
            MessageBox.Show("An Error Occured please try again");
            return false;
        }

        private void loginMenuReturn_Click(object sender, EventArgs e)
        {
            Forms.homePage.Show();
            this.Hide();
        }

        private void RegisterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Forms.homePage.Close();
        }

        public void load() {
            usernameInp.Text = "";
            passwordInp.Text = "";
            confirmPasswordInp.Text = "";
            roleInp.SelectedIndex = 0;
        }

        public void showForm()
        {
            load();
            this.Show();
        }
    }
}
