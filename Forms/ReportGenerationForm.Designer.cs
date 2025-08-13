namespace eshift_good_tranport_system.Forms
{
    partial class ReportGenerationForm
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
            btnBacktoDashboard = new Button();
            cmbReportType = new ComboBox();
            label3 = new Label();
            label1 = new Label();
            dgvReport = new DataGridView();
            btnGenerate = new Button();
            dtpTo = new DateTimePicker();
            lblTo = new Label();
            dtpFrom = new DateTimePicker();
            lblFrom = new Label();
            groupBox1 = new GroupBox();
            cbStatus = new ComboBox();
            label2 = new Label();
            btnExport = new Button();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvReport).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnBacktoDashboard
            // 
            btnBacktoDashboard.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnBacktoDashboard.BackColor = SystemColors.HotTrack;
            btnBacktoDashboard.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnBacktoDashboard.ForeColor = SystemColors.ButtonHighlight;
            btnBacktoDashboard.Location = new Point(602, 396);
            btnBacktoDashboard.Name = "btnBacktoDashboard";
            btnBacktoDashboard.Size = new Size(172, 42);
            btnBacktoDashboard.TabIndex = 36;
            btnBacktoDashboard.Text = "Back to Dashboard";
            btnBacktoDashboard.UseVisualStyleBackColor = false;
            btnBacktoDashboard.Click += btnBacktoDashboard_Click;
            // 
            // cmbReportType
            // 
            cmbReportType.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cmbReportType.FormattingEnabled = true;
            cmbReportType.Items.AddRange(new object[] { "Customer List", "Job List", "Transport Unit List" });
            cmbReportType.Location = new Point(24, 123);
            cmbReportType.Name = "cmbReportType";
            cmbReportType.Size = new Size(159, 28);
            cmbReportType.TabIndex = 34;
            cmbReportType.SelectedIndexChanged += cmbReportType_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(24, 100);
            label3.Name = "label3";
            label3.Size = new Size(136, 20);
            label3.TabIndex = 33;
            label3.Text = "Select Report Type:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 62);
            label1.Name = "label1";
            label1.Size = new Size(358, 38);
            label1.TabIndex = 32;
            label1.Text = "e-Shift Report Generation";
            // 
            // dgvReport
            // 
            dgvReport.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReport.Location = new Point(6, 26);
            dgvReport.Name = "dgvReport";
            dgvReport.RowHeadersWidth = 51;
            dgvReport.Size = new Size(744, 188);
            dgvReport.TabIndex = 6;
            // 
            // btnGenerate
            // 
            btnGenerate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnGenerate.BackColor = SystemColors.HotTrack;
            btnGenerate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnGenerate.ForeColor = SystemColors.ButtonHighlight;
            btnGenerate.Location = new Point(30, 396);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(190, 42);
            btnGenerate.TabIndex = 42;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = false;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // dtpTo
            // 
            dtpTo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtpTo.Format = DateTimePickerFormat.Short;
            dtpTo.Location = new Point(604, 121);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(135, 27);
            dtpTo.TabIndex = 41;
            // 
            // lblTo
            // 
            lblTo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTo.AutoSize = true;
            lblTo.ForeColor = SystemColors.ControlText;
            lblTo.Location = new Point(604, 98);
            lblTo.Name = "lblTo";
            lblTo.Size = new Size(28, 20);
            lblTo.TabIndex = 40;
            lblTo.Text = "To:";
            // 
            // dtpFrom
            // 
            dtpFrom.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtpFrom.Format = DateTimePickerFormat.Short;
            dtpFrom.Location = new Point(458, 123);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(135, 27);
            dtpFrom.TabIndex = 39;
            // 
            // lblFrom
            // 
            lblFrom.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblFrom.AutoSize = true;
            lblFrom.ForeColor = SystemColors.ControlText;
            lblFrom.Location = new Point(458, 100);
            lblFrom.Name = "lblFrom";
            lblFrom.Size = new Size(46, 20);
            lblFrom.TabIndex = 38;
            lblFrom.Text = "From:";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(dgvReport);
            groupBox1.Location = new Point(24, 157);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(765, 223);
            groupBox1.TabIndex = 37;
            groupBox1.TabStop = false;
            groupBox1.Text = "Report";
            // 
            // cbStatus
            // 
            cbStatus.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cbStatus.FormattingEnabled = true;
            cbStatus.Items.AddRange(new object[] { "All", "Pending", "Approved", "Declined", "Completed" });
            cbStatus.Location = new Point(216, 123);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(159, 28);
            cbStatus.TabIndex = 43;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(216, 100);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 44;
            label2.Text = "Status:";
            // 
            // btnExport
            // 
            btnExport.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnExport.BackColor = SystemColors.HotTrack;
            btnExport.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnExport.ForeColor = SystemColors.ButtonHighlight;
            btnExport.Location = new Point(318, 396);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(178, 42);
            btnExport.TabIndex = 45;
            btnExport.Text = "Export";
            btnExport.UseVisualStyleBackColor = false;
            btnExport.Click += btnExport_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Kristen ITC", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.HotTrack;
            label4.Location = new Point(332, 8);
            label4.Name = "label4";
            label4.Size = new Size(164, 54);
            label4.TabIndex = 46;
            label4.Text = "e-Shift";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // ReportGenerationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 450);
            Controls.Add(label4);
            Controls.Add(btnExport);
            Controls.Add(label2);
            Controls.Add(cbStatus);
            Controls.Add(btnBacktoDashboard);
            Controls.Add(cmbReportType);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(btnGenerate);
            Controls.Add(dtpTo);
            Controls.Add(lblTo);
            Controls.Add(dtpFrom);
            Controls.Add(lblFrom);
            Controls.Add(groupBox1);
            Name = "ReportGenerationForm";
            Text = "ReportGenerationForm";
            Load += ReportGenerationForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvReport).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBacktoDashboard;
        private ComboBox cmbReportType;
        private Label label3;
        private Label label1;
        private DataGridView dgvReport;
        private Button btnGenerate;
        private DateTimePicker dtpTo;
        private Label lblTo;
        private DateTimePicker dtpFrom;
        private Label lblFrom;
        private GroupBox groupBox1;
        private ComboBox cbStatus;
        private Label label2;
        private Button btnExport;
        private Label label4;
    }
}