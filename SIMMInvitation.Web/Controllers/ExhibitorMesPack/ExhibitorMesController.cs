using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using SIMMInvitation.Web.Controllers.BasePack;
using SIMMInvitation.Infrastructure.Dao;
using SIMMInvitation.Infrastructure.ViewModels;
using SIMMInvitation.Web.Controllers.ExhibitorMesPack;
using SIMMInvitation.Infrastructure.DbModels;

namespace SIMMInvitation.Web.Controllers
{
    public class ExhibitorMesController : BaseController
    {
        public ExhibitorMesController(DbService service):base(service)
        {

        }

        // GET: ExhibitorMes
        public ActionResult Index()
        {
            var AtrID = Request["AtrID"];
            var BthCode = "展位号:"+Request["BthCode"];
            ViewData["BthCode"] = BthCode;
            
            _service.Command<Outsourcing>((db, o)=> {
                var ActorObj = db.Queryable<Actor>().Single(m => m.AtrID == Convert.ToInt32(AtrID));
                var comId = ActorObj.ComID;
                var CatalogObj = db.Queryable<Catalog>().Single(it => it.ComID == comId);//48694
                ViewData["ClgPdtIntro"] = CatalogObj.ClgPdtIntro;
            });

            return View();
        }
    }
}