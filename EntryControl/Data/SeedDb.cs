using EntryControl.Shared.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32;

namespace EntryControl.API.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;
        public SeedDb(DataContext context)
        {
            _context = context;
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckTicketsAsync();
        }

        private async Task CheckTicketsAsync()
        {
            var count = await _context.Tickets.CountAsync();

            if (count < 10000)
            {
                for (int i = 0; i < 50000; i++)
                {
                    Guid guid = Guid.NewGuid();
                    var ticket = new Ticket
                    {
                        IdTicket = guid.ToString(),
                        UseDate = null,
                        WasUsed = false,
                        EntranceType = null,
                    };
                    _context.Tickets.Add(ticket);
                    await _context.SaveChangesAsync();
                }
            }
        }
    }
}
