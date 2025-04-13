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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            load();
        }

        public void load()
        {
            if (LoggedInUser.CurrentUser != null)
            {
                if (LoggedInUser.CurrentUser.UserRole != 0)
                {
                    userManagementBtn.Visible = false;
                    reportsBtn.Visible = false;
                }
                else if (LoggedInUser.CurrentUser.UserRole == 1)
                {
                    uploadArtBtn.Visible = false;
                }
            }
        }

        private void userManagementBtn_Click(object sender, EventArgs e)
        {
            Forms.userManagement.showForm();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Forms.homePage.Show();
            this.Hide();
            LoggedInUser.CurrentUser = null;
        }

        private void reportsBtn_Click(object sender, EventArgs e)
        {
            Forms.adminReportForm.Show();
            this.Hide();
        }

        private void uploadArtBtn_Click(object sender, EventArgs e)
        {
            Forms.addGalleryForm.Show();
            this.Hide();
        }

        private void artsBtn_Click(object sender, EventArgs e)
        {
            Forms.artsListForm.showForm();
            this.Hide();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Forms.homePage.Close();
        }

        public void showForm()
        {
            this.Show();
            load();
        }
    }
}
