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
        public void InstanceOK()
        {
            //create an instance
            clsSupplyCollection AllSupplier = new clsSupplyCollection();
            //test to use that is exist
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
            TestIteam.Supplier_Id = 1;
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
            TestIteam.Supplier_Id = 1;
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

        [TestMethod]
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
            TestIteam.Supplier_Id = 1;
            TestIteam.Supplier_Name = "BMW";
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

        [TestMethod]

        public void AddMethodsOK()
        {
            //create an instance of class
            clsSupplyCollection AllSupplier = new clsSupplyCollection();
       
            //create the iteam test data
            clsSupply TestIteam = new clsSupply();
            //vriable tostore the primary key 
            Int32 PrimaryKey = 0;
            //set its properties 
            TestIteam.Supplier_Id = 1;
            TestIteam.Supplier_Name = "BMW";
            TestIteam.Supplier_Phone_Number = "07979481290";
            TestIteam.Supplier_Address = "Some Street";
            TestIteam.Supplier_Email = "Test@gmail.com";
            TestIteam.Supplier_Country = "Portugal";
            TestIteam.Supplier_Export = true;
            TestIteam.Supplier_Trade_Restrictions = true;
            //set thissupplier to the test data
            AllSupplier.ThisSupplier = TestIteam;
            //add the record
            PrimaryKey = AllSupplier.Add();
            //assign the data to teh property
            TestIteam.Supplier_Id = PrimaryKey;
            //test to the seee that two values are the same
            Assert.AreEqual(AllSupplier.ThisSupplier, TestIteam);

        }

        public void UpdateMethodsOK()
        {
            //create an instance of class
            clsSupplyCollection AllSupplier = new clsSupplyCollection();

            //create the iteam test data
            clsSupply TestIteam = new clsSupply();
            //vriable tostore the primary key 
            Int32 PrimaryKey = 0;
            //set its properties
            TestIteam.Supplier_Name = "BMW";
            TestIteam.Supplier_Phone_Number = "07979481290";
            TestIteam.Supplier_Address = "Some Street";
            TestIteam.Supplier_Email = "Test@gmail.com";
            TestIteam.Supplier_Country = "Portugal";
            TestIteam.Supplier_Export = true;
            TestIteam.Supplier_Trade_Restrictions = true;
            //set thissupplier to the test data
            AllSupplier.ThisSupplier = TestIteam;
            //add the record
            PrimaryKey = AllSupplier.Add();
            //assign the data to teh property
            TestIteam.Supplier_Id = PrimaryKey;
            //modfity the data
            TestIteam.Supplier_Name = "Oudi";
            TestIteam.Supplier_Phone_Number = "07979480090";
            TestIteam.Supplier_Address = "Some";
            TestIteam.Supplier_Email = "Test65@gmail.com";
            TestIteam.Supplier_Country = "England";
            TestIteam.Supplier_Export = false;
            TestIteam.Supplier_Trade_Restrictions = false;
            //test to the seee that two values are the same
            Assert.AreEqual(AllSupplier.ThisSupplier, TestIteam);
            //update the records
            AllSupplier.Update();
            //find the records
            AllSupplier.ThisSupplier.Find(PrimaryKey);
            Assert.AreEqual(AllSupplier.ThisSupplier, TestIteam);


        }


    }
}
