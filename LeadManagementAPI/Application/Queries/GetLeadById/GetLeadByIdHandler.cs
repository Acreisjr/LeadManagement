using MediatR;
using LeadManagementAPI.Data;
using LeadManagementAPI.Models;

namespace LeadManagementAPI.Application.Queries
{
    public class GetLeadByIdHandler : IRequestHandler<GetLeadByIdQuery, Lead>
    {
        private readonly LeadDbContext _context;

        public GetLeadByIdHandler(LeadDbContext context)
        {
            _context = context;
        }

        public async Task<Lead> Handle(GetLeadByIdQuery request, CancellationToken cancellationToken)
        {
            var lead = await _context.Leads.FindAsync(request.Id);

            if (lead == null)
                throw new KeyNotFoundException($"Lead with ID {request.Id} not found.");

            return lead;
        }
    }
}
