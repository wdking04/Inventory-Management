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
    public partial class AddPartScreen : Form
    {

        public void AddPartScreenLoad()
        {
            buttonAddPartSave.Enabled = false; //Disable Search button until all fields have correct data type inputs

        }
        public AddPartScreen()
        {
            InitializeComponent();
            AddPartScreenLoad();
        }

        private void radioButtonAddPartOutsourced_CheckedChanged(object sender, EventArgs e)
        {

            {
                labelMachineID.Text = "Company Name";

                if (string.IsNullOrWhiteSpace(textBoxAddPartMachineCompany.Text) ||
                    (radioButtonAddPartOutsourced.Checked && int.TryParse(textBoxAddPartMachineCompany.Text, out int s)))
                {
                   // textBoxAddPartMachineCompany.BackColor = Color.LightGray;
                    buttonAddPartSave.Enabled = false;

                    //MessageBox.Show("Reminder: Update company name");
                    //return;

                }
                else
                {
                    //textBoxAddPartMachineCompany.BackColor = Color.White;
                    buttonAddPartSave.Enabled = true;

                }
            }
        }

        private void radioButtonAddPartInHouse_CheckedChanged(object sender, EventArgs e)
        {
            labelMachineID.Text = "Machine ID";

            if (string.IsNullOrWhiteSpace(textBoxAddPartMachineCompany.Text) ||
               (radioButtonAddPartInHouse.Checked && !(int.TryParse(textBoxAddPartMachineCompany.Text, out int n))))
            {

                //textBoxAddPartMachineCompany.BackColor = Color.LightGray;
                buttonAddPartSave.Enabled = false;

                //MessageBox.Show("Reminder: Id must be numeric");
                //return;

            }
            else
            {

                textBoxAddPartMachineCompany.BackColor = Color.White;
                buttonAddPartSave.Enabled = true;

            }
        }
       
        //Grays text box until correct format is entered
        private void textBoxAddPartName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxAddPartName.Text) || int.TryParse(textBoxAddPartName.Text, out int i))
            {
                
                textBoxAddPartName.BackColor = Color.LightGray;
                buttonAddPartSave.Enabled = false;

            }
            else
            {
                textBoxAddPartName.Enabled = true;
                textBoxAddPartName.BackColor = Color.White;

            }

            if (textBoxAddPartName.BackColor == Color.White &&
               textBoxAddPartInventory.BackColor == Color.White &&
               textBoxAddPartPriceCost.BackColor == Color.White &&
               textBoxAddPartMax.BackColor == Color.White &&
               textBoxAddPartMin.BackColor == Color.White)
            {
                buttonAddPartSave.Enabled = true;
            }
        }

        private void textBoxAddPartMax_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textBoxAddPartMax.Text) || !(int.TryParse(textBoxAddPartMax.Text, out int n)))
            {
                textBoxAddPartMax.BackColor = Color.LightGray;
                buttonAddPartSave.Enabled = false;
                
            }
            else
            {
                textBoxAddPartMax.BackColor = Color.White;
                
            }

            if (textBoxAddPartName.BackColor == Color.White &&
                textBoxAddPartInventory.BackColor == Color.White &&
                textBoxAddPartPriceCost.BackColor == Color.White &&
                textBoxAddPartMax.BackColor == Color.White &&
                textBoxAddPartMin.BackColor == Color.White)
            {
                buttonAddPartSave.Enabled = true;
            }
        }
        private void textBoxAddPartMin_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textBoxAddPartMax.Text) || !(int.TryParse(textBoxAddPartMin.Text, out int n)))
            {
                textBoxAddPartMin.BackColor = Color.LightGray;
                buttonAddPartSave.Enabled = false;

            }
            else
            {
                textBoxAddPartMin.BackColor = Color.White;

            }

            if (textBoxAddPartName.BackColor == Color.White &&
                textBoxAddPartInventory.BackColor == Color.White &&
                textBoxAddPartPriceCost.BackColor == Color.White &&
                textBoxAddPartMax.BackColor == Color.White &&
                textBoxAddPartMin.BackColor == Color.White)
            {
                buttonAddPartSave.Enabled = true;
            }
        }
        private void textBoxAddPartInventory_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textBoxAddPartInventory.Text) || !(int.TryParse(textBoxAddPartInventory.Text, out int n)))
            {
                textBoxAddPartInventory.BackColor = Color.LightGray;
                buttonAddPartSave.Enabled = false;

            }
            else
            {
                textBoxAddPartInventory.BackColor = Color.White;

            }

            if (textBoxAddPartName.BackColor == Color.White &&
                textBoxAddPartInventory.BackColor == Color.White &&
                textBoxAddPartPriceCost.BackColor == Color.White &&
                textBoxAddPartMax.BackColor == Color.White &&
                textBoxAddPartMin.BackColor == Color.White)
            {
                buttonAddPartSave.Enabled = true;
            }
        }
        private void textBoxAddPartPriceCost_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textBoxAddPartPriceCost.Text) || !(double.TryParse(textBoxAddPartPriceCost.Text, out double n)))
            {
                textBoxAddPartPriceCost.BackColor = Color.LightGray;
                buttonAddPartSave.Enabled = false;

            }
            else
            {
                textBoxAddPartPriceCost.BackColor = Color.White;

            }

            if (textBoxAddPartName.BackColor == Color.White &&
                textBoxAddPartInventory.BackColor == Color.White &&
                textBoxAddPartPriceCost.BackColor == Color.White &&
                textBoxAddPartMax.BackColor == Color.White &&
                textBoxAddPartMin.BackColor == Color.White)
            {
                buttonAddPartSave.Enabled = true;
            }
        }

        private void textBoxAddPartMachineCompany_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxAddPartMachineCompany.Text) ||
                  (radioButtonAddPartInHouse.Checked && !(int.TryParse(textBoxAddPartMachineCompany.Text, out int n))) ||
               (radioButtonAddPartOutsourced.Checked && int.TryParse(textBoxAddPartMachineCompany.Text, out int s)))
            {

                textBoxAddPartMachineCompany.BackColor = Color.LightGray;
                buttonAddPartSave.Enabled = false;

               
            }

            else
            {
                textBoxAddPartMachineCompany.BackColor = Color.White;
               
            }


            if (textBoxAddPartName.BackColor == Color.White &&
                textBoxAddPartInventory.BackColor == Color.White &&
                textBoxAddPartPriceCost.BackColor == Color.White &&
                textBoxAddPartMax.BackColor == Color.White &&
                textBoxAddPartMin.BackColor == Color.White &&
                textBoxAddPartMachineCompany.BackColor == Color.White)
            {
                buttonAddPartSave.Enabled = true;
            }
        }

        private void buttonAddPartSave_Click(object sender, EventArgs e)
        {
            // Exception if minimun entered is larger than maximum
            if (textBoxAddPartMinText < textBoxAddPartMinText)
            {
                MessageBox.Show("Minimum must be less than Maximum.");
                return;
            }
            if (textBoxAddPartInventoryText < textBoxAddPartMinText || textBoxAddPartInventoryText > textBoxAddPartMaxText)
            {
                MessageBox.Show("Inventory must be within minimum and maximum range");
                return;
            }


            if (radioButtonAddPartInHouse.Checked)
            {
                InHousePart inHouse = new InHousePart((Inventory.allParts.Count + 1), textBoxAddPartNameText, textBoxAddPartInventoryText, textBoxAddPartPriceCostText, textBoxAddPartMaxText, textBoxAddPartMinText, int.Parse(textBoxAddPartMachineCompanyText)/*, false*/);
                Inventory.AddPart(inHouse);

            }
            else
            {
                OutsourcedPart outsourced = new OutsourcedPart((Inventory.allParts.Count + 1), textBoxAddPartNameText, textBoxAddPartInventoryText, textBoxAddPartPriceCostText, textBoxAddPartMaxText, textBoxAddPartMinText, textBoxAddPartMachineCompanyText/*, true*/);
                Inventory.AddPart(outsourced);

            }
            this.Close();
        }

        private void buttonAddPartCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddPartScreen_Load(object sender, EventArgs e)
        {

        }
    }

}
    
    

        
        
    
   
    
