using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MoviesAdmin.Migrations
{
    /// <inheritdoc />
    public partial class testRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Director",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "Genre",
                table: "Movie");

            migrationBuilder.AddColumn<int>(
                name: "AudienceRatingID",
                table: "Movie",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DirectorID",
                table: "Movie",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GenreID",
                table: "Movie",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RatingID",
                table: "Movie",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "AudienceRating",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AudienceRating", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Director",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Director", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Genre",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genre", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Movie_AudienceRatingID",
                table: "Movie",
                column: "AudienceRatingID");

            migrationBuilder.CreateIndex(
                name: "IX_Movie_DirectorID",
                table: "Movie",
                column: "DirectorID");

            migrationBuilder.CreateIndex(
                name: "IX_Movie_GenreID",
                table: "Movie",
                column: "GenreID");

            migrationBuilder.AddForeignKey(
                name: "FK_Movie_AudienceRating_AudienceRatingID",
                table: "Movie",
                column: "AudienceRatingID",
                principalTable: "AudienceRating",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Movie_Director_DirectorID",
                table: "Movie",
                column: "DirectorID",
                principalTable: "Director",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Movie_Genre_GenreID",
                table: "Movie",
                column: "GenreID",
                principalTable: "Genre",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movie_AudienceRating_AudienceRatingID",
                table: "Movie");

            migrationBuilder.DropForeignKey(
                name: "FK_Movie_Director_DirectorID",
                table: "Movie");

            migrationBuilder.DropForeignKey(
                name: "FK_Movie_Genre_GenreID",
                table: "Movie");

            migrationBuilder.DropTable(
                name: "AudienceRating");

            migrationBuilder.DropTable(
                name: "Director");

            migrationBuilder.DropTable(
                name: "Genre");

            migrationBuilder.DropIndex(
                name: "IX_Movie_AudienceRatingID",
                table: "Movie");

            migrationBuilder.DropIndex(
                name: "IX_Movie_DirectorID",
                table: "Movie");

            migrationBuilder.DropIndex(
                name: "IX_Movie_GenreID",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "AudienceRatingID",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "DirectorID",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "GenreID",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "RatingID",
                table: "Movie");

            migrationBuilder.AddColumn<string>(
                name: "Director",
                table: "Movie",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Genre",
                table: "Movie",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
