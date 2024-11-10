using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperNorthwind_5.DTO.CategoryDto
{
	// bu sınıf bizim bütün listeleme işlemleri için kullanacağımız kategori sınıfımız 
	public class ResultCategoryDto
	{
		public int CategoryID { get; set; }
		public string CategoryName { get; set; }
		public string Description { get; set; }
	}
}
