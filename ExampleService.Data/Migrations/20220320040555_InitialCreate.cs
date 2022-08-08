using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace ExampleService.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            foreach (String sqlString in this.GetSQLResourceFileText("ExampleService.Data.Migrations.InitialScripts.01_createUsers.sql"))
            {
                migrationBuilder.Sql(sqlString);
            }
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
        
        }
    }
}
