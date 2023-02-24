using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppToDo.Core.Entities
{
    public class User:BaseEntity
    {
        public String Name { get; set; }
        public String UserName { get; set; }
    }
}
