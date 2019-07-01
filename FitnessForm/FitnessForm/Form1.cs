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
    public partial class Form1 : Form
    {
        private readonly FitnessEntities _context = new FitnessEntities();
        public Form1()
        {
            InitializeComponent();
        }

      
        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (username == string.Empty || password == string.Empty)
            {
                MessageBox.Show("Username and password fields should be filled", "Error");
                return;
            }

            User user = _context.Users.FirstOrDefault(u => u.Username.ToLower() == username.ToLower());

            if (user == null)
            {
                MessageBox.Show("Username or password is invalid", "Error");
                return;
            }

            if (!CheckHash(user.Password, password))
            {
                MessageBox.Show("Username or password is invalid", "Error");
                return;
            }

            switch (user.RoleId)
            {
                case 1:
                    new AdminForm().ShowDialog();
                    break;
                case 2:
                    if (user.HasVerifiedPassword == false)
                        new VerifyForm(user).ShowDialog();
                    else
                        new UserForm(user).ShowDialog();
                    break;
                default:
                    MessageBox.Show("Unknown login error", "Unknown error occurred. Please, contact admin!");
                    break;
            }
            txtUsername.Text = "";
            txtPassword.Text = "";
        }
    }
}
