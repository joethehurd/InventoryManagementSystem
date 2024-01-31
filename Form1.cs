using InventoryManagementSystem.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class MainScreen : Form
    {
        public static MainScreen instance;

        public MainScreen()
        {
            // check if instance already exists before initializing
            if (instance == null)
            {
                instance = this;
                InitializeComponent();

                // sets data grid views to binding lists
                PartsGrid.DataSource = Inventory.AllParts; 
                ProductsGrid.DataSource = Inventory.Products;               
            }         
            else
            {
                this.Dispose();                
            }
        }

        public void ResetInterface()
        {
            // clears selections
            // disables ui elements required for validation
            // and returns to MainScreen if exiting a sub-screen
           
            PartsGrid.ClearSelection();
            ProductsGrid.ClearSelection();

            PartsGrid.CurrentCell = null;
            ProductsGrid.CurrentCell = null;

            ModifyPartButton.Enabled = false;
            ModifyProductButton.Enabled = false;
            DeletePartButton.Enabled = false;           
            DeleteProductButton.Enabled = false;
            SearchPartsButton.Enabled = false;
            SearchProductsButton.Enabled = false;

            SearchBarParts.Text = String.Empty;
            SearchBarProducts.Text = String.Empty;

            if (this.Visible == false)
            {
                this.Show();
            }           
        }
                
        private void ExitMain_Click(object sender, EventArgs e)
        {
            // closes the Application
            Application.Exit();
        }

        private void AddPartButton_Click(object sender, EventArgs e)
        {            
            // hides the MainScreen
            this.Hide();

            // opens the AddPartScreen          
            AddPartScreen screen = new AddPartScreen();
            screen.ShowDialog();                   
        }     

        private void ModifyPartButton_Click(object sender, EventArgs e)
        {           
            // initializes the ModifyPartScreen     
            ModifyPartScreen screen = new ModifyPartScreen();
                        
            // get the selected part
            Part tempPart = PartsGrid.CurrentRow.DataBoundItem as Part;
            
            // determine if the selected Part is In-House or Outsourced
            if (tempPart.ToString().Contains("Inhouse"))
            {
                Inhouse selectedPart = PartsGrid.CurrentRow.DataBoundItem as Inhouse;

                // prepare properties of selected part for transmission
                int index = PartsGrid.CurrentCell.RowIndex;
                int partID = selectedPart.PartID;
                string name = selectedPart.Name;
                decimal price = selectedPart.Price;
                int inStock = selectedPart.InStock;
                int max = selectedPart.Max;
                int min = selectedPart.Min;
                int machineID = selectedPart.MachineID;

                // pass properties of selected part to ModifyPartScreen
                screen.PopulateInhouseForm(index, partID, name, price, inStock, max, min, machineID);
            }
            else if (tempPart.ToString().Contains("Outsourced"))
            {
                Outsourced selectedPart = PartsGrid.CurrentRow.DataBoundItem as Outsourced;

                // prepare properties of selected part for transmission
                int index = PartsGrid.CurrentCell.RowIndex;
                int partID = selectedPart.PartID;
                string name = selectedPart.Name;
                decimal price = selectedPart.Price;
                int inStock = selectedPart.InStock;
                int max = selectedPart.Max;
                int min = selectedPart.Min;
                string companyName = selectedPart.CompanyName;

                // pass properties of selected part to ModifyPartScreen
                screen.PopulateOutsourcedForm(index, partID, name, price, inStock, max, min, companyName);
            }

            // hides the MainScreen
            this.Hide();

            // opens the ModifyPartScreen     
            screen.ShowDialog();
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            // initializes the AddProductScreen    
            AddProductScreen screen = new AddProductScreen();

            // hides the MainScreen
            this.Hide();

            // create template product                                          
            Inventory.Products.Add(
                new Product { 
                    ProductID = GenerateProductID.AutoIncrement(), 
                    Name = "Default", 
                    Price = 0.00m, 
                    InStock = 0, 
                    Max = 0, 
                    Min = 0
                });

            int index = Inventory.Products.Count - 1;           
            screen.PopulateForm(index);           

            // opens the AddProductScreen                       
            screen.ShowDialog();
        }

        private void ModifyProductButton_Click(object sender, EventArgs e)
        {           
            // initializes the ModifyProductScreen     
            ModifyProductScreen screen = new ModifyProductScreen();

            // get the selected product
            Product selectedProduct = ProductsGrid.CurrentRow.DataBoundItem as Product;

            // prepare properties of selected product for transmission
            int index = ProductsGrid.CurrentCell.RowIndex;
            int productID = selectedProduct.ProductID;
            string name = selectedProduct.Name;
            decimal price = selectedProduct.Price;
            int inStock = selectedProduct.InStock;
            int max = selectedProduct.Max;
            int min = selectedProduct.Min;          

            // pass properties of selected product to ModifyProductScreen
            screen.PopulateForm(index, productID, name, price, inStock, max, min);
                      
            // hides the MainScreen
            this.Hide();

            // opens the ModifyProductScreen                    
            screen.ShowDialog();
        }

        private void BindingIsComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            PartsGrid.ClearSelection();
            ProductsGrid.ClearSelection();
        }

        private void DeletePartButton_Click(object sender, EventArgs e)
        {          
            if (PartsGrid.CurrentRow.Selected == true)
            {
                // confirm deletion
                var confirmDeletion = MessageBox.Show("Are you sure you want to delete this part?",
                                                      "Confirm", MessageBoxButtons.YesNo);
                if (confirmDeletion == DialogResult.Yes)
                {
                    int selectedID = (int)(PartsGrid.CurrentRow.Cells["PartID"].Value);
                    foreach (Part part in Inventory.AllParts)
                    {
                        if (part.PartID == selectedID)
                        {
                            Inventory.AllParts.Remove(part);
                            ResetInterface();
                            return;
                        }
                    }
                }               
            }          
        }
        private void DeleteProductButton_Click(object sender, EventArgs e)
        {                        
            if (ProductsGrid.CurrentRow.Selected == true)
            {
                // confirm deletion
                var confirmDeletion = MessageBox.Show("Are you sure you want to delete this product?",
                                                     "Confirm", MessageBoxButtons.YesNo);
                if (confirmDeletion == DialogResult.Yes)
                {
                    int selectedID = (int)(ProductsGrid.CurrentRow.Cells["ProductID"].Value);
                    foreach (Product product in Inventory.Products)
                    {
                        if (product.ProductID == selectedID)
                        {
                            // check for associated parts
                            bool listIsEmpty = !product.AssociatedParts.Any();
                            {
                                if (listIsEmpty == true)
                                {               
                                    // product does not have associated parts = delete
                                    Inventory.Products.Remove(product);
                                    ResetInterface();
                                    return;                                    
                                }
                                else
                                {
                                    // product has associated parts = cancel
                                    MessageBox.Show("This product cannot be deleted while it has parts associated with it." +
                                                    "\n\n" + "To delete this product, you must first navigate to the Modify Product " +
                                                    "\n" + "menu and remove all associated parts from this product.",
                                                    "Alert");
                                    return;
                                }
                            }                                                                                  
                        }
                    }
                }

               
            }
        }

        private void PartsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (PartsGrid.CurrentRow.Selected == true)
            {              
                ModifyPartButton.Enabled = true;
                DeletePartButton.Enabled = true;              
            }
        }
        private void ProductsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ProductsGrid.CurrentRow.Selected == true)
            {
                ModifyProductButton.Enabled = true;
                DeleteProductButton.Enabled = true;             
            }
        }

        private void SearchBarParts_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SearchBarParts.Text))
            {
                SearchPartsButton.Enabled = false;
            }
            else
            {
                SearchPartsButton.Enabled = true;
            }
        }

        private void SearchBarProducts_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SearchBarProducts.Text))
            {
                SearchProductsButton.Enabled = false;
            }
            else
            {
                SearchProductsButton.Enabled = true;
            }
        }
       
        private void SearchPartsButton_Click(object sender, EventArgs e)
        {
            LookupPart();
        }

        private void SearchProductsButton_Click(object sender, EventArgs e)
        {
            LookupProduct();
        }

        // for confirming a search with a keyboard
        private void SearchBarParts_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (!string.IsNullOrEmpty(SearchBarParts.Text))
                {
                    LookupPart();                   
                }
                else
                {
                    PartsGrid.ClearSelection();                  
                    ModifyPartButton.Enabled = false;
                    DeletePartButton.Enabled = false;
                }

                e.Handled = true;
            }         
        }

        // for confirming a search with a keyboard
        private void SearchBarProducts_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (!string.IsNullOrEmpty(SearchBarProducts.Text))
                {
                    LookupProduct();                    
                }
                else
                {
                    ProductsGrid.ClearSelection();                                     
                    ModifyProductButton.Enabled = false;
                    DeleteProductButton.Enabled = false;
                }

                e.Handled = true;
            }
        }

        public void LookupPart()
        {            
            string searchValue = SearchBarParts.Text;
            bool searchValueFound = false;
            int rowIndex = 0;
            int columnIndex = 0;

            foreach (DataGridViewRow row in PartsGrid.Rows)
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
                PartsGrid.Rows[rowIndex].Selected = true;
                PartsGrid.CurrentCell = PartsGrid.Rows[rowIndex].Cells[columnIndex];           
                ModifyPartButton.Enabled = true;
                DeletePartButton.Enabled = true;
            }
            else
            {
                MessageBox.Show("Part could not be found.", "Alert");
                PartsGrid.ClearSelection();
                PartsGrid.CurrentCell = null;
                SearchBarParts.Text = String.Empty;
                SearchPartsButton.Enabled = false;
                ModifyPartButton.Enabled = false;
                DeletePartButton.Enabled = false;
            }
        }

        public void LookupProduct()
        {           
            string searchValue = SearchBarProducts.Text;
            bool searchValueFound = false;
            int rowIndex = 0;
            int columnIndex = 0;

            foreach (DataGridViewRow row in ProductsGrid.Rows)
            {              
                //search ProductsID
                if (row.Cells[0].Value.ToString().Equals(searchValue))
                {
                    rowIndex = row.Index;
                    columnIndex = 0;
                    searchValueFound = true;
                    break;
                }
                //search ProductsName
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
                ProductsGrid.Rows[rowIndex].Selected = true;
                ProductsGrid.CurrentCell = ProductsGrid.Rows[rowIndex].Cells[columnIndex];
                ModifyProductButton.Enabled = true;
                DeleteProductButton.Enabled = true;
            }
            else
            {
                MessageBox.Show("Product could not be found.", "Alert");
                ProductsGrid.ClearSelection();
                ProductsGrid.CurrentCell = null;
                SearchBarProducts.Text = String.Empty;
                SearchProductsButton.Enabled = false;
                ModifyProductButton.Enabled = false;
                DeleteProductButton.Enabled = false;
            }
        }

        // for navigating the DataGridView with a keyboard
        private void PartsGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (PartsGrid.Rows.Count > 0)
            {
                if (PartsGrid.CurrentCell == null || PartsGrid.Rows.Count == 1)
                {
                    PartsGrid.Rows[0].Selected = true;
                    PartsGrid.CurrentCell = PartsGrid.Rows[0].Cells[0];
                    ProductsGrid.ClearSelection();
                    ModifyPartButton.Enabled = true;
                    DeletePartButton.Enabled = true;
                    ModifyProductButton.Enabled = false;
                    DeleteProductButton.Enabled = false;
                }

                if (e.KeyCode == Keys.Enter)
                {
                    if (PartsGrid.CurrentCell.RowIndex != PartsGrid.Rows.Count - 1)
                    {
                        int rowIndex = PartsGrid.CurrentRow.Index;
                        int columnIndex = PartsGrid.CurrentCell.ColumnIndex;
                        PartsGrid.Rows[rowIndex].Selected = true;
                        PartsGrid.CurrentCell = PartsGrid.Rows[rowIndex].Cells[columnIndex];

                        ProductsGrid.ClearSelection();
                        ModifyPartButton.Enabled = true;
                        DeletePartButton.Enabled = true;
                        ModifyProductButton.Enabled = false;
                        DeleteProductButton.Enabled = false;

                        e.Handled = true;
                    }
                }
                else if (e.KeyCode == Keys.Up)
                {
                    if (PartsGrid.CurrentCell.RowIndex > 0)
                    {
                        int rowIndex = PartsGrid.CurrentRow.Index;
                        int columnIndex = PartsGrid.CurrentCell.ColumnIndex;
                        PartsGrid.Rows[rowIndex - 1].Selected = true;
                        PartsGrid.CurrentCell = PartsGrid.Rows[rowIndex - 1].Cells[columnIndex];

                        ProductsGrid.ClearSelection();
                        ModifyPartButton.Enabled = true;
                        DeletePartButton.Enabled = true;
                        ModifyProductButton.Enabled = false;
                        DeleteProductButton.Enabled = false;

                        e.Handled = true;
                    }
                }
                else if (e.KeyCode == Keys.Down)
                {
                    if (PartsGrid.CurrentCell.RowIndex < PartsGrid.Rows.Count - 1)
                    {
                        int rowIndex = PartsGrid.CurrentRow.Index;
                        int columnIndex = PartsGrid.CurrentCell.ColumnIndex;
                        PartsGrid.Rows[rowIndex + 1].Selected = true;
                        PartsGrid.CurrentCell = PartsGrid.Rows[rowIndex + 1].Cells[columnIndex];

                        ProductsGrid.ClearSelection();
                        ModifyPartButton.Enabled = true;
                        DeletePartButton.Enabled = true;
                        ModifyProductButton.Enabled = false;
                        DeleteProductButton.Enabled = false;

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
        private void ProductsGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (ProductsGrid.Rows.Count > 0)
            {
                if (ProductsGrid.CurrentCell == null || ProductsGrid.Rows.Count == 1)
                {
                    ProductsGrid.Rows[0].Selected = true;
                    ProductsGrid.CurrentCell = ProductsGrid.Rows[0].Cells[0];
                    PartsGrid.ClearSelection();
                    ModifyPartButton.Enabled = false;
                    DeletePartButton.Enabled = false;
                    ModifyProductButton.Enabled = true;
                    DeleteProductButton.Enabled = true;
                }               

                if (e.KeyCode == Keys.Enter)
                {
                    if (ProductsGrid.CurrentCell.RowIndex != ProductsGrid.Rows.Count - 1)
                    {
                        int rowIndex = ProductsGrid.CurrentRow.Index;
                        int columnIndex = ProductsGrid.CurrentCell.ColumnIndex;
                        ProductsGrid.Rows[rowIndex].Selected = true;
                        ProductsGrid.CurrentCell = ProductsGrid.Rows[rowIndex].Cells[columnIndex];

                        PartsGrid.ClearSelection();
                        ModifyPartButton.Enabled = false;
                        DeletePartButton.Enabled = false;
                        ModifyProductButton.Enabled = true;
                        DeleteProductButton.Enabled = true;

                        e.Handled = true;
                    }
                }
                else if (e.KeyCode == Keys.Up)
                {
                    if (ProductsGrid.CurrentCell.RowIndex > 0)
                    {
                        int rowIndex = ProductsGrid.CurrentRow.Index;
                        int columnIndex = ProductsGrid.CurrentCell.ColumnIndex;
                        ProductsGrid.Rows[rowIndex - 1].Selected = true;
                        ProductsGrid.CurrentCell = ProductsGrid.Rows[rowIndex - 1].Cells[columnIndex];

                        PartsGrid.ClearSelection();
                        ModifyPartButton.Enabled = false;
                        DeletePartButton.Enabled = false;
                        ModifyProductButton.Enabled = true;
                        DeleteProductButton.Enabled = true;

                        e.Handled = true;
                    }
                }
                else if (e.KeyCode == Keys.Down)
                {
                    if (ProductsGrid.CurrentCell.RowIndex < ProductsGrid.Rows.Count - 1)
                    {
                        int rowIndex = ProductsGrid.CurrentRow.Index;
                        int columnIndex = ProductsGrid.CurrentCell.ColumnIndex;
                        ProductsGrid.Rows[rowIndex + 1].Selected = true;
                        ProductsGrid.CurrentCell = ProductsGrid.Rows[rowIndex + 1].Cells[columnIndex];

                        PartsGrid.ClearSelection();
                        ModifyPartButton.Enabled = false;
                        DeletePartButton.Enabled = false;
                        ModifyProductButton.Enabled = true;
                        DeleteProductButton.Enabled = true;

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
