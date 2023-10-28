using System;
using Microsoft.EntityFrameworkCore.Migrations;
using NetTopologySuite.Geometries;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace GeomidisSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("Npgsql:PostgresExtension:postgis", ",,");

            migrationBuilder.CreateTable(
                name: "paisExamples",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CANBEN = table.Column<string>(type: "text", nullable: false),
                    CANBEN2 = table.Column<string>(type: "text", nullable: false),
                    CANBEN3 = table.Column<string>(type: "text", nullable: false),
                    CANBEN4 = table.Column<string>(type: "text", nullable: false),
                    CANBEN5 = table.Column<string>(type: "text", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_paisExamples", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "spgPsCaratambs",
                columns: table => new
                {
                    CODTAM = table.Column<string>(type: "text", nullable: false),
                    NOMTAM = table.Column<string>(type: "text", nullable: true),
                    UBIGEO = table.Column<string>(type: "text", nullable: true),
                    DEPART = table.Column<string>(type: "text", nullable: true),
                    PROVIN = table.Column<string>(type: "text", nullable: true),
                    DISTRI = table.Column<string>(type: "text", nullable: true),
                    CENPOB = table.Column<float>(type: "real", nullable: true),
                    ALTITU = table.Column<int>(type: "integer", nullable: true),
                    CANPOB = table.Column<int>(type: "integer", nullable: true),
                    CANVIV = table.Column<int>(type: "integer", nullable: true),
                    HOGARE = table.Column<int>(type: "integer", nullable: true),
                    POBOBJ = table.Column<int>(type: "integer", nullable: true),
                    NCPAIN = table.Column<int>(type: "integer", nullable: true),
                    ZOPOTE = table.Column<string>(type: "text", nullable: true),
                    IMPEST = table.Column<string>(type: "text", nullable: true),
                    CUENCA = table.Column<string>(type: "text", nullable: true),
                    AREA = table.Column<int>(type: "integer", nullable: true),
                    PERIME = table.Column<int>(type: "integer", nullable: true),
                    ESTADO = table.Column<string>(type: "text", nullable: true),
                    SNIPTA = table.Column<string>(type: "text", nullable: true),
                    EJETEM = table.Column<string>(type: "text", nullable: true),
                    TIPINT = table.Column<string>(type: "text", nullable: true),
                    NUMINT = table.Column<int>(type: "integer", nullable: true),
                    NUMATEN = table.Column<int>(type: "integer", nullable: true),
                    NUMUSU = table.Column<int>(type: "integer", nullable: true),
                    COUNTE = table.Column<string>(type: "text", nullable: true),
                    COUBIX = table.Column<float>(type: "real", nullable: true),
                    COUBIY = table.Column<float>(type: "real", nullable: true),
                    IDEASG = table.Column<Point>(type: "geometry", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_spgPsCaratambs", x => x.CODTAM);
                });

            migrationBuilder.CreateTable(
                name: "spgPsGeoemtrys",
                columns: table => new
                {
                    CODTAM = table.Column<string>(type: "text", nullable: false),
                    NOMTAM = table.Column<string>(type: "text", nullable: true),
                    UBIGEO = table.Column<string>(type: "text", nullable: true),
                    IDEASG = table.Column<Geometry>(type: "geometry", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_spgPsGeoemtrys", x => x.CODTAM);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "paisExamples");

            migrationBuilder.DropTable(
                name: "spgPsCaratambs");

            migrationBuilder.DropTable(
                name: "spgPsGeoemtrys");
        }
    }
}
