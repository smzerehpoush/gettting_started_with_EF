using Microsoft.EntityFrameworkCore.Migrations;

namespace EFGetStarted.Migrations
{
    public partial class InitialCreate3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Blogs_BlogId",
                table: "Posts");

            migrationBuilder.RenameColumn(
                name: "BlogId",
                table: "Posts",
                newName: "BlogID");

            migrationBuilder.RenameIndex(
                name: "IX_Posts_BlogId",
                table: "Posts",
                newName: "IX_Posts_BlogID");

            migrationBuilder.AlterColumn<int>(
                name: "BlogID",
                table: "Posts",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Blogs_BlogID",
                table: "Posts",
                column: "BlogID",
                principalTable: "Blogs",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Blogs_BlogID",
                table: "Posts");

            migrationBuilder.RenameColumn(
                name: "BlogID",
                table: "Posts",
                newName: "BlogId");

            migrationBuilder.RenameIndex(
                name: "IX_Posts_BlogID",
                table: "Posts",
                newName: "IX_Posts_BlogId");

            migrationBuilder.AlterColumn<int>(
                name: "BlogId",
                table: "Posts",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Blogs_BlogId",
                table: "Posts",
                column: "BlogId",
                principalTable: "Blogs",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
