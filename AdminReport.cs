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
    public partial class AdminReport : Form
    {
        public AdminReport()
        {
            InitializeComponent();
        }

        private void DisplayReport_Click(object sender, EventArgs e)
        {
            if(ReportType.SelectedItem != null)
            {
                if (ReportType.SelectedItem.ToString() == "Users")
                    crystalReportViewer1.ReportSource = new UsersReport();
                if(ReportType.SelectedItem.ToString() == "Transactions")
                    crystalReportViewer1.ReportSource = new TransactionsReport();
            }
        }

        private void backToMenuBtn_Click(object sender, EventArgs e)
        {
            Forms.mainForm.showForm();
            this.Hide();
        }

        private void AdminReport_FormClosing(object sender, FormClosingEventArgs e)
        {
            Forms.homePage.Close();
        }
    }
}
