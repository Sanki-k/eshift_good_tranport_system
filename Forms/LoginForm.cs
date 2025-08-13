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
    public partial class LoginForm : Form
    {
        private readonly LoginService _service;

        public LoginForm()
        {
            InitializeComponent();
            _service = new LoginService(new LoginRepository());

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            cmbRole.Items.AddRange(new string[] { "Admin", "Customer" });
            cmbRole.SelectedIndex = 0;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //var model = new LoginModel
            //{
            //    Username = txtUsername.Text.Trim(),
            //    Password = txtPassword.Text.Trim(),
            //    Role = cmbRole.Text
            //};

            //if (string.IsNullOrEmpty(model.Username) || string.IsNullOrEmpty(model.Password) || string.IsNullOrEmpty(model.Role)) //check empty fields
            //{
            //    MessageBox.Show("Please fill in all fields.");
            //    return;
            //}

            //bool result = _service.Login(model);

            //if (result)
            //{
            //    MessageBox.Show("Login successful!");

            //    if (model.Role == "Admin")
            //    {
            //        new AdminDashboardForm().Show();
            //    }
            //    else if (model.Role == "Customer")
            //    {
            //        new CustomerDashboardForm(model.Username).Show();
            //    }

            //    this.Hide();
            //}
            //else
            //{
            //    MessageBox.Show("Invalid credentials.");
            //}
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            new CustomerRegistrationForm().Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {


        }

        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            new CustomerRegistrationForm().Show();
            this.Hide();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            var model = new LoginModel
            {
                Username = txtUsername.Text.Trim(),
                Password = txtPassword.Text.Trim(),
                Role = cmbRole.Text
            };

            if (string.IsNullOrEmpty(model.Username) || string.IsNullOrEmpty(model.Password) || string.IsNullOrEmpty(model.Role)) //check empty fields
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            bool result = _service.Login(model);

            if (result)
            {
                MessageBox.Show("Login successful!");

                if (model.Role == "Admin")
                {
                    new AdminDashboardForm().Show();
                }
                else if (model.Role == "Customer")
                {
                    new CustomerDashboardForm(model.Username).Show();
                }

                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid credentials.");
            }
        }
    }
}
