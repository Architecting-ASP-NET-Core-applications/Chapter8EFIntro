using Microsoft.EntityFrameworkCore;

namespace Chapter8EFIntro.Models;

public class DataContext : DbContext
{
    public DbSet<Book> Books { get; set; }
    protected override void OnConfiguring
        (DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite
                ("Data Source=blazorwithefcore.db");
    public void InitializeDatabase()
        => Database.EnsureCreated();
}

