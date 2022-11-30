using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels.DataModels
{
    public class Lion_Context:DbContext
    {
        public DbSet<Lion> Lions { get; set; }
        public DbSet<Lion_Breed> Breeds { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB);Initial Catalog=DataModels; ";
        }

        internal object Entry<T>(T item) where T : class
        {
            throw new NotImplementedException();
        }
    }
}
