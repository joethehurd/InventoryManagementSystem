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
    public partial class AddPartScreen : Form
    {      
        public AddPartScreen()
        {
            InitializeComponent();           
        }
       
        private void CancelPartButton_Click(object sender, EventArgs e)
        {
            // closes AddPartScreen and returns to MainScreen            
            MainScreen.instance.ResetInterface();
            this.Close();
        }

        private void SavePartButton_Click(object sender, EventArgs e)
        {
            string tempName = AddPartName.Text.ToLower();
            decimal tempPrice = (Math.Round(decimal.Parse(AddPartCost.Text), 2, MidpointRounding.ToEven) + 0.00m);
            int tempInStock = int.Parse(AddPartInventory.Text);
            int tempMax = int.Parse(AddPartMax.Text);
            int tempMin = int.Parse(AddPartMin.Text);
            string tempSource = AddPartSource.Text.ToLower();

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
            // verifyy source and add new part
            else if (InHouseButton.Checked == true)
            {
                // sets properties
                Inhouse newPart = new Inhouse();
                newPart.PartID = GeneratePartID.AutoIncrement();               
                newPart.Name = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(tempName);
                newPart.Price = tempPrice;
                newPart.InStock = tempInStock;
                newPart.Max = tempMax;
                newPart.Min = tempMin;
                newPart.MachineID = int.Parse(AddPartSource.Text);

                // adds new part
                Inventory.AddPart(newPart);

                // closes AddPartScreen and returns to MainScreen            
                MainScreen.instance.ResetInterface();
                this.Close();
            }
            else if (OutsourcedButton.Checked == true)
            {
                // sets properties
                Outsourced newPart = new Outsourced();
                newPart.PartID = GeneratePartID.AutoIncrement();
                newPart.Name = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(tempName);
                newPart.Price = tempPrice;
                newPart.InStock = tempInStock;
                newPart.Max = tempMax;
                newPart.Min = tempMin;
                newPart.CompanyName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(tempSource);

                // adds new part
                Inventory.AddPart(newPart);

                // closes AddPartScreen and returns to MainScreen            
                MainScreen.instance.ResetInterface();
                this.Close();
            }           
        }
       
        private void ValidateSave(object sender, EventArgs e)
        {            
            List<string> tempList = new List<string>()
            {
                AddPartName.Text,               
                AddPartCost.Text,
                AddPartInventory.Text,
                AddPartMax.Text,
                AddPartMin.Text,
                AddPartSource.Text
            };

            foreach (string tempString in tempList)
            {
                if (string.IsNullOrEmpty(tempString))
                {        
                    // a form is blank
                    SavePartButton.Enabled = false;
                    break;
                }
                else
                {          
                    // form is ready to be saved
                    SavePartButton.Enabled = true;
                }
            }            
        }

        private void AddPartName_KeyPress(object sender, KeyPressEventArgs e)
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

        private void AddPartInventory_KeyPress(object sender, KeyPressEventArgs e)
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

        private void AddPartCost_KeyPress(object sender, KeyPressEventArgs e)
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
                char[] tempArray = AddPartCost.Text.ToCharArray();

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

        private void AddPartMax_KeyPress(object sender, KeyPressEventArgs e)
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

        private void AddPartMin_KeyPress(object sender, KeyPressEventArgs e)
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

        private void AddPartSource_KeyPress(object sender, KeyPressEventArgs e)
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
            if (InHouseButton.Checked == true)
            {
                PartSourceLabel.Text = "Machine ID";
            }
            else if (OutsourcedButton.Checked == true)
            {
                PartSourceLabel.Text = "Company Name";
            }

            AddPartSource.Text = String.Empty;
        }


    }
}
