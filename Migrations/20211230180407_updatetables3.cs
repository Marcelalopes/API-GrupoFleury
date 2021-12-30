using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API_GrupoFleury.Migrations
{
    public partial class updatetables3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExamId",
                table: "Schedulings");

            migrationBuilder.AddColumn<string>(
                name: "ExamIds",
                table: "Schedulings",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "District",
                table: "Adresses",
                type: "varchar(16)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(15)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExamIds",
                table: "Schedulings");

            migrationBuilder.AddColumn<Guid>(
                name: "ExamId",
                table: "Schedulings",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci");

            migrationBuilder.AlterColumn<string>(
                name: "District",
                table: "Adresses",
                type: "varchar(15)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(16)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }
    }
}
