using MediatR;
using LeadManagementAPI.Data;
using LeadManagementAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace LeadManagementAPI.Application.Queries
{
    public class GetAcceptedLeadsHandler : IRequestHandler<GetAcceptedLeadsQuery, List<Lead>>
    {
        private readonly LeadDbContext _context;

        public GetAcceptedLeadsHandler(LeadDbContext context)
        {
            _context = context;
        }

        public async Task<List<Lead>> Handle(GetAcceptedLeadsQuery request, CancellationToken cancellationToken)
        {
            return await _context.Leads.Where(l => l.Status == "Accepted").ToListAsync();
        }
    }
}
