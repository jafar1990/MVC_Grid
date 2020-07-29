using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace MVC_Grid.Models
{
    public class tbl_studentModel:DbContext
    {
        public tbl_studentModel() : base("name=tbl_studentModel")
        {
        }
        public virtual DbSet<tbl_student> tbl_student { get; set; }

        public virtual DbSet<Customer> Customer { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

       
    }
}