using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace FileUploader.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Upload(HttpPostedFileWrapper uploadFile)
        {
            if (uploadFile != null)
            {
                uploadFile.SaveAs(@"c:\upload-file\" + Path.GetFileName(uploadFile.FileName));
            }
            return View();
        }
    }
}