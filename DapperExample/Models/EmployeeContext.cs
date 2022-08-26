using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Dapper;
using System.Data;

namespace DapperExample.Models
{
    public class EmployeeContext
    {

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlCon"].ToString());
        public List<EmployeeModel> GetAllEmployee()
        {
          var result1 = con.Query<EmployeeModel>("SELECT * FROM employeeDetails");
         var result = con.Query<EmployeeModel>("sp_Employee",commandType:CommandType.StoredProcedure);
         return result.ToList();
        }
        
        public int SaveEmployee(EmployeeModel emp)
        {
            var parameter = new DynamicParameters();
            parameter.Add("@EmpName",emp.EmpName);
            parameter.Add("@EmpSalary",emp.EmpSalary);

            var result = con.Execute("sp_CreateEmployee",param:parameter,commandType: CommandType.StoredProcedure);
            return result;
        }
    }
}