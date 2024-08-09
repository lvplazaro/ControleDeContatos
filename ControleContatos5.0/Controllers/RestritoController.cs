using ControleContatos5._0.Filters;
using Microsoft.AspNetCore.Mvc;

namespace ControleContatos5._0.Controllers
{
    [PaginaParaUsuarioLogado]
    public class RestritoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
