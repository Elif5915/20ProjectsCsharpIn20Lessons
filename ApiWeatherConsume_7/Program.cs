#region Menü_Baslangıc

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text;

Console.WriteLine("Api Consume İşlemine Hoş Geldiniz");
Console.WriteLine();
Console.WriteLine("### Yapmak istediğiniz İşlemi Seçin ###");
Console.WriteLine();
Console.WriteLine("1-Şehir Listesini Getirin.");
Console.WriteLine("2-Şehir ve Hava durumu listesini getirin");
Console.WriteLine("3-Yeni şehir Ekleme");
Console.WriteLine("4-Şehir Silme İşlemi");
Console.WriteLine("5-Şehir Güncelleme İşlemi");
Console.WriteLine("6-Id Göre Şehir Getirme İşlemi");

Console.WriteLine();

#endregion

string number;


Console.Write("Tercihiniz : ");
number = Console.ReadLine();
Console.WriteLine();

if (number == "1")
{
    Console.WriteLine("Şehir Listesi buraya gelecek");
    string url = "https://localhost:7010/api/Weathers";//buradaki url bizim apimizin urlsi apimizi tüketmemiz için url ihtiyacımız var tabiki.
    using (HttpClient client = new HttpClient()) //HttpClient sınıfı : HTTP istekleri göndermek ve URI ile tanımlanan bir kaynaktan HTTP yanıtları almak için bir sınıf sağlar.
    {
        HttpResponseMessage response = await client.GetAsync(url); // HttpResponseMessage : Durum kodu ve verileri içeren bir HTTP yanıt iletisini temsil eder.
        string responseBody = await response.Content.ReadAsStringAsync();
        JArray jArray = JArray.Parse(responseBody);
        //JArray bu paket Newtonsoft.json paketin yükleyişnce gelir ve bu jarray bizim string formatta apiden okuduğumuz değerleri/dataları json formatına parse edilip istediğin bir değeri gösterebilrsin
        foreach (var item in jArray)
        {
            string cityName = item["cityName"].ToString();
            Console.WriteLine($"{cityName}");

        }
    }
}
if (number == "2")
{
    string url = "https://localhost:7010/api/Weathers";
    using (HttpClient client = new HttpClient())
    {
        HttpResponseMessage response = await client.GetAsync(url);
        string responseBody = await response.Content.ReadAsStringAsync();
        JArray jArray = JArray.Parse(responseBody);
        foreach (var data in jArray)
        {
            string cityName = data["cityName"].ToString();
            string country = data["country"].ToString();
            string temp = data["temp"].ToString();
            Console.WriteLine(cityName + "-" + country + "-" + temp);
            Console.WriteLine("***************************************************");
        }
    }

}
if (number == "3")
{
    Console.WriteLine("### Yeni Şehir ekleme işlemi ###");
    Console.WriteLine();
    string cityName, country, detail;
    decimal temp;

    Console.Write("Şehir Adı: ");
    cityName = Console.ReadLine();
    Console.Write("Ülke Adı: ");
    country = Console.ReadLine();
    Console.Write("Hava durumu detayı: ");
    detail = Console.ReadLine();

    Console.Write("Sıcaklık: ");
    temp = decimal.Parse(Console.ReadLine());

    string url = "https://localhost:7010/api/Weathers";
    var newWeatherCity = new
    {
        CityName = cityName,
        Country = country,
        Detail = detail,
        temp = temp
    };

    using (HttpClient client = new HttpClient())
    {
        string JsonData = JsonConvert.SerializeObject(newWeatherCity);
        StringContent content = new StringContent(JsonData, Encoding.UTF8, "application/json");
        HttpResponseMessage response = await client.PostAsync(url, content);
        response.EnsureSuccessStatusCode();
        //bir HTTP isteğinin başarılı olup olmadığını kontrol etmek için kullanılır.
        //Eğer HTTP yanıtı başarısız bir durum kodu döndürürse (örneğin: 4xx veya 5xx hataları), bu metod bir HttpRequestException fırlatır.
    }

}
if (number == "4")
{
    string url = "https://localhost:7010/api/Weathers?id=";

    Console.Write("Silmek istediğiniz Id değeri: ");
    int id = int.Parse(Console.ReadLine());

    using (HttpClient client = new HttpClient())
    {
        HttpResponseMessage response = await client.DeleteAsync(url + id);
        response.EnsureSuccessStatusCode();
    }
}
if (number == "5")
{

    string url = "https://localhost:7010/api/Weathers";

    Console.WriteLine("### Şehir bilgisi güncelleme işlemi ###");
    Console.WriteLine();
    string cityName, country, detail;
    decimal temp;
    int cityId;

    Console.Write("Şehir Adı: ");
    cityName = Console.ReadLine();
    Console.Write("Ülke Adı: ");
    country = Console.ReadLine();
    Console.Write("Hava durumu detayı: ");
    detail = Console.ReadLine();

    Console.Write("Sıcaklık: ");
    temp = decimal.Parse(Console.ReadLine());

    Console.Write("Şehir Id: ");
    cityId = int.Parse(Console.ReadLine());

    var updateWeatherCity = new
    {
        CityId = cityId,
        CityName = cityName,
        Country = country,
        Detail = detail,
        temp = temp

    };
    using (HttpClient client = new HttpClient())
    {
        string json = JsonConvert.SerializeObject(updateWeatherCity);
        StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
        HttpResponseMessage response = await client.PutAsync(url, content);
        response.EnsureSuccessStatusCode();
    }

}
Console.Read();