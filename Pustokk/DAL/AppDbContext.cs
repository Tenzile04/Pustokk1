using Microsoft.EntityFrameworkCore;
using Pustokk.Models;
using System.Collections.Generic;

namespace Pustokk.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Slider> Sliders { get; set; }
    }
}
