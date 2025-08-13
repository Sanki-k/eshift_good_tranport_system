namespace eshift_good_tranport_system.Forms
{
    partial class AdminManagementForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnBack = new Button();
            btnDeleteAdmin = new Button();
            btnEditAdmin = new Button();
            btnAddAdmin = new Button();
            txtPassword = new TextBox();
            lblPassword = new Label();
            txtUsername = new TextBox();
            label2 = new Label();
            dgvAdmins = new DataGridView();
            label1 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAdmins).BeginInit();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnBack.BackColor = SystemColors.HotTrack;
            btnBack.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnBack.ForeColor = SystemColors.ButtonHighlight;
            btnBack.Location = new Point(411, 312);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(222, 38);
            btnBack.TabIndex = 32;
            btnBack.Text = "Back to Dashboard";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnDeleteAdmin
            // 
            btnDeleteAdmin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnDeleteAdmin.BackColor = Color.Red;
            btnDeleteAdmin.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnDeleteAdmin.ForeColor = SystemColors.ButtonHighlight;
            btnDeleteAdmin.Location = new Point(23, 311);
            btnDeleteAdmin.Name = "btnDeleteAdmin";
            btnDeleteAdmin.Size = new Size(250, 32);
            btnDeleteAdmin.TabIndex = 31;
            btnDeleteAdmin.Text = "Delete Admin";
            btnDeleteAdmin.UseVisualStyleBackColor = false;
            btnDeleteAdmin.Click += btnDeleteAdmin_Click;
            // 
            // btnEditAdmin
            // 
            btnEditAdmin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnEditAdmin.BackColor = SystemColors.HotTrack;
            btnEditAdmin.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnEditAdmin.ForeColor = SystemColors.ButtonHighlight;
            btnEditAdmin.Location = new Point(23, 271);
            btnEditAdmin.Name = "btnEditAdmin";
            btnEditAdmin.Size = new Size(250, 34);
            btnEditAdmin.TabIndex = 30;
            btnEditAdmin.Text = "Edit Admin";
            btnEditAdmin.UseVisualStyleBackColor = false;
            btnEditAdmin.Click += btnEditAdmin_Click;
            // 
            // btnAddAdmin
            // 
            btnAddAdmin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAddAdmin.BackColor = SystemColors.HotTrack;
            btnAddAdmin.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnAddAdmin.ForeColor = SystemColors.ButtonHighlight;
            btnAddAdmin.Location = new Point(23, 232);
            btnAddAdmin.Name = "btnAddAdmin";
            btnAddAdmin.Size = new Size(250, 33);
            btnAddAdmin.TabIndex = 29;
            btnAddAdmin.Text = "Add Admin";
            btnAddAdmin.UseVisualStyleBackColor = false;
            btnAddAdmin.Click += btnAddAdmin_Click;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtPassword.Location = new Point(23, 199);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(250, 27);
            txtPassword.TabIndex = 28;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            lblPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(23, 176);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(73, 20);
            lblPassword.TabIndex = 27;
            lblPassword.Text = "Password:";
            // 
            // txtUsername
            // 
            txtUsername.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtUsername.Location = new Point(23, 142);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(250, 27);
            txtUsername.TabIndex = 26;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(23, 119);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 25;
            label2.Text = "Username:";
            // 
            // dgvAdmins
            // 
            dgvAdmins.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvAdmins.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAdmins.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAdmins.Location = new Point(279, 100);
            dgvAdmins.Name = "dgvAdmins";
            dgvAdmins.RowHeadersWidth = 51;
            dgvAdmins.Size = new Size(351, 188);
            dgvAdmins.TabIndex = 24;
            dgvAdmins.CellContentClick += dgvAdmins_CellContentClick;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 59);
            label1.Name = "label1";
            label1.Size = new Size(288, 38);
            label1.TabIndex = 22;
            label1.Text = "Admin Management";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Kristen ITC", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.HotTrack;
            label3.Location = new Point(469, 9);
            label3.Name = "label3";
            label3.Size = new Size(164, 54);
            label3.TabIndex = 33;
            label3.Text = "e-Shift";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // AdminManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(642, 362);
            Controls.Add(label3);
            Controls.Add(btnBack);
            Controls.Add(btnDeleteAdmin);
            Controls.Add(btnEditAdmin);
            Controls.Add(btnAddAdmin);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(dgvAdmins);
            Controls.Add(label1);
            Name = "AdminManagementForm";
            Text = "AdminManagementForm";
            Load += AdminManagementForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAdmins).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Button btnDeleteAdmin;
        private Button btnEditAdmin;
        private Button btnAddAdmin;
        private TextBox txtPassword;
        private Label lblPassword;
        private TextBox txtUsername;
        private Label label2;
        private DataGridView dgvAdmins;
        private Label label1;
        private Label label3;
    }
}