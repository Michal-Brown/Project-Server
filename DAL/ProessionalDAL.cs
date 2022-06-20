using System;

namespace DAL
{
    public class ProessionalDAL
    {
        public ProessionalDAL()
        {
        }

        public void Add(DAL.Professional p)
        {
            try
            {
                using (MG_FinalProjectEntities ctx = new MG_FinalProjectEntities())
                {
                    ctx.Professionals.Add(p);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}