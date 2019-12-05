using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using TeduCoreApp.Data.Enums;
using TeduCoreApp.Data.Interfaces;
using TeduCoreApp.Infrastructure.SharedKernel;

namespace TeduCoreApp.Data.Entities
{
    [Table("TodoLists")]
    public class TodoList : DomainEntity<int>, ISwitchable
    {
        public TodoList() { }
        public TodoList(int id, string userID, string content, DateTime createddate, Status status)
        {
            Id = id;
            UserID = userID;
            Content = content;
            CreatedDate = createddate;
            Status = status;
        }
        public TodoList( string userID, string content, DateTime createddate, Status status)
        {
           
            UserID  = userID;
            Content = content;
            CreatedDate = createddate;
            Status = status;
        }
        [Required]
        public string UserID { get; set; }
        [Required]
        public string Content { get; set; }
        public DateTime CreatedDate { get; set; }
        public Status Status { get; set; }
    }
}
