using Microsoft.EntityFrameworkCore;

namespace PetStoreApp_Project.Models
{
    public class DataDbContext : DbContext //Create db context class and inherit with base class
    {
        public DataDbContext(DbContextOptions<DataDbContext> options) : base(options) //configure dbContext option
        {

        }
        public DbSet<Pet> Pet { get; set; } // add your data models


    }
}
