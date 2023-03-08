using Microsoft.AspNetCore.Mvc;

namespace Hashboard.Controllers
{
	public class ProjectController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
