using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.Models
{
    public class Customer : IIdentifiable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int ClientId { get; set; }
        public List<Project> Projects { get; set; }
    }
}