
namespace SalesWinApp
{
    partial class frmProducts
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchUnitsInStock = new System.Windows.Forms.TextBox();
            this.txtSearchUnitPrice = new System.Windows.Forms.TextBox();
            this.txtSearchProductName = new System.Windows.Forms.TextBox();
            this.txtSearchProductID = new System.Windows.Forms.TextBox();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.txtCategoryID = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtUnitsInStock = new System.Windows.Forms.TextBox();
            this.lbProductName = new System.Windows.Forms.Label();
            this.lbCategoryID = new System.Windows.Forms.Label();
            this.lbProductID = new System.Windows.Forms.Label();
            this.lbWeight = new System.Windows.Forms.Label();
            this.lbUnitPrice = new System.Windows.Forms.Label();
            this.lbUnitsInStock = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvProductList = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.lbSearchProductID = new System.Windows.Forms.Label();
            this.lbSearchProductName = new System.Windows.Forms.Label();
            this.lbSearchUnitPrice = new System.Windows.Forms.Label();
            this.lbSearchUnitlnStock = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(651, 256);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 22;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchUnitsInStock
            // 
            this.txtSearchUnitsInStock.Location = new System.Drawing.Point(524, 256);
            this.txtSearchUnitsInStock.Name = "txtSearchUnitsInStock";
            this.txtSearchUnitsInStock.Size = new System.Drawing.Size(100, 23);
            this.txtSearchUnitsInStock.TabIndex = 21;
            // 
            // txtSearchUnitPrice
            // 
            this.txtSearchUnitPrice.Location = new System.Drawing.Point(357, 256);
            this.txtSearchUnitPrice.Name = "txtSearchUnitPrice";
            this.txtSearchUnitPrice.Size = new System.Drawing.Size(100, 23);
            this.txtSearchUnitPrice.TabIndex = 20;
            // 
            // txtSearchProductName
            // 
            this.txtSearchProductName.Location = new System.Drawing.Point(192, 256);
            this.txtSearchProductName.Name = "txtSearchProductName";
            this.txtSearchProductName.Size = new System.Drawing.Size(100, 23);
            this.txtSearchProductName.TabIndex = 19;
            // 
            // txtSearchProductID
            // 
            this.txtSearchProductID.Location = new System.Drawing.Point(36, 257);
            this.txtSearchProductID.Name = "txtSearchProductID";
            this.txtSearchProductID.Size = new System.Drawing.Size(100, 23);
            this.txtSearchProductID.TabIndex = 18;
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(147, 50);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.ReadOnly = true;
            this.txtProductID.Size = new System.Drawing.Size(188, 23);
            this.txtProductID.TabIndex = 34;
            // 
            // txtCategoryID
            // 
            this.txtCategoryID.Location = new System.Drawing.Point(147, 100);
            this.txtCategoryID.Name = "txtCategoryID";
            this.txtCategoryID.ReadOnly = true;
            this.txtCategoryID.Size = new System.Drawing.Size(188, 23);
            this.txtCategoryID.TabIndex = 33;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(147, 153);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.ReadOnly = true;
            this.txtProductName.Size = new System.Drawing.Size(188, 23);
            this.txtProductName.TabIndex = 32;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(471, 50);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.ReadOnly = true;
            this.txtWeight.Size = new System.Drawing.Size(193, 23);
            this.txtWeight.TabIndex = 31;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(471, 100);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.ReadOnly = true;
            this.txtUnitPrice.Size = new System.Drawing.Size(193, 23);
            this.txtUnitPrice.TabIndex = 30;
            // 
            // txtUnitsInStock
            // 
            this.txtUnitsInStock.Location = new System.Drawing.Point(471, 153);
            this.txtUnitsInStock.Name = "txtUnitsInStock";
            this.txtUnitsInStock.ReadOnly = true;
            this.txtUnitsInStock.Size = new System.Drawing.Size(193, 23);
            this.txtUnitsInStock.TabIndex = 29;
            // 
            // lbProductName
            // 
            this.lbProductName.AutoSize = true;
            this.lbProductName.Location = new System.Drawing.Point(24, 161);
            this.lbProductName.Name = "lbProductName";
            this.lbProductName.Size = new System.Drawing.Size(84, 15);
            this.lbProductName.TabIndex = 28;
            this.lbProductName.Text = "Product Name";
            // 
            // lbCategoryID
            // 
            this.lbCategoryID.AutoSize = true;
            this.lbCategoryID.Location = new System.Drawing.Point(24, 108);
            this.lbCategoryID.Name = "lbCategoryID";
            this.lbCategoryID.Size = new System.Drawing.Size(69, 15);
            this.lbCategoryID.TabIndex = 27;
            this.lbCategoryID.Text = "Category ID";
            // 
            // lbProductID
            // 
            this.lbProductID.AutoSize = true;
            this.lbProductID.Location = new System.Drawing.Point(24, 58);
            this.lbProductID.Name = "lbProductID";
            this.lbProductID.Size = new System.Drawing.Size(63, 15);
            this.lbProductID.TabIndex = 26;
            this.lbProductID.Text = "Product ID";
            // 
            // lbWeight
            // 
            this.lbWeight.AutoSize = true;
            this.lbWeight.Location = new System.Drawing.Point(384, 58);
            this.lbWeight.Name = "lbWeight";
            this.lbWeight.Size = new System.Drawing.Size(45, 15);
            this.lbWeight.TabIndex = 25;
            this.lbWeight.Text = "Weight";
            // 
            // lbUnitPrice
            // 
            this.lbUnitPrice.AutoSize = true;
            this.lbUnitPrice.Location = new System.Drawing.Point(384, 108);
            this.lbUnitPrice.Name = "lbUnitPrice";
            this.lbUnitPrice.Size = new System.Drawing.Size(55, 15);
            this.lbUnitPrice.TabIndex = 24;
            this.lbUnitPrice.Text = "UnitPrice";
            // 
            // lbUnitsInStock
            // 
            this.lbUnitsInStock.AutoSize = true;
            this.lbUnitsInStock.Location = new System.Drawing.Point(384, 161);
            this.lbUnitsInStock.Name = "lbUnitsInStock";
            this.lbUnitsInStock.Size = new System.Drawing.Size(73, 15);
            this.lbUnitsInStock.TabIndex = 23;
            this.lbUnitsInStock.Text = "UnitsInStock";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(328, 502);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 36;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvProductList
            // 
            this.dgvProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductList.Location = new System.Drawing.Point(10, 294);
            this.dgvProductList.Name = "dgvProductList";
            this.dgvProductList.ReadOnly = true;
            this.dgvProductList.RowTemplate.Height = 25;
            this.dgvProductList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductList.Size = new System.Drawing.Size(716, 202);
            this.dgvProductList.TabIndex = 35;
            this.dgvProductList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductList_CellDoubleClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(440, 211);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 39;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(317, 211);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 38;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(202, 211);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 37;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // lbSearchProductID
            // 
            this.lbSearchProductID.AutoSize = true;
            this.lbSearchProductID.Location = new System.Drawing.Point(12, 260);
            this.lbSearchProductID.Name = "lbSearchProductID";
            this.lbSearchProductID.Size = new System.Drawing.Size(18, 15);
            this.lbSearchProductID.TabIndex = 40;
            this.lbSearchProductID.Text = "ID";
            // 
            // lbSearchProductName
            // 
            this.lbSearchProductName.AutoSize = true;
            this.lbSearchProductName.Location = new System.Drawing.Point(147, 259);
            this.lbSearchProductName.Name = "lbSearchProductName";
            this.lbSearchProductName.Size = new System.Drawing.Size(39, 15);
            this.lbSearchProductName.TabIndex = 41;
            this.lbSearchProductName.Text = "Name";
            // 
            // lbSearchUnitPrice
            // 
            this.lbSearchUnitPrice.AutoSize = true;
            this.lbSearchUnitPrice.Location = new System.Drawing.Point(317, 259);
            this.lbSearchUnitPrice.Name = "lbSearchUnitPrice";
            this.lbSearchUnitPrice.Size = new System.Drawing.Size(33, 15);
            this.lbSearchUnitPrice.TabIndex = 42;
            this.lbSearchUnitPrice.Text = "Price";
            // 
            // lbSearchUnitlnStock
            // 
            this.lbSearchUnitlnStock.AutoSize = true;
            this.lbSearchUnitlnStock.Location = new System.Drawing.Point(482, 260);
            this.lbSearchUnitlnStock.Name = "lbSearchUnitlnStock";
            this.lbSearchUnitlnStock.Size = new System.Drawing.Size(36, 15);
            this.lbSearchUnitlnStock.TabIndex = 43;
            this.lbSearchUnitlnStock.Text = "Stock";
            // 
            // frmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 535);
            this.Controls.Add(this.lbSearchUnitlnStock);
            this.Controls.Add(this.lbSearchUnitPrice);
            this.Controls.Add(this.lbSearchProductName);
            this.Controls.Add(this.lbSearchProductID);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvProductList);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.txtCategoryID);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.txtUnitsInStock);
            this.Controls.Add(this.lbProductName);
            this.Controls.Add(this.lbCategoryID);
            this.Controls.Add(this.lbProductID);
            this.Controls.Add(this.lbWeight);
            this.Controls.Add(this.lbUnitPrice);
            this.Controls.Add(this.lbUnitsInStock);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchUnitsInStock);
            this.Controls.Add(this.txtSearchUnitPrice);
            this.Controls.Add(this.txtSearchProductName);
            this.Controls.Add(this.txtSearchProductID);
            this.Name = "frmProducts";
            this.Text = "frmProducts";
            this.Load += new System.EventHandler(this.frmProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchUnitsInStock;
        private System.Windows.Forms.TextBox txtSearchUnitPrice;
        private System.Windows.Forms.TextBox txtSearchProductName;
        private System.Windows.Forms.TextBox txtSearchProductID;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.TextBox txtCategoryID;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txtUnitsInStock;
        private System.Windows.Forms.Label lbProductName;
        private System.Windows.Forms.Label lbCategoryID;
        private System.Windows.Forms.Label lbProductID;
        private System.Windows.Forms.Label lbWeight;
        private System.Windows.Forms.Label lbUnitPrice;
        private System.Windows.Forms.Label lbUnitsInStock;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvProductList;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label lbSearchProductID;
        private System.Windows.Forms.Label lbSearchProductName;
        private System.Windows.Forms.Label lbSearchUnitPrice;
        private System.Windows.Forms.Label lbSearchUnitlnStock;
    }
}