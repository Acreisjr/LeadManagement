using MediatR;
using LeadManagementAPI.Models;

namespace LeadManagementAPI.Application.Queries
{
    public class GetLeadByIdQuery : IRequest<Lead>
    {
        public int Id { get; set; }
    }
}
