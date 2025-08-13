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
    public partial class CustomerDashboardForm : Form
    {
        private readonly string _username;
        private readonly CustomerService _customerService;          /*customerservice object*/
        private readonly JobService _jobService;


        public CustomerDashboardForm(string username)    /*Constructor - receives the username and initializes the fields*/
        {
            InitializeComponent();
            _username = username;
            _customerService = new CustomerService(new CustomerRepository());
            _jobService = new JobService(new JobRepository());
        }


        private void txtProfileInfo_TextChanged(object sender, EventArgs e)
        {

        }

        private void CustomerDashboardForm_Load(object sender, EventArgs e)
        {
            LoadCustomerProfile();
            LoadJobs();
        }

        private void LoadJobs()
        {
            List<JobModel> jobs = _jobService.GetJobs(_username);
            dgvJobs.DataSource = jobs;

        }

        private void LoadCustomerProfile()
        {
            var customer = _customerService.GetCustomerByUsername(_username);
            if (customer != null)
            {
                var sb = new StringBuilder();
                sb.AppendLine($"Name: {customer.Name}");
                sb.AppendLine($"Email: {customer.Email}");
                sb.AppendLine($"Phone: {customer.Phone}");
                sb.AppendLine($"Address: {customer.Address}");

                txtProfileInfo.Text = sb.ToString();
                txtProfileInfo.ReadOnly = true;
            }
        }

        private void btnManageJobs_Click(object sender, EventArgs e)
        {
            var jobForm = new JobManagementForm(_username);
            jobForm.ShowDialog();
            LoadJobs(); // Refresh after closing job form
        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            var updateForm = new EditCustomerForm(_username);
            updateForm.ShowDialog();
            LoadCustomerProfile(); // Refresh profile display
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm().Show();
        }
    }
}
