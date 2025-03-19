using Microsoft.AspNetCore.Mvc;
using MvcNetCoreChollome.Repositories;
using MvcNetCoreChollome.Models;

namespace MvcNetCoreChollome.Controllers
{
    public class ChollometroController : Controller
    {
        private RepositoryChollometro repo;
        public ChollometroController(RepositoryChollometro repo) {
            this.repo = repo;
        }

        public async Task<IActionResult> Index() {
            List<Chollo> chollos = await this.repo.GetChollosAsync();
            return View(chollos);
        }


    }
}
