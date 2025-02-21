using MediatR;
using LeadManagementAPI.Data;
using System.Text;


namespace LeadManagementAPI.Application.Commands
{
    public class AcceptLeadHandler : IRequestHandler<AcceptLeadCommand, bool>
    {
        private readonly LeadDbContext _context;

        public AcceptLeadHandler(LeadDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(AcceptLeadCommand request, CancellationToken cancellationToken)
        {
            var lead = await _context.Leads.FindAsync(request.Id);
            if (lead == null) return false;

            if (lead.Price > 500)
                lead.Price *= 0.9m;

            lead.Status = "Accepted";
            await _context.SaveChangesAsync();

            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "lead_notifications.txt");
            string emailMessage = $"Lead {lead.Id} was accepted!\n" +
                                  $"Name: {lead.FirstName} {lead.LastName}\n" +
                                  $"Email: {lead.Email}\n" +
                                  $"Price: ${lead.Price:F2}\n" +
                                  $"Notification sent to vendas@test.com\n\n";

            await System.IO.File.AppendAllTextAsync(filePath, emailMessage, Encoding.UTF8);
            return true;
        }
    }
}
