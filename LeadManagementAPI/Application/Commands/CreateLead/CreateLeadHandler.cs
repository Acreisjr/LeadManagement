using MediatR;
using LeadManagementAPI.Data;
using LeadManagementAPI.Models;


namespace LeadManagementAPI.Application.Commands
{
    public class CreateLeadHandler : IRequestHandler<CreateLeadCommand, Lead>
    {
        private readonly LeadDbContext _context;

        public CreateLeadHandler(LeadDbContext context)
        {
            _context = context;
        }

        public async Task<Lead> Handle(CreateLeadCommand request, CancellationToken cancellationToken)
        {

            var lead = new Lead
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                Suburb = request.Suburb,
                Category = request.Category,
                Description = request.Description,
                Price = request.Price,
                DateCreated = DateTime.Now,
                PhoneNumber = request.PhoneNumber,
                Email = request.Email,
                Status = "Invited"
            };

            _context.Leads.Add(lead);
            await _context.SaveChangesAsync();

            return lead;
        }
    }
}
