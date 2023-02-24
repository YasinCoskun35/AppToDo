using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppToDo.Core.Entities
{
    public class ToDoAction:BaseEntity
    {
        public bool IsDone { get; set; }
        public Guid ToDoItemId { get; set; }
    }
}
