namespace ACT3
{
    partial class SignInForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panelHeader = new Panel();
            lblTitle = new Label();
            lblSignIn = new Label();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            btnSignIn = new Button();
            linkRegister = new LinkLabel();
            panelHeader.SuspendLayout();
            SuspendLayout();
            
            panelHeader.BackColor = Color.FromArgb(20, 33, 61);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(3, 2, 3, 2);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(686, 60);
            panelHeader.TabIndex = 0;
            
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(158, 17);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(371, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Inventory Management System";
           
          
            lblSignIn.AutoSize = true;
            lblSignIn.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblSignIn.ForeColor = Color.FromArgb(20, 33, 61);
            lblSignIn.Location = new Point(280, 86);
            lblSignIn.Name = "lblSignIn";
            lblSignIn.Size = new Size(132, 41);
            lblSignIn.TabIndex = 1;
            lblSignIn.Text = "SIGN IN";
           
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(192, 142);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(60, 15);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "Username";
            
            txtUsername.Font = new Font("Segoe UI", 11F);
            txtUsername.Location = new Point(192, 161);
            txtUsername.Margin = new Padding(3, 2, 3, 2);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(307, 27);
            txtUsername.TabIndex = 3;
         
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(192, 199);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(57, 15);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password";
            
            txtPassword.Font = new Font("Segoe UI", 11F);
            txtPassword.Location = new Point(192, 218);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(307, 27);
            txtPassword.TabIndex = 5;
            txtPassword.UseSystemPasswordChar = true;
            
            btnSignIn.BackColor = Color.FromArgb(20, 33, 61);
            btnSignIn.FlatStyle = FlatStyle.Flat;
            btnSignIn.ForeColor = Color.White;
            btnSignIn.Location = new Point(192, 262);
            btnSignIn.Margin = new Padding(3, 2, 3, 2);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(306, 30);
            btnSignIn.TabIndex = 6;
            btnSignIn.Text = "SIGN IN";
            btnSignIn.UseVisualStyleBackColor = false;
            btnSignIn.Click += btnSignIn_Click;
            
            linkRegister.AutoSize = true;
            linkRegister.Location = new Point(262, 308);
            linkRegister.Name = "linkRegister";
            linkRegister.Size = new Size(176, 15);
            linkRegister.TabIndex = 7;
            linkRegister.TabStop = true;
            linkRegister.Text = "Don't have an account? Register";
            linkRegister.LinkClicked += linkRegister_LinkClicked;
            
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(686, 346);
            Controls.Add(panelHeader);
            Controls.Add(lblSignIn);
            Controls.Add(lblUsername);
            Controls.Add(txtUsername);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(btnSignIn);
            Controls.Add(linkRegister);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "SignInForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventory Management System - Sign In";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelHeader;
        private Label lblTitle;
        private Label lblSignIn;
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblPassword;
        private TextBox txtPassword;
        private Button btnSignIn;
        private LinkLabel linkRegister;
    }
}