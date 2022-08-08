using Microsoft.EntityFrameworkCore.Migrations;
using System;

#nullable disable

namespace ExampleService.Data.Migrations
{
    public partial class RemoveViewsProcsandTriggerMigrationHistory2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            String sqlString = String.Empty;

            sqlString =
                      "IF EXISTS(SELECT *" +
                      "          FROM __EFMigrationsHistory" +
                      "          WHERE MigrationId = '99999999999996_ExampleService_Procs') " +
                      "  BEGIN " +
                      "       DELETE FROM __EFMigrationsHistory WHERE MigrationId = '99999999999996_ExampleService_Procs'" +
                      "  END ";

            migrationBuilder.Sql(sqlString);

            sqlString =
                      "IF EXISTS(SELECT *" +
                      "          FROM __EFMigrationsHistory" +
                      "          WHERE MigrationId = '99999999999997_ExampleService_Views') " +
                      "  BEGIN " +
                      "       DELETE FROM __EFMigrationsHistory WHERE MigrationId = '99999999999997_ExampleService_Views'" +
                      "  END ";

            migrationBuilder.Sql(sqlString);

            sqlString =
                      "IF EXISTS(SELECT *" +
                      "          FROM __EFMigrationsHistory" +
                      "          WHERE MigrationId = '99999999999998_ExampleService_Triggers') " +
                      "  BEGIN " +
                      "       DELETE FROM __EFMigrationsHistory WHERE MigrationId = '99999999999998_ExampleService_Triggers'" +
                      "  END ";

            migrationBuilder.Sql(sqlString);

            sqlString =
                     "IF EXISTS(SELECT *" +
                     "          FROM __EFMigrationsHistory" +
                     "          WHERE MigrationId = '99999999999999_RemoveViewsProcsandTriggerMigrationHistory1') " +
                     "  BEGIN " +
                     "       DELETE FROM __EFMigrationsHistory WHERE MigrationId = '99999999999999_RemoveViewsProcsandTriggerMigrationHistory1'" +
                     "  END ";

            migrationBuilder.Sql(sqlString);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
