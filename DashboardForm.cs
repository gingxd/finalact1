using System;
using System.Windows.Forms;

namespace ACT3
{
    public partial class DashboardForm : Form
    {
        private int userId;
        private string fullName;
        private string userRole;

        public DashboardForm(int id, string name, string role)
        {
            InitializeComponent();

            userId = id;
            fullName = name;
            userRole = role;

            lblWelcome.Text = "Welcome, " + fullName + "  |  " + userRole;

            ShowPage("Dashboard");
        }

        private void btnMenu_Click(object? sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                ShowPage(btn.Text);
            }
        }

        private void ShowPage(string page)
        {
            lblPageTitle.Text = page;

            if (page == "Dashboard")
            {
                lblDescription.Text =
                    "Welcome to your Inventory Management System.\n\n" +
                    "Use the navigation menu to manage your records.";
            }
            else
            {
                lblDescription.Text =
                    page + " Management\n\n" +
                    "This module will be developed next.";
            }
        }

        private void btnLogout_Click(object? sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to log out?",
                "Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                SignInForm login = new SignInForm();
                login.Show();
                this.Close();
            }
        }
    }
}