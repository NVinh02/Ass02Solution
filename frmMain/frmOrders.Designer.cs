
namespace SalesWinApp
{
    partial class frmOrders
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
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.txtOrderDate = new System.Windows.Forms.TextBox();
            this.txtRequiredDate = new System.Windows.Forms.TextBox();
            this.txtShippedDate = new System.Windows.Forms.TextBox();
            this.txtFreight = new System.Windows.Forms.TextBox();
            this.lbOrderDate = new System.Windows.Forms.Label();
            this.lbMemberID = new System.Windows.Forms.Label();
            this.lbOrderID = new System.Windows.Forms.Label();
            this.lbRequiredDate = new System.Windows.Forms.Label();
            this.lbShippedDate = new System.Windows.Forms.Label();
            this.lbFreight = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvOrderList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).BeginInit();
            this.SuspendLayout();
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(173, 51);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.ReadOnly = true;
            this.txtOrderID.Size = new System.Drawing.Size(188, 23);
            this.txtOrderID.TabIndex = 46;
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(173, 101);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.ReadOnly = true;
            this.txtMemberID.Size = new System.Drawing.Size(188, 23);
            this.txtMemberID.TabIndex = 45;
            // 
            // txtOrderDate
            // 
            this.txtOrderDate.Location = new System.Drawing.Point(173, 154);
            this.txtOrderDate.Name = "txtOrderDate";
            this.txtOrderDate.ReadOnly = true;
            this.txtOrderDate.Size = new System.Drawing.Size(188, 23);
            this.txtOrderDate.TabIndex = 44;
            // 
            // txtRequiredDate
            // 
            this.txtRequiredDate.Location = new System.Drawing.Point(509, 51);
            this.txtRequiredDate.Name = "txtRequiredDate";
            this.txtRequiredDate.ReadOnly = true;
            this.txtRequiredDate.Size = new System.Drawing.Size(193, 23);
            this.txtRequiredDate.TabIndex = 43;
            // 
            // txtShippedDate
            // 
            this.txtShippedDate.Location = new System.Drawing.Point(509, 101);
            this.txtShippedDate.Name = "txtShippedDate";
            this.txtShippedDate.ReadOnly = true;
            this.txtShippedDate.Size = new System.Drawing.Size(193, 23);
            this.txtShippedDate.TabIndex = 42;
            // 
            // txtFreight
            // 
            this.txtFreight.Location = new System.Drawing.Point(509, 154);
            this.txtFreight.Name = "txtFreight";
            this.txtFreight.ReadOnly = true;
            this.txtFreight.Size = new System.Drawing.Size(193, 23);
            this.txtFreight.TabIndex = 41;
            // 
            // lbOrderDate
            // 
            this.lbOrderDate.AutoSize = true;
            this.lbOrderDate.Location = new System.Drawing.Point(50, 162);
            this.lbOrderDate.Name = "lbOrderDate";
            this.lbOrderDate.Size = new System.Drawing.Size(64, 15);
            this.lbOrderDate.TabIndex = 40;
            this.lbOrderDate.Text = "Order Date";
            // 
            // lbMemberID
            // 
            this.lbMemberID.AutoSize = true;
            this.lbMemberID.Location = new System.Drawing.Point(50, 109);
            this.lbMemberID.Name = "lbMemberID";
            this.lbMemberID.Size = new System.Drawing.Size(66, 15);
            this.lbMemberID.TabIndex = 39;
            this.lbMemberID.Text = "Member ID";
            // 
            // lbOrderID
            // 
            this.lbOrderID.AutoSize = true;
            this.lbOrderID.Location = new System.Drawing.Point(50, 59);
            this.lbOrderID.Name = "lbOrderID";
            this.lbOrderID.Size = new System.Drawing.Size(51, 15);
            this.lbOrderID.TabIndex = 38;
            this.lbOrderID.Text = "Order ID";
            // 
            // lbRequiredDate
            // 
            this.lbRequiredDate.AutoSize = true;
            this.lbRequiredDate.Location = new System.Drawing.Point(410, 59);
            this.lbRequiredDate.Name = "lbRequiredDate";
            this.lbRequiredDate.Size = new System.Drawing.Size(81, 15);
            this.lbRequiredDate.TabIndex = 37;
            this.lbRequiredDate.Text = "Required Date";
            // 
            // lbShippedDate
            // 
            this.lbShippedDate.AutoSize = true;
            this.lbShippedDate.Location = new System.Drawing.Point(410, 109);
            this.lbShippedDate.Name = "lbShippedDate";
            this.lbShippedDate.Size = new System.Drawing.Size(77, 15);
            this.lbShippedDate.TabIndex = 36;
            this.lbShippedDate.Text = "Shipped Date";
            // 
            // lbFreight
            // 
            this.lbFreight.AutoSize = true;
            this.lbFreight.Location = new System.Drawing.Point(410, 162);
            this.lbFreight.Name = "lbFreight";
            this.lbFreight.Size = new System.Drawing.Size(44, 15);
            this.lbFreight.TabIndex = 35;
            this.lbFreight.Text = "Freight";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(456, 214);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 49;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(324, 214);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 48;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(195, 214);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 47;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(324, 508);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 51;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvOrderList
            // 
            this.dgvOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderList.Location = new System.Drawing.Point(12, 254);
            this.dgvOrderList.Name = "dgvOrderList";
            this.dgvOrderList.ReadOnly = true;
            this.dgvOrderList.RowTemplate.Height = 25;
            this.dgvOrderList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderList.Size = new System.Drawing.Size(729, 242);
            this.dgvOrderList.TabIndex = 50;
            this.dgvOrderList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderList_CellDoubleClick);
            // 
            // frmOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 543);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvOrderList);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.txtMemberID);
            this.Controls.Add(this.txtOrderDate);
            this.Controls.Add(this.txtRequiredDate);
            this.Controls.Add(this.txtShippedDate);
            this.Controls.Add(this.txtFreight);
            this.Controls.Add(this.lbOrderDate);
            this.Controls.Add(this.lbMemberID);
            this.Controls.Add(this.lbOrderID);
            this.Controls.Add(this.lbRequiredDate);
            this.Controls.Add(this.lbShippedDate);
            this.Controls.Add(this.lbFreight);
            this.Name = "frmOrders";
            this.Text = "frmOrders";
            this.Load += new System.EventHandler(this.frmOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.TextBox txtOrderDate;
        private System.Windows.Forms.TextBox txtRequiredDate;
        private System.Windows.Forms.TextBox txtShippedDate;
        private System.Windows.Forms.TextBox txtFreight;
        private System.Windows.Forms.Label lbOrderDate;
        private System.Windows.Forms.Label lbMemberID;
        private System.Windows.Forms.Label lbOrderID;
        private System.Windows.Forms.Label lbRequiredDate;
        private System.Windows.Forms.Label lbShippedDate;
        private System.Windows.Forms.Label lbFreight;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvOrderList;
    }
}