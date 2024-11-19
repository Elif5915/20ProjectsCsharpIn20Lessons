using ApiWeather_6.Context;
using ApiWeather_6.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ApiWeather_6.Controllers;
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
	public IActionResult WeatherCityAdd(City city)
	{
		context.Cities.Add(city);
		context.SaveChanges();

		return Ok("Şehir Eklendi..");

	}

	[HttpDelete]
	public IActionResult WeatherCityDelete(int id)
	{
		var value = context.Cities.Find(id);
		context.Cities.Remove(value);
		context.SaveChanges();

		return Ok("Şehir Silindi..");
	}

	[HttpPut]
	public IActionResult WeatherCityUpdate(City city)
	{
		var value = context.Cities.Find(city.CityId);
		value.CityName = city.CityName;
		value.Country = city.Country;
		value.Temp = city.Temp;
		value.Detail = city.Detail;
		context.SaveChanges();

		return Ok("Hava Durumu Bilgisi Güncellendi.");

	}

	[HttpGet("GetByIdWeatherCity")]
	//Bir Api projesindekicontrollerde iki defa aynı get,post, vs attribute kullanılmaz ama kullanmak
	//istersende attribute içine metodun ismini yazman gerekir.
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

	[HttpGet("MaxTempCity")]
	public IActionResult MaxTempCity()
	{
		var values = context.Cities.Max(x => x.Temp);
		return Ok(values);
	}

	[HttpGet("MinTempCity")]
	public IActionResult MinTempCity()
	{
		var value = context.Cities.OrderBy(x => x.Temp).Select(y => y.CityName).FirstOrDefault();
		return Ok(value);
	}
}
