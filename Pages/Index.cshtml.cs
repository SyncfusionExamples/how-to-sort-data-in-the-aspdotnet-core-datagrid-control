using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Dynamic;
namespace DataGrid.Pages
{
    public class OrderDetails
    {
        public static List<OrderDetails> order = new List<OrderDetails>();

        public OrderDetails(int OrderID, string CustomerId, int EmployeeId, double Freight,
            DateTime OrderDate, string ShipCity, string status)
        {
            this.OrderID = OrderID;
            this.CustomerID = CustomerId;
            this.EmployeeID = EmployeeId;
            this.Freight = Freight;
            this.ShipCity = ShipCity;
            this.OrderDate = OrderDate;
            this.Status = status;
        }

        public static List<OrderDetails> GetAllRecords()
        {
            if (order.Count() == 0)
            {
                int code = 100;
                for (int i = 1; i < 3; i++)
                {
                    order.Add(new OrderDetails(code + 1, "BLONP", i + 0, 2.3 * i, new DateTime(2023, 05, 15), "Berlin", "Order Received"));
                    order.Add(new OrderDetails(code + 2, "ANATR", i + 2, 3.3 * i, new DateTime(2022, 04, 04), "Madrid", "Shipped"));
                    order.Add(new OrderDetails(code + 3, "JOE", i + 1, 4.3 * i, new DateTime(2023, 11, 30), "Cholchester", "Out for Delivery"));
                    order.Add(new OrderDetails(code + 4, "ALFKI", i + 3, 5.3 * i, new DateTime(2021, 10, 22), "Marseille", "Delivered"));
                    order.Add(new OrderDetails(code + 5, "BOLID", i + 4, 6.3 * i, new DateTime(2020, 02, 18), "Tsawassen", "Out for Delivery"));
                    order.Add(new OrderDetails(code + 6, "MICHAEL", i + 4, 6.3 * i, new DateTime(2021, 02, 18), "Berlin", "Shipped"));
                    order.Add(new OrderDetails(code + 7, "DANIEL", i + 4, 6.3 * i, new DateTime(2022, 02, 18), "Berlin", "Delivered"));
                    order.Add(new OrderDetails(code + 8, "RICHARD", i + 4, 6.3 * i, new DateTime(2023, 02, 18), "Berlin", "Shipped"));
                    order.Add(new OrderDetails(code + 9, "ANTON", i + 4, 6.3 * i, new DateTime(2022, 02, 18), "Berlin", "Out for Delivery"));
                    code += 9;
                }
            }
            return order;
        }

        public int OrderID { get; set; }
        public string CustomerID { get; set; }
        public int? EmployeeID { get; set; }
        public double? Freight { get; set; }
        public string ShipCity { get; set; }
        public DateTime OrderDate { get; set; }

        public string Status { get; set; }

    }

    public class IndexModel : PageModel
    { 
        public void OnGet()
        {
           
        }
    }
}