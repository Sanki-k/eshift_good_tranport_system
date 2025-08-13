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

namespace eshift_good_tranport_system.Forms
{
    public partial class AdminManagementForm : Form
    {
        private readonly AdminService _service;

        public AdminManagementForm()
        {
            InitializeComponent();
            _service = new AdminService(new AdminRepository());

        }

        private void AdminManagementForm_Load(object sender, EventArgs e)
        {
            LoadAdmins();
        }

        private void LoadAdmins()
        {
            dgvAdmins.DataSource = _service.GetAllAdmins();
        }

        private void btnAddAdmin_Click(object sender, EventArgs e)
        {
            var admin = new AdminModel
            {
                Username = txtUsername.Text,
                Password = txtPassword.Text
            };

            _service.AddAdmin(admin);
            LoadAdmins();
            ClearFields();
        }

        private void btnEditAdmin_Click(object sender, EventArgs e)
        {
            if (dgvAdmins.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvAdmins.SelectedRows[0].Cells["Id"].Value);

                var admin = new AdminModel
                {
                    Id = id,
                    Username = txtUsername.Text,
                    Password = txtPassword.Text
                };

                _service.UpdateAdmin(admin);
                LoadAdmins();
                ClearFields();
            }
        }

        private void ClearFields()
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void btnDeleteAdmin_Click(object sender, EventArgs e)
        {
            if (dgvAdmins.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvAdmins.SelectedRows[0].Cells["Id"].Value);
                _service.DeleteAdmin(id);
                LoadAdmins();
                ClearFields();
            }
        }


        // Method that loads data into TextBox when DataGridView is clicked
        private void dgvAdmins_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvAdmins.Rows.Count > e.RowIndex)
            {
                txtUsername.Text = dgvAdmins.Rows[e.RowIndex].Cells["Username"].Value.ToString();
                txtPassword.Text = dgvAdmins.Rows[e.RowIndex].Cells["Password"].Value.ToString();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminDashboardForm().Show();
        }
    }
}
