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
using static FitnessForm.Hash;

namespace FitnessForm
{
    public partial class UpdateEmployeeForm : Form
    {
        private readonly FitnessEntities _context;
        public UpdateEmployeeForm()
        {
            InitializeComponent();
            _context = new FitnessEntities();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UpdateEmployeeForm_Load(object sender, EventArgs e)
        {
            cmbEmployee.Items.AddRange(_context.Users.ToArray());
            cmbRole.Items.AddRange(_context.Roles.ToArray());
        }

        private void cmbEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlUpdate.Visible = true;
            User selectedUser = cmbEmployee.SelectedItem as User;
            txtFname.Text = selectedUser.Firstname;
            txtLname.Text = selectedUser.Lastname;
            txtUsername.Text = selectedUser.Username;
            txtPassword.Text = selectedUser.Password;
            cmbRole.SelectedIndex = (int)selectedUser.RoleId - 1;
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            User selectedUser = cmbEmployee.SelectedItem as User;
            string fname = txtFname.Text.Trim();
            string lname = txtLname.Text.Trim();
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string roles = cmbRole.SelectedText.Trim();

            if (fname == string.Empty || lname == string.Empty || username == string.Empty || password == string.Empty || roles == string.Empty)
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }
            User user = _context.Users.FirstOrDefault(u => u.Username.ToLower() == username.ToLower());

            if (user != null)
            {
                MessageBox.Show("This Username is in already use.");
                return;
            }
            if(cmbRole.SelectedText.Trim() == "Admin")
            {
                selectedUser.Firstname = fname;
                selectedUser.Lastname = lname;
                selectedUser.Username = username;
                selectedUser.Password = GetHash(password);
                selectedUser.RoleId = 1;
            }
            if (cmbRole.SelectedText.Trim() == "Employee")
            {
                selectedUser.Firstname = fname;
                selectedUser.Lastname = lname;
                selectedUser.Username = username;
                selectedUser.Password = GetHash(password);
                selectedUser.RoleId = 2;
            }

            await _context.SaveChangesAsync();

            txtFname.Text = "";
            txtLname.Text = "";
            txtPassword.Text = "";
            txtUsername.Text = "";
            Close();
        }
    }
}
