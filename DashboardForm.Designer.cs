namespace ACT3
{
    partial class DashboardForm
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
            sidebar = new Panel();
            lblBrand = new Label();
            btnDashboard = new Button();
            btnInventory = new Button();
            btnProducts = new Button();
            btnCategories = new Button();
            btnUsers = new Button();
            btnLogout = new Button();
            header = new Panel();
            lblWelcome = new Label();
            mainPanel = new Panel();
            lblPageTitle = new Label();
            lblDescription = new Label();
            sidebar.SuspendLayout();
            header.SuspendLayout();
            mainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(24, 45, 75);
            sidebar.Controls.Add(lblBrand);
            sidebar.Controls.Add(btnDashboard);
            sidebar.Controls.Add(btnInventory);
            sidebar.Controls.Add(btnProducts);
            sidebar.Controls.Add(btnCategories);
            sidebar.Controls.Add(btnUsers);
            sidebar.Controls.Add(btnLogout);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 0);
            sidebar.Margin = new Padding(3, 2, 3, 2);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(237, 511);
            sidebar.TabIndex = 2;
            // 
            // lblBrand
            // 
            lblBrand.AutoSize = true;
            lblBrand.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblBrand.ForeColor = Color.White;
            lblBrand.Location = new Point(18, 22);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(207, 28);
            lblBrand.TabIndex = 0;
            lblBrand.Text = "INVENTORY SYSTEM";
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(24, 45, 75);
            btnDashboard.Cursor = Cursors.Hand;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 11F);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(13, 90);
            btnDashboard.Margin = new Padding(3, 2, 3, 2);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(175, 34);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnMenu_Click;
            // 
            // btnInventory
            // 
            btnInventory.BackColor = Color.FromArgb(24, 45, 75);
            btnInventory.Cursor = Cursors.Hand;
            btnInventory.FlatAppearance.BorderSize = 0;
            btnInventory.FlatStyle = FlatStyle.Flat;
            btnInventory.Font = new Font("Segoe UI", 11F);
            btnInventory.ForeColor = Color.White;
            btnInventory.Location = new Point(13, 131);
            btnInventory.Margin = new Padding(3, 2, 3, 2);
            btnInventory.Name = "btnInventory";
            btnInventory.Size = new Size(175, 34);
            btnInventory.TabIndex = 2;
            btnInventory.Text = "Inventory";
            btnInventory.TextAlign = ContentAlignment.MiddleLeft;
            btnInventory.UseVisualStyleBackColor = false;
            btnInventory.Click += btnMenu_Click;
            // 
            // btnProducts
            // 
            btnProducts.BackColor = Color.FromArgb(24, 45, 75);
            btnProducts.Cursor = Cursors.Hand;
            btnProducts.FlatAppearance.BorderSize = 0;
            btnProducts.FlatStyle = FlatStyle.Flat;
            btnProducts.Font = new Font("Segoe UI", 11F);
            btnProducts.ForeColor = Color.White;
            btnProducts.Location = new Point(13, 172);
            btnProducts.Margin = new Padding(3, 2, 3, 2);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(175, 34);
            btnProducts.TabIndex = 3;
            btnProducts.Text = "Products";
            btnProducts.TextAlign = ContentAlignment.MiddleLeft;
            btnProducts.UseVisualStyleBackColor = false;
            btnProducts.Click += btnMenu_Click;
            // 
            // btnCategories
            // 
            btnCategories.BackColor = Color.FromArgb(24, 45, 75);
            btnCategories.Cursor = Cursors.Hand;
            btnCategories.FlatAppearance.BorderSize = 0;
            btnCategories.FlatStyle = FlatStyle.Flat;
            btnCategories.Font = new Font("Segoe UI", 11F);
            btnCategories.ForeColor = Color.White;
            btnCategories.Location = new Point(13, 214);
            btnCategories.Margin = new Padding(3, 2, 3, 2);
            btnCategories.Name = "btnCategories";
            btnCategories.Size = new Size(175, 34);
            btnCategories.TabIndex = 4;
            btnCategories.Text = "Categories";
            btnCategories.TextAlign = ContentAlignment.MiddleLeft;
            btnCategories.UseVisualStyleBackColor = false;
            btnCategories.Click += btnMenu_Click;
            // 
            // btnUsers
            // 
            btnUsers.BackColor = Color.FromArgb(24, 45, 75);
            btnUsers.Cursor = Cursors.Hand;
            btnUsers.FlatAppearance.BorderSize = 0;
            btnUsers.FlatStyle = FlatStyle.Flat;
            btnUsers.Font = new Font("Segoe UI", 11F);
            btnUsers.ForeColor = Color.White;
            btnUsers.Location = new Point(13, 255);
            btnUsers.Margin = new Padding(3, 2, 3, 2);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(175, 34);
            btnUsers.TabIndex = 5;
            btnUsers.Text = "Users";
            btnUsers.TextAlign = ContentAlignment.MiddleLeft;
            btnUsers.UseVisualStyleBackColor = false;
            btnUsers.Click += btnMenu_Click;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnLogout.BackColor = Color.FromArgb(190, 55, 55);
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(18, 442);
            btnLogout.Margin = new Padding(3, 2, 3, 2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(166, 34);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "LOG OUT";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // header
            // 
            header.BackColor = Color.White;
            header.Controls.Add(lblWelcome);
            header.Dock = DockStyle.Top;
            header.Location = new Point(237, 0);
            header.Margin = new Padding(3, 2, 3, 2);
            header.Name = "header";
            header.Size = new Size(755, 60);
            header.TabIndex = 1;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.FromArgb(30, 64, 110);
            lblWelcome.Location = new Point(26, 21);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(82, 21);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome";
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.FromArgb(245, 247, 250);
            mainPanel.Controls.Add(lblPageTitle);
            mainPanel.Controls.Add(lblDescription);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(237, 60);
            mainPanel.Margin = new Padding(3, 2, 3, 2);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(755, 451);
            mainPanel.TabIndex = 0;
            // 
            // lblPageTitle
            // 
            lblPageTitle.AutoSize = true;
            lblPageTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblPageTitle.ForeColor = Color.FromArgb(30, 64, 110);
            lblPageTitle.Location = new Point(31, 26);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new Size(184, 45);
            lblPageTitle.TabIndex = 0;
            lblPageTitle.Text = "Dashboard";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 12F);
            lblDescription.ForeColor = Color.DimGray;
            lblDescription.Location = new Point(35, 75);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(89, 21);
            lblDescription.TabIndex = 1;
            lblDescription.Text = "Description";
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(992, 511);
            Controls.Add(mainPanel);
            Controls.Add(header);
            Controls.Add(sidebar);
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(877, 460);
            Name = "DashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventory Management System";
            sidebar.ResumeLayout(false);
            sidebar.PerformLayout();
            header.ResumeLayout(false);
            header.PerformLayout();
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel sidebar;
        private Label lblBrand;
        private Button btnDashboard;
        private Button btnInventory;
        private Button btnProducts;
        private Button btnCategories;
        private Button btnUsers;
        private Button btnLogout;
        private Panel header;
        private Label lblWelcome;
        private Panel mainPanel;
        private Label lblPageTitle;
        private Label lblDescription;
    }
}