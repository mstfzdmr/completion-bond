using System;

namespace completion.bond.tests.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public bool IsSale { get; set; }
    }
}
