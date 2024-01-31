using InventoryManagementSystem.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class ModifyPartScreen : Form
    {
        public List<string> originalList = new List<string>();

        public int partIndex;
        public string originalPartSource;
        public string originalPartSourceType;

        public ModifyPartScreen()
        {
            InitializeComponent();            
        }

        public void PopulateInhouseForm(int index, int partID, string name, decimal price, int inStock, int max, int min, int machineID)
        {
            // fills form with original part properties
            partIndex = index;
            ModifyPartID.Text = partID.ToString();
            ModifyPartName.Text = name;
            ModifyPartCost.Text = price.ToString();
            ModifyPartInventory.Text = inStock.ToString();
            ModifyPartMax.Text = max.ToString();
            ModifyPartMin.Text = min.ToString();
            ModifyPartSource.Text = machineID.ToString();
            PartSourceLabel.Text = "Machine ID";
            InHouseButton.Checked = true;
            OutsourcedButton.Checked = false;

            // creates list of original parts for future validation
            originalList = new List<string>()
            {
                ModifyPartName.Text,
                ModifyPartCost.Text,
                ModifyPartInventory.Text,
                ModifyPartMax.Text,
                ModifyPartMin.Text,
                ModifyPartSource.Text
            };
           
            // captures original part source types for future validation
            originalPartSource = ModifyPartSource.Text;
            originalPartSourceType = "Inhouse";
        }
        public void PopulateOutsourcedForm(int index, int partID, string name, decimal price, int inStock, int max, int min, string companyName)
        {
            // fills form with original part properties
            partIndex = index;
            ModifyPartID.Text = partID.ToString();
            ModifyPartName.Text = name;
            ModifyPartCost.Text = price.ToString();
            ModifyPartInventory.Text = inStock.ToString();
            ModifyPartMax.Text = max.ToString();
            ModifyPartMin.Text = min.ToString();
            ModifyPartSource.Text = companyName;
            PartSourceLabel.Text = "Company Name";
            InHouseButton.Checked = false;
            OutsourcedButton.Checked = true;

            // creates list of original parts for future validation
            originalList = new List<string>()
            {
                ModifyPartName.Text,
                ModifyPartCost.Text,
                ModifyPartInventory.Text,
                ModifyPartMax.Text,
                ModifyPartMin.Text,
                ModifyPartSource.Text
            };

            // captures original part source types for future validation
            originalPartSource = ModifyPartSource.Text;
            originalPartSourceType = "Outsourced";
        }

        private void CancelPartButton_Click(object sender, EventArgs e)
        {            
            // closes AddPartScreen and returns to MainScreen            
            MainScreen.instance.ResetInterface();
            this.Close();
        }

        private void SavePartButton_Click(object sender, EventArgs e)
        {
            // get properties
            int tempID = int.Parse(ModifyPartID.Text);
            string tempName = ModifyPartName.Text.ToLower();
            decimal tempPrice = (Math.Round(decimal.Parse(ModifyPartCost.Text), 2, MidpointRounding.ToEven) + 0.00m);
            int tempInStock = int.Parse(ModifyPartInventory.Text);
            int tempMax = int.Parse(ModifyPartMax.Text);
            int tempMin = int.Parse(ModifyPartMin.Text);
            string tempSource = ModifyPartSource.Text.ToLower();

            // check that Inventory is between Max and Min
            if (tempMax < tempMin)
            {
                // throw exception
                MessageBox.Show("Max value must be greater than Min value");
                return;
            }
            // check that Min is lower than Max
            else if (tempInStock > tempMax || tempInStock < tempMin)
            {
                // throw exception
                MessageBox.Show("Inventory value must be within Max and Min values");
                return;
            }
            // verify source and Modify new part
            else if (InHouseButton.Checked == true)
            {
                // set properties
                Inhouse newPart = new Inhouse();
                newPart.PartID = tempID;
                newPart.Name = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(tempName);
                newPart.Price = tempPrice;
                newPart.InStock = tempInStock;
                newPart.Max = tempMax;
                newPart.Min = tempMin;
                newPart.MachineID = int.Parse(ModifyPartSource.Text);

                // send modified part to be updated
                Inventory.UpdatePart(partIndex, newPart);

                // closes ModifyPartScreen and returns to MainScreen            
                MainScreen.instance.ResetInterface();
                this.Close();
            }
            else if (OutsourcedButton.Checked == true)
            {
                // sets properties
                Outsourced newPart = new Outsourced();
                newPart.PartID = tempID;
                newPart.Name = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(tempName);
                newPart.Price = tempPrice;
                newPart.InStock = tempInStock;
                newPart.Max = tempMax;
                newPart.Min = tempMin;
                newPart.CompanyName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(tempSource);

                // send modified part to be updated
                Inventory.UpdatePart(partIndex, newPart);

                // closes ModifyPartScreen and returns to MainScreen            
                MainScreen.instance.ResetInterface();
                this.Close();
            }           
        }

        private void ValidateSave(object sender, EventArgs e)
        {
            SavePartButton.Enabled = false;

            // creates list of current part properties to compare with original parts
            List<string> tempList = new List<string>()
            {
                ModifyPartName.Text,
                ModifyPartCost.Text,
                ModifyPartInventory.Text,
                ModifyPartMax.Text,
                ModifyPartMin.Text,
                ModifyPartSource.Text
            };

            for (int i = 0; i < originalList.Count; i++)
            {                
                if (string.IsNullOrEmpty(tempList[i]))
                {
                    // a form is blank
                    SavePartButton.Enabled = false;
                    break;
                }
                if (tempList[i] != originalList[i])
                {
                    // modifications are ready to be saved
                    SavePartButton.Enabled = true;
                    break;
                }               
                else
                {
                    // no changes have been made
                    SavePartButton.Enabled = false;
                }
            }          
        }

        private void ModifyPartName_KeyPress(object sender, KeyPressEventArgs e)
        {
            // accept letters
            if (!char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            // accept backspacing
            if (e.KeyChar == (char)8)
            {
                e.Handled = false;
            }
            // accept spacing
            if (e.KeyChar == (char)Keys.Space)
            {
                e.Handled = false;
            }
        }

        private void ModifyPartInventory_KeyPress(object sender, KeyPressEventArgs e)
        {
            // accept numbers
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            // accept backspacing
            if (e.KeyChar == (char)8)
            {
                e.Handled = false;
            }
        }

        private void ModifyPartCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            // accept numbers
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            // accept backspacing
            if (e.KeyChar == (char)8)
            {
                e.Handled = false;
            }
            // accept one decimal
            if (e.KeyChar == '.')
            {               
                bool decimalExists = false;
                char[] tempArray = ModifyPartCost.Text.ToCharArray();

                foreach (char tempChar in tempArray)
                {
                    if (tempChar == '.')
                    {
                        decimalExists = true;
                        break;
                    }
                    else
                    {
                        decimalExists = false;
                    }
                }

                if (decimalExists == true)
                {
                    e.Handled = true;
                }
                else
                {
                    e.Handled = false;
                }
            }
        }

        private void ModifyPartMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            // accept numbers
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            // accept backspacing
            if (e.KeyChar == (char)8)
            {
                e.Handled = false;
            }
        }

        private void ModifyPartMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            // accept numbers
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            // accept backspacing
            if (e.KeyChar == (char)8)
            {
                e.Handled = false;
            }
        }

        private void ModifyPartSource_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (InHouseButton.Checked == true)
            {
                // accept numbers
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
                // accept backspacing
                if (e.KeyChar == (char)8)
                {
                    e.Handled = false;
                }
            }
            else if (OutsourcedButton.Checked == true)
            {
                // accept letters
                if (!char.IsLetter(e.KeyChar))
                {
                    e.Handled = true;
                }
                // accept backspacing
                if (e.KeyChar == (char)8)
                {
                    e.Handled = false;
                }
                // accept spacing
                if (e.KeyChar == (char)Keys.Space)
                {
                    e.Handled = false;
                }
                // accept dash
                if (e.KeyChar == '-')
                {
                    e.Handled = false;
                }
            }
        }
      
        private void RadioButtonChanged(object sender, EventArgs e)
        {           
            if (originalPartSourceType == "Inhouse")
            {
                if (InHouseButton.Checked == true)
                {
                    ModifyPartSource.Text = originalPartSource;
                }
                else
                {
                    ModifyPartSource.Text = String.Empty;
                }

            }
            else if (originalPartSourceType == "Outsourced")
            {
                if (OutsourcedButton.Checked == true)
                {
                    ModifyPartSource.Text = originalPartSource;
                }
                else
                {
                    ModifyPartSource.Text = String.Empty;
                }
            }

            if (InHouseButton.Checked == true)
            {
                PartSourceLabel.Text = "Machine ID";
            }
            else if (OutsourcedButton.Checked == true)
            {
                PartSourceLabel.Text = "Company Name";
            }
        }
    }
}
