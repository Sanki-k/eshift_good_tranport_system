using eshift_good_tranport_system.Business.Service;
using eshift_good_tranport_system.Models;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace eshift_good_tranport_system.Forms
{
    public partial class JobManagementForm : Form
    {
        private readonly JobService _service;
        private readonly string _username;
        public JobManagementForm(string username)
        {
            InitializeComponent();
            _service = new JobService(new JobRepository());
            _username = username;
        }
        private void LoadJobs()
        {
            dgvJobs.DataSource = _service.GetJobs(_username);
        }

        private void JobManagementForm_Load(object sender, EventArgs e)
        {
            LoadJobs();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var job = new JobModel
            {
                Username = _username,
                PickupLocation = txtStartLocation.Text,
                DeliveryLocation = txtDestination.Text,
                RequestDate = DateTime.Now
            };

            _service.AddJob(job);
            LoadJobs();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvJobs.SelectedRows.Count == 0) return;

            var selected = (JobModel)dgvJobs.SelectedRows[0].DataBoundItem;
            selected.PickupLocation = txtStartLocation.Text;
            selected.DeliveryLocation = txtDestination.Text;

            _service.UpdateJob(selected);
            LoadJobs();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dgvJobs.DataSource = null;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvJobs.SelectedRows.Count == 0) return;

            var selected = (JobModel)dgvJobs.SelectedRows[0].DataBoundItem;
            _service.DeleteJob(selected.Id);
            LoadJobs();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
