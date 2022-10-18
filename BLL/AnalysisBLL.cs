using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo3.BLL
{
    internal class AnalysisBLL
    {
        public string Bill_No { get; set; }
        public string Customer_Name { get; set; }
        public string Customer_Contact { get; set; }
        public DateTime Date { get; set; }
        public decimal Grand_Total { get; set; }
    }
}
