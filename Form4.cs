using InventoryManagementSystem.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{    
    public partial class AddProductScreen : Form
    {
        public int productIndex;

        public AddProductScreen()
        {
            InitializeComponent();
        }
       
        public void PopulateForm(int index)
        {
            productIndex = index;

            // set data grid views
            CandidatePartsGrid.DataSource = Inventory.AllParts;
            AssociatedPartsGrid.DataSource = Inventory.Products[index].AssociatedParts;            
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
            string tempName = AddProductName.Text.ToLower();
            decimal tempPrice = (Math.Round(decimal.Parse(AddProductCost.Text), 2, MidpointRounding.ToEven) + 0.00m);
            int tempInStock = int.Parse(AddProductInventory.Text);
            int tempMax = int.Parse(AddProductMax.Text);
            int tempMin = int.Parse(AddProductMin.Text);               

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
        }

        private void CancelProductButton_Click(object sender, EventArgs e)
        {
            Inventory.Products.RemoveAt(productIndex);
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

            List<string> tempList = new List<string>()
            {
                AddProductName.Text,
                AddProductCost.Text,
                AddProductInventory.Text,
                AddProductMax.Text,
                AddProductMin.Text,
            };

            foreach (string tempString in tempList)
            {
                if (string.IsNullOrEmpty(tempString))
                {
                    // a form is blank
                    SaveProductButton.Enabled = false;
                    break;
                }
                else
                {
                    // form is ready to be saved
                    SaveProductButton.Enabled = true;
                }
            }
        }
       
        private void AddProductName_KeyPress(object sender, KeyPressEventArgs e)
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

        private void AddProductInventory_KeyPress(object sender, KeyPressEventArgs e)
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

        private void AddProductCost_KeyPress(object sender, KeyPressEventArgs e)
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
                char[] tempArray = AddProductCost.Text.ToCharArray();

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

        private void AddProductMax_KeyPress(object sender, KeyPressEventArgs e)
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

        private void AddProductMin_KeyPress(object sender, KeyPressEventArgs e)
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
