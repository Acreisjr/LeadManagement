using System;

namespace LeadManagementAPI.Models
{
    public class Lead
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime DateCreated { get; set; }
        public string? Suburb { get; set; }
        public string? Category { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public string? Status { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
    }
}
