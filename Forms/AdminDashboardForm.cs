using eshift_good_tranport_system.Business.Service;
using eshift_good_tranport_system.Repository.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eshift_good_tranport_system.Forms
{
    public partial class AdminDashboardForm : Form
    {
        private readonly JobService _jobService;

        public AdminDashboardForm()
        {
            InitializeComponent();
            _jobService = new JobService(new JobRepository()); /*Injecting the JobRepository*/

        }

        private void AdminDashboardForm_Load(object sender, EventArgs e)
        {
            LoadJobs();
            LoadTransportUnits();
            LoadLorries();


        }
        private void LoadJobs()
        {
            dgvJobs.DataSource = _jobService.GetAllJobs();
        }

        private void btnAcceptJob_Click(object sender, EventArgs e)
        {
            if (dgvJobs.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a job to accept.");
                return;
            }

            int jobId = Convert.ToInt32(dgvJobs.SelectedRows[0].Cells["Id"].Value);
            _jobService.UpdateJobStatus(jobId, "Approved");
            LoadJobs();
        }

        private void btnRejectJob_Click(object sender, EventArgs e)
        {
            if (dgvJobs.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a job to reject.");
                return;
            }

            int jobId = Convert.ToInt32(dgvJobs.SelectedRows[0].Cells["Id"].Value);
            _jobService.UpdateJobStatus(jobId, "Declined");
            LoadJobs();
        }

        private void btnManageUnits_Click(object sender, EventArgs e)
        {
            new TransportUnitManagementForm().ShowDialog();
            LoadTransportUnits();
        }

        private void LoadTransportUnits()  // The method that binds the transport unit list to dgvTransportUnits
        {
            var unitService = new TransportUnitService(new TransportUnitRepository());
            dgvTransportUnits.DataSource = unitService.GetAllUnits();
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            new ReportGenerationForm().ShowDialog();

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm().Show();
        }

        private void dgvTransportUnits_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var unitService = new TransportUnitService(new TransportUnitRepository());
            dgvTransportUnits.DataSource = unitService.GetAllUnits();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            new AdminManagementForm().ShowDialog();
            LoadAdmin();
        }

        private void LoadAdmin()
        {

        }
        private void LoadLorries()
        {
            var lorryService = new TransportUnitService(new TransportUnitRepository());
            var lorries = lorryService.GetAllUnits();
            cmbLorries.DataSource = lorries;
            cmbLorries.DisplayMember = "VehicleNumber";
            cmbLorries.ValueMember = "LorryId";
        }

        private void btnAssignLorry_Click(object sender, EventArgs e)
        {
            if (dgvJobs.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a job to assign a lorry.");
                return;
            }

            if (cmbLorries.SelectedValue == null)
            {
                MessageBox.Show("Please select a lorry.");
                return;
            }

            int jobId = Convert.ToInt32(dgvJobs.SelectedRows[0].Cells["Id"].Value);
            int lorryId = Convert.ToInt32(cmbLorries.SelectedValue);

            _jobService.AssignLorry(jobId, lorryId);
            MessageBox.Show("Lorry assigned to job.");
            LoadJobs(); // reload grid
        }
    }
}
