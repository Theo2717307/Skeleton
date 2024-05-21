using System;

namespace ClassLibrary
{
    public class clsStock
    {
        public clsStock()
        {
        }

        public int quantity { get; set; }
        public int unit_price { get; set; }
        public int product_id { get; set; }
        public string stockName { get; set; }
        public string stockDetails { get; set; }
        public DateTime last_restock_date { get; set; }
        public bool discontinued { get; set; }
    }
}