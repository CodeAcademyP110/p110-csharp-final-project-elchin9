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
    public partial class AddEmployeeForm : Form
    {
        private readonly FitnessEntities _context;
        public AddEmployeeForm()
        {
            InitializeComponent();
            _context = new FitnessEntities();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddEmployeeForm_Load(object sender, EventArgs e)
        {
            string[] roles = new string[] { "Admin", "Employee" };
            cmbRole.Items.AddRange(roles);
        }

        private async void btnAddEmployee_Click(object sender, EventArgs e)
        {
            string fname = txtFname.Text.Trim();
            string lname = txtLname.Text.Trim();
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string roles = cmbRole.Text.Trim();

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
            if (roles == "Admin")
            {
                _context.Users.Add(new User
                {
                    Firstname = fname,
                    Lastname = lname,
                    Username = username,
                    Password = GetHash(password),
                    RoleId = 1,
                    HasVerifiedPassword = false
                });
            }
            if (roles == "Employee")
            {
                _context.Users.Add(new User
                {
                    Firstname = fname,
                    Lastname = lname,
                    Username = username,
                    Password = GetHash(password),
                    RoleId = 2,
                    HasVerifiedPassword = false
                });
            }

            await _context.SaveChangesAsync();
            MessageBox.Show("Employee is added");

            txtFname.Text = "";
            txtLname.Text = "";
            txtPassword.Text = "";
            txtUsername.Text = "";
            
            Close();
        }
    }
}
