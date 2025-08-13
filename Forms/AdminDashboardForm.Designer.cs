namespace eshift_good_tranport_system.Forms
{
    partial class AdminDashboardForm
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
            btnManageUnits = new Button();
            btnGenerateReport = new Button();
            dgvTransportUnits = new DataGridView();
            lblTransportUnits = new Label();
            btnRejectJob = new Button();
            btnLogout = new Button();
            btnAcceptJob = new Button();
            dgvJobs = new DataGridView();
            lblAllJobs = new Label();
            lblWelcome = new Label();
            btnAdmin = new Button();
            cmbLorries = new ComboBox();
            btnAssignLorry = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTransportUnits).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvJobs).BeginInit();
            SuspendLayout();
            // 
            // btnManageUnits
            // 
            btnManageUnits.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnManageUnits.BackColor = SystemColors.HotTrack;
            btnManageUnits.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnManageUnits.ForeColor = SystemColors.ButtonHighlight;
            btnManageUnits.Location = new Point(559, 367);
            btnManageUnits.Name = "btnManageUnits";
            btnManageUnits.Size = new Size(480, 36);
            btnManageUnits.TabIndex = 39;
            btnManageUnits.Text = "Manage Unit";
            btnManageUnits.UseVisualStyleBackColor = false;
            btnManageUnits.Click += btnManageUnits_Click;
            // 
            // btnGenerateReport
            // 
            btnGenerateReport.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnGenerateReport.BackColor = SystemColors.HotTrack;
            btnGenerateReport.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnGenerateReport.ForeColor = SystemColors.ButtonHighlight;
            btnGenerateReport.Location = new Point(909, 90);
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.Size = new Size(130, 36);
            btnGenerateReport.TabIndex = 37;
            btnGenerateReport.Text = "Generate Report";
            btnGenerateReport.UseVisualStyleBackColor = false;
            btnGenerateReport.Click += btnGenerateReport_Click;
            // 
            // dgvTransportUnits
            // 
            dgvTransportUnits.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvTransportUnits.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTransportUnits.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransportUnits.Location = new Point(559, 164);
            dgvTransportUnits.Name = "dgvTransportUnits";
            dgvTransportUnits.RowHeadersWidth = 51;
            dgvTransportUnits.Size = new Size(480, 162);
            dgvTransportUnits.TabIndex = 36;
            dgvTransportUnits.CellContentClick += dgvTransportUnits_CellContentClick;
            // 
            // lblTransportUnits
            // 
            lblTransportUnits.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTransportUnits.AutoSize = true;
            lblTransportUnits.Location = new Point(559, 132);
            lblTransportUnits.Name = "lblTransportUnits";
            lblTransportUnits.Size = new Size(108, 20);
            lblTransportUnits.TabIndex = 35;
            lblTransportUnits.Text = "Transport Units";
            // 
            // btnRejectJob
            // 
            btnRejectJob.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnRejectJob.BackColor = SystemColors.HotTrack;
            btnRejectJob.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnRejectJob.ForeColor = SystemColors.ButtonHighlight;
            btnRejectJob.Location = new Point(33, 385);
            btnRejectJob.Name = "btnRejectJob";
            btnRejectJob.Size = new Size(508, 37);
            btnRejectJob.TabIndex = 34;
            btnRejectJob.Text = "Reject Job";
            btnRejectJob.UseVisualStyleBackColor = false;
            btnRejectJob.Click += btnRejectJob_Click;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnLogout.BackColor = Color.Red;
            btnLogout.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnLogout.ForeColor = SystemColors.ButtonHighlight;
            btnLogout.Location = new Point(559, 400);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(480, 38);
            btnLogout.TabIndex = 33;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnAcceptJob
            // 
            btnAcceptJob.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAcceptJob.BackColor = SystemColors.HotTrack;
            btnAcceptJob.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnAcceptJob.ForeColor = SystemColors.ButtonHighlight;
            btnAcceptJob.Location = new Point(33, 342);
            btnAcceptJob.Name = "btnAcceptJob";
            btnAcceptJob.Size = new Size(508, 37);
            btnAcceptJob.TabIndex = 32;
            btnAcceptJob.Text = "Accept Job";
            btnAcceptJob.UseVisualStyleBackColor = false;
            btnAcceptJob.Click += btnAcceptJob_Click;
            // 
            // dgvJobs
            // 
            dgvJobs.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvJobs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvJobs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvJobs.Location = new Point(33, 164);
            dgvJobs.Name = "dgvJobs";
            dgvJobs.RowHeadersWidth = 51;
            dgvJobs.Size = new Size(508, 162);
            dgvJobs.TabIndex = 31;
            // 
            // lblAllJobs
            // 
            lblAllJobs.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblAllJobs.AutoSize = true;
            lblAllJobs.Location = new Point(33, 132);
            lblAllJobs.Name = "lblAllJobs";
            lblAllJobs.Size = new Size(60, 20);
            lblAllJobs.TabIndex = 30;
            lblAllJobs.Text = "All Jobs";
            // 
            // lblWelcome
            // 
            lblWelcome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(33, 85);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(350, 31);
            lblWelcome.TabIndex = 29;
            lblWelcome.Text = "Welcome to Admin Dashboard!";
            // 
            // btnAdmin
            // 
            btnAdmin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAdmin.BackColor = SystemColors.HotTrack;
            btnAdmin.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnAdmin.ForeColor = SystemColors.ButtonHighlight;
            btnAdmin.Location = new Point(763, 90);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(128, 36);
            btnAdmin.TabIndex = 40;
            btnAdmin.Text = "Manage Admin";
            btnAdmin.UseVisualStyleBackColor = false;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // cmbLorries
            // 
            cmbLorries.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cmbLorries.FormattingEnabled = true;
            cmbLorries.Location = new Point(559, 332);
            cmbLorries.Name = "cmbLorries";
            cmbLorries.Size = new Size(265, 28);
            cmbLorries.TabIndex = 41;
            // 
            // btnAssignLorry
            // 
            btnAssignLorry.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAssignLorry.BackColor = SystemColors.HotTrack;
            btnAssignLorry.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnAssignLorry.ForeColor = SystemColors.ButtonHighlight;
            btnAssignLorry.Location = new Point(830, 332);
            btnAssignLorry.Name = "btnAssignLorry";
            btnAssignLorry.Size = new Size(209, 38);
            btnAssignLorry.TabIndex = 42;
            btnAssignLorry.Text = "Assign Lorry";
            btnAssignLorry.UseVisualStyleBackColor = false;
            btnAssignLorry.Click += btnAssignLorry_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Kristen ITC", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(451, 9);
            label2.Name = "label2";
            label2.Size = new Size(164, 54);
            label2.TabIndex = 43;
            label2.Text = "e-Shift";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // AdminDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1075, 450);
            Controls.Add(label2);
            Controls.Add(btnAssignLorry);
            Controls.Add(cmbLorries);
            Controls.Add(btnAdmin);
            Controls.Add(btnManageUnits);
            Controls.Add(btnGenerateReport);
            Controls.Add(dgvTransportUnits);
            Controls.Add(lblTransportUnits);
            Controls.Add(btnRejectJob);
            Controls.Add(btnLogout);
            Controls.Add(btnAcceptJob);
            Controls.Add(dgvJobs);
            Controls.Add(lblAllJobs);
            Controls.Add(lblWelcome);
            Name = "AdminDashboardForm";
            Text = "AdminDashboardForm";
            Load += AdminDashboardForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTransportUnits).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvJobs).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnManageUnits;
        private Button btnGenerateReport;
        private DataGridView dgvTransportUnits;
        private Label lblTransportUnits;
        private Button btnRejectJob;
        private Button btnLogout;
        private Button btnAcceptJob;
        private DataGridView dgvJobs;
        private Label lblAllJobs;
        private Label lblWelcome;
        private Button btnAdmin;
        private ComboBox cmbLorries;
        private Button btnAssignLorry;
        private Label label2;
    }
}