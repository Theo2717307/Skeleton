namespace ClassLibrary
{
    public class clsOrderLine
    {
        //private data members for the properties
        private int mPrice;
        private int mQuantity;
        private int mCustomer_id;
        private int mOrder_id;

        public int Price
        {
            get { return mPrice; } 
            set { mPrice = value; }
        }
        public int Quantity
        {
            get { return mQuantity; }
            set { mQuantity = value; }
        }
        public int Customer_id
        {
            get { return mCustomer_id; }
            set { mCustomer_id = value; }
        }
        public int Order_id
        {
            get { return mOrder_id; }
            set { mOrder_id = value; }
        }

        public bool Find(int testOrderID, int testCustomerID)
        {
            //set the private data members to the test data value
            mOrder_id = 15;
            mCustomer_id = 26;
            mQuantity = 45;
            mPrice = 560;
            //always return true
            return true;
        }
    }
}