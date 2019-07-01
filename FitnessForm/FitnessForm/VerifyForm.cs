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
    public partial class VerifyForm : Form
    {
        private readonly FitnessEntities _context = new FitnessEntities();
        private User _loggedUser;
        public VerifyForm(User user)
        {
            InitializeComponent();
            _loggedUser = user;
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            string currentPassword = txtCurrentPass.Text.Trim();
            string newPassword = txtNewPass.Text.Trim();
            string confirmPassword = txtConfirmPass.Text.Trim();

            if (currentPassword == string.Empty || newPassword == string.Empty || confirmPassword == string.Empty)
            {
                MessageBox.Show("Fill all the password fields", "Error");
                return;
            }

            if (!CheckHash(_loggedUser.Password, currentPassword))
            {
                MessageBox.Show("Current password is invalid.", "Error");
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("New password and confirm password don't match.", "Error");
                return;
            }

            User updateUser = await _context.Users.FindAsync(_loggedUser.Id);
            updateUser.Password = GetHash(newPassword);
            updateUser.HasVerifiedPassword = true;
            await _context.SaveChangesAsync();


            if (updateUser.Role.Name == "Employee")
            {
                this.Close();
                new UserForm(updateUser).Show();
            }

            txtCurrentPass.Text = "";
            txtConfirmPass.Text = "";
            txtNewPass.Text = "";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
