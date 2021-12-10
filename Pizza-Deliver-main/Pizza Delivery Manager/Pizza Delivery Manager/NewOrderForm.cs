using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Delivery_Manager
{
    public partial class NewOrderForm : Form
    {
        public NewOrderForm()
        {
            InitializeComponent();

        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            if (cboType.SelectedItem != null && cboSize.SelectedItem != null && cboTopping.SelectedItem != null && cboDeliveryBoy.SelectedItem!=null)
            {
                Order order = new Order()
                {
                    OrderId = new Random().Next(111111, 999999),
                    Type = cboType.SelectedItem.ToString(),
                    Size = cboSize.SelectedItem.ToString(),
                    Topping = cboTopping.SelectedItem.ToString(),
                    Quantity = Convert.ToInt32(numQuantity.Value),
                    DateTime = DateTime.Now,
                    DeliveryBoy = cboDeliveryBoy.SelectedItem.ToString()
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
    }
}
