using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FitnessForm.Model;

namespace FitnessForm
{
    public partial class ServiceForm : Form
    {
        private readonly FitnessEntities _context;
        public ServiceForm()
        {
            InitializeComponent();
            _context = new FitnessEntities();
        }

        private void ServiceForm_Load(object sender, EventArgs e)
        {
            Load_Service();
        }

        private void Load_Service()
        {
            dgwServices.DataSource = _context.Services.Select(s => new {
                s.Name,
                s.Price,
                s.Time
            }).ToList();
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            var del = new DeleteService();
            del.FormClosed += ServiceClosed;
            del.ShowDialog();
        }
        private void ServiceClosed(object sender, EventArgs e)
        {
            Load_Service();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            var updateService = new UpdateForm();
            updateService.FormClosed += ServiceClosed;
            updateService.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var addService = new AddServiceForm();
            addService.FormClosed += ServiceClosed;
            addService.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
