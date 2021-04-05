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
    
    public partial class ModifyPartScreen : Form
    {
        //bool isInHousePart;

        MainScreen MainForm = (MainScreen)Application.OpenForms["MainScreen"];

        
        private void radioButtonOutsourced_CheckedChanged(object sender, EventArgs e)
        {

            {
                labelMachineID.Text = "Company Name";

                if (string.IsNullOrWhiteSpace(textBoxModifyMachineCompany.Text) ||
                    (radioButtonOutsourced.Checked && int.TryParse(textBoxModifyMachineCompany.Text, out int s)))
                {
                    textBoxModifyMachineCompany.BackColor = Color.LightGray;
                    buttonModifyPartSave.Enabled = false;

                    //MessageBox.Show("Reminder: Update company name");
                    //return;

                }
                else
                {
                    textBoxModifyMachineCompany.BackColor = Color.White;
                    buttonModifyPartSave.Enabled = true;

                }
            }
        }

        private void radioButtonInhouse_CheckedChanged(object sender, EventArgs e)
        {
            labelMachineID.Text = "Machine ID";

            if (string.IsNullOrWhiteSpace(textBoxModifyMachineCompany.Text) ||
               (radioButtonInhouse.Checked && !(int.TryParse(textBoxModifyMachineCompany.Text, out int n))))
            {

                textBoxModifyMachineCompany.BackColor = Color.LightGray;
                buttonModifyPartSave.Enabled = false;

                //MessageBox.Show("Reminder: Id must be numeric");
                //return;

            }
            else
            {

                textBoxModifyMachineCompany.BackColor = Color.White;
                buttonModifyPartSave.Enabled = true;

            }
        }

        public ModifyPartScreen(InHousePart inPart)
        {
            InitializeComponent();
           // ModifyPartScreenLoad();

            ModifyPartIdText = inPart.PartID; 
            ModifyPartNameText = inPart.Name;
            ModifyPartInventoryText = inPart.InStock;
            ModifyPartPriceText = decimal.Parse(inPart.Price.Substring(1));
            ModifyPartMaxText = inPart.Max;
            ModifyPartMinText = inPart.Min;
            ModifyPartMachineCompanyText = inPart.MachineID.ToString();

        }
        public ModifyPartScreen(OutsourcedPart outPart)
        {
            InitializeComponent();
           // ModifyPartScreenLoad();

            ModifyPartIdText = outPart.PartID; 
            ModifyPartNameText = outPart.Name;
            ModifyPartInventoryText = outPart.InStock;
            ModifyPartPriceText = decimal.Parse(outPart.Price.Substring(1));
            ModifyPartMaxText = outPart.Max;
            ModifyPartMinText = outPart.Min;
            ModifyPartMachineCompanyText = outPart.CompanyName;

            radioButtonOutsourced.Checked = true;
            //radioButtonInhouse.Enabled = false; // Disables inhouse from being changed to outsourced

        }
       
        public void ModifyPartScreenLoad()
        {
            buttonModifyPartSave.Enabled = false;
        }


        private void textBoxModifyPartName_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textBoxModifyPartName.Text) || int.TryParse(textBoxModifyPartName.Text, out int n))
            {
                textBoxModifyPartName.BackColor = Color.LightGray;
                buttonModifyPartSave.Enabled = false;

            }
            else
            {
                textBoxModifyPartName.BackColor = Color.White;

            }

            if (textBoxModifyPartName.BackColor == Color.White &&
                textBoxModifyPartInventory.BackColor == Color.White &&
                textBoxModifyPriceCost.BackColor == Color.White &&
                textBoxModifyPartMax.BackColor == Color.White &&
                textBoxModifyPartMin.BackColor == Color.White &&
                textBoxModifyMachineCompany.BackColor == Color.White)
            {
                buttonModifyPartSave.Enabled = true;
            }

        }

        private void textBoxModifyPartInventory_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textBoxModifyPartInventory.Text) || !(int.TryParse(textBoxModifyPartInventory.Text, out int n)))
            {
                textBoxModifyPartInventory.BackColor = Color.LightGray;
                buttonModifyPartSave.Enabled = false;

            }
            else
            {
                buttonModifyPartSave.Enabled = true;
                textBoxModifyPartInventory.BackColor = Color.White;

            }

            if (textBoxModifyPartName.BackColor == Color.White &&
                textBoxModifyPartInventory.BackColor == Color.White &&
                textBoxModifyPriceCost.BackColor == Color.White &&
                textBoxModifyPartMax.BackColor == Color.White &&
                textBoxModifyPartMin.BackColor == Color.White &&
                textBoxModifyMachineCompany.BackColor == Color.White)
            {
                buttonModifyPartSave.Enabled = true;
            }

        }
        private void textBoxModifyPriceCost_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textBoxModifyPriceCost.Text) || !(double.TryParse(textBoxModifyPriceCost.Text, out double n)))
            {
                textBoxModifyPriceCost.BackColor = Color.LightGray;
                buttonModifyPartSave.Enabled = false;

            }
            else
            {
                buttonModifyPartSave.Enabled = true;
                textBoxModifyPriceCost.BackColor = Color.White;

            }

            if (textBoxModifyPartName.BackColor == Color.White &&
                textBoxModifyPartInventory.BackColor == Color.White &&
                textBoxModifyPriceCost.BackColor == Color.White &&
                textBoxModifyPartMax.BackColor == Color.White &&
                textBoxModifyPartMin.BackColor == Color.White &&
                textBoxModifyMachineCompany.BackColor == Color.White)
            {
                buttonModifyPartSave.Enabled = true;
            }


        }
        private void textBoxModifyPartMax_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textBoxModifyPartMax.Text) || !(int.TryParse(textBoxModifyPartMax.Text, out int n)))
            {
                textBoxModifyPartMax.BackColor = Color.LightGray;
                buttonModifyPartSave.Enabled = false;

            }
            else
            {
                buttonModifyPartSave.Enabled = true;
                textBoxModifyPartMax.BackColor = Color.White;

            }

            if (textBoxModifyPartName.BackColor == Color.White &&
                textBoxModifyPartInventory.BackColor == Color.White &&
                textBoxModifyPriceCost.BackColor == Color.White &&
                textBoxModifyPartMax.BackColor == Color.White &&
                textBoxModifyPartMin.BackColor == Color.White &&
                textBoxModifyMachineCompany.BackColor == Color.White)
            {
                buttonModifyPartSave.Enabled = true;
            }

        }



        private void textBoxModifyPartMin_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textBoxModifyPartMin.Text) || !(int.TryParse(textBoxModifyPartMin.Text, out int n)))
            {
                textBoxModifyPartMin.BackColor = Color.LightGray;
                buttonModifyPartSave.Enabled = false;

            }
            else
            {
                buttonModifyPartSave.Enabled = true;
                textBoxModifyPartMin.BackColor = Color.White;


            }

            if (textBoxModifyPartName.BackColor == Color.White &&
                textBoxModifyPartInventory.BackColor == Color.White &&
                textBoxModifyPriceCost.BackColor == Color.White &&
                textBoxModifyPartMax.BackColor == Color.White &&
                textBoxModifyPartMin.BackColor == Color.White &&
                textBoxModifyMachineCompany.BackColor == Color.White)
            {
                buttonModifyPartSave.Enabled = true;
            }

        }

        private void textBoxModifyMachineCompany_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxModifyMachineCompany.Text) ||
                  (radioButtonInhouse.Checked && !(int.TryParse(textBoxModifyMachineCompany.Text, out int n))) ||
               (radioButtonOutsourced.Checked && int.TryParse(textBoxModifyMachineCompany.Text, out int s)))
            {

                textBoxModifyMachineCompany.BackColor = Color.LightGray;
                buttonModifyPartSave.Enabled = false;
     

            }

            else
            {
                textBoxModifyMachineCompany.BackColor = Color.White;
              
            }


            if (textBoxModifyPartName.BackColor == Color.White &&
                textBoxModifyPartInventory.BackColor == Color.White &&
                textBoxModifyPriceCost.BackColor == Color.White &&
                textBoxModifyPartMax.BackColor == Color.White &&
                textBoxModifyPartMin.BackColor == Color.White &&
                textBoxModifyMachineCompany.BackColor == Color.White)
            {
                buttonModifyPartSave.Enabled = true;
            }
        }


        private void buttonModifyPartSave_Click(object sender, EventArgs e)
        {
            if (ModifyPartMaxText < ModifyPartMinText)
            {
                MessageBox.Show("Minimum must be less than Maximum.");
                return;
            }
            if (ModifyPartInventoryText < ModifyPartMinText || ModifyPartInventoryText > ModifyPartMaxText)
            {
                MessageBox.Show("Inventory must be within minimum and maximum range");
                return;
            }

            if (radioButtonInhouse.Checked)
            {
                InHousePart inHouse = new InHousePart(ModifyPartIdText, ModifyPartNameText, ModifyPartInventoryText, ModifyPartPriceText, ModifyPartMaxText, ModifyPartMinText, int.Parse(ModifyPartMachineCompanyText));
                Inventory.UpdatePart(ModifyPartIdText, inHouse);
                radioButtonInhouse.Checked = true;

            }

            else
            {
                OutsourcedPart outSourced = new OutsourcedPart(ModifyPartIdText, ModifyPartNameText, ModifyPartInventoryText, ModifyPartPriceText, ModifyPartMaxText, ModifyPartMinText, ModifyPartMachineCompanyText);
                Inventory.UpdatePart(ModifyPartIdText, outSourced);
   
            }


            this.Close();
            MainForm.MainScreenFormLoad();
            MainForm.dataGridViewMainParts.Update();
            MainForm.dataGridViewMainParts.Refresh();

            //this.Close();
        }
        private void buttonModifyPartCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ModifyPartScreen_Load(object sender, EventArgs e)
        {

        }

       
    }
}
