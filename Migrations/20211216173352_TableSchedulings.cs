using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API_GrupoFleury.Migrations
{
    public partial class TableSchedulings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "Pk_ClientCpf",
                table: "Exams");

            migrationBuilder.AddPrimaryKey(
                name: "Pk_ExamId",
                table: "Exams",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Schedulings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    DateHour = table.Column<DateTime>(type: "datetime", nullable: false),
                    Total = table.Column<double>(type: "double", precision: 4, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Pk_SchedulingId", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Schedulings");

            migrationBuilder.DropPrimaryKey(
                name: "Pk_ExamId",
                table: "Exams");

            migrationBuilder.AddPrimaryKey(
                name: "Pk_ClientCpf",
                table: "Exams",
                column: "Id");
        }
    }
}
