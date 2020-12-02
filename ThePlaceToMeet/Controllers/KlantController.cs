using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ThePlaceToMeet.Filters;
using ThePlaceToMeet.Models.Domain;

namespace ThePlaceToMeet.Controllers
{
    public class KlantController : Controller
    {
        [ServiceFilter(typeof(KlantFilter))]
        [Authorize]
        public IActionResult Index(Klant klant)
        {
            return View(klant.Reservaties);
        }
    }
}
