using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DssdemoApiApp.Data;

namespace DssdemoApiApp.Models
{
    public class DssdemoApiAppContext : DbContext
    {
        public DssdemoApiAppContext (DbContextOptions<DssdemoApiAppContext> options)
            : base(options)
        {
        }

        public DbSet<DssdemoApiApp.Data.Employee> Employee { get; set; }
    }
}
