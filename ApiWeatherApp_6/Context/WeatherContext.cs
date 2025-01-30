using ApiWeatherApp_6.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApiWeatherApp_6.Context;

public class WeatherContext : DbContext
{
	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		optionsBuilder.UseSqlServer("Server= NETCADYAZ;initial catalog=ApiWeatherDB;integrated Security=true");
	}
	public DbSet<City> Cities { get; set; }
}
