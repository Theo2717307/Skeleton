using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing1
{
    [TestClass]
    public class tstSupplyCollection
    {
        [TestMethod]
        public void instanceOK()
        {
            //create an instance of the class we want to create
            clsSupplyCollection AllSupplier = new clsSupplyCollection();
            //test to see that is exists
            Assert.IsNotNull(AllSupplier);
        }

        [TestMethod]
        public void SupplyListOK()
        {
            //create an instance of class
            clsSupplyCollection AllSupplier = new clsSupplyCollection();
            //create some test to assign property
            List<clsSupply> TestList = new List<clsSupply>();
            //add iteam to the list
            //create the iteam test data
            clsSupply TestIteam = new clsSupply();
            //set its properties 
            TestIteam.Supplier_Name = "Test";
            TestIteam.Supplier_Phone_Number = "07979481290";
            TestIteam.Supplier_Address = "Some Street";
            TestIteam.Supplier_Email = "Test@gmail.com";
            TestIteam.Supplier_Country = "Portugal";
            TestIteam.Supplier_Export = true;
            TestIteam.Supplier_Trade_Restrictions = true;
            //add the iteam to the test list
            TestList.Add(TestIteam);
            //assign the data to teh property
            AllSupplier.SupplierList = TestList;
            //test to the seee that two values are the same
            Assert.AreEqual(AllSupplier.SupplierList, TestList);

        }

  

        [TestMethod]
        public void ThisSupplierPropertyOK()
        {
            //create an instance of class
            clsSupplyCollection AllSupplier = new clsSupplyCollection();
            //create some test to assign property            
            //create the iteam test data
            clsSupply TestIteam = new clsSupply();
            //set its properties 
            TestIteam.Supplier_Name = "Test";
            TestIteam.Supplier_Phone_Number = "07979481290";
            TestIteam.Supplier_Address = "Some Street";
            TestIteam.Supplier_Email = "Test@gmail.com";
            TestIteam.Supplier_Country = "Portugal";
            TestIteam.Supplier_Export = true;
            TestIteam.Supplier_Trade_Restrictions = true;
            //assign the data to teh property
            AllSupplier.ThisSupplier = TestIteam;
            //test to the seee that two values are the same
            Assert.AreEqual(AllSupplier.ThisSupplier, TestIteam);

        }

        public void ListAndCountOK()
        {
            //create an instance of class
            clsSupplyCollection AllSupplier = new clsSupplyCollection();
            //create some test to assign property
            List<clsSupply> TestList = new List<clsSupply>();
            //add iteam to the list
            //create the iteam test data
            clsSupply TestIteam = new clsSupply();
            //set its properties 
            TestIteam.Supplier_Name = "Test";
            TestIteam.Supplier_Phone_Number = "07979481290";
            TestIteam.Supplier_Address = "Some Street";
            TestIteam.Supplier_Email = "Test@gmail.com";
            TestIteam.Supplier_Country = "Portugal";
            TestIteam.Supplier_Export = true;
            TestIteam.Supplier_Trade_Restrictions = true;
            //add the iteam to the test list
            TestList.Add(TestIteam);
            //assign the data to teh property
            AllSupplier.SupplierList = TestList;
            //test to the seee that two values are the same
            Assert.AreEqual(AllSupplier.Count, TestList.Count);

        }
    }
}

