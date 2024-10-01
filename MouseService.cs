using System;
using Task.Models;

namespace Task
{
    public class MouseService
    {
        private readonly AppDbContext _context;

        public MouseService(AppDbContext context)
        {
            _context = context;
        }

        public async ValueTask SaveMouseDataAsync(string coordinates)
        {
            var mouseMovement = new MouseMovement
            {
                Coordinates = coordinates
            };

            _context.MouseMovements.Add(mouseMovement);
            await _context.SaveChangesAsync();
        }
    }
}
