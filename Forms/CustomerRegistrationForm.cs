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
    public partial class CustomerRegistrationForm : Form
    {
        private readonly CustomerService _service;

        public CustomerRegistrationForm()
        {
            InitializeComponent();
            _service = new CustomerService(new CustomerRepository());

        }

        private void CustomerRegistrationForm_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            var customer = new CustomerModel
            {
                Name = txtName.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Phone = txtPhone.Text.Trim(),
                Address = txtAddress.Text.Trim(),
                Password = txtPassword.Text
            };

            bool success = _service.RegisterCustomer(customer, out string message);
            MessageBox.Show(message);

            if (success)
            {
                // Go back to login form or dashboard
                new LoginForm().Show();
                this.Hide();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Hide();
        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
