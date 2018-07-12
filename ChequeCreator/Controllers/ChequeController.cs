using System.Web.Mvc;

using ChequeCreator.Extensions;
using ChequeCreator.Models;

namespace ChequeCreator.Controllers
{
    public class ChequeController : Controller
    {
        // GET: Cheque
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateInput(true)]
        public ActionResult Submit(ChequeModel model)
        {
            if (!ModelState.IsValid)
                return Index();

            var vm = model.MapToViewModel();

            return View(vm);
        }
    }
}
