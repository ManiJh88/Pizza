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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            NewOrderForm newOrderForm = new NewOrderForm();
            newOrderForm.ShowDialog();
        }

        private void btnOrderList_Click(object sender, EventArgs e)
        {
            OrderListForm orderListForm = new OrderListForm();
            orderListForm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pizzaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PizzaRatingForm pizzaRatingForm = new PizzaRatingForm();
            pizzaRatingForm.ShowDialog();
        }

        private void deliveryBoyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeliveryBoyRatingForm deliveryBoyRatingForm = new DeliveryBoyRatingForm();
            deliveryBoyRatingForm.ShowDialog();
        }
    }
}
