using Microsoft.EntityFrameworkCore.Migrations;
using System;

#nullable disable

namespace SpotifyRecommendedPlaylistAPI.Data.Migrations
{
    public partial class RemoveViewsProcsandTriggerMigrationHistory1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            String sqlString = String.Empty;

            sqlString =
                      "IF EXISTS(SELECT *" +
                      "          FROM __EFMigrationsHistory" +
                      "          WHERE MigrationId = '99999999999996_SpotifyRecommendedPlaylistAPI_Procs') " +
                      "  BEGIN " +
                      "       DELETE FROM __EFMigrationsHistory WHERE MigrationId = '99999999999996_SpotifyRecommendedPlaylistAPI_Procs'" +
                      "  END ";

            migrationBuilder.Sql(sqlString);

            sqlString =
                      "IF EXISTS(SELECT *" +
                      "          FROM __EFMigrationsHistory" +
                      "          WHERE MigrationId = '99999999999997_SpotifyRecommendedPlaylistAPI_Views') " +
                      "  BEGIN " +
                      "       DELETE FROM __EFMigrationsHistory WHERE MigrationId = '99999999999997_SpotifyRecommendedPlaylistAPI_Views'" +
                      "  END ";

            migrationBuilder.Sql(sqlString);

            sqlString =
                      "IF EXISTS(SELECT *" +
                      "          FROM __EFMigrationsHistory" +
                      "          WHERE MigrationId = '99999999999998_SpotifyRecommendedPlaylistAPI_Triggers') " +
                      "  BEGIN " +
                      "       DELETE FROM __EFMigrationsHistory WHERE MigrationId = '99999999999998_SpotifyRecommendedPlaylistAPI_Triggers'" +
                      "  END ";

            migrationBuilder.Sql(sqlString);

            sqlString =
                     "IF EXISTS(SELECT *" +
                     "          FROM __EFMigrationsHistory" +
                     "          WHERE MigrationId = '99999999999999_RemoveViewsProcsandTriggerMigrationHistory2') " +
                     "  BEGIN " +
                     "       DELETE FROM __EFMigrationsHistory WHERE MigrationId = '99999999999999_RemoveViewsProcsandTriggerMigrationHistory2'" +
                     "  END ";

            migrationBuilder.Sql(sqlString);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
