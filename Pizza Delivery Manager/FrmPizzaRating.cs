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
    public partial class FrmPizzaRating : Form
    {
        public FrmPizzaRating()
        {
            InitializeComponent();
        }

        private void PizzaRatingForm_Load(object sender, EventArgs e)
        {
            dgvRating.DataSource = PizzaRatingService.GetRatings();
        }

        private void btnAddRating_Click(object sender, EventArgs e)
        {
            if (cbxPizza.SelectedItem != null)
            {
                PizzaRating pizzaRating = new PizzaRating()
                {
                    Pizza = cbxPizza.SelectedItem.ToString(),
                    Rating = numRating.Value
                };
                PizzaRatingService.AddNewRating(pizzaRating);
                dgvRating.DataSource = null;
                dgvRating.DataSource = PizzaRatingService.GetRatings();
                dgvRating.Refresh();
                MessageBox.Show("Rating is successfully added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Pizza is not selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
