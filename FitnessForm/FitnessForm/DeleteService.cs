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
    public partial class DeleteService : Form
    {
        private readonly FitnessEntities _context;
        public DeleteService()
        {
            InitializeComponent();
            _context = new FitnessEntities();
        }

        private void DeleteService_Load(object sender, EventArgs e)
        {
            cmbDeleteService.Items.AddRange(_context.Services.ToArray());
        }

        private async void btnDeleteService_Click(object sender, EventArgs e)
        {
            _context.Services.Remove(cmbDeleteService.SelectedItem as Service);

            await _context.SaveChangesAsync();
            MessageBox.Show("Service Deleted");

            Close();
        }

        private void cmbDeleteService_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDeleteService.Visible = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
