using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckStock
{
    public class WareRepository
    {
        public Dictionary<int, IWare> WareList = new Dictionary<int, IWare>();
        int Id = 1;
        public WareRepository()
        {

        }
        public Dictionary<int, IWare> GetWares()
        {
            return WareList;
        }
        public void addItem(Ware item)
        {
            WareList.Add(Id++, item);
        }
        public void DeleteWareByID(int ID)
        {
            WareList.Remove(ID);
        }
        public void UpdateQuantity (int ID, int newAmount)
        {
            WareList[ID].Amount = newAmount;
        }
        public void UpdatePrice(int ID, int newPrice)
        {
            WareList[ID].Price = newPrice;
        }
        public void UpdateDesignation(int ID, string newDesignation)
        {
            WareList[ID].Designation = newDesignation;
        }
        public Dictionary<int, IWare> getWares()
        {
            return WareList;
        }
        private Ware getWaresByID(int ID)
        {
            return null;
        }
    }
}
