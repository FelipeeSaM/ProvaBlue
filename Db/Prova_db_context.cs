using Bogus;
using Microsoft.EntityFrameworkCore;
using ProvaBlue.Models;

namespace ProvaBlue.Db {
    public class Prova_db_context : DbContext {
        public DbSet<ContatoModel> Contatos { get; set; }

        public Prova_db_context(DbContextOptions<Prova_db_context> options) : base(options) {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {

            modelBuilder.Entity<ContatoModel>().HasData(GetContatosSeed());

            base.OnModelCreating(modelBuilder);
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
