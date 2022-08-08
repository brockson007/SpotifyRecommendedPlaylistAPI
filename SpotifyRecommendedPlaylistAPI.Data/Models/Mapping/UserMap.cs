using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SpotifyRecommendedPlaylistAPI.Data.Models.Mapping
{
    public class UserMap: IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            #region Primary Key
            builder.HasKey(t => t.UserID);
            #endregion Primary Key

            builder.ToTable("Users");
            builder.Property(t => t.UserID).HasColumnName("UserID");
            builder.Property(t => t.Name).HasColumnName("Name");
            builder.Property(t => t.UserName).HasColumnName("UserName");
            builder.Property(t => t.Email).HasColumnName("Email");
            builder.Property(t => t.Phone).HasColumnName("Phone");
        }
    }
}
