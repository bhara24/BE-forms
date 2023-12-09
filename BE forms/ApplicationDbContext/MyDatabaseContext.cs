using BE_forms.Models;
using Microsoft.EntityFrameworkCore;

namespace BE_forms.ApplicationDbContext
{
    public class MyDatabaseContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "formdb");
        }

        public DbSet<SubmitForm>? submitForms { get; set; }
    }
}
