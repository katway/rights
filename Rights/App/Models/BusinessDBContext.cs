using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Langben.App.Models
{
    public class BusinessDBContext : DbContext
    {
        public BusinessDBContext()
            : base("BusinessDB")
        { }
        public DbSet<LawCase> Cases { get; set; }
        public DbSet<Sample> Samples { get; set; }
    }
}