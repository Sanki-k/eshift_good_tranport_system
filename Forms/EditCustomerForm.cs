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
    public partial class EditCustomerForm : Form
    {
        private readonly string _username;
        private readonly CustomerService _service;
        public EditCustomerForm(string username)
        {
            InitializeComponent();
            _username = username;
            _service = new CustomerService(new CustomerRepository());
        }

        private void EditCustomerForm_Load(object sender, EventArgs e)
        {
            var customer = _service.GetCustomerByUsername(_username);
            if (customer != null)
            {
                txtName.Text = customer.Name;
                txtEmail.Text = customer.Email;
                txtPhone.Text = customer.Phone;
                txtAddress.Text = customer.Address;

            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text) ||
                string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            var customer = new CustomerModel
            {
                Username = _username,
                Name = txtName.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Phone = txtPhone.Text.Trim(),
                Address = txtAddress.Text.Trim()
            };

            _service.UpdateCustomer(customer);
            MessageBox.Show("Profile updated successfully.");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
