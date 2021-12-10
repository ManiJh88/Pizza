using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PizzaDeliveryManager.Bll;
using PizzaDeliveryManager.Model;

namespace Pizza_Delivery_Manager
{
    public partial class FrmNewOrder : Form
    {
        public FrmNewOrder()
        {
            InitializeComponent();

        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            if (cbxType.SelectedItem != null && cbxSize.SelectedItem != null && cbxTopping.SelectedItem != null && cbxDeliveryBoy.SelectedItem!=null)
            {

                Order order = new Order()
                {
                    CustomerName = txtCustomerName.Text,
                    OrderId = new Random().Next(111111, 999999),
                    Type = cbxType.SelectedItem.ToString(),
                    Size = cbxSize.SelectedItem.ToString(),
                    Topping = cbxTopping.SelectedItem.ToString(),
                    Quantity = Convert.ToInt32(numQuantity.Value),
                    DateTime = DateTime.Now,
                    DeliveryBoy = cbxDeliveryBoy.SelectedItem.ToString()
                };

                OrderService.PlaceNewOrder(order);
                MessageBox.Show("Order is successfully placed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Fileds are not entered correctly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmNewOrder_Load(object sender, EventArgs e)
        {
            cbxType.SelectedIndex = 0;
            cbxDeliveryBoy.SelectedIndex = 0;
            cbxSize.SelectedIndex = 0;
            cbxTopping.SelectedIndex = 0;
        }
    }
}
