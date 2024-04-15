using Bogus;
using Microsoft.EntityFrameworkCore;
using ProvaBlue.Models;

namespace ProvaBlue.Db {
    public class Prova_db_context : DbContext {
        public DbSet<ContatoModel> Contatos { get; set; }
        public DbSet<UserModel> Users { get; set; }

        public Prova_db_context(DbContextOptions<Prova_db_context> options) : base(options) {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {

            modelBuilder.Entity<ContatoModel>().HasData(GetContatosSeed());
            modelBuilder.Entity<UserModel>().HasData(GetUsersSeed());

            base.OnModelCreating(modelBuilder);
        }

        private List<UserModel> GetUsersSeed() {
            var usersList = new List<UserModel>();
            usersList.Add(new UserModel { Id = 1, UserName = "felipe", Password = "123", Role = "BlueEmployee" });
            usersList.Add(new UserModel { Id = 2, UserName = "marcio", Password = "321", Role = "NotEmployee" });

            return usersList;
        }

        private List<ContatoModel> GetContatosSeed() {
            // biblioteca legal a do faker: https://fakerjs.dev/api/phone.html#number
            List<ContatoModel> contatos = new List<ContatoModel>();
            for(int i = 0; i < 10; i++) {
                contatos.Add(new ContatoModel() {
                    Id = 1 + i,
                    Nome = new Faker().Person.FullName,
                    Email = new Faker().Person.Email.ToLower(),
                    Numero = $"81-9-{new Faker().Phone.PhoneNumber("####-####")}"
                });
            }
            return contatos;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-TF0LNRF\\SQLEXPRESS2019;Initial Catalog=prova_db;Integrated Security=True;TrustServerCertificate=True");
        }
    }
}
