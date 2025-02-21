using MediatR;
using LeadManagementAPI.Data;
using LeadManagementAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace LeadManagementAPI.Application.Queries
{
    public class GetInvitedLeadsHandler : IRequestHandler<GetInvitedLeadsQuery, List<Lead>>
    {
        private readonly LeadDbContext _context;

        public GetInvitedLeadsHandler(LeadDbContext context)
        {
            _context = context;
        }

        public async Task<List<Lead>> Handle(GetInvitedLeadsQuery request, CancellationToken cancellationToken)
        {
            return await _context.Leads.Where(l => l.Status == "Invited").ToListAsync();
        }
    }
}
