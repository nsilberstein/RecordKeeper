using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RecordKeeperBizObjects;

namespace RecordKeeperWeb.Controllers
{
    public class PartiesController : Controller
    {
        
        public ActionResult Index()
        {
            List<BizParty> lst = BizParty.GetAll();
            return View(lst);
        }
        [EnableCors("Policy1")]
        public ActionResult APIPartyList()
        {
            List<BizParty> lst = BizParty.GetAll();
            return Json(lst);
        }

        // GET: PartiesController/Details/5
        public ActionResult Details(string id)
        {
            BizParty p = BizParty.Get("PartyName", id);
            return View(p);
        }

 

        // GET: PartiesController/Edit/5
        public ActionResult Edit(string id)
        {
            BizParty p;
            if (string.IsNullOrEmpty(id))
            {
                p = new();
            }
            else
            {
               p = BizParty.Get("PartyName", id);
            }
       
            return View(p);
        }

        // POST: PartiesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(BizParty partyobj)
        {
            try
            {
                partyobj.Save();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(partyobj);
            }
        }

        // GET: PartiesController/Delete/5
        public ActionResult Delete(string id)
        {
            BizParty p = BizParty.Get("PartyName", id);
            return View(p);
        }

        // POST: PartiesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(BizParty party)
        {
            try
            {
                party.Delete();
                return RedirectToAction(nameof(Index));
            }
            catch(CPUFramework.CPUException ex)
            {
                party = BizParty.Get(party.PartyId);
                ViewBag.ErrorMessage = ex.FriendlyMessage;
                return View(party);
            }
                         
        }
    }
}
