using InventoryManagementSystem.Classes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO.Ports;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{    
    public partial class ModifyProductScreen : Form
    {
        public List<string> originalFormList = new List<string>();
        public List<string> addedPartsList = new List<string>();
        public List<string> deletedPartsList = new List<string>();
        public List<string> originalPartsList = new List<string>();        

        public int productIndex;       

        public ModifyProductScreen()
        {
            InitializeComponent();
        }
      
        public void PopulateForm(int index, int productID, string name, decimal price, int inStock, int max, int min)
        {          
            // set data grid views
            CandidatePartsGrid.DataSource = Inventory.AllParts;
            AssociatedPartsGrid.DataSource = Inventory.Products[index].AssociatedParts;

            // fills form with original product properties
            productIndex = index;
            ModifyProductID.Text = productID.ToString();
            ModifyProductName.Text = name;
            ModifyProductCost.Text = price.ToString();
            ModifyProductInventory.Text = inStock.ToString();
            ModifyProductMax.Text = max.ToString();
            ModifyProductMin.Text = min.ToString();

            // creates list of original parts for future validation
            originalFormList = new List<string>()
            {
                ModifyProductName.Text,
                ModifyProductCost.Text,
                ModifyProductInventory.Text,
                ModifyProductMax.Text,
                ModifyProductMin.Text,                
            };
          
            foreach (Part part in Inventory.Products[index].AssociatedParts)
            {
                originalPartsList.Add(part.Name);
            }

            SaveProductButton.Enabled = false;
        }

        private void BindingIsComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            CandidatePartsGrid.ClearSelection();
            AssociatedPartsGrid.ClearSelection();
        }

        private void CandidatePartsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (CandidatePartsGrid.CurrentRow.Selected == true)
            {
                AddCandidatePartButton.Enabled = true;

                DeleteAssociatedPartButton.Enabled = false;
                AssociatedPartsGrid.ClearSelection();
            }
        }

        private void AssociatedPartsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (AssociatedPartsGrid.CurrentRow.Selected == true)
            {
                DeleteAssociatedPartButton.Enabled = true;

                AddCandidatePartButton.Enabled = false;
                CandidatePartsGrid.ClearSelection();
            }
        }

        private void SearchCandidatePartsButton_Click(object sender, EventArgs e)
        {
            LookupPart();
        }

        private void AddCandidatePartButton_Click(object sender, EventArgs e)
        {          
            if (CandidatePartsGrid.Rows.Count > 0)
            {
                Part selectedPart = CandidatePartsGrid.CurrentRow.DataBoundItem as Part;
                Inventory.Products[productIndex].AssociatedParts.Add(selectedPart);
                addedPartsList.Add(selectedPart.PartID.ToString());               
            }

            AssociatedPartsGrid.ClearSelection();
            DeleteAssociatedPartButton.Enabled = false;

            if (CandidatePartsGrid.Rows.Count > 0)
            {
                int rowIndex = CandidatePartsGrid.CurrentRow.Index;
                int columnIndex = CandidatePartsGrid.CurrentCell.ColumnIndex;
                CandidatePartsGrid.Rows[rowIndex].Selected = true;
                CandidatePartsGrid.CurrentCell = CandidatePartsGrid.Rows[rowIndex].Cells[columnIndex];
            }
            else
            {
                AddCandidatePartButton.Enabled = false;
            }          
           
            ValidationCheck();
        }

        private void DeleteAssociatedPartButton_Click(object sender, EventArgs e)
        {
            // confirm deletion
            var confirmDeletion = MessageBox.Show("Are you sure you want to remove this associated part?",
                                                    "Confirm", MessageBoxButtons.YesNo);
            if (confirmDeletion == DialogResult.Yes)
            {
                if (AssociatedPartsGrid.Rows.Count > 0)
                {
                    Part selectedPart = AssociatedPartsGrid.CurrentRow.DataBoundItem as Part;
                    Inventory.Products[productIndex].AssociatedParts.Remove(selectedPart);                   
                    deletedPartsList.Add(selectedPart.PartID.ToString());
                }

                CandidatePartsGrid.ClearSelection();
                AddCandidatePartButton.Enabled = false;

                if (AssociatedPartsGrid.Rows.Count > 0)
                {
                    int rowIndex = AssociatedPartsGrid.CurrentRow.Index;
                    int columnIndex = AssociatedPartsGrid.CurrentCell.ColumnIndex;
                    AssociatedPartsGrid.Rows[rowIndex].Selected = true;
                    AssociatedPartsGrid.CurrentCell = AssociatedPartsGrid.Rows[rowIndex].Cells[columnIndex];
                }
                else
                {
                    DeleteAssociatedPartButton.Enabled = false;
                }

                ValidationCheck();
            }         
        }

        private void SaveProductButton_Click(object sender, EventArgs e)
        {           
            // get properties                     
            string tempName = ModifyProductName.Text.ToLower();
            decimal tempPrice = (Math.Round(decimal.Parse(ModifyProductCost.Text), 2, MidpointRounding.ToEven) + 0.00m);
            int tempInStock = int.Parse(ModifyProductInventory.Text);
            int tempMax = int.Parse(ModifyProductMax.Text);
            int tempMin = int.Parse(ModifyProductMin.Text);

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
            else
            {               
                // update product properties
                Inventory.Products[productIndex].Name = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(tempName);
                Inventory.Products[productIndex].Price = tempPrice;
                Inventory.Products[productIndex].InStock = tempInStock;
                Inventory.Products[productIndex].Max = tempMax;
                Inventory.Products[productIndex].Min = tempMin;

                // closes AddPartScreen and returns to MainScreen            
                MainScreen.instance.ResetInterface();
                this.Close();
            }

            // closes AddPartScreen and returns to MainScreen            
            MainScreen.instance.ResetInterface();
            this.Close();
        }

        private void CancelProductButton_Click(object sender, EventArgs e)
        {
            // remove associated parts
            for (int i = addedPartsList.Count - 1; i >= 0; i--)
            {
                for (int j = Inventory.Products[productIndex].AssociatedParts.Count - 1; j >= 0; j--)
                {                   
                    Part tempPart = Inventory.Products[productIndex].AssociatedParts[j] as Part;
                                        
                    if (addedPartsList[i].Equals(tempPart.PartID.ToString()))
                    {                       
                        Inventory.Products[productIndex].AssociatedParts.Remove(tempPart);
                        addedPartsList.RemoveAt(i);
                        break;
                    }                                           
                }
            }

            // re-associate deleted parts
            for (int i = deletedPartsList.Count - 1; i >= 0; i--)
            {
                for (int j = Inventory.AllParts.Count - 1; j >= 0; j--)
                {
                    Part tempPart = Inventory.AllParts[j] as Part;

                    if (deletedPartsList[i].Equals(tempPart.PartID.ToString()))
                    {
                        Inventory.Products[productIndex].AssociatedParts.Add(tempPart);
                        deletedPartsList.RemoveAt(i);
                        break;
                    }
                }
            }

            // closes AddPartScreen and returns to MainScreen            
            MainScreen.instance.ResetInterface();
            this.Close();
        }                       

        private void ValidateSave(object sender, EventArgs e)
        {
            ValidationCheck();
        }

        public void ValidationCheck()
        {
            SaveProductButton.Enabled = false;
          
            List<string> tempFormList = new List<string>()
            {
                ModifyProductName.Text,
                ModifyProductCost.Text,
                ModifyProductInventory.Text,
                ModifyProductMax.Text,
                ModifyProductMin.Text,
            };                     

            for (int i = 0; i < originalFormList.Count; i++)
            {
                if (string.IsNullOrEmpty(tempFormList[i]))
                {
                    // a form is blank
                    SaveProductButton.Enabled = false;
                    break;
                }
                if (tempFormList[i] != originalFormList[i])
                {
                    // modifications are ready to be saved
                    SaveProductButton.Enabled = true;
                    break;
                }
                else
                {
                    // no changes have been made, check associated parts for changes
                    if (SaveProductButton.Enabled == false)
                    {
                        List<string> tempPartsList = new List<string>();

                        foreach (Part part in Inventory.Products[productIndex].AssociatedParts)
                        {
                            tempPartsList.Add(part.Name);
                        }

                        bool partsEquivalent = (originalPartsList.Count == tempPartsList.Count) && 
                                                !originalPartsList.Except(tempPartsList).Any();

                        if (partsEquivalent == true)
                        {
                            // no changes made
                            SaveProductButton.Enabled = false;
                        }
                        else
                        {
                            // changes made
                            SaveProductButton.Enabled = true;
                        }
                    }
                }
            }           
        }     

        private void ModifyProductName_KeyPress(object sender, KeyPressEventArgs e)
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

        private void ModifyProductInventory_KeyPress(object sender, KeyPressEventArgs e)
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

        private void ModifyProductCost_KeyPress(object sender, KeyPressEventArgs e)
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
                char[] tempArray = ModifyProductCost.Text.ToCharArray();

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

        private void ModifyProductMax_KeyPress(object sender, KeyPressEventArgs e)
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

        private void ModifyProductMin_KeyPress(object sender, KeyPressEventArgs e)
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

        private void SearchBarCandidateParts_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SearchBarCandidateParts.Text))
            {
                SearchCandidatePartsButton.Enabled = false;
            }
            else
            {
                SearchCandidatePartsButton.Enabled = true;
            }
        }

        // for confirming a search with a keyboard
        private void SearchBarCandidateParts_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (!string.IsNullOrEmpty(SearchBarCandidateParts.Text))
                {
                    LookupPart();
                }
                else
                {
                    CandidatePartsGrid.ClearSelection();
                    AddCandidatePartButton.Enabled = false;
                }

                e.Handled = true;
            }
        }

        public void LookupPart()
        {
            string searchValue = SearchBarCandidateParts.Text;
            bool searchValueFound = false;
            int rowIndex = 0;
            int columnIndex = 0;

            foreach (DataGridViewRow row in CandidatePartsGrid.Rows)
            {
                //search PartsID
                if (row.Cells[0].Value.ToString().Equals(searchValue))
                {
                    rowIndex = row.Index;
                    columnIndex = 0;
                    searchValueFound = true;
                    break;
                }
                //search PartsName
                else if (row.Cells[1].Value.ToString().ToLower().Contains(searchValue.ToLower()))
                {
                    rowIndex = row.Index;
                    columnIndex = 1;
                    searchValueFound = true;
                    break;
                }
            }

            if (searchValueFound == true)
            {
                CandidatePartsGrid.Rows[rowIndex].Selected = true;
                CandidatePartsGrid.CurrentCell = CandidatePartsGrid.Rows[rowIndex].Cells[columnIndex];
                AddCandidatePartButton.Enabled = true;
                DeleteAssociatedPartButton.Enabled = false;
                AssociatedPartsGrid.ClearSelection();
            }
            else
            {
                MessageBox.Show("Part could not be found.", "Alert");
                CandidatePartsGrid.ClearSelection();
                CandidatePartsGrid.CurrentCell = null;
                SearchBarCandidateParts.Text = String.Empty;
                SearchCandidatePartsButton.Enabled = false;
                AddCandidatePartButton.Enabled = false;
                DeleteAssociatedPartButton.Enabled = false;
                AssociatedPartsGrid.ClearSelection();
            }
        }

        // for navigating the DataGridView with a keyboard
        private void CandidatePartsGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (CandidatePartsGrid.Rows.Count > 0)
            {
                if (CandidatePartsGrid.CurrentCell == null || CandidatePartsGrid.Rows.Count == 1)
                {
                    CandidatePartsGrid.Rows[0].Selected = true;
                    CandidatePartsGrid.CurrentCell = CandidatePartsGrid.Rows[0].Cells[0];
                    AssociatedPartsGrid.ClearSelection();
                    AddCandidatePartButton.Enabled = true;
                    DeleteAssociatedPartButton.Enabled = false;
                }

                if (e.KeyCode == Keys.Enter)
                {
                    if (CandidatePartsGrid.CurrentCell.RowIndex != CandidatePartsGrid.Rows.Count - 1)
                    {
                        int rowIndex = CandidatePartsGrid.CurrentRow.Index;
                        int columnIndex = CandidatePartsGrid.CurrentCell.ColumnIndex;
                        CandidatePartsGrid.Rows[rowIndex].Selected = true;
                        CandidatePartsGrid.CurrentCell = CandidatePartsGrid.Rows[rowIndex].Cells[columnIndex];

                        AssociatedPartsGrid.ClearSelection();
                        AddCandidatePartButton.Enabled = true;
                        DeleteAssociatedPartButton.Enabled = false;

                        e.Handled = true;
                    }
                }
                else if (e.KeyCode == Keys.Up)
                {
                    if (CandidatePartsGrid.CurrentCell.RowIndex > 0)
                    {
                        int rowIndex = CandidatePartsGrid.CurrentRow.Index;
                        int columnIndex = CandidatePartsGrid.CurrentCell.ColumnIndex;
                        CandidatePartsGrid.Rows[rowIndex - 1].Selected = true;
                        CandidatePartsGrid.CurrentCell = CandidatePartsGrid.Rows[rowIndex - 1].Cells[columnIndex];

                        AssociatedPartsGrid.ClearSelection();
                        AddCandidatePartButton.Enabled = true;
                        DeleteAssociatedPartButton.Enabled = false;

                        e.Handled = true;
                    }
                }
                else if (e.KeyCode == Keys.Down)
                {
                    if (CandidatePartsGrid.CurrentCell.RowIndex < CandidatePartsGrid.Rows.Count - 1)
                    {
                        int rowIndex = CandidatePartsGrid.CurrentRow.Index;
                        int columnIndex = CandidatePartsGrid.CurrentCell.ColumnIndex;
                        CandidatePartsGrid.Rows[rowIndex + 1].Selected = true;
                        CandidatePartsGrid.CurrentCell = CandidatePartsGrid.Rows[rowIndex + 1].Cells[columnIndex];

                        AssociatedPartsGrid.ClearSelection();
                        AddCandidatePartButton.Enabled = true;
                        DeleteAssociatedPartButton.Enabled = false;

                        e.Handled = true;
                    }
                }
                else if (e.KeyCode == Keys.Tab)
                {
                    e.Handled = false;
                }
            }           
        }

        // for navigating the DataGridView with a keyboard
        private void AssociatedPartsGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (AssociatedPartsGrid.Rows.Count > 0)
            {
                if (AssociatedPartsGrid.CurrentCell == null || AssociatedPartsGrid.Rows.Count == 1)
                {
                    AssociatedPartsGrid.Rows[0].Selected = true;
                    AssociatedPartsGrid.CurrentCell = AssociatedPartsGrid.Rows[0].Cells[0];
                    CandidatePartsGrid.ClearSelection();
                    AddCandidatePartButton.Enabled = false;
                    DeleteAssociatedPartButton.Enabled = true;

                }

                if (e.KeyCode == Keys.Enter)
                {
                    if (AssociatedPartsGrid.CurrentCell.RowIndex != AssociatedPartsGrid.Rows.Count - 1)
                    {
                        int rowIndex = AssociatedPartsGrid.CurrentRow.Index;
                        int columnIndex = AssociatedPartsGrid.CurrentCell.ColumnIndex;
                        AssociatedPartsGrid.Rows[rowIndex].Selected = true;
                        AssociatedPartsGrid.CurrentCell = AssociatedPartsGrid.Rows[rowIndex].Cells[columnIndex];

                        CandidatePartsGrid.ClearSelection();
                        AddCandidatePartButton.Enabled = false;
                        DeleteAssociatedPartButton.Enabled = true;

                        e.Handled = true;
                    }
                }
                else if (e.KeyCode == Keys.Up)
                {
                    if (AssociatedPartsGrid.CurrentCell.RowIndex > 0)
                    {
                        int rowIndex = AssociatedPartsGrid.CurrentRow.Index;
                        int columnIndex = AssociatedPartsGrid.CurrentCell.ColumnIndex;
                        AssociatedPartsGrid.Rows[rowIndex - 1].Selected = true;
                        AssociatedPartsGrid.CurrentCell = AssociatedPartsGrid.Rows[rowIndex - 1].Cells[columnIndex];

                        CandidatePartsGrid.ClearSelection();
                        AddCandidatePartButton.Enabled = false;
                        DeleteAssociatedPartButton.Enabled = true;

                        e.Handled = true;
                    }
                }
                else if (e.KeyCode == Keys.Down)
                {
                    if (AssociatedPartsGrid.CurrentCell.RowIndex < AssociatedPartsGrid.Rows.Count - 1)
                    {
                        int rowIndex = AssociatedPartsGrid.CurrentRow.Index;
                        int columnIndex = AssociatedPartsGrid.CurrentCell.ColumnIndex;
                        AssociatedPartsGrid.Rows[rowIndex + 1].Selected = true;
                        AssociatedPartsGrid.CurrentCell = AssociatedPartsGrid.Rows[rowIndex + 1].Cells[columnIndex];

                        CandidatePartsGrid.ClearSelection();
                        AddCandidatePartButton.Enabled = false;
                        DeleteAssociatedPartButton.Enabled = true;

                        e.Handled = true;
                    }
                }
                else if (e.KeyCode == Keys.Tab)
                {
                    e.Handled = false;
                }
            }           
        }
    }
}
