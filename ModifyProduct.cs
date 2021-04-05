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
    public partial class ModifyProductScreen : Form
    {
        BindingList<Part> partsToAdd = new BindingList<Part>();
        MainScreen MainForm = (MainScreen)Application.OpenForms["MainScreen"];

        public ModifyProductScreen(Product prod)
        {
            InitializeComponent();
            ModifyProductScreenLoad(prod);
        }

        public void ModifyProductScreenLoad(Product selectedProd)
        {
            
            textBoxModifyProductIdText = selectedProd.ProductID;
            textBoxModifyProductNameText = selectedProd.Name;
            textBoxModifyProductInventoryText = selectedProd.InStock;
            textBoxModifyProductPriceText = decimal.Parse(selectedProd.Price.Substring(1));
            textBoxModifyProductMaxText = selectedProd.Max;
            textboxModifyProductMinText = selectedProd.Min;

            var bs1 = new BindingSource();
            bs1.DataSource = Inventory.allParts;
            dataGridViewModifyProductAll.DataSource = bs1;
            dataGridViewModifyProductAll.Columns["PartID"].HeaderText = "Part ID";
            dataGridViewModifyProductAll.Columns["Name"].HeaderText = "Part Name";
            dataGridViewModifyProductAll.Columns["InStock"].HeaderText = "Inventory Level";
            dataGridViewModifyProductAll.Columns["Price"].HeaderText = "Price per Unit";
            dataGridViewModifyProductAll.Columns["Max"].HeaderText = "Max";
            dataGridViewModifyProductAll.Columns["Min"].HeaderText = "Min";

            // This contains all parts associated with their product 
            foreach (Part part in selectedProd.AssociatedParts)
            {
                partsToAdd.Add(part);

            }

            var bs2 = new BindingSource();
            bs2.DataSource = partsToAdd;
            dataGridViewModifyProductAssociated.DataSource = bs2;
            dataGridViewModifyProductAssociated.Columns["PartID"].HeaderText = "Part ID";
            dataGridViewModifyProductAssociated.Columns["Name"].HeaderText = "Part Name";
            dataGridViewModifyProductAssociated.Columns["InStock"].HeaderText = "Inventory Level";
            dataGridViewModifyProductAssociated.Columns["Price"].HeaderText = "Price per Unit";
            dataGridViewModifyProductAssociated.Columns["Max"].Visible = true;
            dataGridViewModifyProductAssociated.Columns["Min"].Visible = true;

            buttonModifyProductSave.Enabled = false;
            buttonDelete.Enabled = false;

        }

        //Grays out Name textbox until correct 
        private void textBoxModifyProductName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxModifyProductName.Text) || int.TryParse(textBoxModifyProductName.Text, out int i))
            {

                textBoxModifyProductName.BackColor = Color.LightGray;
                buttonModifyProductSave.Enabled = false;

            }
            else
            {
                textBoxModifyProductName.Enabled = true;
                textBoxModifyProductName.BackColor = Color.White;

            }

            if (textBoxModifyProductName.BackColor == Color.White &&
               textBoxModifyProductInventory.BackColor == Color.White &&
               textBoxModifyProductPrice.BackColor == Color.White &&
               textBoxModifyProductMax.BackColor == Color.White &&
               textboxModifyProductMin.BackColor == Color.White)
            {
                buttonModifyProductSave.Enabled = true;
            }
        }

        private void textBoxModifyProductInventory_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxModifyProductInventory.Text) || !(int.TryParse(textBoxModifyProductInventory.Text, out int i)))
            {

                textBoxModifyProductInventory.BackColor = Color.LightGray;
                buttonModifyProductSave.Enabled = false;

            }
            else
            {
                textBoxModifyProductInventory.Enabled = true;
                textBoxModifyProductInventory.BackColor = Color.White;

            }

            if (textBoxModifyProductName.BackColor == Color.White &&
               textBoxModifyProductInventory.BackColor == Color.White &&
               textBoxModifyProductPrice.BackColor == Color.White &&
               textBoxModifyProductMax.BackColor == Color.White &&
               textboxModifyProductMin.BackColor == Color.White)
            {
                buttonModifyProductSave.Enabled = true;
            }
        }

        private void textBoxModifyProductPrice_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxModifyProductPrice.Text) || !(double.TryParse(textBoxModifyProductPrice.Text, out double i)))
            {

                textBoxModifyProductPrice.BackColor = Color.LightGray;
                buttonModifyProductSave.Enabled = false;

            }
            else
            {
                textBoxModifyProductPrice.Enabled = true;
                textBoxModifyProductPrice.BackColor = Color.White;

            }

            if (textBoxModifyProductName.BackColor == Color.White &&
               textBoxModifyProductInventory.BackColor == Color.White &&
               textBoxModifyProductPrice.BackColor == Color.White &&
               textBoxModifyProductMax.BackColor == Color.White &&
               textboxModifyProductMin.BackColor == Color.White)
            {
                buttonModifyProductSave.Enabled = true;
            }
        }

        private void textBoxModifyProductMax_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxModifyProductMax.Text) || !(int.TryParse(textBoxModifyProductMax.Text, out int i)))
            {

                textBoxModifyProductMax.BackColor = Color.LightGray;
                buttonModifyProductSave.Enabled = false;

            }
            else
            {
                textBoxModifyProductMax.Enabled = true;
                textBoxModifyProductMax.BackColor = Color.White;

            }

            if (textBoxModifyProductName.BackColor == Color.White &&
               textBoxModifyProductInventory.BackColor == Color.White &&
               textBoxModifyProductPrice.BackColor == Color.White &&
               textBoxModifyProductMax.BackColor == Color.White &&
               textboxModifyProductMin.BackColor == Color.White)
            {
                buttonModifyProductSave.Enabled = true;
            }
        }

        private void textBoxModifyProductMin_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textboxModifyProductMin.Text) || !(int.TryParse(textboxModifyProductMin.Text, out int i)))
            {

                textboxModifyProductMin.BackColor = Color.LightGray;
                buttonModifyProductSave.Enabled = false;

            }
            else
            {
                textboxModifyProductMin.Enabled = true;
                textboxModifyProductMin.BackColor = Color.White;

            }

            if (textBoxModifyProductName.BackColor == Color.White &&
               textBoxModifyProductInventory.BackColor == Color.White &&
               textBoxModifyProductPrice.BackColor == Color.White &&
               textBoxModifyProductMax.BackColor == Color.White &&
               textboxModifyProductMin.BackColor == Color.White)
            {
                buttonModifyProductSave.Enabled = true;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult deleteProductDialogResult = MessageBox.Show("Are you sure you want to delete this?", "Delete", MessageBoxButtons.YesNo);

            if (deleteProductDialogResult == DialogResult.Yes)
            {

                //Deletes product

            }
            else if (deleteProductDialogResult == DialogResult.No)
                return;
            {
                //Does nothing
            }

            Part currentPart = (Part)dataGridViewModifyProductAssociated.CurrentRow.DataBoundItem;

            int lookupID = this.textBoxModifyProductIdText;
            Product currentProd = Inventory.LookupProduct(lookupID);
            currentProd.RemoveAssociatedPart(currentPart.PartID);

            foreach (DataGridViewRow row in dataGridViewModifyProductAssociated.SelectedRows)
            {
                dataGridViewModifyProductAssociated.Rows.RemoveAt(row.Index);
                
            }

            buttonModifyProductSave.Enabled = true;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            // Search using part ID
            int searchValue = int.Parse(textBoxModifyProductSearch.Text);

            Part match = Inventory.LookupPart(searchValue);

            foreach (DataGridViewRow row in dataGridViewModifyProductAll.Rows)
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

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Part partToAdd = (Part)dataGridViewModifyProductAll.CurrentRow.DataBoundItem;
            partsToAdd.Add(partToAdd);

            buttonModifyProductSave.Enabled = true;
            buttonDelete.Enabled = true;

        }

        private void buttonModifyProductSave_Click(object sender, EventArgs e)
        {
            
            if (textBoxModifyProductMaxText < textboxModifyProductMinText)
            {
                MessageBox.Show("Minimum must be less than Maximum.");
                return;
            }
            if (textBoxModifyProductInventoryText < textboxModifyProductMinText || textBoxModifyProductInventoryText > textBoxModifyProductMaxText)
            {
                MessageBox.Show("Inventory must be within minimum and maximum range");
                return;
            }

            Product updatedProduct = new Product(textBoxModifyProductIdText, textBoxModifyProductNameText, textBoxModifyProductInventoryText, textBoxModifyProductPriceText, textBoxModifyProductMaxText, textboxModifyProductMinText);

            foreach (Part newPart in partsToAdd)
            {
                updatedProduct.AddAssociatedPart(newPart);
                
            }

            buttonModifyProductSave.Enabled = true;

            Inventory.UpdateProduct(textBoxModifyProductIdText, updatedProduct);
       
            this.Close();

            MainForm.MainScreenFormLoad();
            MainForm.dataGridViewMainProducts.Update();
            MainForm.dataGridViewMainProducts.Refresh();

        }
        

        private void buttonModifyProductCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ModifyProductScreen_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridViewModifyProductAll_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}


