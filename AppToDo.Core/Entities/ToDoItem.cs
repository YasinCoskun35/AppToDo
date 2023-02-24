using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppToDo.Core.Entities
{
    public class ToDoItem : BaseEntity
    {
        public string Title { get; set; }

        public string Detail { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public Guid ToDoListId { get; set; }
    }
}
