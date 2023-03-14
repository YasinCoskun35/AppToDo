using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppToDo.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AppToDo.Repository.Configuration
{
    internal class ToDoActionConfiguration:IEntityTypeConfiguration<ToDoAction>
    {
        public void Configure(EntityTypeBuilder<ToDoAction> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.HasOne(tdi => tdi.ToDoItem).WithMany(tda => tda.ToDoActions);
            builder.ToTable("ToDoActions");
        }
    }
}
