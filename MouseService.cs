using System;
using System.Text.Json;
using Task.Models;

namespace Task
{
    public class MouseService
    {
        private readonly AppDbContext context;

        public MouseService(AppDbContext context)
        {
            this.context = context;
        }

        public async ValueTask SaveMouseDataAsync(List<MouseCoordinates> mouseData)
        {
            var serializedData = JsonSerializer.Serialize(mouseData);

            var mouseMovement = new MouseMovement
            {
                Coordinates = serializedData
            };

            await context.MouseMovements.AddAsync(mouseMovement);
            await context.SaveChangesAsync();
        }
    }
}
