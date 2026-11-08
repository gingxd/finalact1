namespace ACT3
{
    partial class RegisterForm
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
            components = new System.ComponentModel.Container();
            panelHeader = new Panel();
            lblTitle = new Label();
            lblHeading = new Label();
            lblFullName = new Label();
            txtFullName = new TextBox();
            lblUser = new Label();
            txtUsername = new TextBox();
            lblPass = new Label();
            txtPassword = new TextBox();
            lblConfirm = new Label();
            txtConfirmPassword = new TextBox();
            btnRegister = new Button();
            lblLogin = new LinkLabel();
            panelHeader.SuspendLayout();
            SuspendLayout();

            
            panelHeader.BackColor = Color.FromArgb(20, 33, 61);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(800, 80);
            panelHeader.TabIndex = 0;

            
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(180, 23);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(200, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Inventory Management System";


            lblHeading.AutoSize = true;
            lblHeading.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblHeading.ForeColor = Color.FromArgb(20, 33, 61);
            lblHeading.Location = new Point(260, 105);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(280, 40);
            lblHeading.TabIndex = 1;
            lblHeading.Text = "CREATE ACCOUNT";

           
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(220, 175);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(70, 20);
            lblFullName.TabIndex = 2;
            lblFullName.Text = "Full Name";

            
            txtFullName.Font = new Font("Segoe UI", 11F);
            txtFullName.Location = new Point(220, 200);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(350, 32);
            txtFullName.TabIndex = 3;

            
            lblUser.AutoSize = true;
            lblUser.Location = new Point(220, 245);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(70, 20);
            lblUser.TabIndex = 4;
            lblUser.Text = "Username";

       
            txtUsername.Font = new Font("Segoe UI", 11F);
            txtUsername.Location = new Point(220, 270);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(350, 32);
            txtUsername.TabIndex = 5;

           
            lblPass.AutoSize = true;
            lblPass.Location = new Point(220, 315);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(70, 20);
            lblPass.TabIndex = 6;
            lblPass.Text = "Password";

          
            txtPassword.Font = new Font("Segoe UI", 11F);
            txtPassword.Location = new Point(220, 340);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(350, 32);
            txtPassword.TabIndex = 7;
            txtPassword.UseSystemPasswordChar = true;

           
            lblConfirm.AutoSize = true;
            lblConfirm.Location = new Point(220, 385);
            lblConfirm.Name = "lblConfirm";
            lblConfirm.Size = new Size(130, 20);
            lblConfirm.TabIndex = 8;
            lblConfirm.Text = "Confirm Password";

            // txtConfirmPassword
            txtConfirmPassword.Font = new Font("Segoe UI", 11F);
            txtConfirmPassword.Location = new Point(220, 410);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(350, 32);
            txtConfirmPassword.TabIndex = 9;
            txtConfirmPassword.UseSystemPasswordChar = true;

            // btnRegister
            btnRegister.BackColor = Color.FromArgb(20, 33, 61);
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(220, 455);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(350, 40);
            btnRegister.TabIndex = 10;
            btnRegister.Text = "REGISTER";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;

           
            lblLogin.AutoSize = true;
            lblLogin.Location = new Point(295, 510);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(220, 20);
            lblLogin.TabIndex = 11;
            lblLogin.TabStop = true;
            lblLogin.Text = "Already have an account? Sign In";
            lblLogin.LinkClicked += lblLogin_LinkClicked;

            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(784, 561);
            Controls.Add(panelHeader);
            Controls.Add(lblHeading);
            Controls.Add(lblFullName);
            Controls.Add(txtFullName);
            Controls.Add(lblUser);
            Controls.Add(txtUsername);
            Controls.Add(lblPass);
            Controls.Add(txtPassword);
            Controls.Add(lblConfirm);
            Controls.Add(txtConfirmPassword);
            Controls.Add(btnRegister);
            Controls.Add(lblLogin);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventory Management System - Register";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelHeader;
        private Label lblTitle;
        private Label lblHeading;
        private Label lblFullName;
        private TextBox txtFullName;
        private Label lblUser;
        private TextBox txtUsername;
        private Label lblPass;
        private TextBox txtPassword;
        private Label lblConfirm;
        private TextBox txtConfirmPassword;
        private Button btnRegister;
        private LinkLabel lblLogin;
    }
}