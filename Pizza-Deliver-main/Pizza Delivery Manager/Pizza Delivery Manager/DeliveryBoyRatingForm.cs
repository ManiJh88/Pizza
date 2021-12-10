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
    public partial class DeliveryBoyRatingForm : Form
    {
        public DeliveryBoyRatingForm()
        {
            InitializeComponent();
        }

        private void DeliveryBoyRatingForm_Load(object sender, EventArgs e)
        {
            ratingsDataGridView.DataSource = DeliveryBoyRatingService.GetRatings();
        }

        private void btnAddRating_Click(object sender, EventArgs e)
        {
            if (cboDeliveryBoy.SelectedItem != null)
            {
                DeliveryBoyRating deliveryBoyRating = new DeliveryBoyRating()
                {
                    DeliveryBoy = cboDeliveryBoy.SelectedItem.ToString(),
                    Rating = numRating.Value
                };
                DeliveryBoyRatingService.AddNewRating(deliveryBoyRating);
                ratingsDataGridView.DataSource = null;
                ratingsDataGridView.DataSource = DeliveryBoyRatingService.GetRatings();
                ratingsDataGridView.Refresh();
                MessageBox.Show("Rating is successfully added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Delivery boy is not selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
