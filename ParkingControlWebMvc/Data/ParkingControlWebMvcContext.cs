using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ParkingControlWebMvc.Models
{
    public class ParkingControlWebMvcContext : DbContext
    {
        public ParkingControlWebMvcContext (DbContextOptions<ParkingControlWebMvcContext> options)
            : base(options)
        {
        }

        public DbSet<ParkingControlWebMvc.Models.Aluno> Aluno { get; set; }
    }
}
