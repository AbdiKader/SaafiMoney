using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SaafiMoney.Data.Migrations
{
    public partial class AddRecipientFieldToRemittance : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Remittances",
                newName: "ID");

            migrationBuilder.AddColumn<int>(
                name: "RecipientId",
                table: "Remittances",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RemittanceID",
                table: "Recipients",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Recipients_RemittanceID",
                table: "Recipients",
                column: "RemittanceID");

            migrationBuilder.AddForeignKey(
                name: "FK_Recipients_Remittances_RemittanceID",
                table: "Recipients",
                column: "RemittanceID",
                principalTable: "Remittances",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recipients_Remittances_RemittanceID",
                table: "Recipients");

            migrationBuilder.DropIndex(
                name: "IX_Recipients_RemittanceID",
                table: "Recipients");

            migrationBuilder.DropColumn(
                name: "RecipientId",
                table: "Remittances");

            migrationBuilder.DropColumn(
                name: "RemittanceID",
                table: "Recipients");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Remittances",
                newName: "Id");
        }
    }
}
