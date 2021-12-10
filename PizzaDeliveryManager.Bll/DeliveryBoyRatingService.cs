using PizzaDeliveryManager.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace PizzaDeliveryManager.Bll
{
    public class DeliveryBoyRatingService
    {
        public static void AddNewRating(DeliveryBoyRating deliveryBoyRating)
        {
            StreamWriter streamWriter = new StreamWriter("deliveryBoyRatings.txt", true);
            streamWriter.WriteLine(deliveryBoyRating.DeliveryBoy + ", " + deliveryBoyRating.Rating.ToString());
            streamWriter.Close();
        }

        public static List<DeliveryBoyRating> GetRatings()
        {
            List<DeliveryBoyRating> ratings = new List<DeliveryBoyRating>();

            StreamReader streamReader = new StreamReader("deliveryBoyRatings.txt");
            while (true)
            {
                string line = streamReader.ReadLine();
                if (line != null)
                {
                    DeliveryBoyRating deliveryBoyRating = new DeliveryBoyRating()
                    {
                        DeliveryBoy = line.Split(',')[0].Trim(),
                        Rating = Convert.ToDecimal(line.Split(',')[1].Trim()),
                    };
                    ratings.Add(deliveryBoyRating);
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
