using System.Collections.Generic;

namespace Tracking.Models
{
    public class Vendor
    {
        public string VendorName { get; set; }
        public string Description { get; set; }

        public int Id { get; }
        private static List<Vendor> _vendorList = new List<Vendor> { };

        public List<Item> Items {get; set; }

        public Vendor(string vendorName, string description)
        {
            VendorName = vendorName;
            Description = description;
            _vendorList.Add(this);
            Id = _vendorList.Count;
            Items = new List<Item> { };
        }

        public static List<Vendor> GetAll()
        {
            return _vendorList;
        }

        public static void ClearAll()
        {
            _vendorList.Clear();
        }
        public void AddItem(Item item)
        {
            Items.Add(item);
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
}