namespace InventoryManagementSystem
{
    partial class ModifyProductScreen
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
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ModifyProductID = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.ModifyProductMax = new System.Windows.Forms.TextBox();
            this.ModifyProductName = new System.Windows.Forms.TextBox();
            this.ModifyProductInventory = new System.Windows.Forms.TextBox();
            this.ModifyProductCost = new System.Windows.Forms.TextBox();
            this.ModifyProductMin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SearchCandidatePartsButton = new System.Windows.Forms.Button();
            this.SearchBarCandidateParts = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.AddCandidatePartButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.DeleteAssociatedPartButton = new System.Windows.Forms.Button();
            this.CancelProductButton = new System.Windows.Forms.Button();
            this.SaveProductButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.AssociatedPartsGrid = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CandidatePartsGrid = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ModifyProductLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AssociatedPartsGrid)).BeginInit();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CandidatePartsGrid)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 30);
            this.label8.Margin = new System.Windows.Forms.Padding(20, 5, 5, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(247, 25);
            this.label8.TabIndex = 19;
            this.label8.Text = "All candidate Parts";
            this.label8.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ModifyProductID
            // 
            this.ModifyProductID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ModifyProductID.Enabled = false;
            this.ModifyProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyProductID.Location = new System.Drawing.Point(223, 20);
            this.ModifyProductID.Margin = new System.Windows.Forms.Padding(5);
            this.ModifyProductID.Name = "ModifyProductID";
            this.ModifyProductID.ReadOnly = true;
            this.ModifyProductID.Size = new System.Drawing.Size(178, 27);
            this.ModifyProductID.TabIndex = 0;
            this.ModifyProductID.TabStop = false;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.ModifyProductMax, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(159, 275);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(306, 62);
            this.tableLayoutPanel5.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(256, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Min";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ModifyProductMax
            // 
            this.ModifyProductMax.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ModifyProductMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyProductMax.Location = new System.Drawing.Point(65, 17);
            this.ModifyProductMax.Margin = new System.Windows.Forms.Padding(5, 5, 15, 5);
            this.ModifyProductMax.Name = "ModifyProductMax";
            this.ModifyProductMax.Size = new System.Drawing.Size(89, 27);
            this.ModifyProductMax.TabIndex = 5;
            this.ModifyProductMax.TextChanged += new System.EventHandler(this.ValidateSave);
            this.ModifyProductMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ModifyProductMax_KeyPress);
            // 
            // ModifyProductName
            // 
            this.ModifyProductName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ModifyProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyProductName.Location = new System.Drawing.Point(223, 88);
            this.ModifyProductName.Margin = new System.Windows.Forms.Padding(5);
            this.ModifyProductName.Name = "ModifyProductName";
            this.ModifyProductName.Size = new System.Drawing.Size(178, 27);
            this.ModifyProductName.TabIndex = 1;
            this.ModifyProductName.TextChanged += new System.EventHandler(this.ValidateSave);
            this.ModifyProductName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ModifyProductName_KeyPress);
            // 
            // ModifyProductInventory
            // 
            this.ModifyProductInventory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ModifyProductInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyProductInventory.Location = new System.Drawing.Point(223, 156);
            this.ModifyProductInventory.Margin = new System.Windows.Forms.Padding(5);
            this.ModifyProductInventory.Name = "ModifyProductInventory";
            this.ModifyProductInventory.Size = new System.Drawing.Size(178, 27);
            this.ModifyProductInventory.TabIndex = 2;
            this.ModifyProductInventory.TextChanged += new System.EventHandler(this.ValidateSave);
            this.ModifyProductInventory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ModifyProductInventory_KeyPress);
            // 
            // ModifyProductCost
            // 
            this.ModifyProductCost.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ModifyProductCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyProductCost.Location = new System.Drawing.Point(223, 224);
            this.ModifyProductCost.Margin = new System.Windows.Forms.Padding(5);
            this.ModifyProductCost.Name = "ModifyProductCost";
            this.ModifyProductCost.Size = new System.Drawing.Size(178, 27);
            this.ModifyProductCost.TabIndex = 3;
            this.ModifyProductCost.TextChanged += new System.EventHandler(this.ValidateSave);
            this.ModifyProductCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ModifyProductCost_KeyPress);
            // 
            // ModifyProductMin
            // 
            this.ModifyProductMin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ModifyProductMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyProductMin.Location = new System.Drawing.Point(489, 292);
            this.ModifyProductMin.Margin = new System.Windows.Forms.Padding(5, 5, 30, 5);
            this.ModifyProductMin.Name = "ModifyProductMin";
            this.ModifyProductMin.Size = new System.Drawing.Size(89, 27);
            this.ModifyProductMin.TabIndex = 6;
            this.ModifyProductMin.TextChanged += new System.EventHandler(this.ValidateSave);
            this.ModifyProductMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ModifyProductMin_KeyPress);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 157);
            this.label4.Margin = new System.Windows.Forms.Padding(5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "Inventory";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(48, 225);
            this.label5.Margin = new System.Windows.Forms.Padding(5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 25);
            this.label5.TabIndex = 20;
            this.label5.Text = "Price";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(48, 293);
            this.label7.Margin = new System.Windows.Forms.Padding(5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 25);
            this.label7.TabIndex = 21;
            this.label7.Text = "Max";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SearchCandidatePartsButton
            // 
            this.SearchCandidatePartsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchCandidatePartsButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SearchCandidatePartsButton.Enabled = false;
            this.SearchCandidatePartsButton.Location = new System.Drawing.Point(479, 19);
            this.SearchCandidatePartsButton.Margin = new System.Windows.Forms.Padding(5);
            this.SearchCandidatePartsButton.Name = "SearchCandidatePartsButton";
            this.SearchCandidatePartsButton.Size = new System.Drawing.Size(77, 36);
            this.SearchCandidatePartsButton.TabIndex = 11;
            this.SearchCandidatePartsButton.Text = "Search";
            this.SearchCandidatePartsButton.UseVisualStyleBackColor = true;
            this.SearchCandidatePartsButton.Click += new System.EventHandler(this.SearchCandidatePartsButton_Click);
            // 
            // SearchBarCandidateParts
            // 
            this.SearchBarCandidateParts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SearchBarCandidateParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBarCandidateParts.Location = new System.Drawing.Point(566, 28);
            this.SearchBarCandidateParts.Margin = new System.Windows.Forms.Padding(5);
            this.SearchBarCandidateParts.Name = "SearchBarCandidateParts";
            this.SearchBarCandidateParts.Size = new System.Drawing.Size(330, 27);
            this.SearchBarCandidateParts.TabIndex = 10;
            this.SearchBarCandidateParts.TextChanged += new System.EventHandler(this.SearchBarCandidateParts_TextChanged);
            this.SearchBarCandidateParts.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchBarCandidateParts_KeyPress);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.ModifyProductID, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 1, 4);
            this.tableLayoutPanel4.Controls.Add(this.ModifyProductName, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.ModifyProductInventory, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.ModifyProductCost, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.ModifyProductMin, 2, 4);
            this.tableLayoutPanel4.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.label7, 0, 4);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 6;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(624, 413);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 5);
            this.label9.Margin = new System.Windows.Forms.Padding(20, 5, 5, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(641, 24);
            this.label9.TabIndex = 20;
            this.label9.Text = "Parts Associated with this Product";
            this.label9.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // AddCandidatePartButton
            // 
            this.AddCandidatePartButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AddCandidatePartButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddCandidatePartButton.Enabled = false;
            this.AddCandidatePartButton.Location = new System.Drawing.Point(832, 5);
            this.AddCandidatePartButton.Margin = new System.Windows.Forms.Padding(50, 5, 5, 5);
            this.AddCandidatePartButton.Name = "AddCandidatePartButton";
            this.AddCandidatePartButton.Size = new System.Drawing.Size(64, 36);
            this.AddCandidatePartButton.TabIndex = 15;
            this.AddCandidatePartButton.Text = "Add";
            this.AddCandidatePartButton.UseVisualStyleBackColor = true;
            this.AddCandidatePartButton.Click += new System.EventHandler(this.AddCandidatePartButton_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel6, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel7, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(624, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(936, 689);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel8, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 344);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 3;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(936, 345);
            this.tableLayoutPanel6.TabIndex = 13;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 5;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel8.Controls.Add(this.DeleteAssociatedPartButton, 4, 0);
            this.tableLayoutPanel8.Controls.Add(this.CancelProductButton, 4, 1);
            this.tableLayoutPanel8.Controls.Add(this.SaveProductButton, 3, 1);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(0, 258);
            this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 2;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(936, 87);
            this.tableLayoutPanel8.TabIndex = 19;
            // 
            // DeleteAssociatedPartButton
            // 
            this.DeleteAssociatedPartButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DeleteAssociatedPartButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DeleteAssociatedPartButton.Enabled = false;
            this.DeleteAssociatedPartButton.Location = new System.Drawing.Point(832, 5);
            this.DeleteAssociatedPartButton.Margin = new System.Windows.Forms.Padding(50, 5, 5, 5);
            this.DeleteAssociatedPartButton.Name = "DeleteAssociatedPartButton";
            this.DeleteAssociatedPartButton.Size = new System.Drawing.Size(64, 33);
            this.DeleteAssociatedPartButton.TabIndex = 20;
            this.DeleteAssociatedPartButton.Text = "Delete";
            this.DeleteAssociatedPartButton.UseVisualStyleBackColor = true;
            this.DeleteAssociatedPartButton.Click += new System.EventHandler(this.DeleteAssociatedPartButton_Click);
            // 
            // CancelProductButton
            // 
            this.CancelProductButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CancelProductButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelProductButton.Location = new System.Drawing.Point(832, 48);
            this.CancelProductButton.Margin = new System.Windows.Forms.Padding(50, 5, 5, 5);
            this.CancelProductButton.Name = "CancelProductButton";
            this.CancelProductButton.Size = new System.Drawing.Size(64, 34);
            this.CancelProductButton.TabIndex = 21;
            this.CancelProductButton.Text = "Cancel";
            this.CancelProductButton.UseVisualStyleBackColor = true;
            this.CancelProductButton.Click += new System.EventHandler(this.CancelProductButton_Click);
            // 
            // SaveProductButton
            // 
            this.SaveProductButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveProductButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SaveProductButton.Enabled = false;
            this.SaveProductButton.Location = new System.Drawing.Point(684, 48);
            this.SaveProductButton.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.SaveProductButton.Name = "SaveProductButton";
            this.SaveProductButton.Size = new System.Drawing.Size(64, 34);
            this.SaveProductButton.TabIndex = 22;
            this.SaveProductButton.Text = "Save";
            this.SaveProductButton.UseVisualStyleBackColor = true;
            this.SaveProductButton.Click += new System.EventHandler(this.SaveProductButton_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.AssociatedPartsGrid);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(25, 39);
            this.panel3.Margin = new System.Windows.Forms.Padding(25, 5, 40, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(871, 214);
            this.panel3.TabIndex = 17;
            // 
            // AssociatedPartsGrid
            // 
            this.AssociatedPartsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AssociatedPartsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AssociatedPartsGrid.Location = new System.Drawing.Point(0, 0);
            this.AssociatedPartsGrid.Margin = new System.Windows.Forms.Padding(0);
            this.AssociatedPartsGrid.MultiSelect = false;
            this.AssociatedPartsGrid.Name = "AssociatedPartsGrid";
            this.AssociatedPartsGrid.ReadOnly = true;
            this.AssociatedPartsGrid.RowHeadersWidth = 51;
            this.AssociatedPartsGrid.RowTemplate.Height = 24;
            this.AssociatedPartsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AssociatedPartsGrid.Size = new System.Drawing.Size(871, 214);
            this.AssociatedPartsGrid.StandardTab = true;
            this.AssociatedPartsGrid.TabIndex = 18;
            this.AssociatedPartsGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AssociatedPartsGrid_CellClick);
            this.AssociatedPartsGrid.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.BindingIsComplete);
            this.AssociatedPartsGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AssociatedPartsGrid_KeyDown);
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel9, 0, 2);
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel10, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 3;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.5F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.5F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(936, 344);
            this.tableLayoutPanel7.TabIndex = 8;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 5;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel9.Controls.Add(this.AddCandidatePartButton, 4, 0);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(0, 283);
            this.tableLayoutPanel9.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(936, 61);
            this.tableLayoutPanel9.TabIndex = 14;
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 3;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel10.Controls.Add(this.SearchCandidatePartsButton, 1, 0);
            this.tableLayoutPanel10.Controls.Add(this.SearchBarCandidateParts, 2, 0);
            this.tableLayoutPanel10.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel10.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 1;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(936, 60);
            this.tableLayoutPanel10.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.CandidatePartsGrid);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(25, 65);
            this.panel2.Margin = new System.Windows.Forms.Padding(25, 5, 40, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(871, 213);
            this.panel2.TabIndex = 12;
            // 
            // CandidatePartsGrid
            // 
            this.CandidatePartsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CandidatePartsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CandidatePartsGrid.Location = new System.Drawing.Point(0, 0);
            this.CandidatePartsGrid.Margin = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.CandidatePartsGrid.MultiSelect = false;
            this.CandidatePartsGrid.Name = "CandidatePartsGrid";
            this.CandidatePartsGrid.ReadOnly = true;
            this.CandidatePartsGrid.RowHeadersWidth = 51;
            this.CandidatePartsGrid.RowTemplate.Height = 24;
            this.CandidatePartsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CandidatePartsGrid.Size = new System.Drawing.Size(871, 213);
            this.CandidatePartsGrid.StandardTab = true;
            this.CandidatePartsGrid.TabIndex = 13;
            this.CandidatePartsGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CandidatePartsGrid_CellClick);
            this.CandidatePartsGrid.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.BindingIsComplete);
            this.CandidatePartsGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CandidatePartsGrid_KeyDown);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 689F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1560, 689);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.ModifyProductLabel, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(624, 689);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 172);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(624, 413);
            this.panel1.TabIndex = 0;
            // 
            // ModifyProductLabel
            // 
            this.ModifyProductLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyProductLabel.Location = new System.Drawing.Point(10, 10);
            this.ModifyProductLabel.Margin = new System.Windows.Forms.Padding(10, 10, 5, 5);
            this.ModifyProductLabel.Name = "ModifyProductLabel";
            this.ModifyProductLabel.Size = new System.Drawing.Size(425, 148);
            this.ModifyProductLabel.TabIndex = 9;
            this.ModifyProductLabel.Text = "Modify Product";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(577, -36);
            this.label6.Margin = new System.Windows.Forms.Padding(5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Min";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ModifyProductScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1560, 689);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ModifyProductScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Product";
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AssociatedPartsGrid)).EndInit();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel10.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CandidatePartsGrid)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ModifyProductID;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ModifyProductMax;
        private System.Windows.Forms.TextBox ModifyProductName;
        private System.Windows.Forms.TextBox ModifyProductInventory;
        private System.Windows.Forms.TextBox ModifyProductCost;
        private System.Windows.Forms.TextBox ModifyProductMin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button SearchCandidatePartsButton;
        private System.Windows.Forms.TextBox SearchBarCandidateParts;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button AddCandidatePartButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Button DeleteAssociatedPartButton;
        private System.Windows.Forms.Button CancelProductButton;
        private System.Windows.Forms.Button SaveProductButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView AssociatedPartsGrid;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView CandidatePartsGrid;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ModifyProductLabel;
        private System.Windows.Forms.Label label6;
    }
}