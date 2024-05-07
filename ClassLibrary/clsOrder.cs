using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        public bool Order_processed { get; set; }
        public DateTime Order_timestamp { get; set; }
        public int Order_id { get; set; }
        public int Customer_id { get; set; }
    }
}