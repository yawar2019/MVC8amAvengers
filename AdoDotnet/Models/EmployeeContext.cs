using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace AdoDotnet.Models
{

    public class EmployeeContext
    {
        //SqlConnection con = new SqlConnection("Data Source=AZAM-PC\\SQLEXPRESS;Initial Catalog=AvengersDb;Integrated Security=true");
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlCon"].ToString());
        //        //
        //        CREATE PROCEDURE sp_getEmployee
        //        As
        //BEGIN
        //select* from[dbo].[Employee]
        //        End
        public List<EmployeeModel> GetAllEmployee()
        {
            List<EmployeeModel> listemp = new List<EmployeeModel>();
            SqlCommand cmd = new SqlCommand("sp_getEmployee", con);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);//Now Data is fillupin datatable

            foreach (DataRow dr in dt.Rows)
            {
                EmployeeModel emp = new EmployeeModel();
                emp.EmpId = Convert.ToInt32(dr["EmpId"]);
                emp.EmpName = Convert.ToString(dr["EmpName"]);
                emp.EmpSalary = Convert.ToInt32(dr["EmpSalary"]);
                listemp.Add(emp);
            }

            return listemp;
        }

        //        USE[AvengersDb]
        //GO
        ///****** Object:  StoredProcedure [dbo].[sp_getEmployee]    Script Date: 7/30/2022 8:24:15 AM ******/
        //SET ANSI_NULLS ON
        //GO
        //SET QUOTED_IDENTIFIER ON
        //GO

        //CREATE PROCEDURE[dbo].[sp_SaveEmployee]
        //        @EmpName varchar(50),
        //@EmpSalary int
        //As
        //BEGIN
        //insert into[dbo].[Employee](EmpName,EmpSalary)values(@EmpName, @EmpSalary)
        //END
        public int SaveEmployee(EmployeeModel emp)
        {
            SqlCommand cmd = new SqlCommand("sp_SaveEmployee", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@EmpName", emp.EmpName);
            cmd.Parameters.AddWithValue("@EmpSalary", emp.EmpSalary);
            con.Open();
            int i = cmd.ExecuteNonQuery();//returns nos of rows effected
            con.Close();
            return i;
        }

        public EmployeeModel GetEmployeeById(int id)
        {
            EmployeeModel emp = new EmployeeModel();
            SqlCommand cmd = new SqlCommand("sp_getEmployeeById", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@EmpId", id);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);//Now Data is fillupin datatable

            foreach (DataRow dr in dt.Rows)
            {

                emp.EmpId = Convert.ToInt32(dr["EmpId"]);
                emp.EmpName = Convert.ToString(dr["EmpName"]);
                emp.EmpSalary = Convert.ToInt32(dr["EmpSalary"]);
            }

            return emp;
        }



//        Create PROCEDURE[dbo].[sp_UpdateEmployeeById]
//        @EmpId int,
//@EmpName varchar(50),
//@EmpSalary int

//As
//BEGIN
//update[dbo].[Employee]
//        set EmpName = @EmpName, EmpSalary = @EmpSalary where Empid = @EmpId
//END
        public int UpdateEmployee(EmployeeModel emp)
        {
            SqlCommand cmd = new SqlCommand("sp_UpdateEmployeeById", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@EmpId", emp.EmpId);
            cmd.Parameters.AddWithValue("@EmpName", emp.EmpName);
            cmd.Parameters.AddWithValue("@EmpSalary", emp.EmpSalary);
            con.Open();
            int i = cmd.ExecuteNonQuery();//returns nos of rows effected
            con.Close();
            return i;
        }
        public int DeleteEmployee(int id)
        {
            SqlCommand cmd = new SqlCommand("sp_DeleteEmployeeById", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@EmpId",id);
            con.Open();
            int i = cmd.ExecuteNonQuery();//returns nos of rows effected
            con.Close();
            return i;
        }

        
    }
}
//Bookid,BookName,Author,Category,Description,price