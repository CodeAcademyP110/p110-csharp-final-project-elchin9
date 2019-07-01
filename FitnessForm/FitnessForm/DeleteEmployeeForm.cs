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
    public partial class DeleteEmployeeForm : Form
    {
        private readonly FitnessEntities _context;
        public DeleteEmployeeForm()
        {
            InitializeComponent();
            _context = new FitnessEntities();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DeleteEmployeeForm_Load(object sender, EventArgs e)
        {
            cmbDeleteEmployee.Items.AddRange(_context.Users.ToArray());
        }

        private async void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            _context.Users.Remove(cmbDeleteEmployee.SelectedItem as User);

            await _context.SaveChangesAsync();
            MessageBox.Show("Employee has deleted");
            Close();
        }

        private void cmbDeleteEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDeleteEmployee.Visible = true;
        }
    }
}
