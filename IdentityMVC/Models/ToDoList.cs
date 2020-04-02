using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IdentityMVC.Models
{
    [Table("TB_T_ToDoList")]
    public class ToDoList
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual string UserId { get; set; } // Foreign Key
    }
}