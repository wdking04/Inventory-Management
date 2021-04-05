namespace W.King_c968
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
            this.labelModifyProduct = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelInventory = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelMax = new System.Windows.Forms.Label();
            this.labelMin = new System.Windows.Forms.Label();
            this.textBoxModifyProductId = new System.Windows.Forms.TextBox();
            this.textBoxModifyProductName = new System.Windows.Forms.TextBox();
            this.textBoxModifyProductInventory = new System.Windows.Forms.TextBox();
            this.textBoxModifyProductPrice = new System.Windows.Forms.TextBox();
            this.textBoxModifyProductMax = new System.Windows.Forms.TextBox();
            this.textboxModifyProductMin = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxModifyProductSearch = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonModifyProductSave = new System.Windows.Forms.Button();
            this.buttonModifyProductCancel = new System.Windows.Forms.Button();
            this.dataGridViewModifyProductAll = new System.Windows.Forms.DataGridView();
            this.dataGridViewModifyProductAssociated = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewModifyProductAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewModifyProductAssociated)).BeginInit();
            this.SuspendLayout();
            // 
            // labelModifyProduct
            // 
            this.labelModifyProduct.AutoSize = true;
            this.labelModifyProduct.Location = new System.Drawing.Point(27, 16);
            this.labelModifyProduct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelModifyProduct.Name = "labelModifyProduct";
            this.labelModifyProduct.Size = new System.Drawing.Size(102, 17);
            this.labelModifyProduct.TabIndex = 0;
            this.labelModifyProduct.Text = "Modify Product";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(58, 149);
            this.labelID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(21, 17);
            this.labelID.TabIndex = 1;
            this.labelID.Text = "ID";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(34, 203);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(45, 17);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Name";
            // 
            // labelInventory
            // 
            this.labelInventory.AutoSize = true;
            this.labelInventory.Location = new System.Drawing.Point(13, 247);
            this.labelInventory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInventory.Name = "labelInventory";
            this.labelInventory.Size = new System.Drawing.Size(66, 17);
            this.labelInventory.TabIndex = 3;
            this.labelInventory.Text = "Inventory";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(39, 299);
            this.labelPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(40, 17);
            this.labelPrice.TabIndex = 4;
            this.labelPrice.Text = "Price";
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.Location = new System.Drawing.Point(46, 356);
            this.labelMax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(33, 17);
            this.labelMax.TabIndex = 5;
            this.labelMax.Text = "Max";
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.Location = new System.Drawing.Point(185, 356);
            this.labelMin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(30, 17);
            this.labelMin.TabIndex = 6;
            this.labelMin.Text = "Min";
            // 
            // textBoxModifyProductId
            // 
            this.textBoxModifyProductId.Location = new System.Drawing.Point(112, 144);
            this.textBoxModifyProductId.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxModifyProductId.Name = "textBoxModifyProductId";
            this.textBoxModifyProductId.ReadOnly = true;
            this.textBoxModifyProductId.Size = new System.Drawing.Size(132, 22);
            this.textBoxModifyProductId.TabIndex = 7;
            // 
            // textBoxModifyProductName
            // 
            this.textBoxModifyProductName.Location = new System.Drawing.Point(112, 203);
            this.textBoxModifyProductName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxModifyProductName.Name = "textBoxModifyProductName";
            this.textBoxModifyProductName.Size = new System.Drawing.Size(132, 22);
            this.textBoxModifyProductName.TabIndex = 8;
            this.textBoxModifyProductName.TextChanged += new System.EventHandler(this.textBoxModifyProductName_TextChanged);
            // 
            // textBoxModifyProductInventory
            // 
            this.textBoxModifyProductInventory.Location = new System.Drawing.Point(112, 247);
            this.textBoxModifyProductInventory.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxModifyProductInventory.Name = "textBoxModifyProductInventory";
            this.textBoxModifyProductInventory.Size = new System.Drawing.Size(132, 22);
            this.textBoxModifyProductInventory.TabIndex = 9;
            this.textBoxModifyProductInventory.TextChanged += new System.EventHandler(this.textBoxModifyProductInventory_TextChanged);
            // 
            // textBoxModifyProductPrice
            // 
            this.textBoxModifyProductPrice.Location = new System.Drawing.Point(112, 299);
            this.textBoxModifyProductPrice.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxModifyProductPrice.Name = "textBoxModifyProductPrice";
            this.textBoxModifyProductPrice.Size = new System.Drawing.Size(132, 22);
            this.textBoxModifyProductPrice.TabIndex = 10;
            this.textBoxModifyProductPrice.TextChanged += new System.EventHandler(this.textBoxModifyProductPrice_TextChanged);
            // 
            // textBoxModifyProductMax
            // 
            this.textBoxModifyProductMax.Location = new System.Drawing.Point(97, 356);
            this.textBoxModifyProductMax.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxModifyProductMax.Name = "textBoxModifyProductMax";
            this.textBoxModifyProductMax.Size = new System.Drawing.Size(65, 22);
            this.textBoxModifyProductMax.TabIndex = 11;
            this.textBoxModifyProductMax.TextChanged += new System.EventHandler(this.textBoxModifyProductMax_TextChanged);
            // 
            // textboxModifyProductMin
            // 
            this.textboxModifyProductMin.Location = new System.Drawing.Point(245, 356);
            this.textboxModifyProductMin.Margin = new System.Windows.Forms.Padding(4);
            this.textboxModifyProductMin.Name = "textboxModifyProductMin";
            this.textboxModifyProductMin.Size = new System.Drawing.Size(65, 22);
            this.textboxModifyProductMin.TabIndex = 12;
            this.textboxModifyProductMin.TextChanged += new System.EventHandler(this.textBoxModifyProductMin_TextChanged);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(547, 16);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(100, 44);
            this.buttonSearch.TabIndex = 15;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxModifyProductSearch
            // 
            this.textBoxModifyProductSearch.Location = new System.Drawing.Point(655, 33);
            this.textBoxModifyProductSearch.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxModifyProductSearch.Name = "textBoxModifyProductSearch";
            this.textBoxModifyProductSearch.Size = new System.Drawing.Size(264, 22);
            this.textBoxModifyProductSearch.TabIndex = 16;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(847, 243);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 45);
            this.buttonAdd.TabIndex = 17;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(847, 471);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(100, 42);
            this.buttonDelete.TabIndex = 18;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonModifyProductSave
            // 
            this.buttonModifyProductSave.Location = new System.Drawing.Point(720, 539);
            this.buttonModifyProductSave.Margin = new System.Windows.Forms.Padding(4);
            this.buttonModifyProductSave.Name = "buttonModifyProductSave";
            this.buttonModifyProductSave.Size = new System.Drawing.Size(100, 40);
            this.buttonModifyProductSave.TabIndex = 19;
            this.buttonModifyProductSave.Text = "Save";
            this.buttonModifyProductSave.UseVisualStyleBackColor = true;
            this.buttonModifyProductSave.Click += new System.EventHandler(this.buttonModifyProductSave_Click);
            // 
            // buttonModifyProductCancel
            // 
            this.buttonModifyProductCancel.Location = new System.Drawing.Point(847, 538);
            this.buttonModifyProductCancel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonModifyProductCancel.Name = "buttonModifyProductCancel";
            this.buttonModifyProductCancel.Size = new System.Drawing.Size(100, 41);
            this.buttonModifyProductCancel.TabIndex = 20;
            this.buttonModifyProductCancel.Text = "Cancel";
            this.buttonModifyProductCancel.UseVisualStyleBackColor = true;
            this.buttonModifyProductCancel.Click += new System.EventHandler(this.buttonModifyProductCancel_Click);
            // 
            // dataGridViewModifyProductAll
            // 
            this.dataGridViewModifyProductAll.AllowUserToAddRows = false;
            this.dataGridViewModifyProductAll.AllowUserToDeleteRows = false;
            this.dataGridViewModifyProductAll.AllowUserToResizeColumns = false;
            this.dataGridViewModifyProductAll.AllowUserToResizeRows = false;
            this.dataGridViewModifyProductAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewModifyProductAll.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewModifyProductAll.Location = new System.Drawing.Point(413, 68);
            this.dataGridViewModifyProductAll.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewModifyProductAll.MultiSelect = false;
            this.dataGridViewModifyProductAll.Name = "dataGridViewModifyProductAll";
            this.dataGridViewModifyProductAll.RowHeadersVisible = false;
            this.dataGridViewModifyProductAll.RowHeadersWidth = 51;
            this.dataGridViewModifyProductAll.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewModifyProductAll.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewModifyProductAll.Size = new System.Drawing.Size(533, 166);
            this.dataGridViewModifyProductAll.TabIndex = 21;
            this.dataGridViewModifyProductAll.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewModifyProductAll_CellContentClick);
            // 
            // dataGridViewModifyProductAssociated
            // 
            this.dataGridViewModifyProductAssociated.AllowUserToAddRows = false;
            this.dataGridViewModifyProductAssociated.AllowUserToDeleteRows = false;
            this.dataGridViewModifyProductAssociated.AllowUserToResizeColumns = false;
            this.dataGridViewModifyProductAssociated.AllowUserToResizeRows = false;
            this.dataGridViewModifyProductAssociated.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewModifyProductAssociated.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewModifyProductAssociated.Location = new System.Drawing.Point(413, 309);
            this.dataGridViewModifyProductAssociated.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewModifyProductAssociated.MultiSelect = false;
            this.dataGridViewModifyProductAssociated.Name = "dataGridViewModifyProductAssociated";
            this.dataGridViewModifyProductAssociated.RowHeadersVisible = false;
            this.dataGridViewModifyProductAssociated.RowHeadersWidth = 51;
            this.dataGridViewModifyProductAssociated.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewModifyProductAssociated.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewModifyProductAssociated.Size = new System.Drawing.Size(533, 148);
            this.dataGridViewModifyProductAssociated.TabIndex = 22;
            // 
            // ModifyProductScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 606);
            this.Controls.Add(this.dataGridViewModifyProductAssociated);
            this.Controls.Add(this.dataGridViewModifyProductAll);
            this.Controls.Add(this.buttonModifyProductCancel);
            this.Controls.Add(this.buttonModifyProductSave);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxModifyProductSearch);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textboxModifyProductMin);
            this.Controls.Add(this.textBoxModifyProductMax);
            this.Controls.Add(this.textBoxModifyProductPrice);
            this.Controls.Add(this.textBoxModifyProductInventory);
            this.Controls.Add(this.textBoxModifyProductName);
            this.Controls.Add(this.textBoxModifyProductId);
            this.Controls.Add(this.labelMin);
            this.Controls.Add(this.labelMax);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelInventory);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.labelModifyProduct);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ModifyProductScreen";
            this.Text = "Modify Product";
            this.Load += new System.EventHandler(this.ModifyProductScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewModifyProductAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewModifyProductAssociated)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelModifyProduct;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelInventory;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.Label labelMin;
        private System.Windows.Forms.TextBox textBoxModifyProductId;
        private System.Windows.Forms.TextBox textBoxModifyProductName;
        private System.Windows.Forms.TextBox textBoxModifyProductInventory;
        private System.Windows.Forms.TextBox textBoxModifyProductPrice;
        private System.Windows.Forms.TextBox textBoxModifyProductMax;
        private System.Windows.Forms.TextBox textboxModifyProductMin;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxModifyProductSearch;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonModifyProductSave;
        private System.Windows.Forms.Button buttonModifyProductCancel;
        private System.Windows.Forms.DataGridView dataGridViewModifyProductAll;
        private System.Windows.Forms.DataGridView dataGridViewModifyProductAssociated;

        public int textBoxModifyProductIdText
        {
            get { return int.Parse(textBoxModifyProductId.Text); }
            set { textBoxModifyProductId.Text = value.ToString(); }
        }
        public string textBoxModifyProductNameText
        {
            get { return textBoxModifyProductName.Text; }
            set { textBoxModifyProductName.Text = value; }
        }
        public int textBoxModifyProductInventoryText
        {
            get { return int.Parse(textBoxModifyProductInventory.Text); }
            set { textBoxModifyProductInventory.Text = value.ToString(); }
        }
        public decimal textBoxModifyProductPriceText
        {
            get { return decimal.Parse(textBoxModifyProductPrice.Text); }
            set { textBoxModifyProductPrice.Text = value.ToString(); }
        }
        public int textBoxModifyProductMaxText
        {
            get { return int.Parse(textBoxModifyProductMax.Text); }
            set { textBoxModifyProductMax.Text = value.ToString(); }
        }
        public int textboxModifyProductMinText
        {
            get { return int.Parse(textboxModifyProductMin.Text); }
            set { textboxModifyProductMin.Text = value.ToString(); }
        }
    }
}

