using MediatR;
using LeadManagementAPI.Models;

namespace LeadManagementAPI.Application.Commands
{
    public class CreateLeadCommand : IRequest<Lead>
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Suburb { get; set; }
        public string? Category { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
    }
}
