using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckStock
{
    public class Ware : IWare
    {
        public int id = 0;
        public int Price;
        public int Amount;
        public string designation;

        public Ware (int P, int A, string Desc)
        {
            Price = P;
            Amount = A;
            designation = Desc;
        }
        public int Id
        {
            set
            {
                id = value;
            }
            get
            {
                return id;
            }
            
        }
        public int NextID()
        {
            id++;
            return id;
        }
        public int GetID()
        {
            return Id;
        }
    }
}
