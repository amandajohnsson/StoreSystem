using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.IO;

namespace StoreSystem
{
    public partial class UserControlCashier : UserControl
    {

        DataTable dt = new DataTable();
        BindingSource ProductSource;
        BindingList<Product> productList;
        ProductHandler producthandler;
        float currentPrice = 0;
        public UserControlCashier(ProductHandler productHandler)
        {
            InitializeComponent();
            this.producthandler = productHandler;
            productList = new BindingList<Product>(productHandler.Products);
            ProductSource = new BindingSource();
            ProductSource.DataSource = productList;
            dataGridCashier.DataSource = ProductSource;

            dt.Columns.Add("Quantity");
            dt.Columns.Add("ID");
            dt.Columns.Add("Name");
            dt.Columns.Add("Price");
            dt.Columns.Add("Category");
            dataGridViewCart.DataSource = dt;

        }

        private void buttonAddCart_Click(object sender, EventArgs e)
        {
            float price = 0;
            float quantity = 0;
            
            if (dataGridCashier.SelectedRows.Count > 0)
            {
                if (float.Parse(dataGridCashier.SelectedRows[0].Cells[0].Value.ToString()) == 0)
                {
                    MessageBox.Show("You can't add an item with quantity 0", "Can't add item", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    producthandler.changeQuantity(dataGridCashier.SelectedRows[0].Cells["ID"].Value.ToString(), "remove");
                    dt = dataGridViewCart.DataSource as DataTable;
                    if (dataGridViewCart.Rows.Count > 0)
                    {
                        foreach (DataGridViewRow row in dataGridViewCart.Rows)
                        {

                            if (row.Cells["ID"].Value == dataGridCashier.SelectedRows[0].Cells["ID"].Value)
                            {
                                quantity = float.Parse(row.Cells["Quantity"].Value.ToString());
                                quantity += 1;
                                row.Cells["Quantity"].Value = quantity;
                                dataGridViewCart.Refresh();
                            }
      
                        }
                    }
                    if(quantity == 0)
                        dt.Rows.Add(1, dataGridCashier.SelectedRows[0].Cells[1].Value.ToString(), dataGridCashier.SelectedRows[0].Cells[2].Value.ToString(), dataGridCashier.SelectedRows[0].Cells[3].Value.ToString(), dataGridCashier.SelectedRows[0].Cells[4].Value.ToString());


                    if (currentPrice > 0)
                        currentPrice = float.Parse(textBoxTotalPrice.Text);
                    price = float.Parse(dataGridCashier.SelectedRows[0].Cells["Price"].Value.ToString());
                    currentPrice = currentPrice + price;
                    textBoxTotalPrice.Text = currentPrice.ToString();

                    dataGridCashier.Refresh();
                }
            }
        }

        private void buttonRemoveCart_Click(object sender, EventArgs e)
        {
            float removeprice = 0;
            bool removed = false;
            if (dataGridViewCart.Rows.Count > 0)
            {
                float quantity = 0;

                quantity = float.Parse(dataGridViewCart.SelectedRows[0].Cells["Quantity"].Value.ToString());
                if (quantity == 1)
                {
                    producthandler.changeQuantity(dataGridViewCart.SelectedRows[0].Cells["ID"].Value.ToString(), "add");
                    removeprice = float.Parse(dataGridViewCart.SelectedRows[0].Cells["Price"].Value.ToString());
                    dataGridViewCart.Rows.RemoveAt(dataGridViewCart.SelectedRows[0].Index);
                    removed = true;

                }
                else if (float.Parse(dataGridViewCart.SelectedRows[0].Cells["Quantity"].Value.ToString()) > 0)
                {
                    producthandler.changeQuantity(dataGridViewCart.SelectedRows[0].Cells["ID"].Value.ToString(), "add");
                    quantity = quantity - 1;
                    dataGridViewCart.SelectedRows[0].Cells["Quantity"].Value = quantity;
                    removeprice = float.Parse(dataGridViewCart.SelectedRows[0].Cells["Price"].Value.ToString());
                    removed = true;
                }


                if (removed)
                {
                    if (currentPrice > 0)
                        currentPrice = float.Parse(textBoxTotalPrice.Text);

                    removeprice = currentPrice - removeprice;
                    textBoxTotalPrice.Text = removeprice.ToString();
                    dataGridCashier.Refresh();
                }

            }
        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            if (dataGridViewCart.Rows.Count > 0)
            {            
               
            }
           
        }
      

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            bool exists = false;
            string ReturnID = textBoxReturn.Text;
            foreach(DataGridViewRow row in dataGridCashier.Rows)
            {
                string temp = row.Cells["ID"].Value.ToString();
                temp = temp.Replace(" ", string.Empty);
                if (temp == ReturnID)
                {
                    exists = true;
                    producthandler.changeQuantity(row.Cells["ID"].Value.ToString(), "add");
                    dataGridCashier.Refresh();
                    
                }
            }
            if(exists == false)
                MessageBox.Show("ID does not exist in store.", "Coukd not return", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


    }
}
