using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;

namespace WebAPI.Controllers
{
    public class ProfessionalController : ApiController
    {
        [HttpPost]
        public void Add(DTO.Professional p)
        {
            new BL.ProfessionalBL().AddProfessional(p);
        }
    }
}