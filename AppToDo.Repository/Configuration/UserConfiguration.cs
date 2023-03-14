using AppToDo.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AppToDo.Repository.Configuration
{
    internal class UserConfiguration:IEntityTypeConfiguration<User>
    {

        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.UserName).IsRequired();
            builder.HasMany(user => user.FollowedToDoLists);
            builder.HasMany(user => user.CreatedToDoLists);
        }
    }
}
