using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API_GrupoFleury.Migrations
{
    public partial class relacionamento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropIndex(
                name: "IX_Exams_SchedulingId",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "SchedulingId",
                table: "Exams");

            migrationBuilder.AlterColumn<string>(
                name: "ClientCpf",
                table: "Schedulings",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "AddressId",
                table: "Clients",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClientCpf",
                table: "Address",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ExamScheduling",
                columns: table => new
                {
                    ExamsId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    SchedulingsId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamScheduling", x => new { x.ExamsId, x.SchedulingsId });
                    table.ForeignKey(
                        name: "FK_ExamScheduling_Exams_ExamsId",
                        column: x => x.ExamsId,
                        principalTable: "Exams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExamScheduling_Schedulings_SchedulingsId",
                        column: x => x.SchedulingsId,
                        principalTable: "Schedulings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_ExamScheduling_SchedulingsId",
                table: "ExamScheduling",
                column: "SchedulingsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_Address_AddressId",
                table: "Clients",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Schedulings_Clients_ClientCpf",
                table: "Schedulings",
                column: "ClientCpf",
                principalTable: "Clients",
                principalColumn: "Cpf",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Address_AddressId",
                table: "Clients");

            migrationBuilder.DropForeignKey(
                name: "FK_Schedulings_Clients_ClientCpf",
                table: "Schedulings");

            migrationBuilder.DropTable(
                name: "ExamScheduling");

            migrationBuilder.DropColumn(
                name: "ClientCpf",
                table: "Address");

            migrationBuilder.AlterColumn<string>(
                name: "ClientCpf",
                table: "Schedulings",
                type: "varchar(255)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<Guid>(
                name: "SchedulingId",
                table: "Exams",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci");

            migrationBuilder.AlterColumn<int>(
                name: "AddressId",
                table: "Clients",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Exams_SchedulingId",
                table: "Exams",
                column: "SchedulingId");

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
    }
}
