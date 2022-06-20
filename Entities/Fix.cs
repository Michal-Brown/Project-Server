using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Fix
    {
        public int ID { get; set; }
        public int CustomerID { get; set; }
        public int ProfessionalID { get; set; }
        public int ProductID { get; set; }
        public string ProblemDetails { get; set; }
        public string FixDetails { get; set; }
        public string Note { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string PaymentConfirmation { get; set; }
    }
}
