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
    public partial class EmployeeForm : Form
    {
        private readonly FitnessEntities _context;
        public EmployeeForm()
        {
            InitializeComponent();
            _context = new FitnessEntities();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            Load_Employee();
        }
        private void Load_Employee()
        {
            dgwEmployee.DataSource = _context.Users.Select(u => new {
                u.Firstname,
                u.Lastname,
                u.Username,
                Role = u.Role.Name,
            }).ToList();
        }
        private void EmployeeClosed(object sender, EventArgs e)
        {
            Load_Employee();
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AddEmployeeForm addEmp = new AddEmployeeForm();
            addEmp.FormClosed += EmployeeClosed;
            addEmp.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            UpdateEmployeeForm upEmp = new UpdateEmployeeForm();
            upEmp.FormClosed += EmployeeClosed;
            upEmp.ShowDialog();
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            DeleteEmployeeForm delEmp = new DeleteEmployeeForm();
            delEmp.FormClosed += EmployeeClosed;
            delEmp.ShowDialog();
        }
    }
}
