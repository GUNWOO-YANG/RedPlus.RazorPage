using RedPlus.Models;
using System.Text.Json;

namespace RedPlus.Service
{
    public class PortfoliosServiceJsonFile
    {
        private readonly IWebHostEnvironment _webHostEnvironment;

        public PortfoliosServiceJsonFile(IWebHostEnvironment webHostEnvironment)
        {
            this._webHostEnvironment = webHostEnvironment;
        }

        private  string JsonFileName {
            get
            {
                //return _webHostEnvironment.WebRootPath + "\\Portfolios" + "\\portfolios.json";
                return Path.Combine(_webHostEnvironment.WebRootPath, "Portfolios", "portfolios.json");
            }
        }

        public IEnumerable<Portfolio>GetPortfolios()
        {
            //var jsonFileName = @"C:\\RazorPages\\RedPlus.RazorPage\\RedPlus\\wwwroot\\Portfolios\\portfolios.json";

            using(var jsonFileReader = File.OpenText(JsonFileName))
            {
                var options = new JsonSerializerOptions() { PropertyNameCaseInsensitive=true };

                var portfolios =JsonSerializer.Deserialize<Portfolio[]>(jsonFileReader.ReadToEnd(), options);
                return portfolios;
            }
        }
    }
}
