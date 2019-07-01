using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitnessForm.Model;

using System.Windows.Forms;

namespace FitnessForm
{
    public partial class UserForm : Form
    {
        private readonly FitnessEntities _context;
        private readonly User _loggedUser;
      
        public UserForm(User user)
        {
            InitializeComponent();
            _loggedUser = user;
            _context = new FitnessEntities();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            lblUser.Text = $"Welcome {_loggedUser.Firstname} {_loggedUser.Lastname}";
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            runner.Height = btnRegister.Height;
            runner.Top = btnRegister.Top;

        }

        private void btnHome_Click_1(object sender, EventArgs e)
        {
            runner.Height = btnHome.Height;
            runner.Top = btnHome.Top;
            home2.BringToFront();
        }

        private void btnServices_Click_1(object sender, EventArgs e)
        {
            runner.Height = btnServices.Height;
            runner.Top = btnServices.Top;
            ourServices2.Visible = true;
            ourServices2.BringToFront();
        }

        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            runner.Height = btnRegister.Height;
            runner.Top = btnRegister.Top;
            pnlAddCustomer.Visible = true;
            pnlAddCustomer.BringToFront();
            string[] menu = new string[] { "Services", "Packets" };
            cmbSelect.DataSource = menu;
        }

        private async void btnAddCustomer_Click(object sender, EventArgs e)
        {
            string selectedItem = cmbSelect.Items[cmbSelect.SelectedIndex].ToString();
            string firstname = txtFirstname.Text.Trim();
            string lastname = txtLastname.Text.Trim();
            Service selectedService = cmbServices.SelectedItem as Service;
            Packet selectedPacket = cmbPackets.SelectedItem as Packet;

            if(firstname == string.Empty || lastname == string.Empty)
            {
                MessageBox.Show("Please fill all fields.");
            }
            Customer thisCustomer = _context.Customers.Add(new Customer
            {
                Firstname = firstname,
                Lastname = lastname
            });
            await _context.SaveChangesAsync();
            Card thisCard = _context.Cards.Add(new Card
            {
                CustomerId = thisCustomer.Id,
                StartDate = DateTime.Now
            });
            await _context.SaveChangesAsync();
            Order thisOrder = _context.Orders.Add(new Order
            {
                UserId = _loggedUser.Id,
                Date = DateTime.Now
            });
            await _context.SaveChangesAsync();

            OrderDetail thisOrderDetails = new OrderDetail();

            if (selectedItem == "Services")
            {
                thisOrderDetails = _context.OrderDetails.Add(new OrderDetail
                {
                    OrderId = thisOrder.Id,
                    CardsId = thisCard.Id,
                    ServiceId = selectedService.Id,
                    PackedId = null,
                    Price = selectedService.Price
                });
                lblCardHeading.Text = $"{selectedService.Name} Services";
            }
            if(selectedItem == "Packets")
            {
                thisOrderDetails = _context.OrderDetails.Add(new OrderDetail
                {
                    OrderId = thisOrder.Id,
                    CardsId = thisCard.Id,
                    ServiceId = null,
                    PackedId = selectedPacket.Id,
                    Price = selectedPacket.Price
                });
                lblCardHeading.Text = $"{selectedPacket.Name} Packed";
            }

            await _context.SaveChangesAsync();

            _context.Revenues.Add(new Revenue
            {
               PriceId = thisOrderDetails.Id,
               Price = thisOrderDetails.Price
            });

            await _context.SaveChangesAsync();

            pnlCard.Visible = true;
            lblCardNumber.Text = $"Serial Number : {thisCard.Id}";
            lblFirstname.Text = $"Firstname : {firstname}";
            lblLastname.Text = $"Lastname : {lastname}";
            Load_Customers();

            txtFirstname.Text = "";
            txtLastname.Text = "";
        }

        private void cmbSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = cmbSelect.Items[cmbSelect.SelectedIndex].ToString();
            if (selectedItem == "Services")
            {
                cmbServices.DataSource = _context.Services.ToArray();
                cmbServices.Visible = true;
                lblServFalse.Visible = true;
                cmbPackets.Visible = false;
                lblPackFalse.Visible = false;
            }
            if (selectedItem == "Packets")
            {
                cmbPackets.DataSource = _context.Packets.ToArray();
                cmbPackets.Visible = true;
                lblPackFalse.Visible = true;
                cmbServices.Visible = false;
                lblServFalse.Visible = false;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            runner.Height = btnCustomers.Height;
            runner.Top = btnCustomers.Top;
            runner.BringToFront();
            pnlCustomers.Visible = true;
            pnlCustomers.BringToFront();
            Load_Customers();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Load_Customers()
        {
            dgwCustomers.DataSource = _context.Cards.Select(c => new {
                c.Customer.Firstname,
                c.Customer.Lastname,
                c.StartDate,
                Card_Number = c.Id
            }).ToList();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            runner.Height = btnHome.Height;
            runner.Top = btnHome.Top;
            home2.BringToFront();
        }
    }
}
