using ItemNamespace;
using UserAccountNamespace;
namespace CashierApplication
{
    public partial class frmPurchasedDiscountedItem : Form
    {
        private double TotalAmount = 0;
        private Cashier cashier;
        public frmPurchasedDiscountedItem(Cashier casherAccount)
        {
            InitializeComponent();
            bs.Enabled = false;
            cashier = casherAccount;
            MessageBox.Show($"Welocme {cashier.FullName} of {cashier.Department}");
            InitializeMenuStrip();
        }
        private void InitializeMenuStrip()
        {
            MenuStrip menuStrip = new MenuStrip();
            ToolStripMenuItem fileMenu = new ToolStripMenuItem("File");
            ToolStripMenuItem logoutMenuItem = new ToolStripMenuItem("Logout");
            ToolStripMenuItem exitMenuItem = new ToolStripMenuItem("Exit");

            logoutMenuItem.Click += LogoutMenuItem_Click;
            exitMenuItem.Click += ExitMenuItem_Click;

            fileMenu.DropDownItems.Add(logoutMenuItem);
            fileMenu.DropDownItems.Add(exitMenuItem);
            menuStrip.Items.Add(fileMenu);

            this.MainMenuStrip = menuStrip;
            this.Controls.Add(menuStrip);
        }

        private void bC_Click(object sender, EventArgs e)
        {
            try
            {
                string itemName = tbIN.Text;
                double price = Convert.ToDouble(tbP.Text);
                int quantity = Convert.ToInt32(tbQ.Text);
                double discount = Convert.ToDouble(tbD.Text);
                DiscountedItem item = new DiscountedItem(itemName, price, quantity, discount);
                TotalAmount = item.CalcuTotal();
                LTA.Text += " " + TotalAmount.ToString("C");
                bs.Enabled = true;
            }
            catch (FormatException)  {}
            catch (OverflowException) {}
        }

        private void bs_Click(object sender, EventArgs e)
        {
            try
            {
                double paymentAmount = Convert.ToDouble(tbpr.Text);
                double change = paymentAmount - TotalAmount;
                LC.Text += " " + change.ToString("C");
            }
            catch (FormatException)  {}
            catch (OverflowException) {}
        }
        private void LogoutMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLoginAccount loginForm = new frmLoginAccount();
            loginForm.Show();
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
