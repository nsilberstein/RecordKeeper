using Microsoft.AspNetCore.Mvc;
using RecordKeeperBizObjects;
using CPUFramework;
using Microsoft.AspNetCore.Cors;

namespace RecordKeeperWeb.Controllers
{
    public class PresidentController : Controller
    {
        public IActionResult Index()
        {
            List<BizPresident> lst = BizPresident.GetAll();
            return View(lst);
        }

        [EnableCors("Policy1")]
        public IActionResult APIPresidentList()
        {
            List<BizPresident> lst = BizPresident.GetAll();
            return Json(lst);
        }

        public IActionResult President(string id)
        {
            BizPresident prez = BizPresident.Get("Code", id);
            return View(prez);
        }

        public IActionResult Edit(string id)
        {           
            BizPresident prez = BizPresident.Get("Code", id);
            return View(prez);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(BizPresident prez)
        {
            try
            {
                prez.Save();
            }
            catch (CPUException ex)
            {
                prez = BizPresident.Get(prez.PresidentId);
                ViewBag.ErrorMessage = ex.FriendlyMessage;
            }
            return View(prez);
        }
    }
}
