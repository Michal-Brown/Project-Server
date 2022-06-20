using DTO;
using System;

namespace BL
{
    public class ProfessionalBL
    {
        public ProfessionalBL()
        {
        }

        public void AddProfessional(Professional p)
        {

            new DAL.ProessionalDAL().Add(p);
            
        }
    }
}