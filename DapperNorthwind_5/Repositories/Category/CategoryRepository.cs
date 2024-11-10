using DapperNorthwind_5.DTO.CategoryDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperNorthwind_5.Repositories.Category
{
	public class CategoryRepository : ICategoryRepository
	{
		public Task CreateCategoryAsync(CreateCategoryDto createCategoryDto)
		{
			throw new NotImplementedException();
		}

		public Task DeleteCategoryAsync(int id)
		{
			throw new NotImplementedException();
		}

		public Task<List<ResultCategoryDto>> GetAllCategoryAsync()
		{
			throw new NotImplementedException();
		}

		public Task<GetByIdCategoryDto> GetByIdCategoryAsync(int id)
		{
			throw new NotImplementedException();
		}

		public Task UpdateCategoryAsync(UpdateCategoryDto updateCategoryDto)
		{
			throw new NotImplementedException();
		}
	}
}
