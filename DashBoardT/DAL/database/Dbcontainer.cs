using DashBoardT.DAL.entity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace DashBoardT.DAL.database
{
    public class Dbcontainer : IdentityDbContext
    {
        public DbSet<department> departments { get; set; }
        public DbSet<employee> employee { get; set; }
        public Dbcontainer (DbContextOptions<Dbcontainer> otps) : base(otps) { }

    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //{
    //    optionsBuilder.UseSqlServer("server = .; database = sharpdb ; integrated security = true ;");
    //}

}
}
