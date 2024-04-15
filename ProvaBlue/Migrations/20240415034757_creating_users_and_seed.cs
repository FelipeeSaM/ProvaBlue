using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProvaBlue.Migrations
{
    /// <inheritdoc />
    public partial class creating_users_and_seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Email", "Nome", "Numero" },
                values: new object[] { "ervin_feil15@hotmail.com", "Courtney Cummings", "81-9-7864-4631" });

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Email", "Nome", "Numero" },
                values: new object[] { "jeanette39@gmail.com", "Freddie Zieme", "81-9-0955-4692" });

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Email", "Nome", "Numero" },
                values: new object[] { "marc.lang82@gmail.com", "Juan Quigley", "81-9-6656-3599" });

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Email", "Nome", "Numero" },
                values: new object[] { "andrew.hahn@hotmail.com", "Clayton Legros", "81-9-3612-7387" });

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Email", "Nome", "Numero" },
                values: new object[] { "marcus7@hotmail.com", "Kent Ullrich", "81-9-5812-8613" });

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Email", "Nome", "Numero" },
                values: new object[] { "agnes_okon@gmail.com", "Harriet Windler", "81-9-8787-9600" });

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Email", "Nome", "Numero" },
                values: new object[] { "steve.gleason14@gmail.com", "Elias Wisozk", "81-9-9527-1612" });

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Email", "Nome", "Numero" },
                values: new object[] { "wallace.rodriguez36@gmail.com", "Tim Yundt", "81-9-0864-6699" });

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Email", "Nome", "Numero" },
                values: new object[] { "clayton.mcglynn98@yahoo.com", "Hannah Bernier", "81-9-4543-8012" });

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Email", "Nome", "Numero" },
                values: new object[] { "andy_bergstrom@hotmail.com", "Harry Cassin", "81-9-6349-5168" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Password", "Role", "UserName" },
                values: new object[,]
                {
                    { 1, "123", "BlueEmployee", "felipe" },
                    { 2, "321", "NotEmployee", "marcio" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Email", "Nome", "Numero" },
                values: new object[] { "claudia_moen@hotmail.com", "Laverne Kunde", "81-9-3368-7044" });

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Email", "Nome", "Numero" },
                values: new object[] { "kayla78@gmail.com", "Elsie Schaden", "81-9-4878-9128" });

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Email", "Nome", "Numero" },
                values: new object[] { "shelia_von@hotmail.com", "Ian Tremblay", "81-9-0053-9813" });

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Email", "Nome", "Numero" },
                values: new object[] { "courtney.johnston61@hotmail.com", "Lance Sanford", "81-9-4376-0926" });

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Email", "Nome", "Numero" },
                values: new object[] { "kate22@hotmail.com", "Julian Macejkovic", "81-9-6161-4110" });

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Email", "Nome", "Numero" },
                values: new object[] { "angie.shanahan85@hotmail.com", "Jeffery King", "81-9-8943-3726" });

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Email", "Nome", "Numero" },
                values: new object[] { "owen.rice@yahoo.com", "Lynda Legros", "81-9-2861-5559" });

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Email", "Nome", "Numero" },
                values: new object[] { "stella.rohan@gmail.com", "Lonnie Hartmann", "81-9-2222-2888" });

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Email", "Nome", "Numero" },
                values: new object[] { "monica_mcdermott79@hotmail.com", "Josefina McGlynn", "81-9-9713-0989" });

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Email", "Nome", "Numero" },
                values: new object[] { "albert_runolfsson17@yahoo.com", "Andy Greenholt", "81-9-4474-8383" });
        }
    }
}
