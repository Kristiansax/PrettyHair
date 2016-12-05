using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CheckStock
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void RepositoryExists()
        {
            WareRepository repository = new WareRepository();
            Assert.IsTrue(repository.WareList.Exists(x => x.GetID() == 2));
        }
        [TestMethod]
        public void CanAddItem()
        {
            Ware Table = new Ware(1500, 1, "This is a wooden table");
            WareRepository repository = new WareRepository();
            repository.addItem(Table);
            Assert.AreEqual(Table, repository.WareList);

        }
        [TestMethod]
        public void WareExists()
        {
            Ware Table = new Ware(1500, 1, "This is a wooden table");
            Assert.AreEqual(1500, Table.Price);
            Assert.AreEqual(1, Table.Amount);
            Assert.AreEqual("This is a wooden table", Table.designation);
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
            
        }
    }
}
