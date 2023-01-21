using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechStore.Interfaces;
using TechStore.DAL;

namespace TechStore.Services
{
    public class LayoutService : ILayoutService
    {
        private readonly AppDbContext _context;
        public LayoutService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IDictionary<string, string>> GetSettings()
        {

            return await _context.Settings.ToDictionaryAsync(s => s.Key, s => s.Value);
        }
    }
}
