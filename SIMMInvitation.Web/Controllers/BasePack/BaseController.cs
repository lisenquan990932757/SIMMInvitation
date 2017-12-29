using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using SIMMInvitation.Infrastructure.Dao;

namespace SIMMInvitation.Web.Controllers.BasePack
{
    public class BaseController : Controller
    {
        // GET: Base
        protected DbService _service;
        protected BaseController(DbService s)
        {
            _service = s;
        }
    }
}