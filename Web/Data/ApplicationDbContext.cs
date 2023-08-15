using Microsoft.EntityFrameworkCore;
using Web.Models;

namespace Web.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
                
        }
        //create the database so we have create a dbset inside the applicationdbcontext
        public DbSet<Category> Categories { get; set; }   //Categories --> table name with four column i.e. mentioned in our category model
    
    }
}
