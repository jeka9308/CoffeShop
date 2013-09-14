using System.Data.Entity;
using Domain.Models;

namespace CoffeeShop.Db.Context
{
    public class MediaRotateContext : DbContext
    {
        public DbSet<CoffeeSort> Sizes { get; set; }
    }
}