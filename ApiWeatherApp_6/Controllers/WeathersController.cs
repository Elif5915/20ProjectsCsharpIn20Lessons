using ApiWeatherApp_6.Context;
using ApiWeatherApp_6.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ApiWeatherApp_6.Controllers;
[Route("api/[controller]")]
[ApiController]
public class WeathersController : ControllerBase
{
	WeatherContext context = new WeatherContext();

	[HttpGet]
	public IActionResult WeatherCityList()
	{
		var values = context.Cities.ToList();
		return Ok(values);
	}

	[HttpPost]
	public IActionResult WeatherCreate(City city)
	{
		context.Cities.Add(city);
		context.SaveChanges();
		return Ok("İşlem başarı ile gerçekleşti,yeni kayıt oluştu.");
	}

	[HttpDelete]
	public IActionResult DeleteWeatherCity(int id)
	{
		var value = context.Cities.Find(id);
		context.Cities.Remove(value);
		context.SaveChanges();
		return Ok("Şehir Silindi");
	}

	[HttpPut]
	public IActionResult UpdateWeatherCity(City city)
	{
		var value = context.Cities.Find(city.CityId);
		value.CityName = city.CityName;
		value.Country = city.Country;
		value.Temp = city.Temp;
		value.Detail = city.Detail;
		context.SaveChanges();
		return Ok("Şehir Bilgisi Güncellendi..");
	}

	[HttpGet("GetByIdWeatherCity")]
	public IActionResult GetByIdWeatherCity(int id)
	{
		var value = context.Cities.Find(id);
		return Ok(value);
	}
	[HttpGet("TotalCityCount")]
	public IActionResult TotalCityCount()
	{
		var value = context.Cities.Count();
		return Ok(value);
	}

	[HttpGet("MaxTempCityName")]
	public IActionResult MaxTempCityName()
	{
		var value = context.Cities.OrderByDescending(x => x.Temp).Select(y => y.CityName).FirstOrDefault();
		return Ok(value);
	}

	[HttpGet("MinTempCityName")]

	public IActionResult MinTempCityName()
	{
		var value = context.Cities.OrderBy(z => z.Temp).Select(x => x.CityName).FirstOrDefault();
		return Ok(value);
	}




}
