using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment_03_EF.Migrations
{
    /// <inheritdoc />
    public partial class FixNullableInsID : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Department_Data_Ins_ID",
                table: "Department_Data");

            migrationBuilder.AlterColumn<int>(
                name: "Ins_ID",
                table: "Department_Data",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Department_Data_Ins_ID",
                table: "Department_Data",
                column: "Ins_ID",
                unique: true,
                filter: "[Ins_ID] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Department_Data_Ins_ID",
                table: "Department_Data");

            migrationBuilder.AlterColumn<int>(
                name: "Ins_ID",
                table: "Department_Data",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Department_Data_Ins_ID",
                table: "Department_Data",
                column: "Ins_ID",
                unique: true);
        }
    }
}
