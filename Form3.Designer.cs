namespace InventoryManagementSystem
{
    partial class ModifyPartScreen
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
            this.label1 = new System.Windows.Forms.Label();
            this.ModifyPartID = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.ModifyPartMax = new System.Windows.Forms.TextBox();
            this.ModifyPartName = new System.Windows.Forms.TextBox();
            this.ModifyPartInventory = new System.Windows.Forms.TextBox();
            this.ModifyPartCost = new System.Windows.Forms.TextBox();
            this.ModifyPartSource = new System.Windows.Forms.TextBox();
            this.ModifyPartMin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PartSourceLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.SavePartButton = new System.Windows.Forms.Button();
            this.CancelPartButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.OutsourcedButton = new System.Windows.Forms.RadioButton();
            this.InHouseButton = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ModifyPartLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ModifyPartID
            // 
            this.ModifyPartID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ModifyPartID.Enabled = false;
            this.ModifyPartID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyPartID.Location = new System.Drawing.Point(157, 19);
            this.ModifyPartID.Margin = new System.Windows.Forms.Padding(5);
            this.ModifyPartID.Name = "ModifyPartID";
            this.ModifyPartID.ReadOnly = true;
            this.ModifyPartID.ShortcutsEnabled = false;
            this.ModifyPartID.Size = new System.Drawing.Size(178, 27);
            this.ModifyPartID.TabIndex = 11;
            this.ModifyPartID.TabStop = false;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.ModifyPartMax, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(126, 267);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(241, 60);
            this.tableLayoutPanel5.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(185, 17);
            this.label6.Margin = new System.Windows.Forms.Padding(5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Min";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ModifyPartMax
            // 
            this.ModifyPartMax.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ModifyPartMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyPartMax.Location = new System.Drawing.Point(33, 16);
            this.ModifyPartMax.Margin = new System.Windows.Forms.Padding(5, 5, 20, 5);
            this.ModifyPartMax.Name = "ModifyPartMax";
            this.ModifyPartMax.ShortcutsEnabled = false;
            this.ModifyPartMax.Size = new System.Drawing.Size(99, 27);
            this.ModifyPartMax.TabIndex = 8;
            this.ModifyPartMax.TextChanged += new System.EventHandler(this.ValidateSave);
            this.ModifyPartMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ModifyPartMax_KeyPress);
            // 
            // ModifyPartName
            // 
            this.ModifyPartName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ModifyPartName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyPartName.Location = new System.Drawing.Point(157, 85);
            this.ModifyPartName.Margin = new System.Windows.Forms.Padding(5);
            this.ModifyPartName.Name = "ModifyPartName";
            this.ModifyPartName.ShortcutsEnabled = false;
            this.ModifyPartName.Size = new System.Drawing.Size(178, 27);
            this.ModifyPartName.TabIndex = 4;
            this.ModifyPartName.TextChanged += new System.EventHandler(this.ValidateSave);
            this.ModifyPartName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ModifyPartName_KeyPress);
            // 
            // ModifyPartInventory
            // 
            this.ModifyPartInventory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ModifyPartInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyPartInventory.Location = new System.Drawing.Point(157, 151);
            this.ModifyPartInventory.Margin = new System.Windows.Forms.Padding(5);
            this.ModifyPartInventory.Name = "ModifyPartInventory";
            this.ModifyPartInventory.ShortcutsEnabled = false;
            this.ModifyPartInventory.Size = new System.Drawing.Size(178, 27);
            this.ModifyPartInventory.TabIndex = 5;
            this.ModifyPartInventory.TextChanged += new System.EventHandler(this.ValidateSave);
            this.ModifyPartInventory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ModifyPartInventory_KeyPress);
            // 
            // ModifyPartCost
            // 
            this.ModifyPartCost.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ModifyPartCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyPartCost.Location = new System.Drawing.Point(157, 217);
            this.ModifyPartCost.Margin = new System.Windows.Forms.Padding(5);
            this.ModifyPartCost.Name = "ModifyPartCost";
            this.ModifyPartCost.ShortcutsEnabled = false;
            this.ModifyPartCost.Size = new System.Drawing.Size(178, 27);
            this.ModifyPartCost.TabIndex = 6;
            this.ModifyPartCost.TextChanged += new System.EventHandler(this.ValidateSave);
            this.ModifyPartCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ModifyPartCost_KeyPress);
            // 
            // ModifyPartSource
            // 
            this.ModifyPartSource.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ModifyPartSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyPartSource.Location = new System.Drawing.Point(157, 349);
            this.ModifyPartSource.Margin = new System.Windows.Forms.Padding(5);
            this.ModifyPartSource.Name = "ModifyPartSource";
            this.ModifyPartSource.ShortcutsEnabled = false;
            this.ModifyPartSource.Size = new System.Drawing.Size(178, 27);
            this.ModifyPartSource.TabIndex = 10;
            this.ModifyPartSource.TextChanged += new System.EventHandler(this.ValidateSave);
            this.ModifyPartSource.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ModifyPartSource_KeyPress);
            // 
            // ModifyPartMin
            // 
            this.ModifyPartMin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ModifyPartMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyPartMin.Location = new System.Drawing.Point(375, 283);
            this.ModifyPartMin.Margin = new System.Windows.Forms.Padding(5, 5, 20, 5);
            this.ModifyPartMin.Name = "ModifyPartMin";
            this.ModifyPartMin.ShortcutsEnabled = false;
            this.ModifyPartMin.Size = new System.Drawing.Size(99, 27);
            this.ModifyPartMin.TabIndex = 9;
            this.ModifyPartMin.TextChanged += new System.EventHandler(this.ValidateSave);
            this.ModifyPartMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ModifyPartMin_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 152);
            this.label3.Margin = new System.Windows.Forms.Padding(5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "Inventory";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 218);
            this.label4.Margin = new System.Windows.Forms.Padding(5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "Price / Cost";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 284);
            this.label5.Margin = new System.Windows.Forms.Padding(5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 25);
            this.label5.TabIndex = 21;
            this.label5.Text = "Max";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PartSourceLabel
            // 
            this.PartSourceLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.PartSourceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartSourceLabel.Location = new System.Drawing.Point(9, 350);
            this.PartSourceLabel.Margin = new System.Windows.Forms.Padding(5);
            this.PartSourceLabel.Name = "PartSourceLabel";
            this.PartSourceLabel.Size = new System.Drawing.Size(109, 25);
            this.PartSourceLabel.TabIndex = 22;
            this.PartSourceLabel.Text = "Machine ID";
            this.PartSourceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.ModifyPartID, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 1, 4);
            this.tableLayoutPanel4.Controls.Add(this.ModifyPartName, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.ModifyPartInventory, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.ModifyPartCost, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.ModifyPartSource, 1, 5);
            this.tableLayoutPanel4.Controls.Add(this.ModifyPartMin, 2, 4);
            this.tableLayoutPanel4.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.PartSourceLabel, 0, 5);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 66);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 6;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(494, 396);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // SavePartButton
            // 
            this.SavePartButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SavePartButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SavePartButton.Enabled = false;
            this.SavePartButton.Location = new System.Drawing.Point(311, 5);
            this.SavePartButton.Margin = new System.Windows.Forms.Padding(5);
            this.SavePartButton.Name = "SavePartButton";
            this.SavePartButton.Size = new System.Drawing.Size(64, 36);
            this.SavePartButton.TabIndex = 12;
            this.SavePartButton.Text = "Save";
            this.SavePartButton.UseVisualStyleBackColor = true;
            this.SavePartButton.Click += new System.EventHandler(this.SavePartButton_Click);
            // 
            // CancelPartButton
            // 
            this.CancelPartButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CancelPartButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelPartButton.Location = new System.Drawing.Point(411, 5);
            this.CancelPartButton.Margin = new System.Windows.Forms.Padding(5);
            this.CancelPartButton.Name = "CancelPartButton";
            this.CancelPartButton.Size = new System.Drawing.Size(64, 36);
            this.CancelPartButton.TabIndex = 13;
            this.CancelPartButton.Text = "Cancel";
            this.CancelPartButton.UseVisualStyleBackColor = true;
            this.CancelPartButton.Click += new System.EventHandler(this.CancelPartButton_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Controls.Add(this.SavePartButton, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.CancelPartButton, 4, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 462);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(494, 67);
            this.tableLayoutPanel3.TabIndex = 11;
            // 
            // OutsourcedButton
            // 
            this.OutsourcedButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.OutsourcedButton.AutoSize = true;
            this.OutsourcedButton.Location = new System.Drawing.Point(284, 10);
            this.OutsourcedButton.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.OutsourcedButton.Name = "OutsourcedButton";
            this.OutsourcedButton.Size = new System.Drawing.Size(97, 20);
            this.OutsourcedButton.TabIndex = 2;
            this.OutsourcedButton.TabStop = true;
            this.OutsourcedButton.Text = "Outsourced";
            this.OutsourcedButton.UseVisualStyleBackColor = true;
            this.OutsourcedButton.CheckedChanged += new System.EventHandler(this.RadioButtonChanged);
            // 
            // InHouseButton
            // 
            this.InHouseButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.InHouseButton.AutoSize = true;
            this.InHouseButton.Location = new System.Drawing.Point(168, 10);
            this.InHouseButton.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.InHouseButton.Name = "InHouseButton";
            this.InHouseButton.Size = new System.Drawing.Size(82, 20);
            this.InHouseButton.TabIndex = 1;
            this.InHouseButton.Text = "In-House";
            this.InHouseButton.UseVisualStyleBackColor = true;
            this.InHouseButton.CheckedChanged += new System.EventHandler(this.RadioButtonChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.OutsourcedButton, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.ModifyPartLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.InHouseButton, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(494, 66);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // ModifyPartLabel
            // 
            this.ModifyPartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyPartLabel.Location = new System.Drawing.Point(10, 10);
            this.ModifyPartLabel.Margin = new System.Windows.Forms.Padding(10, 10, 5, 5);
            this.ModifyPartLabel.Name = "ModifyPartLabel";
            this.ModifyPartLabel.Size = new System.Drawing.Size(133, 51);
            this.ModifyPartLabel.TabIndex = 8;
            this.ModifyPartLabel.Text = "Modify Part";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(494, 529);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // ModifyPartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(494, 529);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ModifyPartScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Part";
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ModifyPartID;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ModifyPartMax;
        private System.Windows.Forms.TextBox ModifyPartName;
        private System.Windows.Forms.TextBox ModifyPartInventory;
        private System.Windows.Forms.TextBox ModifyPartCost;
        private System.Windows.Forms.TextBox ModifyPartSource;
        private System.Windows.Forms.TextBox ModifyPartMin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label PartSourceLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button SavePartButton;
        private System.Windows.Forms.Button CancelPartButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.RadioButton OutsourcedButton;
        private System.Windows.Forms.RadioButton InHouseButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label ModifyPartLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}