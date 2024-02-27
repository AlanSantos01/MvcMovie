using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MvcMovie.Migrations
{
    /// <inheritdoc />
    public partial class MovieAndStudio : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MovieId",
                table: "Movie",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ArtistId",
                table: "Artist",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Movie_MovieId",
                table: "Movie",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Artist_ArtistId",
                table: "Artist",
                column: "ArtistId");

            migrationBuilder.AddForeignKey(
                name: "FK_Artist_Artist_ArtistId",
                table: "Artist",
                column: "ArtistId",
                principalTable: "Artist",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Movie_Movie_MovieId",
                table: "Movie",
                column: "MovieId",
                principalTable: "Movie",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Artist_Artist_ArtistId",
                table: "Artist");

            migrationBuilder.DropForeignKey(
                name: "FK_Movie_Movie_MovieId",
                table: "Movie");

            migrationBuilder.DropIndex(
                name: "IX_Movie_MovieId",
                table: "Movie");

            migrationBuilder.DropIndex(
                name: "IX_Artist_ArtistId",
                table: "Artist");

            migrationBuilder.DropColumn(
                name: "MovieId",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "ArtistId",
                table: "Artist");
        }
    }
}
