using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API_GrupoFleury.Migrations
{
    public partial class UpdateTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Endereco",
                table: "Clients");

            migrationBuilder.RenameColumn(
                name: "Total",
                table: "Schedulings",
                newName: "ValueTotal");

            migrationBuilder.RenameColumn(
                name: "DateHour",
                table: "Schedulings",
                newName: "HorarioI");

            migrationBuilder.RenameColumn(
                name: "DataNascimento",
                table: "Clients",
                newName: "BirthDate");

            migrationBuilder.AddColumn<string>(
                name: "ClientCpf",
                table: "Schedulings",
                type: "varchar(255)",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Schedulings",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "HorarioF",
                table: "Schedulings",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Duration",
                table: "Exams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<Guid>(
                name: "SchedulingId",
                table: "Exams",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci");

            migrationBuilder.AddColumn<int>(
                name: "AddressId",
                table: "Clients",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Clients",
                type: "varchar(30)",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Clients",
                type: "varchar(11)",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Street = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Number = table.Column<int>(type: "int", nullable: false),
                    District = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ZipCode = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    City = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Schedulings_ClientCpf",
                table: "Schedulings",
                column: "ClientCpf");

            migrationBuilder.CreateIndex(
                name: "IX_Exams_SchedulingId",
                table: "Exams",
                column: "SchedulingId");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_AddressId",
                table: "Clients",
                column: "AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_Address_AddressId",
                table: "Clients",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Exams_Schedulings_SchedulingId",
                table: "Exams",
                column: "SchedulingId",
                principalTable: "Schedulings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Schedulings_Clients_ClientCpf",
                table: "Schedulings",
                column: "ClientCpf",
                principalTable: "Clients",
                principalColumn: "Cpf",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Address_AddressId",
                table: "Clients");

            migrationBuilder.DropForeignKey(
                name: "FK_Exams_Schedulings_SchedulingId",
                table: "Exams");

            migrationBuilder.DropForeignKey(
                name: "FK_Schedulings_Clients_ClientCpf",
                table: "Schedulings");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropIndex(
                name: "IX_Schedulings_ClientCpf",
                table: "Schedulings");

            migrationBuilder.DropIndex(
                name: "IX_Exams_SchedulingId",
                table: "Exams");

            migrationBuilder.DropIndex(
                name: "IX_Clients_AddressId",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "ClientCpf",
                table: "Schedulings");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "Schedulings");

            migrationBuilder.DropColumn(
                name: "HorarioF",
                table: "Schedulings");

            migrationBuilder.DropColumn(
                name: "Duration",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "SchedulingId",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Clients");

            migrationBuilder.RenameColumn(
                name: "ValueTotal",
                table: "Schedulings",
                newName: "Total");

            migrationBuilder.RenameColumn(
                name: "HorarioI",
                table: "Schedulings",
                newName: "DateHour");

            migrationBuilder.RenameColumn(
                name: "BirthDate",
                table: "Clients",
                newName: "DataNascimento");

            migrationBuilder.AddColumn<string>(
                name: "Endereco",
                table: "Clients",
                type: "varchar(300)",
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");
        }
    }
}
