// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SpotifyRecommendedPlaylistAPI.Data.Migrations
{
    [DbContext(typeof(SpotifyRecommendedPlaylistAPIDataContext))]
    [Migration("99999999999997_SpotifyRecommendedPlaylistAPI_Views")]
    partial class SpotifyRecommendedPlaylistAPI_Views
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SpotifyRecommendedPlaylistAPI.Data.Models.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("UserID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserID"), 1L, 1);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Email");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Name");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Phone");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("UserName");

                    b.HasKey("UserID");

                    b.ToTable("Users", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
