// using System.Collections.Generic;

// namespace Tracking.Models
// {
// public class Order
//     {
//         public string OrderName {get; set; }
//         public string OrderDescription {get; set;}

//         public string OrderPrice {get; set; }

//         public int Id {get; set; }

//         private static List<Order> _orderList = new List<Order> { };

//         public Order (string name, string description, string price)
//         {
//             OrderName = name; 
//             OrderDescription = description;
//             OrderPrice = price;
//             Id = _orderList.Count;
//             _orderList.Add(this);
//         }

//         public static List<Order> GetAll()
//         {
//             return _orderList;
//         }

//         public static Order Find(int searchId)
//         {
//             return _orderList[searchId - 1];
//         }

//     }
// }