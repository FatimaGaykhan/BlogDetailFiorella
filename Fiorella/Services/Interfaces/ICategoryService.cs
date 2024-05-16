using System;
using Fiorella.Models;

namespace Fiorella.Services.Interfaces
{
	public interface ICategoryService
	{
		Task<IEnumerable<Category>> GetAllAsync();
	}
}

