using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Http;
using System.Web.Http.Cors;

namespace WebAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class FixController : ApiController
    {
        [HttpPost]
        public IHttpActionResult Add(DTO.Fix fix)
        {
            new BL.FixBL().Add(fix);
            return 
        }
    }
}