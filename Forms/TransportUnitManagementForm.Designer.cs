namespace eshift_good_tranport_system.Forms
{
    partial class TransportUnitManagementForm
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
            btnDelete = new Button();
            btnEditUnit = new Button();
            btnAddUnit = new Button();
            txtContainer = new TextBox();
            lblContainer = new Label();
            txtAssistant = new TextBox();
            lblAssistant = new Label();
            txtDriver = new TextBox();
            lblDriver = new Label();
            txtLorry = new TextBox();
            lblLorry = new Label();
            dgvUnits = new DataGridView();
            lblTransportUnits = new Label();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvUnits).BeginInit();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnBack.BackColor = SystemColors.HotTrack;
            btnBack.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnBack.ForeColor = SystemColors.ButtonHighlight;
            btnBack.Location = new Point(567, 409);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(221, 29);
            btnBack.TabIndex = 44;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnDelete.BackColor = Color.Red;
            btnDelete.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnDelete.ForeColor = SystemColors.ButtonHighlight;
            btnDelete.Location = new Point(567, 374);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(221, 29);
            btnDelete.TabIndex = 43;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEditUnit
            // 
            btnEditUnit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnEditUnit.BackColor = SystemColors.HotTrack;
            btnEditUnit.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnEditUnit.ForeColor = SystemColors.ButtonHighlight;
            btnEditUnit.Location = new Point(32, 409);
            btnEditUnit.Name = "btnEditUnit";
            btnEditUnit.Size = new Size(209, 29);
            btnEditUnit.TabIndex = 42;
            btnEditUnit.Text = "Edit Unit";
            btnEditUnit.UseVisualStyleBackColor = false;
            btnEditUnit.Click += btnEditUnit_Click;
            // 
            // btnAddUnit
            // 
            btnAddUnit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAddUnit.BackColor = SystemColors.HotTrack;
            btnAddUnit.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnAddUnit.ForeColor = SystemColors.ButtonHighlight;
            btnAddUnit.Location = new Point(32, 374);
            btnAddUnit.Name = "btnAddUnit";
            btnAddUnit.Size = new Size(209, 29);
            btnAddUnit.TabIndex = 41;
            btnAddUnit.Text = "Add Unit";
            btnAddUnit.UseVisualStyleBackColor = false;
            btnAddUnit.Click += btnAddUnit_Click;
            // 
            // txtContainer
            // 
            txtContainer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtContainer.Location = new Point(567, 319);
            txtContainer.Name = "txtContainer";
            txtContainer.Size = new Size(221, 27);
            txtContainer.TabIndex = 40;
            // 
            // lblContainer
            // 
            lblContainer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblContainer.AutoSize = true;
            lblContainer.Location = new Point(567, 296);
            lblContainer.Name = "lblContainer";
            lblContainer.Size = new Size(76, 20);
            lblContainer.TabIndex = 39;
            lblContainer.Text = "Container:";
            // 
            // txtAssistant
            // 
            txtAssistant.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtAssistant.Location = new Point(567, 266);
            txtAssistant.Name = "txtAssistant";
            txtAssistant.Size = new Size(221, 27);
            txtAssistant.TabIndex = 38;
            // 
            // lblAssistant
            // 
            lblAssistant.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblAssistant.AutoSize = true;
            lblAssistant.Location = new Point(567, 243);
            lblAssistant.Name = "lblAssistant";
            lblAssistant.Size = new Size(70, 20);
            lblAssistant.TabIndex = 37;
            lblAssistant.Text = "Assistant:";
            // 
            // txtDriver
            // 
            txtDriver.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtDriver.Location = new Point(567, 213);
            txtDriver.Name = "txtDriver";
            txtDriver.Size = new Size(221, 27);
            txtDriver.TabIndex = 36;
            // 
            // lblDriver
            // 
            lblDriver.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblDriver.AutoSize = true;
            lblDriver.Location = new Point(567, 190);
            lblDriver.Name = "lblDriver";
            lblDriver.Size = new Size(52, 20);
            lblDriver.TabIndex = 35;
            lblDriver.Text = "Driver:";
            // 
            // txtLorry
            // 
            txtLorry.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtLorry.Location = new Point(567, 160);
            txtLorry.Name = "txtLorry";
            txtLorry.Size = new Size(221, 27);
            txtLorry.TabIndex = 34;
            // 
            // lblLorry
            // 
            lblLorry.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblLorry.AutoSize = true;
            lblLorry.Location = new Point(567, 137);
            lblLorry.Name = "lblLorry";
            lblLorry.Size = new Size(45, 20);
            lblLorry.TabIndex = 33;
            lblLorry.Text = "Lorry:";
            // 
            // dgvUnits
            // 
            dgvUnits.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvUnits.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUnits.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUnits.Location = new Point(32, 137);
            dgvUnits.Name = "dgvUnits";
            dgvUnits.RowHeadersWidth = 51;
            dgvUnits.Size = new Size(518, 209);
            dgvUnits.TabIndex = 32;
            dgvUnits.CellContentClick += dgvUnits_CellContentClick;
            // 
            // lblTransportUnits
            // 
            lblTransportUnits.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTransportUnits.AutoSize = true;
            lblTransportUnits.Location = new Point(32, 114);
            lblTransportUnits.Name = "lblTransportUnits";
            lblTransportUnits.Size = new Size(108, 20);
            lblTransportUnits.TabIndex = 31;
            lblTransportUnits.Text = "Transport Units";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 65);
            label1.Name = "label1";
            label1.Size = new Size(390, 38);
            label1.TabIndex = 30;
            label1.Text = "Transport Unit Management";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Kristen ITC", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(335, 11);
            label2.Name = "label2";
            label2.Size = new Size(164, 54);
            label2.TabIndex = 45;
            label2.Text = "e-Shift";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // TransportUnitManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(btnBack);
            Controls.Add(btnDelete);
            Controls.Add(btnEditUnit);
            Controls.Add(btnAddUnit);
            Controls.Add(txtContainer);
            Controls.Add(lblContainer);
            Controls.Add(txtAssistant);
            Controls.Add(lblAssistant);
            Controls.Add(txtDriver);
            Controls.Add(lblDriver);
            Controls.Add(txtLorry);
            Controls.Add(lblLorry);
            Controls.Add(dgvUnits);
            Controls.Add(lblTransportUnits);
            Controls.Add(label1);
            Name = "TransportUnitManagementForm";
            Text = "TransportUnitManagementForm";
            Load += TransportUnitManagementForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUnits).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Button btnDelete;
        private Button btnEditUnit;
        private Button btnAddUnit;
        private TextBox txtContainer;
        private Label lblContainer;
        private TextBox txtAssistant;
        private Label lblAssistant;
        private TextBox txtDriver;
        private Label lblDriver;
        private TextBox txtLorry;
        private Label lblLorry;
        private DataGridView dgvUnits;
        private Label lblTransportUnits;
        private Label label1;
        private Label label2;
    }
}