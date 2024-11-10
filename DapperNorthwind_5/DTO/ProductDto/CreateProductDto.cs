using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperNorthwind_5.DTO.ProductDto
{
	public class CreateProductDto
	{
		// public int ProductID { get; set; } otomatik artan db çünkü ihtiyacımız yok
		public string ProductName { get; set; }

		public decimal UnitPrice { get; set; }
		public int UnitsInStock { get; set; }
		public int CategoryID { get; set; }
	} 
}
