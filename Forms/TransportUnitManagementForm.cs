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
    public partial class TransportUnitManagementForm : Form
    {
        private readonly TransportUnitService _service;

        public TransportUnitManagementForm()
        {
            InitializeComponent();
            _service = new TransportUnitService(new TransportUnitRepository());

        }

        private void TransportUnitManagementForm_Load(object sender, EventArgs e)
        {
            LoadUnits();

        }
        private void LoadUnits()
        {
            dgvUnits.DataSource = _service.GetAll();
        }

        private void btnAddUnit_Click(object sender, EventArgs e)
        {
            var model = new TransportUnitModel
            {
                VehicleNumber = txtLorry.Text,
                DriverName = txtDriver.Text,
                AssistantName = txtAssistant.Text,
                ContainerInfo = txtContainer.Text
            };
            _service.Add(model);
            LoadUnits();
            ClearInputs();
        }

        private void btnEditUnit_Click(object sender, EventArgs e)
        {
            if (dgvUnits.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a unit to edit.");
                return;
            }

            var selectedRow = dgvUnits.SelectedRows[0];
            int unitId = Convert.ToInt32(selectedRow.Cells["LorryId"].Value);

            var updatedUnit = new TransportUnitModel
            {
                LorryId = unitId,
                VehicleNumber = txtLorry.Text.Trim(),
                DriverName = txtDriver.Text.Trim(),
                AssistantName = txtAssistant.Text.Trim(),
                ContainerInfo = txtContainer.Text.Trim()
            };

            _service.Update(updatedUnit);  // this calls repository.UpdateUnit internally

            MessageBox.Show("Unit updated successfully.");
            LoadUnits();
            ClearInputs();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvUnits.CurrentRow == null) return;

            int id = Convert.ToInt32(dgvUnits.CurrentRow.Cells["LorryId"].Value);
            _service.Delete(id);
            LoadUnits();
            ClearInputs();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvUnits_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUnits.CurrentRow != null)
            {
                txtLorry.Text = dgvUnits.CurrentRow.Cells["VehicleNumber"].Value?.ToString();
                txtDriver.Text = dgvUnits.CurrentRow.Cells["DriverName"].Value?.ToString();
                txtAssistant.Text = dgvUnits.CurrentRow.Cells["AssistantName"].Value?.ToString();
                txtContainer.Text = dgvUnits.CurrentRow.Cells["ContainerInfo"].Value?.ToString();
            }
        }

        private void ClearInputs()
        {
            txtLorry.Clear();
            txtDriver.Clear();
            txtAssistant.Clear();
            txtContainer.Clear();
        }
    }
}
