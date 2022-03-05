
namespace SalesWinApp
{
    partial class frmProductDetails
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtUnitsInStock = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtCategoryID = new System.Windows.Forms.TextBox();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.lbUnitsInStock = new System.Windows.Forms.Label();
            this.lbUnitPrice = new System.Windows.Forms.Label();
            this.lbWeight = new System.Windows.Forms.Label();
            this.lbProductName = new System.Windows.Forms.Label();
            this.lbCategoryID = new System.Windows.Forms.Label();
            this.lbProductID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(256, 278);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 27;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(121, 278);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtUnitsInStock
            // 
            this.txtUnitsInStock.Location = new System.Drawing.Point(121, 226);
            this.txtUnitsInStock.Name = "txtUnitsInStock";
            this.txtUnitsInStock.Size = new System.Drawing.Size(210, 23);
            this.txtUnitsInStock.TabIndex = 25;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(121, 187);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(210, 23);
            this.txtUnitPrice.TabIndex = 24;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(121, 146);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(210, 23);
            this.txtWeight.TabIndex = 23;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(121, 108);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(210, 23);
            this.txtProductName.TabIndex = 22;
            // 
            // txtCategoryID
            // 
            this.txtCategoryID.Location = new System.Drawing.Point(121, 66);
            this.txtCategoryID.Name = "txtCategoryID";
            this.txtCategoryID.Size = new System.Drawing.Size(210, 23);
            this.txtCategoryID.TabIndex = 21;
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(121, 19);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(210, 23);
            this.txtProductID.TabIndex = 20;
            // 
            // lbUnitsInStock
            // 
            this.lbUnitsInStock.AutoSize = true;
            this.lbUnitsInStock.Location = new System.Drawing.Point(19, 229);
            this.lbUnitsInStock.Name = "lbUnitsInStock";
            this.lbUnitsInStock.Size = new System.Drawing.Size(79, 15);
            this.lbUnitsInStock.TabIndex = 19;
            this.lbUnitsInStock.Text = "Units In Stock";
            // 
            // lbUnitPrice
            // 
            this.lbUnitPrice.AutoSize = true;
            this.lbUnitPrice.Location = new System.Drawing.Point(19, 190);
            this.lbUnitPrice.Name = "lbUnitPrice";
            this.lbUnitPrice.Size = new System.Drawing.Size(58, 15);
            this.lbUnitPrice.TabIndex = 18;
            this.lbUnitPrice.Text = "Unit Price";
            // 
            // lbWeight
            // 
            this.lbWeight.AutoSize = true;
            this.lbWeight.Location = new System.Drawing.Point(19, 149);
            this.lbWeight.Name = "lbWeight";
            this.lbWeight.Size = new System.Drawing.Size(45, 15);
            this.lbWeight.TabIndex = 17;
            this.lbWeight.Text = "Weight";
            // 
            // lbProductName
            // 
            this.lbProductName.AutoSize = true;
            this.lbProductName.Location = new System.Drawing.Point(19, 111);
            this.lbProductName.Name = "lbProductName";
            this.lbProductName.Size = new System.Drawing.Size(84, 15);
            this.lbProductName.TabIndex = 16;
            this.lbProductName.Text = "Product Name";
            // 
            // lbCategoryID
            // 
            this.lbCategoryID.AutoSize = true;
            this.lbCategoryID.Location = new System.Drawing.Point(19, 69);
            this.lbCategoryID.Name = "lbCategoryID";
            this.lbCategoryID.Size = new System.Drawing.Size(69, 15);
            this.lbCategoryID.TabIndex = 15;
            this.lbCategoryID.Text = "Category ID";
            // 
            // lbProductID
            // 
            this.lbProductID.AutoSize = true;
            this.lbProductID.Location = new System.Drawing.Point(19, 22);
            this.lbProductID.Name = "lbProductID";
            this.lbProductID.Size = new System.Drawing.Size(63, 15);
            this.lbProductID.TabIndex = 14;
            this.lbProductID.Text = "Product ID";
            // 
            // frmProductDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 324);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtUnitsInStock);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtCategoryID);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.lbUnitsInStock);
            this.Controls.Add(this.lbUnitPrice);
            this.Controls.Add(this.lbWeight);
            this.Controls.Add(this.lbProductName);
            this.Controls.Add(this.lbCategoryID);
            this.Controls.Add(this.lbProductID);
            this.Name = "frmProductDetails";
            this.Text = "frmProductDetails";
            this.Load += new System.EventHandler(this.frmProductDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtUnitsInStock;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtCategoryID;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label lbUnitsInStock;
        private System.Windows.Forms.Label lbUnitPrice;
        private System.Windows.Forms.Label lbWeight;
        private System.Windows.Forms.Label lbProductName;
        private System.Windows.Forms.Label lbCategoryID;
        private System.Windows.Forms.Label lbProductID;
    }
}