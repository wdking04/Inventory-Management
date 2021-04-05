using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W.King_c968
{
    public partial class AddProductScreen : Form
    {
        BindingList<Part> addParts = new BindingList<Part>();
        public AddProductScreen()
        {
            InitializeComponent();
            AddProductScreenLoad();
        }

        public void AddProductScreenLoad()
        {
            //  All parts available table
            var bs1 = new BindingSource();
            bs1.DataSource = Inventory.allParts;
            dataGridViewAddProductAll.DataSource = bs1;
            dataGridViewAddProductAll.Columns["PartID"].HeaderText = "Part ID";
            dataGridViewAddProductAll.Columns["Name"].HeaderText = "Part Name";
            dataGridViewAddProductAll.Columns["InStock"].HeaderText = "Inventory";
            dataGridViewAddProductAll.Columns["Price"].HeaderText = "Price";
            dataGridViewAddProductAll.Columns["Max"].Visible = true;
            dataGridViewAddProductAll.Columns["Min"].Visible = true;

            // Associated parts table
            var bs2 = new BindingSource();
            bs2.DataSource = addParts;
            dataGridViewAddProductAssociated.DataSource = bs2;
            dataGridViewAddProductAssociated.Columns["PartID"].HeaderText = "Part ID";
            dataGridViewAddProductAssociated.Columns["Name"].HeaderText = "Part Name";
            dataGridViewAddProductAssociated.Columns["InStock"].HeaderText = "Inventory";
            dataGridViewAddProductAssociated.Columns["Price"].HeaderText = "Price";
            dataGridViewAddProductAssociated.Columns["Max"].Visible = true;
            dataGridViewAddProductAssociated.Columns["Min"].Visible = true;

            buttonAddProductSave.Enabled = false;
            buttonSearch.Enabled = false;
            buttonAddProductDelete.Enabled = false;
            //buttonAddProductAdd.Enabled = false;
           // buttonPartsSearch.Enabled = false;
        }

        //Grays out Name textbox until correct 
        private void textBoxAddProductName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxAddProductName.Text) || int.TryParse(textBoxAddProductName.Text, out int i))
            {

                textBoxAddProductName.BackColor = Color.LightGray;
                buttonAddProductSave.Enabled = false;

            }
            else
            {
                textBoxAddProductName.Enabled = true;
                textBoxAddProductName.BackColor = Color.White;

            }

            if (textBoxAddProductName.BackColor == Color.White &&
               textBoxAddProductInventory.BackColor == Color.White &&
               textBoxAddProductPrice.BackColor == Color.White &&
               textBoxAddProductMax.BackColor == Color.White &&
               textBoxAddProductMin.BackColor == Color.White)
            {
                buttonAddProductSave.Enabled = true;
            }
        }

        private void textBoxAddProductInventory_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxAddProductInventory.Text) || !(int.TryParse(textBoxAddProductInventory.Text, out int i)))
            {

                textBoxAddProductInventory.BackColor = Color.LightGray;
                buttonAddProductSave.Enabled = false;

            }
            else
            {
                textBoxAddProductInventory.Enabled = true;
                textBoxAddProductInventory.BackColor = Color.White;

            }

            if (textBoxAddProductName.BackColor == Color.White &&
               textBoxAddProductInventory.BackColor == Color.White &&
               textBoxAddProductPrice.BackColor == Color.White &&
               textBoxAddProductMax.BackColor == Color.White &&
               textBoxAddProductMin.BackColor == Color.White)
            {
                buttonAddProductSave.Enabled = true;
            }
        }

        private void textBoxAddProductPrice_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxAddProductPrice.Text) || !(double.TryParse(textBoxAddProductPrice.Text, out double i)))
            {

                textBoxAddProductPrice.BackColor = Color.LightGray;
                buttonAddProductSave.Enabled = false;

            }
            else
            {
                textBoxAddProductPrice.Enabled = true;
                textBoxAddProductPrice.BackColor = Color.White;

            }

            if (textBoxAddProductName.BackColor == Color.White &&
               textBoxAddProductInventory.BackColor == Color.White &&
               textBoxAddProductPrice.BackColor == Color.White &&
               textBoxAddProductMax.BackColor == Color.White &&
               textBoxAddProductMin.BackColor == Color.White)
            {
                buttonAddProductSave.Enabled = true;
            }
        }

        private void textBoxAddProductMax_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxAddProductMax.Text) || !(int.TryParse(textBoxAddProductMax.Text, out int i)))
            {

                textBoxAddProductMax.BackColor = Color.LightGray;
                buttonAddProductSave.Enabled = false;

            }
            else
            {
                textBoxAddProductMax.Enabled = true;
                textBoxAddProductMax.BackColor = Color.White;

            }

            if (textBoxAddProductName.BackColor == Color.White &&
               textBoxAddProductInventory.BackColor == Color.White &&
               textBoxAddProductPrice.BackColor == Color.White &&
               textBoxAddProductMax.BackColor == Color.White &&
               textBoxAddProductMin.BackColor == Color.White)
            {
                buttonAddProductSave.Enabled = true;
            }
        }

        private void textBoxAddProductMin_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxAddProductMin.Text) || !(int.TryParse(textBoxAddProductMin.Text, out int i)))
            {

                textBoxAddProductMin.BackColor = Color.LightGray;
                buttonAddProductSave.Enabled = false;

            }
            else
            {
                textBoxAddProductMin.Enabled = true;
                textBoxAddProductMin.BackColor = Color.White;

            }

            if (textBoxAddProductName.BackColor == Color.White &&
               textBoxAddProductInventory.BackColor == Color.White &&
               textBoxAddProductPrice.BackColor == Color.White &&
               textBoxAddProductMax.BackColor == Color.White &&
               textBoxAddProductMin.BackColor == Color.White)
            {
                buttonAddProductSave.Enabled = true;
            }
        }
        private void buttonAddProductDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewAddProductAssociated.SelectedRows)
            {
                dataGridViewAddProductAssociated.Rows.RemoveAt(row.Index);
            }
        }

        private void buttonAddProductSearch_Click(object sender, EventArgs e)
        {
            int searchValue = int.Parse(textBoxAddProductSearch.Text);

            Part match = Inventory.LookupPart(searchValue);

            foreach (DataGridViewRow row in dataGridViewAddProductAll.Rows)
            {
                Part part = (Part)row.DataBoundItem;

                if (part.PartID == match.PartID)
                {
                    row.Selected = true;
                    break;
                }
                else
                {
                    row.Selected = false;
                }
            }
        }

        private void buttonAddProductAdd_Click(object sender, EventArgs e)
        {
            Part addPart = (Part)dataGridViewAddProductAll.CurrentRow.DataBoundItem;
            addParts.Add(addPart);
        }

        private void buttonAddProductSave_Click(object sender, EventArgs e)
        {
            
            if (textBoxAddProductMaxText < textBoxAddProductMinText)
            {
                MessageBox.Show("Minimum must be less than Maximum.");
                return;
            }
            if (textBoxAddProductInventoryText < textBoxAddProductMinText || textBoxAddProductInventoryText > textBoxAddProductMaxText)
            {
                MessageBox.Show("Inventory must be within minimum and maximum range");
                return;
            }
            
            // Creates a new product with values from textboxes and adds product to  inventory.
            Product addProduct = new Product((Inventory.Products.Count + 1), textBoxAddProductNameText, textBoxAddProductInventoryText, textBoxAddProductPriceText, textBoxAddProductMaxText, textBoxAddProductMinText);
            Inventory.AddProduct(addProduct);

            foreach (Part part in addParts)
            {
                addProduct.AddAssociatedPart(part);
                break;
            }
            this.Close();
        }

        private void buttonAddProductCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddProductScreen_Load(object sender, EventArgs e)
        {

        }
    }
}

