namespace TesteController
{
   public class TesteController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Titulo = "Página Inicial - Index";
            return View();
        }

        public IActionResult Listar()
        {
            ViewBag.Titulo = "Página de Listagem";
            return View();
        }

        public IActionResult Cadastrar()
        {
            ViewBag.Titulo = "Página de Cadastro";
            return View();
        }

        public IActionResult Editar()
        {
            ViewBag.Titulo = "Página de Edição";
            return View();
        }
    }
}