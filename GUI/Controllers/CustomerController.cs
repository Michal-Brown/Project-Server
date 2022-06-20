using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;

namespace WebAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class CustomerController : ApiController
    {
        // !!!החזרת שגיאות לא תקנית
        [HttpPost]
        public IHttpActionResult Add(DTO.Customer customer)
        {
            new BL.CustomerBL().Add(customer);
            return Created($"WebAPI/Controllers/CustomerController/Add(customer {customer.ID}) success", customer);
        }

        [HttpPost]
        public IHttpActionResult Update(DTO.Customer customer)
        {
            new BL.CustomerBL().Update(customer);
            return Ok();
        }
    }
}