using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceDapper.DataAccess.Entites
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public byte[] Picture { get; set; }

        public override string ToString()
        {
            return CategoryName;
        }
    }
}
