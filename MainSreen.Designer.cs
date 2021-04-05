namespace W.King_c968
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

        #region #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelInventoryManagementSystem = new System.Windows.Forms.Label();
            this.labelParts = new System.Windows.Forms.Label();
            this.labelProducts = new System.Windows.Forms.Label();
            this.buttonPartsSearch = new System.Windows.Forms.Button();
            this.buttonProductsSearch = new System.Windows.Forms.Button();
            this.textBoxPartsSearch = new System.Windows.Forms.TextBox();
            this.textBoxProductsSearch = new System.Windows.Forms.TextBox();
            this.partsControlBox = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonAddPart = new System.Windows.Forms.Button();
            this.buttonModifyPart = new System.Windows.Forms.Button();
            this.buttonDeletePart = new System.Windows.Forms.Button();
            this.productsControlBox = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.buttonModifyProduct = new System.Windows.Forms.Button();
            this.buttonDeleteProduct = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.groupBoxProducts = new System.Windows.Forms.GroupBox();
            this.dataGridViewMainProducts = new System.Windows.Forms.DataGridView();
            this.groupBoxParts = new System.Windows.Forms.GroupBox();
            this.dataGridViewMainParts = new System.Windows.Forms.DataGridView();
            this.partsControlBox.SuspendLayout();
            this.productsControlBox.SuspendLayout();
            this.groupBoxProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMainProducts)).BeginInit();
            this.groupBoxParts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMainParts)).BeginInit();
            this.SuspendLayout();
            // 
            // labelInventoryManagementSystem
            // 
            this.labelInventoryManagementSystem.AutoSize = true;
            this.labelInventoryManagementSystem.Location = new System.Drawing.Point(17, 16);
            this.labelInventoryManagementSystem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInventoryManagementSystem.Name = "labelInventoryManagementSystem";
            this.labelInventoryManagementSystem.Size = new System.Drawing.Size(202, 17);
            this.labelInventoryManagementSystem.TabIndex = 0;
            this.labelInventoryManagementSystem.Text = "Inventory Management System";
            // 
            // labelParts
            // 
            this.labelParts.AutoSize = true;
            this.labelParts.Location = new System.Drawing.Point(58, 106);
            this.labelParts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelParts.Name = "labelParts";
            this.labelParts.Size = new System.Drawing.Size(41, 17);
            this.labelParts.TabIndex = 1;
            this.labelParts.Text = "Parts";
            // 
            // labelProducts
            // 
            this.labelProducts.AutoSize = true;
            this.labelProducts.Location = new System.Drawing.Point(84, 22);
            this.labelProducts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProducts.Name = "labelProducts";
            this.labelProducts.Size = new System.Drawing.Size(64, 17);
            this.labelProducts.TabIndex = 2;
            this.labelProducts.Text = "Products";
            // 
            // buttonPartsSearch
            // 
            this.buttonPartsSearch.Location = new System.Drawing.Point(368, 22);
            this.buttonPartsSearch.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPartsSearch.Name = "buttonPartsSearch";
            this.buttonPartsSearch.Size = new System.Drawing.Size(100, 28);
            this.buttonPartsSearch.TabIndex = 3;
            this.buttonPartsSearch.Text = "Search";
            this.buttonPartsSearch.UseVisualStyleBackColor = true;
            this.buttonPartsSearch.Click += new System.EventHandler(this.buttonPartsSearch_Click);
            // 
            // buttonProductsSearch
            // 
            this.buttonProductsSearch.Location = new System.Drawing.Point(436, 23);
            this.buttonProductsSearch.Margin = new System.Windows.Forms.Padding(4);
            this.buttonProductsSearch.Name = "buttonProductsSearch";
            this.buttonProductsSearch.Size = new System.Drawing.Size(100, 28);
            this.buttonProductsSearch.TabIndex = 4;
            this.buttonProductsSearch.Text = "Search";
            this.buttonProductsSearch.UseVisualStyleBackColor = true;
            this.buttonProductsSearch.Click += new System.EventHandler(this.buttonProductsSearch_Click);
            // 
            // textBoxPartsSearch
            // 
            this.textBoxPartsSearch.Location = new System.Drawing.Point(509, 22);
            this.textBoxPartsSearch.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPartsSearch.Name = "textBoxPartsSearch";
            this.textBoxPartsSearch.Size = new System.Drawing.Size(218, 22);
            this.textBoxPartsSearch.TabIndex = 5;
            this.textBoxPartsSearch.TextChanged += new System.EventHandler(this.textBoxPartsSearch_TextChanged);
            // 
            // textBoxProductsSearch
            // 
            this.textBoxProductsSearch.Location = new System.Drawing.Point(566, 28);
            this.textBoxProductsSearch.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxProductsSearch.Name = "textBoxProductsSearch";
            this.textBoxProductsSearch.Size = new System.Drawing.Size(239, 22);
            this.textBoxProductsSearch.TabIndex = 6;
            this.textBoxProductsSearch.TextChanged += new System.EventHandler(this.textBoxProductsSearch_TextChanged);
            // 
            // partsControlBox
            // 
            this.partsControlBox.Controls.Add(this.buttonAddPart);
            this.partsControlBox.Controls.Add(this.buttonModifyPart);
            this.partsControlBox.Controls.Add(this.buttonDeletePart);
            this.partsControlBox.Location = new System.Drawing.Point(408, 376);
            this.partsControlBox.Margin = new System.Windows.Forms.Padding(4);
            this.partsControlBox.Name = "partsControlBox";
            this.partsControlBox.Size = new System.Drawing.Size(358, 56);
            this.partsControlBox.TabIndex = 9;
            // 
            // buttonAddPart
            // 
            this.buttonAddPart.Location = new System.Drawing.Point(4, 4);
            this.buttonAddPart.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddPart.Name = "buttonAddPart";
            this.buttonAddPart.Size = new System.Drawing.Size(100, 52);
            this.buttonAddPart.TabIndex = 0;
            this.buttonAddPart.Text = "Add";
            this.buttonAddPart.UseVisualStyleBackColor = true;
            this.buttonAddPart.Click += new System.EventHandler(this.buttonAddPart_Click);
            // 
            // buttonModifyPart
            // 
            this.buttonModifyPart.Location = new System.Drawing.Point(112, 4);
            this.buttonModifyPart.Margin = new System.Windows.Forms.Padding(4);
            this.buttonModifyPart.Name = "buttonModifyPart";
            this.buttonModifyPart.Size = new System.Drawing.Size(100, 52);
            this.buttonModifyPart.TabIndex = 1;
            this.buttonModifyPart.Text = "Modify";
            this.buttonModifyPart.UseVisualStyleBackColor = true;
            this.buttonModifyPart.Click += new System.EventHandler(this.buttonModifyPart_Click);
            // 
            // buttonDeletePart
            // 
            this.buttonDeletePart.Location = new System.Drawing.Point(220, 4);
            this.buttonDeletePart.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDeletePart.Name = "buttonDeletePart";
            this.buttonDeletePart.Size = new System.Drawing.Size(100, 52);
            this.buttonDeletePart.TabIndex = 2;
            this.buttonDeletePart.Text = "Delete";
            this.buttonDeletePart.UseVisualStyleBackColor = true;
            this.buttonDeletePart.Click += new System.EventHandler(this.buttonDeletePart_Click);
            // 
            // productsControlBox
            // 
            this.productsControlBox.Controls.Add(this.buttonAddProduct);
            this.productsControlBox.Controls.Add(this.buttonModifyProduct);
            this.productsControlBox.Controls.Add(this.buttonDeleteProduct);
            this.productsControlBox.Location = new System.Drawing.Point(1237, 376);
            this.productsControlBox.Margin = new System.Windows.Forms.Padding(4);
            this.productsControlBox.Name = "productsControlBox";
            this.productsControlBox.Size = new System.Drawing.Size(354, 68);
            this.productsControlBox.TabIndex = 10;
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.Location = new System.Drawing.Point(4, 4);
            this.buttonAddProduct.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(100, 52);
            this.buttonAddProduct.TabIndex = 0;
            this.buttonAddProduct.Text = "Add";
            this.buttonAddProduct.UseVisualStyleBackColor = true;
            this.buttonAddProduct.Click += new System.EventHandler(this.buttonAddProduct_Click);
            // 
            // buttonModifyProduct
            // 
            this.buttonModifyProduct.Location = new System.Drawing.Point(112, 4);
            this.buttonModifyProduct.Margin = new System.Windows.Forms.Padding(4);
            this.buttonModifyProduct.Name = "buttonModifyProduct";
            this.buttonModifyProduct.Size = new System.Drawing.Size(100, 52);
            this.buttonModifyProduct.TabIndex = 1;
            this.buttonModifyProduct.Text = "Modify";
            this.buttonModifyProduct.UseVisualStyleBackColor = true;
            this.buttonModifyProduct.Click += new System.EventHandler(this.buttonModifyProduct_Click);
            // 
            // buttonDeleteProduct
            // 
            this.buttonDeleteProduct.Location = new System.Drawing.Point(220, 4);
            this.buttonDeleteProduct.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDeleteProduct.Name = "buttonDeleteProduct";
            this.buttonDeleteProduct.Size = new System.Drawing.Size(100, 52);
            this.buttonDeleteProduct.TabIndex = 2;
            this.buttonDeleteProduct.Text = "Delete";
            this.buttonDeleteProduct.UseVisualStyleBackColor = true;
            this.buttonDeleteProduct.Click += new System.EventHandler(this.buttonDeleteProduct_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(1424, 486);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(136, 37);
            this.buttonExit.TabIndex = 11;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // groupBoxProducts
            // 
            this.groupBoxProducts.Controls.Add(this.dataGridViewMainProducts);
            this.groupBoxProducts.Controls.Add(this.labelProducts);
            this.groupBoxProducts.Controls.Add(this.textBoxProductsSearch);
            this.groupBoxProducts.Controls.Add(this.buttonProductsSearch);
            this.groupBoxProducts.Location = new System.Drawing.Point(803, 84);
            this.groupBoxProducts.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxProducts.Name = "groupBoxProducts";
            this.groupBoxProducts.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxProducts.Size = new System.Drawing.Size(801, 445);
            this.groupBoxProducts.TabIndex = 12;
            this.groupBoxProducts.TabStop = false;
            this.groupBoxProducts.Enter += new System.EventHandler(this.groupBoxProducts_Enter);
            // 
            // dataGridViewMainProducts
            // 
            this.dataGridViewMainProducts.AllowUserToAddRows = false;
            this.dataGridViewMainProducts.AllowUserToDeleteRows = false;
            this.dataGridViewMainProducts.AllowUserToResizeColumns = false;
            this.dataGridViewMainProducts.AllowUserToResizeRows = false;
            this.dataGridViewMainProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMainProducts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewMainProducts.Location = new System.Drawing.Point(50, 59);
            this.dataGridViewMainProducts.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewMainProducts.MultiSelect = false;
            this.dataGridViewMainProducts.Name = "dataGridViewMainProducts";
            this.dataGridViewMainProducts.RowHeadersVisible = false;
            this.dataGridViewMainProducts.RowHeadersWidth = 51;
            this.dataGridViewMainProducts.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewMainProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMainProducts.Size = new System.Drawing.Size(738, 225);
            this.dataGridViewMainProducts.TabIndex = 0;
            // 
            // groupBoxParts
            // 
            this.groupBoxParts.Controls.Add(this.dataGridViewMainParts);
            this.groupBoxParts.Controls.Add(this.buttonPartsSearch);
            this.groupBoxParts.Controls.Add(this.textBoxPartsSearch);
            this.groupBoxParts.Location = new System.Drawing.Point(20, 84);
            this.groupBoxParts.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxParts.Name = "groupBoxParts";
            this.groupBoxParts.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxParts.Size = new System.Drawing.Size(791, 378);
            this.groupBoxParts.TabIndex = 13;
            this.groupBoxParts.TabStop = false;
            this.groupBoxParts.Enter += new System.EventHandler(this.groupBoxParts_Enter);
            // 
            // dataGridViewMainParts
            // 
            this.dataGridViewMainParts.AllowUserToAddRows = false;
            this.dataGridViewMainParts.AllowUserToDeleteRows = false;
            this.dataGridViewMainParts.AllowUserToResizeColumns = false;
            this.dataGridViewMainParts.AllowUserToResizeRows = false;
            this.dataGridViewMainParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMainParts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewMainParts.Location = new System.Drawing.Point(21, 59);
            this.dataGridViewMainParts.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewMainParts.MultiSelect = false;
            this.dataGridViewMainParts.Name = "dataGridViewMainParts";
            this.dataGridViewMainParts.RowHeadersVisible = false;
            this.dataGridViewMainParts.RowHeadersWidth = 51;
            this.dataGridViewMainParts.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewMainParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMainParts.Size = new System.Drawing.Size(759, 225);
            this.dataGridViewMainParts.TabIndex = 6;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1609, 535);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.productsControlBox);
            this.Controls.Add(this.partsControlBox);
            this.Controls.Add(this.labelParts);
            this.Controls.Add(this.labelInventoryManagementSystem);
            this.Controls.Add(this.groupBoxProducts);
            this.Controls.Add(this.groupBoxParts);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainScreen";
            this.Text = "Main Screen";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.partsControlBox.ResumeLayout(false);
            this.productsControlBox.ResumeLayout(false);
            this.groupBoxProducts.ResumeLayout(false);
            this.groupBoxProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMainProducts)).EndInit();
            this.groupBoxParts.ResumeLayout(false);
            this.groupBoxParts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMainParts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInventoryManagementSystem;
        private System.Windows.Forms.Label labelParts;
        private System.Windows.Forms.Label labelProducts;
        private System.Windows.Forms.Button buttonPartsSearch;
        private System.Windows.Forms.Button buttonProductsSearch;
        private System.Windows.Forms.TextBox textBoxPartsSearch;
        private System.Windows.Forms.TextBox textBoxProductsSearch;
        private System.Windows.Forms.FlowLayoutPanel partsControlBox;
        private System.Windows.Forms.Button buttonAddPart;
        private System.Windows.Forms.Button buttonModifyPart;
        private System.Windows.Forms.Button buttonDeletePart;
        private System.Windows.Forms.FlowLayoutPanel productsControlBox;
        private System.Windows.Forms.Button buttonAddProduct;
        private System.Windows.Forms.Button buttonModifyProduct;
        private System.Windows.Forms.Button buttonDeleteProduct;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.GroupBox groupBoxProducts;
        private System.Windows.Forms.GroupBox groupBoxParts;
        public System.Windows.Forms.DataGridView dataGridViewMainProducts;
        public System.Windows.Forms.DataGridView dataGridViewMainParts;

        public int textBoxPartsSearchText
        {
            get { return int.Parse(textBoxPartsSearch.Text); }
            set { textBoxPartsSearch.Text = value.ToString(); }
        }

        public int textBoxProductsSearchText
        {
            get { return int.Parse(textBoxProductsSearch.Text); }
            set { textBoxProductsSearch.Text = value.ToString(); }
        }
    }
}

