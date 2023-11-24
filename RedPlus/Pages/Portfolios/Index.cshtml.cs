using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RedPlus.Models;
using RedPlus.Service;

namespace RedPlus.Pages.Portfolios
{
    public class IndexModel : PageModel
    {
        private readonly PortfoliosServiceJsonFile _service;

        //�������� �Ű� ������ ����(�������丮) Ŭ���� ����
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
