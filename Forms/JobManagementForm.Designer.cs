namespace eshift_good_tranport_system.Forms
{
    partial class JobManagementForm
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
            btnClear = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            txtDestination = new TextBox();
            lblDestination = new Label();
            txtStartLocation = new TextBox();
            lblStartLocation = new Label();
            dgvJobs = new DataGridView();
            lblYourJobs = new Label();
            lblJobManagement = new Label();
            btnExit = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvJobs).BeginInit();
            SuspendLayout();
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnClear.BackColor = SystemColors.HotTrack;
            btnClear.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnClear.ForeColor = SystemColors.ButtonHighlight;
            btnClear.Location = new Point(25, 352);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(225, 34);
            btnClear.TabIndex = 36;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnDelete.BackColor = Color.Red;
            btnDelete.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnDelete.ForeColor = SystemColors.ButtonHighlight;
            btnDelete.Location = new Point(25, 392);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(225, 32);
            btnDelete.TabIndex = 35;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnEdit.BackColor = SystemColors.HotTrack;
            btnEdit.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnEdit.ForeColor = SystemColors.ButtonHighlight;
            btnEdit.Location = new Point(526, 345);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(249, 33);
            btnEdit.TabIndex = 34;
            btnEdit.Text = "Edit Job";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAdd.BackColor = SystemColors.HotTrack;
            btnAdd.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnAdd.ForeColor = SystemColors.ButtonHighlight;
            btnAdd.Location = new Point(526, 298);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(249, 33);
            btnAdd.TabIndex = 33;
            btnAdd.Text = "Add Job";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtDestination
            // 
            txtDestination.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtDestination.Location = new Point(526, 254);
            txtDestination.Name = "txtDestination";
            txtDestination.Size = new Size(249, 27);
            txtDestination.TabIndex = 32;
            // 
            // lblDestination
            // 
            lblDestination.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblDestination.AutoSize = true;
            lblDestination.Location = new Point(526, 231);
            lblDestination.Name = "lblDestination";
            lblDestination.Size = new Size(92, 20);
            lblDestination.TabIndex = 31;
            lblDestination.Text = "Destination :";
            // 
            // txtStartLocation
            // 
            txtStartLocation.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtStartLocation.Location = new Point(526, 201);
            txtStartLocation.Name = "txtStartLocation";
            txtStartLocation.Size = new Size(249, 27);
            txtStartLocation.TabIndex = 30;
            // 
            // lblStartLocation
            // 
            lblStartLocation.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblStartLocation.AutoSize = true;
            lblStartLocation.Location = new Point(526, 169);
            lblStartLocation.Name = "lblStartLocation";
            lblStartLocation.Size = new Size(108, 20);
            lblStartLocation.TabIndex = 29;
            lblStartLocation.Text = "Start Location :";
            // 
            // dgvJobs
            // 
            dgvJobs.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvJobs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvJobs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvJobs.Location = new Point(25, 169);
            dgvJobs.Name = "dgvJobs";
            dgvJobs.RowHeadersWidth = 51;
            dgvJobs.Size = new Size(495, 162);
            dgvJobs.TabIndex = 28;
            // 
            // lblYourJobs
            // 
            lblYourJobs.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblYourJobs.AutoSize = true;
            lblYourJobs.Location = new Point(25, 137);
            lblYourJobs.Name = "lblYourJobs";
            lblYourJobs.Size = new Size(71, 20);
            lblYourJobs.TabIndex = 27;
            lblYourJobs.Text = "Your Jobs";
            // 
            // lblJobManagement
            // 
            lblJobManagement.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblJobManagement.AutoSize = true;
            lblJobManagement.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJobManagement.Location = new Point(25, 82);
            lblJobManagement.Name = "lblJobManagement";
            lblJobManagement.Size = new Size(246, 38);
            lblJobManagement.TabIndex = 26;
            lblJobManagement.Text = "Job Management";
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnExit.BackColor = Color.Red;
            btnExit.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnExit.ForeColor = SystemColors.ButtonHighlight;
            btnExit.Location = new Point(526, 391);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(249, 33);
            btnExit.TabIndex = 37;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Kristen ITC", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(312, 18);
            label1.Name = "label1";
            label1.Size = new Size(164, 54);
            label1.TabIndex = 38;
            label1.Text = "e-Shift";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // JobManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(txtDestination);
            Controls.Add(lblDestination);
            Controls.Add(txtStartLocation);
            Controls.Add(lblStartLocation);
            Controls.Add(dgvJobs);
            Controls.Add(lblYourJobs);
            Controls.Add(lblJobManagement);
            Name = "JobManagementForm";
            Text = "JobManagementForm";
            Load += JobManagementForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvJobs).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClear;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private TextBox txtDestination;
        private Label lblDestination;
        private TextBox txtStartLocation;
        private Label lblStartLocation;
        private DataGridView dgvJobs;
        private Label lblYourJobs;
        private Label lblJobManagement;
        private Button btnExit;
        private Label label1;
    }
}