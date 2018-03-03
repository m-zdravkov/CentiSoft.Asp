using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Task { get; set; }
        public DateTime DueDate { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public List<Task> Tasks { get; set; }
    }
}