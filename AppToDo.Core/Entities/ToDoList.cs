using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppToDo.Core.Entities
{
    public class ToDoList:BaseEntity
    {
        public string? Title { get; set; }

        public ICollection<ToDoItem>? ToDoItems { get; set; }
    }
}
