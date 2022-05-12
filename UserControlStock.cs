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
    public partial class UserControlStock : UserControl
    {
        BindingSource ProductSource;
        BindingList<Product> productList;
        ProductHandler producthandler;
        public UserControlStock(ProductHandler productHandler)
        {
            InitializeComponent();
            this.producthandler = productHandler;
            productList = new BindingList<Product>(productHandler.Products);
            ProductSource = new BindingSource();
            ProductSource.DataSource = productList;
            DataGridStock.DataSource = ProductSource;

            labelAuthor.Hide();
            textBoxAuthor.Hide();
            labelBookFormat.Hide();
            comboBoxBookFormat.Hide();
            labelGenre.Hide();
            comboBoxGenre.Hide();
            labelLanguage.Hide();
            textBoxLanguage.Hide();

            labelPlatform.Hide();
            comboBoxPlatform.Hide();

            labelPlaytime.Hide();
            textBoxPlaytime.Hide();
            labelMovieFormat.Hide();
            comboBoxMovieFormat.Hide();


        }


        private void CategoryBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (CategoryBox.SelectedItem.ToString() == "Book")
                {
                    labelAuthor.Show();
                    textBoxAuthor.Show();
                    labelBookFormat.Show();
                    comboBoxBookFormat.Show();
                    labelGenre.Show();
                    comboBoxGenre.Show();
                    labelLanguage.Show();
                    textBoxLanguage.Show();

                    labelPlatform.Hide();
                    comboBoxPlatform.Hide();

                    labelPlaytime.Hide();
                    textBoxPlaytime.Hide();
                    labelMovieFormat.Hide();
                    comboBoxMovieFormat.Hide();

                }
                else if(CategoryBox.SelectedItem.ToString() == "Game")
                {
                    labelPlatform.Show();
                    comboBoxPlatform.Show();

                    labelAuthor.Hide();
                    textBoxAuthor.Hide();
                    labelBookFormat.Hide();
                    comboBoxBookFormat.Hide();
                    labelGenre.Hide();
                    comboBoxGenre.Hide();
                    labelLanguage.Hide();
                    textBoxLanguage.Hide();

                    labelPlaytime.Hide();
                    textBoxPlaytime.Hide();
                    labelMovieFormat.Hide();
                    comboBoxMovieFormat.Hide();
                }
                else if(CategoryBox.SelectedItem.ToString() == "Movie")
                {
                    labelPlaytime.Show();
                    textBoxPlaytime.Show();
                    labelMovieFormat.Show();
                    comboBoxMovieFormat.Show();

                    labelAuthor.Hide();
                    textBoxAuthor.Hide();
                    labelBookFormat.Hide();
                    comboBoxBookFormat.Hide();
                    labelGenre.Hide();
                    comboBoxGenre.Hide();
                    labelLanguage.Hide();
                    textBoxLanguage.Hide();

                    labelPlatform.Hide();
                    comboBoxPlatform.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            bool ID_only_number = false;
            if (textBoxName.Text.Length == 0 || textBoxID.Text.Length == 0 || textBoxQuantity.Text.Length == 0 || textBoxPrice.Text.Length == 0 || CategoryBox.SelectedItem == null)
            {
                MessageBox.Show("All fields marked with * can't be empty", "Can't add product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (float.Parse(textBoxPrice.Text) < 0)
            {
                MessageBox.Show("Price can't be negative", "Can't add product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            else if(float.TryParse(textBoxID.Text, out float ID_float))
            {
                ID_only_number = true;
            }
            if(ID_only_number == false)
            {
                MessageBox.Show("ID can only contaion numbers", "Can't add product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            else
            {
                bool uniqe = true;
                string ID = textBoxID.Text;
                string Name = textBoxName.Text;
                string Quantity = textBoxQuantity.Text;
                string Price = textBoxPrice.Text;
                string category = CategoryBox.SelectedItem.ToString();
                string test;
                foreach (DataGridViewRow row in DataGridStock.Rows)
                {
                    test = row.Cells["ID"].Value.ToString();
                    
                    test = test.Replace(" ", string.Empty);
                    if (test == ID)
                    {
                        uniqe = false;
                        MessageBox.Show("ID has to be uniqe, the one you've chosen already exists.", "Can't add product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (uniqe)
                {
                    string productToAdd = category + "," + Quantity + "," + ID + "," + Name + "," + Price;
                    switch (category)
                    {
                        case "Book":
                            string author = "unknown";
                            if (textBoxAuthor.Text.Length > 0)
                                author = textBoxAuthor.Text;
                            textBoxAuthor.Clear();
                            string language = "unknown";
                            if (textBoxLanguage.Text.Length > 0)
                                language = textBoxLanguage.Text;
                            textBoxLanguage.Clear();
                            string genre;
                            if (comboBoxGenre.SelectedItem == null)
                            {
                                genre = "unknown";
                            }
                            else
                            {
                                genre = comboBoxGenre.SelectedItem.ToString();
                                comboBoxGenre.SelectedItem = null;
                            }
                            string formatB;
                            if (comboBoxBookFormat.SelectedItem == null)
                            {
                                formatB = "unknown";
                            }
                            else
                            {
                                formatB = comboBoxBookFormat.SelectedItem.ToString();
                                comboBoxBookFormat.SelectedItem = null;
                                formatB = formatB.Replace("-", string.Empty);
                            }
                           
                            productToAdd = productToAdd + "," + author + "," + genre + "," + formatB + "," + language;
                            break;

                        case "Game":
                            string platform;
                            if (comboBoxPlatform.SelectedItem == null)
                                platform = "unknown";
                            else
                            {
                                platform = comboBoxPlatform.SelectedItem.ToString();
                                comboBoxPlatform.SelectedItem = null;
                                platform = platform.Replace(" ", string.Empty);
                            }
                            productToAdd = productToAdd + "," + platform;
                            break;
                        case "Movie":
                            string playtime = "unknown";
                            if (textBoxPlaytime.Text.Length > 0)
                            {
                                List<string> PLaytime_list = new List<string>(textBoxPlaytime.Text.Split(' '));
                                if(float.TryParse(PLaytime_list[0], out float time))
                                {
                                    if(time > 0)
                                        playtime = textBoxPlaytime.Text;
                                    else
                                    {
                                        MessageBox.Show("Playtime can't be negative", "Can't add product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        return;
                                    }
                                }
                                
                            }
                            textBoxPlaytime.Clear();
                            string formatM;
                            if (comboBoxMovieFormat.SelectedItem == null)
                                formatM = "unknown";
                            else
                            {
                                formatM = comboBoxMovieFormat.SelectedItem.ToString();
                                comboBoxMovieFormat.SelectedItem = null;
                                formatM = formatM.Replace("-", string.Empty);
                            }
                            productToAdd = productToAdd + "," + formatM + "," + playtime;
                            break;
                    }
                    textBoxID.Clear();
                    textBoxName.Clear();
                    textBoxQuantity.Clear();
                    productList.Add(producthandler.AddNewProduct(productToAdd));
                    textBoxPrice.Clear();
                    DataGridStock.Refresh();
                    
                }
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string ID = textBoxUpdate.Text;
            bool exists = false;
            foreach (DataGridViewRow row in DataGridStock.Rows)
            {
                string test = row.Cells["ID"].Value.ToString();
                float current;
                test = test.Replace(" ", string.Empty);
                if (test == ID)
                {
                    exists = true;
                    try
                    {
                        current = float.Parse(row.Cells["Quantity"].Value.ToString());
                        float addQuantity = float.Parse(textBoxNumber.Text.ToString());

                        current = current + addQuantity;
                        row.Cells["Quantity"].Value = current;
                        DataGridStock.Refresh();
                        return;

                    }catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }


                }

            }
            if (exists == false)
                MessageBox.Show("ID does not exist", "Can't update quantity of product", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonRemoveProduct_Click(object sender, EventArgs e)
        {
            string ID = textBoxRemoveProduct.Text;
            bool exists = false;
            foreach(DataGridViewRow row in DataGridStock.Rows)
            {
                string test = row.Cells["ID"].Value.ToString();
                test = test.Replace(" ", string.Empty);
                if (test == ID)
                {
                    exists = true;
                    if(float.Parse(row.Cells["Quantity"].Value.ToString()) != 0)
                    {
                        DialogResult res = MessageBox.Show("Quantity of product is not 0, are you sure you want to remove product?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (res == DialogResult.Yes)
                        {
                            DataGridStock.Rows.RemoveAt(row.Index);
                            return;
                        }
                        else
                            return;
                    }
                    if(float.Parse(row.Cells["Quantity"].Value.ToString()) == 0)
                        DataGridStock.Rows.RemoveAt(row.Index);

                    return;

                }

            }
            if(exists == false)
                MessageBox.Show("ID does not exist", "Can't remove product", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonAPI_Click(object sender, EventArgs e)
        {
            DataGridStock.Rows.Clear();
            producthandler.LoadAPI();
            productList = new BindingList<Product>(producthandler.Products);
            ProductSource = new BindingSource();
            ProductSource.DataSource = productList;
            DataGridStock.DataSource = ProductSource;
            DataGridStock.Refresh();
        }
    }
}
