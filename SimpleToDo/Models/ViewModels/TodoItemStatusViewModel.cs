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
        public int TodoItemId { get; set; }

        [Display(Name = "Title")]
        [Required]
        public string Title { get; set; }


        [Display(Name = "Status")]
        [Required]
        public int TodoStatusId { get; set; }

        [Display(Name = "Status")]
        [Required]
        public string Status { get; set; }
        public List<SelectListItem> StatusOptions { get; set; }
    }
}
