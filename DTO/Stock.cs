using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Stock
    {
        public Stock() { }
        private string productName;
        private int quantity;
        private string unit;
        private double price;
        private DateTime dateImport;
        private string supplierName;

        public string ProductName { get => productName; set => productName = value; }
        public string Unit { get => unit; set => unit = value; }
        public double Price { get => price; set => price = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public DateTime DateImport { get => dateImport; set => dateImport = value; }
        public string SupplierName { get => supplierName; set => supplierName = value; }
    }
}
