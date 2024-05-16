using System;
using Fiorella.Models;
using Fiorella.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Fiorella.Services
{
	public class CategoryService:ICategoryService
	{
        private readonly AppDbContext _context;

        public CategoryService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Category>> GetAllAsync()
        {
            return await _context.Categories.ToListAsync();
        }
    }
}

