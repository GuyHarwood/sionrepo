using System.Collections.Generic;
using System.Web.Mvc;
using domain;

namespace web.Controllers
{
	public class HomeController : Controller
	{
		private readonly ContactService contactService;

		public HomeController(ContactService contactService)
		{
			this.contactService = contactService;
		}

		public ActionResult Index()
		{
			return View(new HomeIndexViewModel()
			{
				Contacts = contactService.GetActive()
			});
		}
	}

	public class HomeIndexViewModel
	{
		public IEnumerable<Contact> Contacts { get; set; } 
	}
}