using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ApiBackend.Models
{
    public class LocationDB : DbContext
    {
        public LocationDB(DbContextOptions<LocationDB> options) : base(options)
        { 
        }

        public DbSet<Location> Locations { get; set; }
    }
}
