using DiaryApp.Models;
using Microsoft.EntityFrameworkCore;

namespace DiaryApp.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    //steps to create a table using ef core:
    /*
     1. create a class
     2. add DB set
     3. add-migration Name_of_the_migration
     4. update-database
     */

    public DbSet<DiaryEntry> DiaryEntries { get; set; }
}