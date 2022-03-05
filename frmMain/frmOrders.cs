using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessObject;
using DataAccess.Repository;

namespace SalesWinApp
{
    public partial class frmOrders : Form
    {
        public IOrderRepository orderRepository { get; set; }
        public Member isUser { get; set; }
        BindingSource source;

        public frmOrders()
        {
            InitializeComponent();
        }
        
        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadOrderList();
        }
        private void ClearText()
        {
            txtOrderID.Text = string.Empty;
            txtMemberID.Text = string.Empty;
            txtOrderDate.Text = string.Empty;
            txtRequiredDate.Text = string.Empty;
            txtShippedDate.Text = string.Empty;
            txtFreight.Text = string.Empty;
        }

        private OrderObject GetOrderObject()
        {
            OrderObject order = null;
            try
            {
                order = new OrderObject
                {
                    OrderId = int.Parse(txtOrderID.Text),
                    MemberId = int.Parse(txtMemberID.Text),
                    OrderDate = DateTime.Parse(txtOrderDate.Text),
                    RequiredDate = DateTime.Parse(txtRequiredDate.Text),
                    ShippedDate = DateTime.Parse(txtShippedDate.Text),
                    Freight = decimal.Parse(txtFreight.Text)
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Order");
            }
            return order;
        }

        public void LoadOrderList()
        {
            IEnumerable<OrderObject> orders = null;
            if (isUser == null)
                orders = orderRepository.GetOrders();
            else
                orders = orderRepository.GetMemberOrders(isUser.MemberId);
            try
            {
                source = new BindingSource();
                source.DataSource = orders;

                txtOrderID.DataBindings.Clear();
                txtMemberID.DataBindings.Clear();
                txtOrderDate.DataBindings.Clear();
                txtRequiredDate.DataBindings.Clear();
                txtShippedDate.DataBindings.Clear();
                txtFreight.DataBindings.Clear();

                txtOrderID.DataBindings.Add("Text", source, "OrderID");
                txtMemberID.DataBindings.Add("Text", source, "MemberID");
                txtOrderDate.DataBindings.Add("Text", source, "OrderDate");
                txtRequiredDate.DataBindings.Add("Text", source, "RequiredDate");
                txtShippedDate.DataBindings.Add("Text", source, "ShippedDate");
                txtFreight.DataBindings.Add("Text", source, "Freight");

                dgvOrderList.DataSource = null;
                dgvOrderList.DataSource = source;
                if (orders.Count() == 0)
                {
                    ClearText();
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load product list");
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmOrderDetails frmOrderDetails = new frmOrderDetails
            {
                Text = "Add order",
                InsertOrUpdate = false,
                orderRepository = orderRepository
            };
            if (frmOrderDetails.ShowDialog() == DialogResult.OK)
            {
                LoadOrderList();
                source.Position = source.Count - 1;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var order = GetOrderObject();
                orderRepository.DeleteOrder(order.OrderId);
                LoadOrderList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete a order");
            }
        }
    

        private void btnClose_Click(object sender, EventArgs e) => Close();
        
        private void frmOrders_Load(object sender, EventArgs e)
        {
            if (isUser == null)
            {
                btnDelete.Enabled = false;
                dgvOrderList.CellDoubleClick += dgvOrderList_CellDoubleClick;
            } else
            {
                btnDelete.Visible = false;
                btnNew.Visible = false;
            }
        }

        private void dgvOrderList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmOrderDetails frmOrderDetails = new frmOrderDetails
            {
                Text = "Update order",
                InsertOrUpdate = true,
                OrderInfo = GetOrderObject(),
                orderRepository = orderRepository
            };
            if (frmOrderDetails.ShowDialog() == DialogResult.OK)
            {
                LoadOrderList();
                source.Position = source.Count - 1;
            }
        }
    }
}
