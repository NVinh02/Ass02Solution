using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SalesWinApp;
using BusinessObject;
using DataAccess.Repository;

namespace frmMain
{
    public partial class frmMain : Form
    {
        Member user = null;
        frmLogin login;
        frmMembers members;
        frmProducts products;
        frmOrders orders;
        frmMemberDetails profile;
        IMemberRepository memberRepository = new MemberRepository();
        IProductRepository productRepository = new ProductRepository();
        IOrderRepository orderRepository = new OrderRepository();

        public frmMain()
        {
            InitializeComponent();
            toolLogin.PerformClick();
        }

        private void toolMember_Click(object sender, EventArgs e)
        {
            if(members == null)
            {
                members = new frmMembers
                {
                    memberRepository = memberRepository
                };
                members.MdiParent = this;
                members.FormClosed += Members_FormClosed;
                members.Show();
            }
            else
            {
                members.Activate();
            }
        }

        private void Members_FormClosed(object sender, FormClosedEventArgs e)
        {
            members = null;
        }

        private void toolProduct_Click(object sender, EventArgs e)
        {
            if (products == null)
            {
                products = new frmProducts();
                products.MdiParent = this;
                products.FormClosed += Products_FormClosed;
                products.Show();
            }
            else
            {
                products.Activate();
            }
        }

        private void Products_FormClosed(object sender, FormClosedEventArgs e)
        {
            products = null;
        }

        private void toolOrder_Click(object sender, EventArgs e)
        {
            if(orders == null)
            {
                orders = new frmOrders
                {
                    orderRepository = orderRepository,
                    isUser = null
                };
                orders.MdiParent = this;
                orders.FormClosed += Orders_FormClosed;
                orders.Show();
            }
            else
            {
                orders.Activate();
            }
        }

        private void Orders_FormClosed(object sender, FormClosedEventArgs e)
        {
            orders = null;
        }

        private void toolLogin_Click(object sender, EventArgs e)
        {
            if (login == null)
            {
                login = new frmLogin
                {
                    memberRepository = memberRepository,
                    user = user
                };
                login.MdiParent = this;
                login.FormClosed += Login_FormClosed;
                login.Show();
                if (user == null)
                {
                    toolMember.Visible = false;
                    toolProduct.Visible = false;
                    toolOrder.Visible = false;
                    toolProfile.Visible = false;
                    toolOrderHistory.Visible = false;
                    toolLogout.Visible = false;
                }
            } else
            {
                login.Activate();
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            user = login.user;
            if (user != null)
            {
                if (user.Email.Equals("admin@fstore.com"))
                {
                    toolMember.Visible = true;
                    toolProduct.Visible = true;
                    toolOrder.Visible = true;
                } else
                {
                    toolProfile.Visible = true;
                    toolOrderHistory.Visible = true;
                }
                toolLogout.Visible = true;
                toolLogin.Visible = false;
            }
            login = null;
        }

        private void toolLogout_Click(object sender, EventArgs e)
        {
            user = null;
            members = null;
            products = null;
            orders = null;
            profile = null;
            toolMember.Visible = false;
            toolProduct.Visible = false;
            toolOrder.Visible = false;
            toolProfile.Visible = false;
            toolOrderHistory.Visible = false;
            toolLogin.Visible = true;
            toolLogout.Visible = false;
        }

        private void toolExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolProfile_Click(object sender, EventArgs e)
        {
            if (profile == null)
            {
                profile = new frmMemberDetails
                {
                    MemberRepository = memberRepository,
                    MemberInfo = user,
                    InsertOrUpdate = true
                };
                profile.MdiParent = this;
                profile.FormClosed += Profile_FormClosed;
                profile.Show();
            } else
            {
                profile.Activate();
            }
        }

        private void Profile_FormClosed(object sender, FormClosedEventArgs e)
        {
            profile = null;
        }

        private void toolOrderHistory_Click(object sender, EventArgs e)
        {
            if (orders == null)
            {
                orders = new frmOrders
                {
                    orderRepository = orderRepository,
                    isUser = user
                };
                orders.MdiParent = this;
                orders.FormClosed += Orders_FormClosed;
                orders.Show();
            }
            else
            {
                orders.Activate();
            }
        }
    }
}
