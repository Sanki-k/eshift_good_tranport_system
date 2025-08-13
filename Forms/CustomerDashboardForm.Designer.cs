namespace eshift_good_tranport_system.Forms
{
    partial class CustomerDashboardForm
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
            btnUpdateProfile = new Button();
            btnLogout = new Button();
            btnManageJobs = new Button();
            dgvJobs = new DataGridView();
            lblJobs = new Label();
            txtProfileInfo = new TextBox();
            lblProfileDetails = new Label();
            lblWelcome = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvJobs).BeginInit();
            SuspendLayout();
            // 
            // btnUpdateProfile
            // 
            btnUpdateProfile.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnUpdateProfile.BackColor = SystemColors.HotTrack;
            btnUpdateProfile.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnUpdateProfile.ForeColor = SystemColors.ButtonHighlight;
            btnUpdateProfile.Location = new Point(529, 352);
            btnUpdateProfile.Name = "btnUpdateProfile";
            btnUpdateProfile.Size = new Size(247, 34);
            btnUpdateProfile.TabIndex = 30;
            btnUpdateProfile.Text = "Update Profile";
            btnUpdateProfile.UseVisualStyleBackColor = false;
            btnUpdateProfile.Click += btnUpdateProfile_Click;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnLogout.BackColor = Color.Red;
            btnLogout.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = SystemColors.ButtonHighlight;
            btnLogout.Location = new Point(529, 404);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(247, 34);
            btnLogout.TabIndex = 29;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnManageJobs
            // 
            btnManageJobs.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnManageJobs.BackColor = SystemColors.HotTrack;
            btnManageJobs.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnManageJobs.ForeColor = SystemColors.ButtonHighlight;
            btnManageJobs.Location = new Point(12, 353);
            btnManageJobs.Name = "btnManageJobs";
            btnManageJobs.Size = new Size(214, 33);
            btnManageJobs.TabIndex = 28;
            btnManageJobs.Text = "Manage Jobs";
            btnManageJobs.UseVisualStyleBackColor = false;
            btnManageJobs.Click += btnManageJobs_Click;
            // 
            // dgvJobs
            // 
            dgvJobs.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvJobs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvJobs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvJobs.Location = new Point(12, 162);
            dgvJobs.Name = "dgvJobs";
            dgvJobs.RowHeadersWidth = 51;
            dgvJobs.Size = new Size(493, 162);
            dgvJobs.TabIndex = 27;
            // 
            // lblJobs
            // 
            lblJobs.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblJobs.AutoSize = true;
            lblJobs.Location = new Point(12, 139);
            lblJobs.Name = "lblJobs";
            lblJobs.Size = new Size(38, 20);
            lblJobs.TabIndex = 26;
            lblJobs.Text = "Jobs";
            // 
            // txtProfileInfo
            // 
            txtProfileInfo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtProfileInfo.Location = new Point(529, 197);
            txtProfileInfo.Multiline = true;
            txtProfileInfo.Name = "txtProfileInfo";
            txtProfileInfo.ReadOnly = true;
            txtProfileInfo.ScrollBars = ScrollBars.Vertical;
            txtProfileInfo.Size = new Size(233, 102);
            txtProfileInfo.TabIndex = 25;
            txtProfileInfo.TextChanged += txtProfileInfo_TextChanged;
            // 
            // lblProfileDetails
            // 
            lblProfileDetails.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblProfileDetails.AutoSize = true;
            lblProfileDetails.Location = new Point(529, 162);
            lblProfileDetails.Name = "lblProfileDetails";
            lblProfileDetails.Size = new Size(102, 20);
            lblProfileDetails.TabIndex = 24;
            lblProfileDetails.Text = "Profile Details";
            // 
            // lblWelcome
            // 
            lblWelcome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(12, 85);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(381, 31);
            lblWelcome.TabIndex = 23;
            lblWelcome.Text = "Welcome to Customer Dashboard!";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Kristen ITC", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(313, 9);
            label1.Name = "label1";
            label1.Size = new Size(164, 54);
            label1.TabIndex = 31;
            label1.Text = "e-Shift";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // CustomerDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnUpdateProfile);
            Controls.Add(btnLogout);
            Controls.Add(btnManageJobs);
            Controls.Add(dgvJobs);
            Controls.Add(lblJobs);
            Controls.Add(txtProfileInfo);
            Controls.Add(lblProfileDetails);
            Controls.Add(lblWelcome);
            Name = "CustomerDashboardForm";
            Text = "CustomerDashboardForm";
            Load += CustomerDashboardForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvJobs).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUpdateProfile;
        private Button btnLogout;
        private Button btnManageJobs;
        private DataGridView dgvJobs;
        private Label lblJobs;
        private TextBox txtProfileInfo;
        private Label lblProfileDetails;
        private Label lblWelcome;
        private Label label1;
    }
}