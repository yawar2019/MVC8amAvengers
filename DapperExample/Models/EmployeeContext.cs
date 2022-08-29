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

        public EmployeeModel GetEmployeeById(int? id)
        {
            var parameter = new DynamicParameters();
            parameter.Add("@empId", id);
            var result = con.QuerySingle<EmployeeModel>("spr_getEmployeeDetailsbyId", param: parameter, commandType: CommandType.StoredProcedure);
            return result;
        }

        public int UpdateEmployee(EmployeeModel emp)
        {
            var parameter = new DynamicParameters();
            parameter.Add("@Empid", emp.EmpId);
            parameter.Add("@EmpName", emp.EmpName);
            parameter.Add("@EmpSalary", emp.EmpSalary);

            var result = con.Execute("spr_updateEmployeeDetails", param: parameter, commandType: CommandType.StoredProcedure);
            return result;
        }

        public int DeleteEmployee(int? id)
        {
            var parameter = new DynamicParameters();
            parameter.Add("@Empid", id);
            
            var result = con.Execute("usp_DeleteEmployeeById", param: parameter, commandType: CommandType.StoredProcedure);
            return result;
        }
    }
}