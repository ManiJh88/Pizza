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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            FrmNewOrder newOrderForm = new FrmNewOrder();
            newOrderForm.ShowDialog();
        }

        private void btnOrderList_Click(object sender, EventArgs e)
        {
            FrmOrderList orderListForm = new FrmOrderList();
            orderListForm.ShowDialog();
        }

        private void tsmiPizza_Click(object sender, EventArgs e)
        {
            FrmPizzaRating pizzaRatingForm = new FrmPizzaRating();
            pizzaRatingForm.ShowDialog();
        }

        private void tsmiDeliveryBoy_Click(object sender, EventArgs e)
        {
            FrmDeliveryBoyRating deliveryBoyRatingForm = new FrmDeliveryBoyRating();
            deliveryBoyRatingForm.ShowDialog();
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to exit?", "Question", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
