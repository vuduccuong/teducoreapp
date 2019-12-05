using System;
using System.Collections.Generic;
using System.Text;
using TeduCoreApp.Data.Enums;

namespace TeduCoreApp.Application.ViewModels.TodoList
{
    public class TodoListViewModel
    {
        public int ID { get; set; }
        public string UserID { get; set; }
        public string Content { get; set; }
        public DateTime CreatedDate { get; set; }
        public string BackDate { get; set; }
        public Status Status { get; set; }
    }
}
