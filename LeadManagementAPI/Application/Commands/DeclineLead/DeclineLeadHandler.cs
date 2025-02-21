using MediatR;
using LeadManagementAPI.Data;
using System.Threading;
using System.Threading.Tasks;

namespace LeadManagementAPI.Application.Commands
{
    public class DeclineLeadHandler : IRequestHandler<DeclineLeadCommand, bool>
    {
        private readonly LeadDbContext _context;

        public DeclineLeadHandler(LeadDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(DeclineLeadCommand request, CancellationToken cancellationToken)
        {
            var lead = await _context.Leads.FindAsync(request.Id);
            if (lead == null) return false;

            lead.Status = "Declined";
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
