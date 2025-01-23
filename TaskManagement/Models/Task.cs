﻿using System.ComponentModel.DataAnnotations;

namespace TaskManagement.Models
{
    public class Task
    {
        [Key]
        public int Id { get; set; } 
        public string Title { get; set; }
    }
}
