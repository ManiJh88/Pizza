using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Delivery_Manager
{
    public class OrderService
    {
        public static void PlaceNewOrder(Order order)
        {
            string name = textBox1.Text;
            StreamWriter streamWriter = new StreamWriter("orders.txt", true);
            streamWriter.WriteLine(name + "," +OrderId.ToString() + ", " + order.Type + ", " + order.Size + ", " + order.Topping + ", " + order.Quantity.ToString() + ", " + order.DateTime.ToString() + ", " + order.DeliveryBoy.ToString());
            streamWriter.Close();
        }

        public static List<Order> GetOrders()
        {
            List<Order> orders = new List<Order>();

            StreamReader streamReader = new StreamReader("orders.txt");
            while (true)
            {
                string line = streamReader.ReadLine();


                if (line != null)
                {
                    Order order = new Order()
                    {
                        CustomerName = name,
                        OrderId = Convert.ToInt32(line.Split(',')[0].Trim()),
                        Type = line.Split(',')[1].Trim(),
                        Size = line.Split(',')[2].Trim(),
                        Topping = line.Split(',')[3].Trim(),
                        Quantity = Convert.ToInt32(line.Split(',')[4].Trim()),
                        DateTime = Convert.ToDateTime(line.Split(',')[5].Trim()),
                        DeliveryBoy = line.Split(',')[6].Trim()
                    };

                    orders.Add(order);
                }
                else
                {
                    break;
                }
            }
            streamReader.Close();

            return orders;
        }
    }
}
