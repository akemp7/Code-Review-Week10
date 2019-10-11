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

        public static Vendor Find(int search)
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
        public string OrderName { get; set; }
        public string OrderDescription { get; set; }
        public string OrderPrice { get; set; }
        public string OrderDate {get; set; }
        private static List<Order> _orderList = new List<Order> { };

        public Order(string orderName, string description, string price, string date)
        {
           OrderName = orderName;
           OrderDescription = description;
           OrderPrice = price;
           OrderDate = date;
        }

        public static List<Order> GetAll()
        {
            return _orderList;
        }

    }
}