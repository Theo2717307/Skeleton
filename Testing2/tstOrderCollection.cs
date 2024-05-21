using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing2
{
    [TestClass]
    public class tstOrderCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class 
            clsOrderCollection all_orders = new clsOrderCollection();
            //test to see if it exists
            Assert.IsNotNull(all_orders);
        }
        [TestMethod]
        public void OrderListOK()
        {
            //create an instance of the class 
            clsOrderCollection all_orders = new clsOrderCollection();
            //create some test data to assign to the property
            //a list of objects
            List<clsOrder> test_list = new List<clsOrder>();
            //Add item to list
            //create the item of test data
            clsOrder test_item = new clsOrder();
            //set properties
            test_item.Order_id = 1;
            test_item.Customer_id = 2;
            test_item.Order_timestamp = DateTime.Now;
            test_item.Order_processed = false;
            //add the item to the list
            test_list.Add(test_item);
            //assign the data to the property
            all_orders.OrderList = test_list;
            //test to see the values are the same
            Assert.AreEqual(all_orders.OrderList, test_list);
        }
        
        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            //create an instance of the classes
            clsOrderCollection all_orders = new clsOrderCollection();
            clsOrder test_order = new clsOrder();
            //set properties
            test_order.Order_id = 1;
            test_order.Customer_id = 2;
            test_order.Order_timestamp = DateTime.Now;
            test_order.Order_processed = false;
            //assign the data to the property
            all_orders.ThisOrder = test_order;
            //test to see they are the same
            Assert.AreEqual(all_orders.ThisOrder, test_order);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class 
            clsOrderCollection all_orders = new clsOrderCollection();
            //create some test data to assign to the property
            //a list of objects
            List<clsOrder> test_list = new List<clsOrder>();
            //Add item to list
            //create the item of test data
            clsOrder test_item = new clsOrder();
            //set properties
            test_item.Order_id = 1;
            test_item.Customer_id = 2;
            test_item.Order_timestamp = DateTime.Now;
            test_item.Order_processed = false;
            //add the item to the list
            test_list.Add(test_item);
            //assign the data to the property
            all_orders.OrderList = test_list;
            //test to see the values are the same
            Assert.AreEqual(all_orders.Count, test_list.Count);
        }
        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection all_orders = new clsOrderCollection();
            //create an item of the test data
            clsOrder test_order = new clsOrder();
            //variable to store primary key
            Int32 primary_key = 0;
            //set properties
            test_order.Customer_id = 10;
            test_order.Order_timestamp = DateTime.Now;
            test_order.Order_processed = false;
            //set this order to the test data
            all_orders.ThisOrder = test_order;
            primary_key = all_orders.Add();
            //set the primary key of the test data
            test_order.Order_id = primary_key;
            //find the record
            all_orders.ThisOrder.Find(primary_key);
            //test to see the values are the same
            Assert.AreEqual(all_orders.ThisOrder, test_order);
        }

    }
}
