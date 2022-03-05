
namespace frmMain
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMember = new System.Windows.Forms.ToolStripMenuItem();
            this.toolProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.toolOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.toolProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolOrderHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.toolExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.toolLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(585, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.toolExit,
            this.toolLogin,
            this.toolLogout});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.fileToolStripMenuItem.Text = "Menu";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolMember,
            this.toolProduct,
            this.toolOrder,
            this.toolProfile,
            this.toolOrderHistory});
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "Open";
            // 
            // toolMember
            // 
            this.toolMember.Name = "toolMember";
            this.toolMember.Size = new System.Drawing.Size(180, 22);
            this.toolMember.Text = "Member";
            this.toolMember.Click += new System.EventHandler(this.toolMember_Click);
            // 
            // toolProduct
            // 
            this.toolProduct.Name = "toolProduct";
            this.toolProduct.Size = new System.Drawing.Size(180, 22);
            this.toolProduct.Text = "Product";
            this.toolProduct.Click += new System.EventHandler(this.toolProduct_Click);
            // 
            // toolOrder
            // 
            this.toolOrder.Name = "toolOrder";
            this.toolOrder.Size = new System.Drawing.Size(180, 22);
            this.toolOrder.Text = "Order";
            this.toolOrder.Click += new System.EventHandler(this.toolOrder_Click);
            // 
            // toolProfile
            // 
            this.toolProfile.Name = "toolProfile";
            this.toolProfile.Size = new System.Drawing.Size(180, 22);
            this.toolProfile.Text = "Profile";
            this.toolProfile.Click += new System.EventHandler(this.toolProfile_Click);
            // 
            // toolOrderHistory
            // 
            this.toolOrderHistory.Name = "toolOrderHistory";
            this.toolOrderHistory.Size = new System.Drawing.Size(180, 22);
            this.toolOrderHistory.Text = "Order History";
            this.toolOrderHistory.Click += new System.EventHandler(this.toolOrderHistory_Click);
            // 
            // toolExit
            // 
            this.toolExit.Name = "toolExit";
            this.toolExit.Size = new System.Drawing.Size(180, 22);
            this.toolExit.Text = "E&xit";
            this.toolExit.Click += new System.EventHandler(this.toolExit_Click);
            // 
            // toolLogin
            // 
            this.toolLogin.Name = "toolLogin";
            this.toolLogin.Size = new System.Drawing.Size(180, 22);
            this.toolLogin.Text = "Login";
            this.toolLogin.Click += new System.EventHandler(this.toolLogin_Click);
            // 
            // toolLogout
            // 
            this.toolLogout.Name = "toolLogout";
            this.toolLogout.Size = new System.Drawing.Size(180, 22);
            this.toolLogout.Text = "Logout";
            this.toolLogout.Click += new System.EventHandler(this.toolLogout_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 323);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolMember;
        private System.Windows.Forms.ToolStripMenuItem toolProduct;
        private System.Windows.Forms.ToolStripMenuItem toolOrder;
        private System.Windows.Forms.ToolStripMenuItem toolExit;
        private System.Windows.Forms.ToolStripMenuItem toolProfile;
        private System.Windows.Forms.ToolStripMenuItem toolOrderHistory;
        private System.Windows.Forms.ToolStripMenuItem toolLogin;
        private System.Windows.Forms.ToolStripMenuItem toolLogout;
    }
}

