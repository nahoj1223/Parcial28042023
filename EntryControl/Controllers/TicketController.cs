using EntryControl.API.Data;
using EntryControl.Shared.DTOs;
using EntryControl.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace EntryControl.API.Controllers
{
    [ApiController]
    [Route("/api/ticket")]
    public class TicketController : ControllerBase
    {

        private readonly DataContext _context;

        public TicketController(DataContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> Get(string id)
        {
            var ticket = await _context.Tickets
                .FirstOrDefaultAsync(x => x.IdTicket == id);
            if (ticket is null)
            {
                return NotFound();
            }

            return Ok(ticket);
        }

        [HttpPut]
        public async Task<ActionResult> Put(TicketDTO ticketDTO)
        {
            var ticket = new Ticket
            {
                Id= ticketDTO.Id,
                IdTicket = ticketDTO.IdTicket,
                EntranceType = ticketDTO.EntranceType,
                WasUsed = ticketDTO.WasUsed,
                UseDate = ticketDTO.UseDate
            };
            _context.Update(ticket);
            try
            {
                await _context.SaveChangesAsync();
                return Ok(ticket);
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }
    }
}
