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
    public partial class frmOrderDetails : Form
    {
        BindingSource source;

        public frmOrderDetails()
        {
            InitializeComponent();
        }

        private IOrderDetailRepository orderDetailRepository = new OrderDetailRepository();
        public IOrderRepository orderRepository { get; set; }
        public bool InsertOrUpdate { get; set; }
        public OrderObject OrderInfo { get; set; }

        private void frmOrderDetails_Load(object sender, EventArgs e)
        {
            txtOrderID.Enabled = !InsertOrUpdate;
            if(InsertOrUpdate == true)
            {
                txtOrderID.Text = OrderInfo.OrderId.ToString();
                txtMemberID.Text = OrderInfo.MemberId.ToString();
                txtOrderDate.Text = OrderInfo.OrderDate.ToString();
                txtRequiredDate.Text = OrderInfo.RequiredDate.ToString();
                txtShippedDate.Text = OrderInfo.ShippedDate.ToString();
                txtFreight.Text = OrderInfo.Freight.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var order = new OrderObject
                {
                    OrderId = int.Parse(txtOrderID.Text),
                    MemberId = int.Parse(txtMemberID.Text),
                    OrderDate = DateTime.Parse(txtOrderDate.Text),
                    RequiredDate = DateTime.Parse(txtRequiredDate.Text),
                    ShippedDate = DateTime.Parse(txtShippedDate.Text),
                    Freight = decimal.Parse(txtFreight.Text)
                };
                if (InsertOrUpdate == false)
                {
                    orderRepository.InsertOrder(order);
                }
                else
                {
                    orderRepository.UpdateOrder(order);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add a new order" : "Update a order");
            }
        }

        private void btnClose_Click(object sender, EventArgs e) => Close();

        public void LoadMemberList()
        {
            var orderDetails = orderDetailRepository.GetOrderDetailsList(OrderInfo.OrderId);
            try
            {
                source = new BindingSource();
                source.DataSource = orderDetails;

                dgvOrderDetailList.DataSource = null;
                dgvOrderDetailList.DataSource = source;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load order details list");
            }
        }
    }
}
