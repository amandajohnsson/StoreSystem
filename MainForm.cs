using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreSystem
{
    public partial class MainForm : Form
    {
        ProductHandler ProductHandler = new ProductHandler();

        public MainForm()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(this.MainFormClosing);
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            ProductHandler.LoadDatabase();

            UserControlStock stock = new UserControlStock(ProductHandler);
            stock.Dock = DockStyle.Fill;
            stocktab.Controls.Add(stock);
            UserControlCashier cashier = new UserControlCashier(ProductHandler);
            cashier.Dock = DockStyle.Fill;
            cashiertab.Controls.Add(cashier);

        }
        private void MainFormClosing(object sender, CancelEventArgs e)
        {
            ProductHandler.WriteToDB("ProductDB.csv");
            
        }
    }
}
