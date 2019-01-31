using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ReactCrudDemo.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ReactCrudDemo.Controllers
{
    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {
        EmployeeDataAccessLayer objEmployee = new EmployeeDataAccessLayer();


        [HttpGet]
        [Route("api/Employee/Index")]
        public IEnumerable<TblEmployee> Get()
        {
            return objEmployee.GetAllEmployees();
        }

        [HttpGet]
        [Route("api/Employee/Details/{id}")]
        public TblEmployee Get(int id)
        {
            return objEmployee.GetEmployeeData(id);
        }

        // POST api/<controller>
        [HttpPost]
        [Route("api/Employee/Create")]
        public int Create([FromBody] TblEmployee employee)
        {
            return objEmployee.AddEmployee(employee);
        }

        // PUT api/<controller>/5
        [HttpPut]
        [Route("api/Employee/Edit")]
        public int Edit(int id, [FromBody]TblEmployee employee)
        {
            return objEmployee.UpdateEmployee(employee);
        }

        // DELETE api/<controller>/5 
        [HttpDelete]
        [Route("api/Employee/Delete/{id}")]
        public int Delete(int id)
        {
            return objEmployee.DeleteEmployee(id);
        }
    }
}
