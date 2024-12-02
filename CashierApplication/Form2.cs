using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserAccountNamespace;
namespace CashierApplication
{
    public partial class frmLoginAccount : Form
    {
        private Cashier cashierAccount;

        public frmLoginAccount()
        {
            InitializeComponent();
            cashierAccount = new Cashier("Cash1", "cash2", "John Doe", "Finance");
            tbpass.PasswordChar = '*';
           
        }

        private void BLogin_Click(object sender, EventArgs e)
        {
            string enteredUsername = tbusern.Text;
            string enteredPassword = tbpass.Text;

            if (cashierAccount.ValidateCredentials(enteredUsername, enteredPassword))
            {
                this.Hide();
                frmPurchasedDiscountedItem purchaseForm = new frmPurchasedDiscountedItem(cashierAccount);
                purchaseForm.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }
    }
}

