namespace InventoryManagementSystem
{
    partial class MainScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.ProductsLabel = new System.Windows.Forms.Label();
            this.SearchProductsButton = new System.Windows.Forms.Button();
            this.SearchBarProducts = new System.Windows.Forms.TextBox();
            this.PartsGrid = new System.Windows.Forms.DataGridView();
            this.ProductsGrid = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.AddPartButton = new System.Windows.Forms.Button();
            this.ModifyPartButton = new System.Windows.Forms.Button();
            this.DeletePartButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.AddProductButton = new System.Windows.Forms.Button();
            this.ModifyProductButton = new System.Windows.Forms.Button();
            this.ExitMain = new System.Windows.Forms.Button();
            this.DeleteProductButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.InventoryManagementSystem = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.SearchBarParts = new System.Windows.Forms.TextBox();
            this.SearchPartsButton = new System.Windows.Forms.Button();
            this.PartsLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PartsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGrid)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.PartsGrid, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ProductsGrid, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1822, 689);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.12072F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.04024F));
            this.tableLayoutPanel5.Controls.Add(this.ProductsLabel, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.SearchProductsButton, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.SearchBarProducts, 2, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(911, 0);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(911, 172);
            this.tableLayoutPanel5.TabIndex = 4;
            // 
            // ProductsLabel
            // 
            this.ProductsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ProductsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductsLabel.Location = new System.Drawing.Point(20, 142);
            this.ProductsLabel.Margin = new System.Windows.Forms.Padding(20, 5, 5, 5);
            this.ProductsLabel.Name = "ProductsLabel";
            this.ProductsLabel.Size = new System.Drawing.Size(173, 25);
            this.ProductsLabel.TabIndex = 6;
            this.ProductsLabel.Text = "Products";
            // 
            // SearchProductsButton
            // 
            this.SearchProductsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchProductsButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SearchProductsButton.Enabled = false;
            this.SearchProductsButton.Location = new System.Drawing.Point(464, 126);
            this.SearchProductsButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 10);
            this.SearchProductsButton.Name = "SearchProductsButton";
            this.SearchProductsButton.Size = new System.Drawing.Size(77, 36);
            this.SearchProductsButton.TabIndex = 6;
            this.SearchProductsButton.Text = "Search";
            this.SearchProductsButton.UseVisualStyleBackColor = true;
            this.SearchProductsButton.Click += new System.EventHandler(this.SearchProductsButton_Click);
            // 
            // SearchBarProducts
            // 
            this.SearchBarProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SearchBarProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBarProducts.Location = new System.Drawing.Point(551, 135);
            this.SearchBarProducts.Margin = new System.Windows.Forms.Padding(5, 5, 5, 10);
            this.SearchBarProducts.Name = "SearchBarProducts";
            this.SearchBarProducts.Size = new System.Drawing.Size(340, 27);
            this.SearchBarProducts.TabIndex = 5;            
            this.SearchBarProducts.TextChanged += new System.EventHandler(this.SearchBarProducts_TextChanged);
            this.SearchBarProducts.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchBarProducts_KeyPress);
            // 
            // PartsGrid
            // 
            this.PartsGrid.AllowUserToAddRows = false;
            this.PartsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PartsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PartsGrid.Location = new System.Drawing.Point(20, 177);
            this.PartsGrid.Margin = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.PartsGrid.MultiSelect = false;
            this.PartsGrid.Name = "PartsGrid";
            this.PartsGrid.ReadOnly = true;
            this.PartsGrid.RowHeadersWidth = 51;
            this.PartsGrid.RowTemplate.Height = 24;
            this.PartsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PartsGrid.Size = new System.Drawing.Size(871, 334);
            this.PartsGrid.StandardTab = true;
            this.PartsGrid.TabIndex = 17;
            this.PartsGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PartsGrid_CellClick);
            this.PartsGrid.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.BindingIsComplete);
            this.PartsGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PartsGrid_KeyDown);
            // 
            // ProductsGrid
            // 
            this.ProductsGrid.AllowUserToAddRows = false;
            this.ProductsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductsGrid.Location = new System.Drawing.Point(931, 177);
            this.ProductsGrid.Margin = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.ProductsGrid.MultiSelect = false;
            this.ProductsGrid.Name = "ProductsGrid";
            this.ProductsGrid.ReadOnly = true;
            this.ProductsGrid.RowHeadersWidth = 51;
            this.ProductsGrid.RowTemplate.Height = 24;
            this.ProductsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductsGrid.Size = new System.Drawing.Size(871, 334);
            this.ProductsGrid.StandardTab = true;
            this.ProductsGrid.TabIndex = 7;
            this.ProductsGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductsGrid_CellClick);
            this.ProductsGrid.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.BindingIsComplete);
            this.ProductsGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProductsGrid_KeyDown);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.AddPartButton, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.ModifyPartButton, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.DeletePartButton, 4, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 516);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(911, 173);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // AddPartButton
            // 
            this.AddPartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddPartButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddPartButton.Location = new System.Drawing.Point(462, 5);
            this.AddPartButton.Margin = new System.Windows.Forms.Padding(5, 5, 20, 5);
            this.AddPartButton.Name = "AddPartButton";
            this.AddPartButton.Size = new System.Drawing.Size(64, 36);
            this.AddPartButton.TabIndex = 1;
            this.AddPartButton.Text = "Add";
            this.AddPartButton.UseVisualStyleBackColor = true;
            this.AddPartButton.Click += new System.EventHandler(this.AddPartButton_Click);
            // 
            // ModifyPartButton
            // 
            this.ModifyPartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ModifyPartButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ModifyPartButton.Enabled = false;
            this.ModifyPartButton.Location = new System.Drawing.Point(644, 5);
            this.ModifyPartButton.Margin = new System.Windows.Forms.Padding(5, 5, 20, 5);
            this.ModifyPartButton.Name = "ModifyPartButton";
            this.ModifyPartButton.Size = new System.Drawing.Size(64, 36);
            this.ModifyPartButton.TabIndex = 2;
            this.ModifyPartButton.Text = "Modify";
            this.ModifyPartButton.UseVisualStyleBackColor = true;
            this.ModifyPartButton.Click += new System.EventHandler(this.ModifyPartButton_Click);
            // 
            // DeletePartButton
            // 
            this.DeletePartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeletePartButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DeletePartButton.Enabled = false;
            this.DeletePartButton.Location = new System.Drawing.Point(827, 5);
            this.DeletePartButton.Margin = new System.Windows.Forms.Padding(5, 5, 20, 5);
            this.DeletePartButton.Name = "DeletePartButton";
            this.DeletePartButton.Size = new System.Drawing.Size(64, 36);
            this.DeletePartButton.TabIndex = 3;
            this.DeletePartButton.Text = "Delete";
            this.DeletePartButton.UseVisualStyleBackColor = true;
            this.DeletePartButton.Click += new System.EventHandler(this.DeletePartButton_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.AddProductButton, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.ModifyProductButton, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.ExitMain, 4, 1);
            this.tableLayoutPanel3.Controls.Add(this.DeleteProductButton, 4, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(911, 516);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(911, 173);
            this.tableLayoutPanel3.TabIndex = 8;
            // 
            // AddProductButton
            // 
            this.AddProductButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddProductButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddProductButton.Location = new System.Drawing.Point(462, 5);
            this.AddProductButton.Margin = new System.Windows.Forms.Padding(5, 5, 20, 5);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(64, 36);
            this.AddProductButton.TabIndex = 9;
            this.AddProductButton.Text = "Add";
            this.AddProductButton.UseVisualStyleBackColor = true;
            this.AddProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // ModifyProductButton
            // 
            this.ModifyProductButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ModifyProductButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ModifyProductButton.Enabled = false;
            this.ModifyProductButton.Location = new System.Drawing.Point(644, 5);
            this.ModifyProductButton.Margin = new System.Windows.Forms.Padding(5, 5, 20, 5);
            this.ModifyProductButton.Name = "ModifyProductButton";
            this.ModifyProductButton.Size = new System.Drawing.Size(64, 36);
            this.ModifyProductButton.TabIndex = 10;
            this.ModifyProductButton.Text = "Modify";
            this.ModifyProductButton.UseVisualStyleBackColor = true;
            this.ModifyProductButton.Click += new System.EventHandler(this.ModifyProductButton_Click);
            // 
            // ExitMain
            // 
            this.ExitMain.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ExitMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ExitMain.Location = new System.Drawing.Point(827, 111);
            this.ExitMain.Margin = new System.Windows.Forms.Padding(5, 5, 20, 5);
            this.ExitMain.Name = "ExitMain";
            this.ExitMain.Size = new System.Drawing.Size(64, 36);
            this.ExitMain.TabIndex = 12;
            this.ExitMain.Text = "Exit";
            this.ExitMain.UseVisualStyleBackColor = true;
            this.ExitMain.Click += new System.EventHandler(this.ExitMain_Click);
            // 
            // DeleteProductButton
            // 
            this.DeleteProductButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteProductButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DeleteProductButton.Enabled = false;
            this.DeleteProductButton.Location = new System.Drawing.Point(827, 5);
            this.DeleteProductButton.Margin = new System.Windows.Forms.Padding(5, 5, 20, 5);
            this.DeleteProductButton.Name = "DeleteProductButton";
            this.DeleteProductButton.Size = new System.Drawing.Size(64, 36);
            this.DeleteProductButton.TabIndex = 11;
            this.DeleteProductButton.Text = "Delete";
            this.DeleteProductButton.UseVisualStyleBackColor = true;
            this.DeleteProductButton.Click += new System.EventHandler(this.DeleteProductButton_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.InventoryManagementSystem, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel6, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(911, 172);
            this.tableLayoutPanel4.TabIndex = 13;
            // 
            // InventoryManagementSystem
            // 
            this.InventoryManagementSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InventoryManagementSystem.Location = new System.Drawing.Point(20, 10);
            this.InventoryManagementSystem.Margin = new System.Windows.Forms.Padding(20, 10, 5, 5);
            this.InventoryManagementSystem.Name = "InventoryManagementSystem";
            this.InventoryManagementSystem.Size = new System.Drawing.Size(460, 25);
            this.InventoryManagementSystem.TabIndex = 8;
            this.InventoryManagementSystem.Text = "Inventory Management System";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel6.Controls.Add(this.SearchBarParts, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.SearchPartsButton, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.PartsLabel, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 86);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(911, 86);
            this.tableLayoutPanel6.TabIndex = 14;
            // 
            // SearchBarParts
            // 
            this.SearchBarParts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SearchBarParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBarParts.Location = new System.Drawing.Point(551, 49);
            this.SearchBarParts.Margin = new System.Windows.Forms.Padding(5, 5, 5, 10);
            this.SearchBarParts.Name = "SearchBarParts";
            this.SearchBarParts.Size = new System.Drawing.Size(340, 27);
            this.SearchBarParts.TabIndex = 15;            
            this.SearchBarParts.TextChanged += new System.EventHandler(this.SearchBarParts_TextChanged);
            this.SearchBarParts.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchBarParts_KeyPress);
            // 
            // SearchPartsButton
            // 
            this.SearchPartsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchPartsButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SearchPartsButton.Enabled = false;
            this.SearchPartsButton.Location = new System.Drawing.Point(464, 40);
            this.SearchPartsButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 10);
            this.SearchPartsButton.Name = "SearchPartsButton";
            this.SearchPartsButton.Size = new System.Drawing.Size(77, 36);
            this.SearchPartsButton.TabIndex = 16;
            this.SearchPartsButton.Text = "Search";
            this.SearchPartsButton.UseVisualStyleBackColor = true;
            this.SearchPartsButton.Click += new System.EventHandler(this.SearchPartsButton_Click);
            // 
            // PartsLabel
            // 
            this.PartsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PartsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartsLabel.Location = new System.Drawing.Point(20, 56);
            this.PartsLabel.Margin = new System.Windows.Forms.Padding(20, 5, 5, 5);
            this.PartsLabel.Name = "PartsLabel";
            this.PartsLabel.Size = new System.Drawing.Size(173, 25);
            this.PartsLabel.TabIndex = 7;
            this.PartsLabel.Text = "Parts";
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1822, 689);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Screen";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PartsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGrid)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView PartsGrid;
        private System.Windows.Forms.DataGridView ProductsGrid;
        private System.Windows.Forms.Button AddPartButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button ModifyPartButton;
        private System.Windows.Forms.Button DeletePartButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button AddProductButton;
        private System.Windows.Forms.Button ModifyProductButton;
        private System.Windows.Forms.Button DeleteProductButton;
        private System.Windows.Forms.Button ExitMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label ProductsLabel;
        private System.Windows.Forms.Button SearchProductsButton;
        private System.Windows.Forms.TextBox SearchBarProducts;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label InventoryManagementSystem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TextBox SearchBarParts;
        private System.Windows.Forms.Button SearchPartsButton;
        private System.Windows.Forms.Label PartsLabel;
    }
}

