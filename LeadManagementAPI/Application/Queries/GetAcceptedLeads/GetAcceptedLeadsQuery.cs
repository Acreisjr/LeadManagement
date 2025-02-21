using MediatR;
using LeadManagementAPI.Models;

namespace LeadManagementAPI.Application.Queries
{
    public class GetAcceptedLeadsQuery : IRequest<List<Lead>> { }
}
