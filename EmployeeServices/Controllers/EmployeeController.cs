using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EmployeeDataAccess;

namespace EmployeeServices.Controllers
{
    public class EmployeeController : ApiController
    {
        public IEnumerable<EmployeeTable> Get()
        {
            using (EmployeeDetailsEntities entities = new EmployeeDetailsEntities())
            {
                return entities.EmployeeTables.ToList();
            }
        }

        public EmployeeTable Get(int ID)
        {
            using (EmployeeDetailsEntities entities =new EmployeeDetailsEntities())
            {
                return entities.EmployeeTables.FirstOrDefault(e=> e.ID==ID);
                
            }
        }
    }
}
