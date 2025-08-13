using eshift_good_tranport_system.Business.Service;
using eshift_good_tranport_system.Models;
using eshift_good_tranport_system.Repository.Service;
using iTextSharp.text.pdf;
using iTextSharp.text;
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
    public partial class ReportGenerationForm : Form
    {
        // Report, Job and TransportUnit service instances
        private readonly ReportService _service;
        private readonly JobService _jobService;
        private readonly TransportUnitService _unitService;

        public ReportGenerationForm()
        {
            InitializeComponent();
            _service = new ReportService(new ReportRepository());
            _jobService = new JobService(new JobRepository());
            _unitService = new TransportUnitService(new TransportUnitRepository());

        }

        private void ReportGenerationForm_Load(object sender, EventArgs e)
        {
            cmbReportType.Items.AddRange(new string[] { "Jobs", "Transport Units" }); 
            cmbReportType.SelectedIndex = 0;

            cbStatus.Items.AddRange(new string[] { "All", "Pending", "Approved", "Declined", "Customers" });
            cbStatus.SelectedIndex = 0;

            cbStatus.Visible = true; // only for Jobs
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string reportType = cmbReportType.SelectedItem.ToString();

            if (reportType == "Jobs")
            {
                string selectedStatus = cbStatus.SelectedItem.ToString();

                if (selectedStatus == "All")
                    dgvReport.DataSource = _jobService.GetAllJobs();
                else
                    dgvReport.DataSource = _jobService.GetJobsByStatus(selectedStatus);

            }
            else if (reportType == "Transport Units")
            {
                dgvReport.DataSource = _unitService.GetAllUnits();
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dgvReport.Rows.Count == 0)
            {
                MessageBox.Show("No data to export.");
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "PDF files (*.pdf)|*.pdf",
                Title = "Save PDF Report"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Document doc = new Document(PageSize.A4);
                    PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                    doc.Open();

                    // Title
                    Paragraph title = new Paragraph("Transport Job Report", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16));
                    title.Alignment = Element.ALIGN_CENTER;
                    doc.Add(title);
                    doc.Add(new Paragraph("Generated On: " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")));
                    doc.Add(new Paragraph(" ")); // spacing

                    PdfPTable table = new PdfPTable(dgvReport.Columns.Count);
                    table.WidthPercentage = 100;

                    // Headers
                    foreach (DataGridViewColumn column in dgvReport.Columns)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                        cell.BackgroundColor = new BaseColor(240, 240, 240);
                        table.AddCell(cell);
                    }

                    // Data
                    foreach (DataGridViewRow row in dgvReport.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                table.AddCell(cell.Value?.ToString() ?? "");
                            }
                        }
                    }

                    doc.Add(table);
                    doc.Close();

                    MessageBox.Show("PDF report exported successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error exporting PDF: " + ex.Message);
                }
            }
        }

        private void btnBacktoDashboard_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void cmbReportType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbStatus.Visible = cmbReportType.SelectedItem.ToString() == "Jobs";

        }
    }
}
