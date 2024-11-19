using ApiWeather_6.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApiWeather_6.Context;

public class WeatherContext : DbContext
{
	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		optionsBuilder.UseSqlServer("Server = NETCADYAZ; initial catalog =Db6Project20; integrated Security = true");
	}

	public DbSet<City> Cities { get; set; }
}
