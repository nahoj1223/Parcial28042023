using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntryControl.API.Migrations
{
    /// <inheritdoc />
    public partial class TableTickets : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdTicket = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    UseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WasUsed = table.Column<bool>(type: "bit", nullable: false),
                    EntranceType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_IdTicket",
                table: "Tickets",
                column: "IdTicket",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tickets");
        }
    }
}
