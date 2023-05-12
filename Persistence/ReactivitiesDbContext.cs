using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class ReactivitiesDbContext : DbContext
    {
        public DbSet<Activity> Activities {get;set;} 
        public ReactivitiesDbContext(DbContextOptions op) : base(op)
        {
            
        }
        
    }
}