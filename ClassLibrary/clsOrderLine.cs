using System;

namespace ClassLibrary
{
    public class clsOrderLine
    {
        //private data members for the properties
        private int mOrder_id;
        private int mProduct_id;
        private int mQuantity;
        private int mPrice;



        public int Order_id
        {
            get { return mOrder_id; }
            set { mOrder_id = value; }
        }
        public int Product_id
        {
            get { return mProduct_id; }
            set { mProduct_id = value; }
        }
        public int Quantity
        {
            get { return mQuantity; }
            set { mQuantity = value; }
        }
        public int Price
        {
            get { return mPrice; }
            set { mPrice = value; }
        }

        public bool Find(int orderID, int productID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address id to search for
            DB.AddParameter("@orderID", orderID);
            DB.AddParameter("@productID", productID);
            //execute the stored procedure
            DB.Execute("sproc_tblOrderLine_FilterByOrderIdAndProductId");
            //if one record is found (there should be one or zero)
            if (DB.Count == 1)
            {
                mOrder_id =     Convert.ToInt32(DB.DataTable.Rows[0]["order_id"]);
                mProduct_id =   Convert.ToInt32(DB.DataTable.Rows[0]["product_id"]);
                mQuantity =     Convert.ToInt32(DB.DataTable.Rows[0]["quantity"]);
                mPrice =        Convert.ToInt32(DB.DataTable.Rows[0]["price"]);
                //return that everything is OK
                return true;
            }
            //if no record was found
            else
            {
                //return a false indicating there is an error
                return false;
            }
        }
        public string Valid(string order_id
            , string product_id
            , string quantity
            , string price)
        {
            //This function accepts four parameters for validation
            //the function returns a string containing any error messages
            //an empty string is returned in the event of no errors
            string error_message = "";

            /*********************IDS*********************/
            //create temp var for the order_id and product_id
            Int32 order_id_temp;
            Int32 product_id_temp;
          
            //ORDER ID
            try
            {
                order_id_temp = Convert.ToInt32(order_id);
                if (order_id_temp < 0) { error_message += "order_id must be a positive number : "; }
            }
            catch
            {
                error_message += "order_id must be an number : ";
            }
            //PRODUCT ID
            try
            {
                product_id_temp = Convert.ToInt32(product_id);
                if (product_id_temp < 0) { error_message += "product_id must be a positive number : "; }
            }
            catch
            {
                error_message += "product_id must be an number : ";
            }
            /*********************QUANTITY*********************/
            Int32 quantity_temp;
            try
            {
                quantity_temp = Convert.ToInt32(quantity);
                if (quantity_temp < 0) { error_message += "quantity must be a positive number : "; }
            }
            catch
            {
                error_message += "quantity must be an number : ";
            }
            /*********************PRICE*********************/
            Int32 price_temp;
            try
            {
                price_temp = Convert.ToInt32(quantity);
                if (price_temp < 0) { error_message += "price must be a positive number : "; }
            }
            catch
            {
                error_message += "price must be an number : ";
            }


            return error_message;
        }

    }
}