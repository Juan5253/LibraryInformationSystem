using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using model.classes;

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
        protected override void OnConfiguring( DbContextOptionsBuilder optionBuilder)
        {
            if(!optionBuilder.IsConfigured)
            {
                //Connection string
                optionBuilder.UseSqlServer("Data Source=DESKTOP-31E1NSD;Initial Catalog=LibraryInformationSystem;Integrated Security=true;Integrated Security=true;TrustServerCertificate=true;");
            }
        }
    }
}