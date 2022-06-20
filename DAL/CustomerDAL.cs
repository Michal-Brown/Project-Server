using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CustomerDAL
    {
        public CustomerDAL()
        {

        }

        // return type - bool? IHttpActionResults?
        public void Add(Customer customer)
        {
            try
            {
                using (MG_FinalProjectEntities contex = new MG_FinalProjectEntities())
                {
                    contex.Customers.Add(customer);
                    contex.SaveChanges();
                }
            }
            catch (Exception exception)
            {
                throw new Exception($"DB: Trying to add new customer {customer.ID} to DB", exception);
            }
        }

        public void Update(Customer updatedCustomer)
        {
            try
            {
                using (MG_FinalProjectEntities contex = new MG_FinalProjectEntities())
                {
                    DAL.Customer customer = contex.Customers.SingleOrDefault(cust => cust.ID == updatedCustomer.ID);
                    if (customer != null)
                    {
                        contex.Entry(customer).CurrentValues.SetValues(updatedCustomer);
                        contex.SaveChanges();
                    }
                    else Add(customer);
                }
            }
            catch (Exception exception)
            {
                throw new Exception($"DB: Trying to update customer {updatedCustomer.ID}", exception);
            }
        }
    }
}
