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
    public partial class FrmDeliveryBoyRating : Form
    {
        public FrmDeliveryBoyRating()
        {
            InitializeComponent();
        }

        private void DeliveryBoyRatingForm_Load(object sender, EventArgs e)
        {
            dgvRating.DataSource = DeliveryBoyRatingService.GetRatings();
        }

        private void btnAddRating_Click(object sender, EventArgs e)
        {
            if (cbxDeliveryBoy.SelectedItem != null)
            {
                DeliveryBoyRating deliveryBoyRating = new DeliveryBoyRating()
                {
                    DeliveryBoy = cbxDeliveryBoy.SelectedItem.ToString(),
                    Rating = numRating.Value
                };
                DeliveryBoyRatingService.AddNewRating(deliveryBoyRating);
                dgvRating.DataSource = null;
                dgvRating.DataSource = DeliveryBoyRatingService.GetRatings();
                dgvRating.Refresh();
                MessageBox.Show("Rating is successfully added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Delivery boy is not selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
