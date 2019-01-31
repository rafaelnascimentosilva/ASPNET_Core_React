using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ReactCrudDemo.Models
{
    public class EmployeeDataAccessLayer
    {
        EnterpriseDBContext db = new EnterpriseDBContext();

        public IEnumerable<TblEmployee> GetAllEmployees()
        {
            try {
                return db.TblEmployee.ToList();
            }
            catch
            {
                throw;
            }
        }

        public int AddEmployee( TblEmployee employee)
        {
            try
            {
                db.Entry(employee).State = EntityState.Modified;
                db.SaveChanges();
                return 1;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int UpdateEmployee(TblEmployee employee)
        {
            try
            {
                db.Entry(employee).State = EntityState.Modified;
                db.SaveChanges();
                return 1;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public TblEmployee GetEmployeeData(int id)
        {
            try
            {
                TblEmployee employee = db.TblEmployee.Find(id);
                return employee;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int DeleteEmployee(int id)
        {
            try
            {
                TblEmployee emp = db.TblEmployee.Find(id);
                db.TblEmployee.Remove(emp);
                db.SaveChanges();
                return 1;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<TblCities> GetCities()
        {
            List<TblCities> cities = new List<TblCities>();
            cities = (from CityList in db.TblCities select CityList).ToList();

            return cities;
            
        }
    }
}
