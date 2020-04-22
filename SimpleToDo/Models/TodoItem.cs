using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleToDo.Models
{
    public class TodoItem
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public int TodoStatusId { get; set; }
        public TodoStatus TodoStatus { get; set; }
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}
