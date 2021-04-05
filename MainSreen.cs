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
   
    public partial class MainScreen : Form
    {

        public MainScreen()
        {
            InitializeComponent();
            MainScreenFormLoad();
        }
       

        public void MainScreenFormLoad()
        {
           
            //Populates existing inventory Parts
            dataGridViewMainParts.DataSource = Inventory.allParts;

           //Populates existing inventory Products
            dataGridViewMainProducts.DataSource = Inventory.Products;

            //Disables search buttons until proper format is entered
            buttonProductsSearch.Enabled = false;
            buttonPartsSearch.Enabled = false;
        }
        private void textBoxProductsSearch_TextChanged(object sender, EventArgs e)
        {
            //Only enable search button if a valid search text is entered.
            if (string.IsNullOrWhiteSpace(textBoxProductsSearch.Text) || !int.TryParse(textBoxProductsSearch.Text, out int i))
            {
                buttonProductsSearch.Enabled = false;
                textBoxProductsSearch.BackColor = Color.LightGray;
                       
            }
            else
            {
                buttonProductsSearch.Enabled = true;
                textBoxProductsSearch.BackColor = Color.White;

            }
        }

        private void textBoxPartsSearch_TextChanged(object sender, EventArgs e)
        {
            //Only enable search button if a valid search text is entered.
            if (string.IsNullOrWhiteSpace(textBoxPartsSearch.Text) || !int.TryParse(textBoxPartsSearch.Text, out int i))
            {
                buttonPartsSearch.Enabled = false;
                textBoxPartsSearch.BackColor = Color.LightGray;

            }
            else
            {
                buttonPartsSearch.Enabled = true;
                textBoxPartsSearch.BackColor = Color.White;

            }
        }
        private void buttonAddPart_Click(object sender, EventArgs e)
        {

            new AddPartScreen().ShowDialog();
        }

        private void buttonModifyPart_Click(object sender, EventArgs e)
        {
            // Will open the modify parts screen with selected part
            if (dataGridViewMainParts.CurrentRow.DataBoundItem.GetType() == typeof(W.King_c968.InHousePart))
            {
                InHousePart inPart = (InHousePart)dataGridViewMainParts.CurrentRow.DataBoundItem;
                new ModifyPartScreen(inPart).ShowDialog();

            }
            else
            {
                OutsourcedPart outPart = (OutsourcedPart)dataGridViewMainParts.CurrentRow.DataBoundItem;
                new ModifyPartScreen(outPart).ShowDialog();

            }
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {     
            new AddProductScreen().ShowDialog();
        }

        private void buttonModifyProduct_Click(object sender, EventArgs e)
           
        {
            Product selectedProduct = (Product)dataGridViewMainProducts.CurrentRow.DataBoundItem;
            new ModifyProductScreen(selectedProduct).ShowDialog();
        }

        //Deletes part on main screen, opens message box asking user to confirm delete before deleting
        private void buttonDeletePart_Click(object sender, EventArgs e)
        {
            DialogResult deletePartDialogResult = MessageBox.Show("Are you sure you want to delete this?", "Delete", MessageBoxButtons.YesNo);

            if (deletePartDialogResult == DialogResult.Yes)
            {

                //Deletes part

            }
            else if (deletePartDialogResult == DialogResult.No)
                return;
            {
                //Does nothing
            }




            foreach (DataGridViewRow row in dataGridViewMainParts.SelectedRows)
            {
                dataGridViewMainParts.Rows.RemoveAt(row.Index);
            }
        }
        // Deletes selected product when clicked, opens message box asking to confirm delete
        private void buttonDeleteProduct_Click(object sender, EventArgs e)
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

            //Will not allow Product to be deleted if associated with a Part
            Product product = (Product)dataGridViewMainProducts.CurrentRow.DataBoundItem;
            if (product.AssociatedParts.Count > 0)
            {
                MessageBox.Show("Cannot delete assigned product");
                return;
            }


            foreach (DataGridViewRow row in dataGridViewMainProducts.SelectedRows)
            {
                dataGridViewMainProducts.Rows.RemoveAt(row.Index);
            }

        }

       
        // Lookup Part by ID if found highlights in table
        private void buttonPartsSearch_Click(object sender, EventArgs e)
        {

            Part match = Inventory.LookupPart(textBoxPartsSearchText);

           

            int searchedPartID = Convert.ToInt32(textBoxPartsSearch.Text);

            if (Inventory.LookupPart(searchedPartID) != null)
            {

                //Find valid part
               
            }
            else
            {
                MessageBox.Show("Part not found");
                return;
            }

            foreach (DataGridViewRow row in dataGridViewMainParts.Rows)
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


        // Lookup Product by ID if found highlights in table
        private void buttonProductsSearch_Click(object sender, EventArgs e)
        {
            Product match = Inventory.LookupProduct(textBoxProductsSearchText);

            int searchedProductID = Convert.ToInt32(textBoxProductsSearch.Text);

            if (Inventory.LookupPart(searchedProductID) != null)
            {

                //Find valid product
                

            }
            else
            {
                MessageBox.Show("Product not found");
                return;
            }


            foreach (DataGridViewRow row in dataGridViewMainProducts.Rows)
            {
                Product prod = (Product)row.DataBoundItem;

                if (prod.ProductID == match.ProductID)
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
       
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBoxProducts_Enter(object sender, EventArgs e)
        {

        }

        private void MainScreen_Load(object sender, EventArgs e)
        {

        }

        private void groupBoxParts_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridViewMainParts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

      

