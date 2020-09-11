using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using D6TWO_Model;

namespace WebApplication1.Data
{
    public class G6TWO_ZlContext : DbContext
    {
        public G6TWO_ZlContext (DbContextOptions<G6TWO_ZlContext> options)
            : base(options)
        {
        }

        public DbSet<D6TWO_Model.OrderTable> OrderTable { get; set; }
    }
}
