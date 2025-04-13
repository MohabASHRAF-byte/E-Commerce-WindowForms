using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWProject
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
            if(DatabaseHelper.conn.State != ConnectionState.Open)
            {
                DatabaseHelper.conn.Open();
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            Forms.loginForm.showForm();
            this.Hide();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            Forms.registerForm.showForm();
            this.Hide();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void HomePage_FormClosing(object sender, FormClosingEventArgs e)
        {
            DatabaseHelper.conn.Dispose();
        }
    }
}
