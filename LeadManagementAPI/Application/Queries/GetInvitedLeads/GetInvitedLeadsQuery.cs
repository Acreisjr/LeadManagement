using MediatR;
using LeadManagementAPI.Models;

namespace LeadManagementAPI.Application.Queries
{
    public class GetInvitedLeadsQuery : IRequest<List<Lead>> { }
}
