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
        public List<IWare> WareList = new List<IWare>();
        public WareRepository()
        {

        }
        public void addItem(Ware item)
        {
            WareList.Add(item);
        }
        private void deleteWareByID(int ID)
        {
            foreach (IWare item in WareList)
            {
                if (item.GetID() == ID)
                {
                    WareList.Remove(item);
                }
            }
        }
        private void updateWare (int ID)
        {

        }
        public List<IWare> getWares()
        {
            return WareList;
        }
        private Ware getWaresByID(int ID)
        {
            return null;
        }
    }
}
