using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppToDo.Core.Entities
{
    public class ToDoList:BaseEntity
    {
        public string Title { get; set; }
        public bool Public { get; set; }
        public string Description { get; set; }


        public User Creator { get; set; }
        public ICollection<ToDoItem>? ToDoItems { get; set; }
    }
}
