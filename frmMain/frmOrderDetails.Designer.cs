
namespace SalesWinApp
{
    partial class frmOrderDetails
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
            this.txtFreight = new System.Windows.Forms.TextBox();
            this.txtShippedDate = new System.Windows.Forms.TextBox();
            this.txtRequiredDate = new System.Windows.Forms.TextBox();
            this.txtOrderDate = new System.Windows.Forms.TextBox();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.lbFreight = new System.Windows.Forms.Label();
            this.lbShippedDate = new System.Windows.Forms.Label();
            this.lbRequiredDate = new System.Windows.Forms.Label();
            this.lbOrderDate = new System.Windows.Forms.Label();
            this.lbMemberID = new System.Windows.Forms.Label();
            this.lbOrderID = new System.Windows.Forms.Label();
            this.dgvOrderDetailList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetailList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(559, 404);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 41;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(446, 404);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 40;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtFreight
            // 
            this.txtFreight.Location = new System.Drawing.Point(424, 110);
            this.txtFreight.Name = "txtFreight";
            this.txtFreight.Size = new System.Drawing.Size(210, 23);
            this.txtFreight.TabIndex = 39;
            // 
            // txtShippedDate
            // 
            this.txtShippedDate.Location = new System.Drawing.Point(424, 63);
            this.txtShippedDate.Name = "txtShippedDate";
            this.txtShippedDate.Size = new System.Drawing.Size(210, 23);
            this.txtShippedDate.TabIndex = 38;
            // 
            // txtRequiredDate
            // 
            this.txtRequiredDate.Location = new System.Drawing.Point(424, 19);
            this.txtRequiredDate.Name = "txtRequiredDate";
            this.txtRequiredDate.Size = new System.Drawing.Size(210, 23);
            this.txtRequiredDate.TabIndex = 37;
            // 
            // txtOrderDate
            // 
            this.txtOrderDate.Location = new System.Drawing.Point(95, 110);
            this.txtOrderDate.Name = "txtOrderDate";
            this.txtOrderDate.Size = new System.Drawing.Size(210, 23);
            this.txtOrderDate.TabIndex = 36;
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(95, 63);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(210, 23);
            this.txtMemberID.TabIndex = 35;
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(95, 21);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(210, 23);
            this.txtOrderID.TabIndex = 34;
            // 
            // lbFreight
            // 
            this.lbFreight.AutoSize = true;
            this.lbFreight.Location = new System.Drawing.Point(337, 113);
            this.lbFreight.Name = "lbFreight";
            this.lbFreight.Size = new System.Drawing.Size(44, 15);
            this.lbFreight.TabIndex = 33;
            this.lbFreight.Text = "Freight";
            // 
            // lbShippedDate
            // 
            this.lbShippedDate.AutoSize = true;
            this.lbShippedDate.Location = new System.Drawing.Point(337, 66);
            this.lbShippedDate.Name = "lbShippedDate";
            this.lbShippedDate.Size = new System.Drawing.Size(77, 15);
            this.lbShippedDate.TabIndex = 32;
            this.lbShippedDate.Text = "Shipped Date";
            // 
            // lbRequiredDate
            // 
            this.lbRequiredDate.AutoSize = true;
            this.lbRequiredDate.Location = new System.Drawing.Point(337, 22);
            this.lbRequiredDate.Name = "lbRequiredDate";
            this.lbRequiredDate.Size = new System.Drawing.Size(81, 15);
            this.lbRequiredDate.TabIndex = 31;
            this.lbRequiredDate.Text = "Required Date";
            // 
            // lbOrderDate
            // 
            this.lbOrderDate.AutoSize = true;
            this.lbOrderDate.Location = new System.Drawing.Point(25, 113);
            this.lbOrderDate.Name = "lbOrderDate";
            this.lbOrderDate.Size = new System.Drawing.Size(64, 15);
            this.lbOrderDate.TabIndex = 30;
            this.lbOrderDate.Text = "Order Date";
            // 
            // lbMemberID
            // 
            this.lbMemberID.AutoSize = true;
            this.lbMemberID.Location = new System.Drawing.Point(25, 66);
            this.lbMemberID.Name = "lbMemberID";
            this.lbMemberID.Size = new System.Drawing.Size(66, 15);
            this.lbMemberID.TabIndex = 29;
            this.lbMemberID.Text = "Member ID";
            // 
            // lbOrderID
            // 
            this.lbOrderID.AutoSize = true;
            this.lbOrderID.Location = new System.Drawing.Point(25, 24);
            this.lbOrderID.Name = "lbOrderID";
            this.lbOrderID.Size = new System.Drawing.Size(51, 15);
            this.lbOrderID.TabIndex = 28;
            this.lbOrderID.Text = "Order ID";
            // 
            // dgvOrderDetailList
            // 
            this.dgvOrderDetailList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderDetailList.Location = new System.Drawing.Point(25, 152);
            this.dgvOrderDetailList.Name = "dgvOrderDetailList";
            this.dgvOrderDetailList.RowTemplate.Height = 25;
            this.dgvOrderDetailList.Size = new System.Drawing.Size(609, 236);
            this.dgvOrderDetailList.TabIndex = 42;
            // 
            // frmOrderDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 440);
            this.Controls.Add(this.dgvOrderDetailList);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtFreight);
            this.Controls.Add(this.txtShippedDate);
            this.Controls.Add(this.txtRequiredDate);
            this.Controls.Add(this.txtOrderDate);
            this.Controls.Add(this.txtMemberID);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.lbFreight);
            this.Controls.Add(this.lbShippedDate);
            this.Controls.Add(this.lbRequiredDate);
            this.Controls.Add(this.lbOrderDate);
            this.Controls.Add(this.lbMemberID);
            this.Controls.Add(this.lbOrderID);
            this.Name = "frmOrderDetails";
            this.Text = "frmOrderDetails";
            this.Load += new System.EventHandler(this.frmOrderDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetailList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtFreight;
        private System.Windows.Forms.TextBox txtShippedDate;
        private System.Windows.Forms.TextBox txtRequiredDate;
        private System.Windows.Forms.TextBox txtOrderDate;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Label lbFreight;
        private System.Windows.Forms.Label lbShippedDate;
        private System.Windows.Forms.Label lbRequiredDate;
        private System.Windows.Forms.Label lbOrderDate;
        private System.Windows.Forms.Label lbMemberID;
        private System.Windows.Forms.Label lbOrderID;
        private System.Windows.Forms.DataGridView dgvOrderDetailList;
    }
}