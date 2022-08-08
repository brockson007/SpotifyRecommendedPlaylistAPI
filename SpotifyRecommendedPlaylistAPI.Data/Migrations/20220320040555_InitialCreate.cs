using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace SpotifyRecommendedPlaylistAPI.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            foreach (String sqlString in this.GetSQLResourceFileText("SpotifyRecommendedPlaylistAPI.Data.Migrations.InitialScripts.01_createUsers.sql"))
            {
                migrationBuilder.Sql(sqlString);
            }
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
        
        }
    }
}
