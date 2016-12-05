using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CheckStock
{
    [TestClass]
    public class PrettyHairTest
    {
        WareRepository repository = new WareRepository();
        Ware Table = new Ware(1500, 1, "This is a wooden table");
        Ware Shoe = new Ware(200, 30, "This is a pair of shoes");

        [TestMethod]
        public void WareExists()
        {
            Assert.AreEqual(1500, Table.Price);
            Assert.AreEqual(1, Table.Amount);
            Assert.AreEqual("This is a wooden table", Table.Designation);
        }
        [TestMethod]
        public void RepositoryExists()
        {
            Assert.AreEqual(0, repository.GetWares().Count);
        }
        
        [TestMethod]
        public void CanAddItem()
        {
            repository.addItem(Table);
            Assert.AreEqual(1, repository.WareList.Count);

            repository.addItem(Shoe);
            Assert.AreEqual(2, repository.WareList.Count);
        }
        [TestMethod]
        public void CanChangeQuantity()
        {
            repository.addItem(Table);
            Assert.AreEqual(1, repository.WareList[1].Amount);
            repository.UpdateQuantity(1, 20);
            Assert.AreEqual(20, repository.WareList[1].Amount);
        }
        [TestMethod]
        public void CanChangePrice()
        {
            repository.addItem(Table);
            Assert.AreEqual(1500, repository.WareList[1].Price);
            repository.UpdatePrice(1, 1600);
            Assert.AreEqual(1600, repository.WareList[1].Price);
        }
        [TestMethod]
        public void CanChangeDesignation()
        {
            repository.addItem(Table);
            Assert.AreEqual("This is a wooden table", repository.WareList[1].Designation);
            repository.UpdateDesignation(1, "This is a mahogany table");
            Assert.AreEqual("This is a mahogany table", repository.WareList[1].Designation);
        }

        [TestMethod]
        public void CanGetWares()
        {
            Ware Table = new Ware(1500, 1, "This is a wooden table");
            Ware Shoes = new Ware(200, 30, "These are shoes");

        }
        [TestMethod]
        public void CanDeleteWareByID()
        {
            repository.addItem(Table);
            Assert.AreEqual(1, repository.GetWares().Count);
            repository.DeleteWareByID(1);
            Assert.AreEqual(0, repository.GetWares().Count);
        }
    }
}
