using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleToDo.Models.ViewModels
{
    public class TodoItemStatusViewModel
    {
        public int Id { get; set; }

      
        public string Title { get; set; }


        public int TodoStatusId { get; set; }


        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public List<SelectListItem> StatusOptions { get; set; }
    }
}
