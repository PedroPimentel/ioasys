using IoasysApi.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace IoasysApi.Models.Context
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {

        }
        public DbSet<User> TbUser { get; set; }
        public DbSet<Enterprise> TbEnterprise{ get; set; }
        public DbSet<Type> TbType { get; set; }
    }
}
