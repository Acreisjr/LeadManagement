using MediatR;

namespace LeadManagementAPI.Application.Commands
{
    public class AcceptLeadCommand : IRequest<bool>
    {
        public int Id { get; set; }
    }
}
