using Microsoft.EntityFrameworkCore; 
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;


namespace appwebbackend.Models
{
    public class ApplicationDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public Microsoft.EntityFrameworkCore.DbSet<doacao> Doacao { get; set; }
    }
}
