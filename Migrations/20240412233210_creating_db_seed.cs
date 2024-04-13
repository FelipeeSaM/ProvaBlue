using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProvaBlue.Migrations
{
    /// <inheritdoc />
    public partial class creating_db_seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contatos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Numero = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contatos", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Contatos",
                columns: new[] { "Id", "Email", "Nome", "Numero" },
                values: new object[,]
                {
                    { 1, "claudia_moen@hotmail.com", "Laverne Kunde", "81-9-3368-7044" },
                    { 2, "kayla78@gmail.com", "Elsie Schaden", "81-9-4878-9128" },
                    { 3, "shelia_von@hotmail.com", "Ian Tremblay", "81-9-0053-9813" },
                    { 4, "courtney.johnston61@hotmail.com", "Lance Sanford", "81-9-4376-0926" },
                    { 5, "kate22@hotmail.com", "Julian Macejkovic", "81-9-6161-4110" },
                    { 6, "angie.shanahan85@hotmail.com", "Jeffery King", "81-9-8943-3726" },
                    { 7, "owen.rice@yahoo.com", "Lynda Legros", "81-9-2861-5559" },
                    { 8, "stella.rohan@gmail.com", "Lonnie Hartmann", "81-9-2222-2888" },
                    { 9, "monica_mcdermott79@hotmail.com", "Josefina McGlynn", "81-9-9713-0989" },
                    { 10, "albert_runolfsson17@yahoo.com", "Andy Greenholt", "81-9-4474-8383" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contatos");
        }
    }
}
