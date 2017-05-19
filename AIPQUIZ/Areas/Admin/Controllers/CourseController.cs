using BusinessLogicLayer.Implementation;
using BusinessObjectLayer.CommonModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AIPQUIZ.Areas.Admin.Controllers
{
    public class CourseController : Controller
    {
        private readonly CourseModel _courseModel;
        private readonly CourseBs _courseBs;

        public CourseController()
        {
            _courseModel = new CourseModel();
            _courseBs = new CourseBs();
        }
        public ActionResult Index()
        {
            var course = _courseBs.CourseList();
            return View(course);
        }
    }
}