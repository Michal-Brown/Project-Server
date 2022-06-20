using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Professional
    {
        public int ID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Phone { get; set; }
        public Nullable<int> ProfessionID { get; set; }
        public Nullable<bool> IsExpert { get; set; }
        public Nullable<int> CompanyID { get; set; }
        public string Specialty { get; set; }
        public string VisitsArea { get; set; }
        public Nullable<decimal> VisitPrice { get; set; }
    }
}
