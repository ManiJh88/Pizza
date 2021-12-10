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
    public partial class PizzaRatingForm : Form
    {
        public PizzaRatingForm()
        {
            InitializeComponent();
        }

        private void PizzaRatingForm_Load(object sender, EventArgs e)
        {
            ratingsDataGridView.DataSource = PizzaRatingService.GetRatings();
        }

        private void btnAddRating_Click(object sender, EventArgs e)
        {
            if (cboPizza.SelectedItem != null)
            {
                PizzaRating pizzaRating = new PizzaRating()
                {
                    Pizza = cboPizza.SelectedItem.ToString(),
                    Rating = numRating.Value
                };
                PizzaRatingService.AddNewRating(pizzaRating);
                ratingsDataGridView.DataSource = null;
                ratingsDataGridView.DataSource = PizzaRatingService.GetRatings();
                ratingsDataGridView.Refresh();
                MessageBox.Show("Rating is successfully added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Pizza is not selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
