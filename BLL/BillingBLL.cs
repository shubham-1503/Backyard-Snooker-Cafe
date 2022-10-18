using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo3.BLL
{
    internal class BillingBLL
    {
        public string Item_Id { get; set; }
        public string Item_Name { get; set; }
        public decimal Quantity { get; set; }
        public decimal Rate { get; set; }
        public decimal Total { get; set; }
    }
}
