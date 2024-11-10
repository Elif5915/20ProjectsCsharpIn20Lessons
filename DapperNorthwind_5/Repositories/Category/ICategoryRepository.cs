using DapperNorthwind_5.DTO.CategoryDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperNorthwind_5.Repositories.Category
{
	//bizim yapacağımız işlemlerin imzasını tutacak olan yer burası.
	//interface metodların imzasını tutan yapı
	public interface ICategoryRepository
	{
		//Task asenkron metodlarda kullanılır. Asenkron metod ise başka bir işin bitmesini beklemeden çalışması.
		Task<List<ResultCategoryDto>> GetAllCategoryAsync();
		Task CreateCategoryAsync(CreateCategoryDto createCategoryDto);
		Task UpdateCategoryAsync(UpdateCategoryDto updateCategoryDto);
		Task DeleteCategoryAsync(int id);
		Task<GetByIdCategoryDto> GetByIdCategoryAsync(int id);
	}
}
