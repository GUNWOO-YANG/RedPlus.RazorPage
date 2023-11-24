using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RedPlus.Models;
using RedPlus.Service;

namespace RedPlus.Pages.Portfolios
{
    public class IndexModel : PageModel
    {
        private readonly PortfoliosServiceJsonFile _service;

        //생성자의 매개 변수로 서비스(리포지토리) 클래스 주입
        public IndexModel(PortfoliosServiceJsonFile service)
        {
            this._service = service;
        }

        public IEnumerable<Portfolio> Portfolios { get; set; }

        public void OnGet()
        {
            Portfolios = _service.GetPortfolios();
        }
    }
}
