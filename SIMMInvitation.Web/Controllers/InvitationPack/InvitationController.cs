using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using SIMMInvitation.Web.Controllers.BasePack;
using SIMMInvitation.Infrastructure.Dao;
using SIMMInvitation.Infrastructure.ViewModels;
using SIMMInvitation.Web.Controllers.InvitationPack;
using SIMMInvitation.Infrastructure.DbModels;

namespace SIMMInvitation.Web.Controllers
{
    public class InvitationController : BaseController
    {
        public InvitationController(DbService service):base(service)
        {

        }


        public ActionResult Index()
        {
            return View();
        }

        public JsonResult LoginSubmits(string AtrName,string BthCode)
        {
            var model = new ResultModel<string>();
            _service.Command<Outsourcing>((db,o)=> {
                var loginUser = db.Queryable<Actor>().Single(it => it.AtrName == AtrName && it.BthCode == BthCode);
                if (loginUser == null)
                {
                    model.IsSuccess = false;                    
                    model.ResultInfo = "参展公司名称或者展位号不正确！";
                }
                else
                {
                    model.ResultInfo = loginUser.AtrID.ToString();
                    model.IsSuccess = true;                   
                }
            });
            return Json(model, JsonRequestBehavior.AllowGet);
        }
    }
}