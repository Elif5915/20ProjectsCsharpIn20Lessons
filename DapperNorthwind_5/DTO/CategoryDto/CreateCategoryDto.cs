using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperNorthwind_5.DTO.CategoryDto
{
	public class CreateCategoryDto
	{
		//public int CategoryId { get; set; } mssql de db de otomatik artan olduğu için gerek yok buna
		public string CategoryName { get; set; }
		public string Description { get; set; }
	}
}
