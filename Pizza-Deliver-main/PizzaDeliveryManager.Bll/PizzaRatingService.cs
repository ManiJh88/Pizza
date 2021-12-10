using PizzaDeliveryManager.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace PizzaDeliveryManager.Bll
{
    public class PizzaRatingService
    {
        public static void AddNewRating(PizzaRating pizzaRating)
        {
            StreamWriter streamWriter = new StreamWriter("pizzaRatings.txt", true);
            streamWriter.WriteLine(pizzaRating.Pizza + ", " + pizzaRating.Rating.ToString());
            streamWriter.Close();
        }

        public static List<PizzaRating> GetRatings()
        {
            List<PizzaRating> ratings = new List<PizzaRating>();

            StreamReader streamReader = new StreamReader("pizzaRatings.txt");
            while (true)
            {
                string line = streamReader.ReadLine();
                if (line != null)
                {
                    PizzaRating pizzaRating = new PizzaRating()
                    {
                        Pizza = line.Split(',')[0].Trim(),
                        Rating = Convert.ToDecimal(line.Split(',')[1].Trim()),
                    };
                    ratings.Add(pizzaRating);
                }
                else
                {
                    break;
                }
            }
            streamReader.Close();

            return ratings;
        }
    }
}
