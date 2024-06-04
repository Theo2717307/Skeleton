using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        //private data members for the properties
        private Int32 mOrder_id;
        private Int32 mCustomer_id;
        private DateTime mOrder_timestamp;
        private Boolean mOrder_processed;

        public bool Order_processed
        {
            get
            {
                return mOrder_processed;
            }
            set 
            { 
                mOrder_processed = value; 
            }
        }
        public DateTime Order_timestamp
        {
            get
            {
                return mOrder_timestamp;
            }
            set
            {
                mOrder_timestamp = value;
            }
        }
        public int Order_id
        {
            get
            {
                return mOrder_id;
            }
            set
            {
                mOrder_id = value;
            }
        }
        public int Customer_id
        {
            get
            {
                return mCustomer_id;
            }
            set
            {
                mCustomer_id = value;
            }
        }

        public bool Find(int orderID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address id to search for
            DB.AddParameter("@orderID", orderID);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_FilterByOrderId");
            //if one record is found (there should be one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mOrder_id = Convert.ToInt32(DB.DataTable.Rows[0]["order_id"]);
                mCustomer_id = Convert.ToInt32(DB.DataTable.Rows[0]["customer_id"]);
                mOrder_timestamp = Convert.ToDateTime(DB.DataTable.Rows[0]["order_timestamp"]);
                mOrder_processed = Convert.ToBoolean(DB.DataTable.Rows[0]["order_processed"]);
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
        public string Valid(string order_id,
                            string customer_id,
                            string order_timestamp,
                            Boolean order_processed)
        {
            //This function accepts four parameters for validation
            //The function returns a string containing any error message
            //If no errors are found it returns a empty string
            string error_message = "";

            /********************DATE********************/
            //create a temp var for the date values
            DateTime date_temp;
            //check the timestamp exists
            if ((order_timestamp == null) || (order_timestamp == ""))
            {
                error_message += "The date must exist : ";
                
            }
            else //the rest of the date testing in the else
            {
                //copy the value into temp
                try
                {
                    date_temp = Convert.ToDateTime(order_timestamp);

                    //if the date is less than todays date
                    if (date_temp < DateTime.Now.Date)
                    {
                        error_message += "The date cannot be in the past : ";
                    }
                    //if the date is greater than todays date
                    if (date_temp > DateTime.Now.Date)
                    {
                        error_message += "The date cannot be in the future : ";
                    }
                }
                catch
                {
                    error_message += "The date was invalid : ";
                }
                
                

            }
            /********************BOOLEAN********************/
            //create a temp var for the order_processed boolean
            Boolean processed_temp;

            try
            {
                processed_temp = order_processed;
                //if the date is true or false
                if ((processed_temp != true) && (processed_temp != false))
                {
                    error_message += "The boolean must be true or false : ";
                }
            }
            catch
            {
                error_message += "Processed must be valid : ";
            }
            /********************Integers********************/
            //create temp var for the order_id and customer_id
            Int32 order_id_temp;
            Int32 customer_id_temp;
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
            //CUSTOMER ID
            try
            {
                customer_id_temp = Convert.ToInt32(customer_id);
                if (customer_id_temp < 0) { error_message += "customer_id must be a positive number : "; }
            }
            catch
            {
                error_message += "customer_id must be an number : ";
            }
            return error_message;
        }
    }
}