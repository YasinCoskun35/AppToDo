using AppToDo.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AppToDo.Repository.Configuration
{
    internal class ToDoItemConfiguration:IEntityTypeConfiguration<ToDoItem>
    {
        public void Configure(EntityTypeBuilder<ToDoItem> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.ToDoListId).IsRequired();
            builder.Property(x => x.Title).IsRequired();
        }
    }
}
