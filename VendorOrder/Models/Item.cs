using System.Collections.Generic;

namespace Tracking.Models
{
    public class Vendor
    {
        public string VendorName { get; set; }
        public string Description { get; set; }

        public int Id { get; }
        private static List<Vendor> _vendorList = new List<Vendor> { };

        public Vendor(string vendorName, string description)
        {
            VendorName = vendorName;
            Description = description;
            _vendorList.Add(this);
            Id = _vendorList.Count;
        }

        public static List<Vendor> GetAll()
        {
            return _vendorList;
        }

        public static void ClearAll()
        {
            _vendorList.Clear();
        }

        public static Vendor Show(int search)
        {
            return _vendorList[search - 1];
        }

        public static void DeleteItem(int id)
        {
            for (int i = 0; i < _vendorList.Count; i++)
            {
                if (_vendorList[i].Id == id)
                {
                    _vendorList.Remove(_vendorList[i]);
                }
            }
        }
    }

    public class Order
    {
        public string OrderName {get; set; }
        public string OrderDescription {get; set;}

        public string OrderPrice {get; set; }

        private static List<Order> _orderList = new List<Order> { };

        public Order (string name, string description, string price)
        {
            OrderName = name; 
            OrderDescription = description;
            OrderPrice = price; 
            _orderList.Add(this);
        }

        public static List<Order> GetAll()
        {
            return _orderList;
        }
    }
}