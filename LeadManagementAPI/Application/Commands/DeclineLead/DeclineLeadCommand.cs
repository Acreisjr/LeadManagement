using MediatR;

namespace LeadManagementAPI.Application.Commands
{
    public class DeclineLeadCommand : IRequest<bool>
    {
        public int Id { get; set; }
    }
}
