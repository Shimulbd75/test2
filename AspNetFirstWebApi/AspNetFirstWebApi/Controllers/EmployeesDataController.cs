using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AspNetFirstWebApi.Controllers
{
    public class EmployeesDataController : ApiController
    {
        public string[] MyEmployees = { "Naba", "Nihan", "Muaz", "Noushin" };
        public string[] GetEmployees()
        {
            return MyEmployees;
        }
        public string GetEmployeesById(int id)
        {
            return MyEmployees[id];
        }
    }
}
