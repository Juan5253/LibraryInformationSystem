using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace controller.AppRepositories
{
    public class InformationSystemContext : DbContext //superclass inheritance
    {
        //"DbSet" Special data type, from a class you can generate an entity in the database
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Editorial> Editorials { get; set; }
        public DbSet<AuthorBook> AuthorsBooks { get; set; }

        //Method that creates the database
        protected override void OnConfiguring( DbContextOptionBuilder optionBuilder)
        {
            if(!optionBuilder.IsConfigured)
            {
                //Connection string
                optionBuilder.UseSqlServer("Data Source=  ;Initial Catalog= ");
            }

        }
    }
}