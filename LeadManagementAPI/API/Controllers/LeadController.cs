using Microsoft.AspNetCore.Mvc;
using MediatR;
using LeadManagementAPI.Application.Queries;
using LeadManagementAPI.Application.Commands;
using LeadManagementAPI.Models;

namespace LeadManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeadController : ControllerBase
    {
        private readonly IMediator _mediator;

        public LeadController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("invited")]
        public async Task<ActionResult<IEnumerable<Lead>>> GetInvitedLeads()
        {
            return await _mediator.Send(new GetInvitedLeadsQuery());
        }

        [HttpGet("accepted")]
        public async Task<ActionResult<IEnumerable<Lead>>> GetAcceptedLeads()
        {
            return await _mediator.Send(new GetAcceptedLeadsQuery());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetLeadById(int id)
        {
            var lead = await _mediator.Send(new GetLeadByIdQuery { Id = id });
            if (lead == null)
                return NotFound();

            return Ok(lead);
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateLead([FromBody] CreateLeadCommand command)
        {
            var lead = await _mediator.Send(command);
            return CreatedAtAction(nameof(GetLeadById), new { id = lead.Id }, lead);
        }

        [HttpPost("{id}/accept")]
        public async Task<IActionResult> AcceptLead(int id)
        {
            var result = await _mediator.Send(new AcceptLeadCommand { Id = id });
            return result ? NoContent() : NotFound();
        }

        [HttpPost("{id}/decline")]
        public async Task<IActionResult> DeclineLead(int id)
        {
            var result = await _mediator.Send(new DeclineLeadCommand { Id = id });
            return result ? NoContent() : NotFound();
        }
    }
}
