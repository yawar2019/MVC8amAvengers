using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace CodeFirstApproach2.Models
{
    public class EmployeeContext:DbContext
    {
        public EmployeeContext():base("sqlCon")
        {

        }

        public DbSet<EmployeeModel> EmployeeModels { get; set; }

    }
}