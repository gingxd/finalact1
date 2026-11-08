using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ACT3
{
    public partial class SignInForm : Form
    {
        public SignInForm()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (username == "" || password == "")
            {
                MessageBox.Show("Please enter your username and password.");
                return;
            }

            try
            {
                using (OleDbConnection con = Database.GetConnection())
                {
                    con.Open();

                    string query = "SELECT UserID, PasswordHash, FullName, UserRole, IsActive FROM Users WHERE Username = ?";

                    using (OleDbCommand cmd = new OleDbCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);

                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            if (!reader.Read())
                            {
                                MessageBox.Show("Invalid username or password.");
                                return;
                            }

                            int userId = Convert.ToInt32(reader["UserID"]);
                            string storedHash = Convert.ToString(reader["PasswordHash"]) ?? "";
                            string fullName = Convert.ToString(reader["FullName"]) ?? "";
                            string role = Convert.ToString(reader["UserRole"]) ?? "";
                            bool isActive = Convert.ToBoolean(reader["IsActive"]);

                            if (!isActive)
                            {
                                MessageBox.Show("Your account is inactive.");
                                return;
                            }

                            if (!PasswordHelper.VerifyPassword(password, storedHash))
                            {
                                MessageBox.Show("Invalid username or password.");
                                return;
                            }

                            DashboardForm dashboard =
                                new DashboardForm(userId, fullName, role);

                            dashboard.Show();
                            this.Hide();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login error: " + ex.Message);
            }
        }

        private void linkRegister_LinkClicked(
            object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm register = new RegisterForm();
            register.Show();
            this.Hide();
        }
    }
}