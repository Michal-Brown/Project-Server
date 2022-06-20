using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class CustomerBL
    {
        public CustomerBL()
        {

        }

        // bad return type
        public void Add(DTO.Customer customer)
        {
            new DAL.CustomerDAL().Add(new Converters().CustomerConverter(customer));
        }

        public void Update(Customer customer)
        {
            new DAL.CustomerDAL().Add(new Converters().CustomerConverter(customer));
        }
    }
}
