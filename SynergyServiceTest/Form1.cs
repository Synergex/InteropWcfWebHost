using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SynergyServiceTest.SynServer;

namespace SynergyServiceTest
{
    public partial class Form1 : Form
    {
        private SynergyServerClient svr;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            svr = new SynergyServerClient();
            svr.SetLogicals();

            //List<Customer> customers = new List<Customer>();
            //svr.GetAllCustomers(ref customers);
            List<Customer> customers = svr.GetAllCustomers();

            cboCustomer.DataSource = customers;
            cboCustomer.ValueMember = "Customer_id";
            cboCustomer.DisplayMember = "Name";
        }

        private void cboCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCustomer.SelectedItem != null)
            {
                int customerId = ((Customer)cboCustomer.SelectedItem).Customer_id;
                //List<Contact> contacts = new List<Contact>();
                //svr.GetCustomerContacts(customerId, ref contacts);
                List<Contact> contacts = svr.GetCustomerContacts(customerId);
                grdContacts.DataSource = contacts;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            svr = null;
        }

    }
}
