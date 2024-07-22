using Microsoft.AspNetCore.Mvc;

namespace ProjectMVCTow.Controllers
{
    public class ProductController : Controller
    {
        #region MyRegion
        ////public IActionResult Index()
        ////{
        ////    return View();
        ////}
        //public ContentResult PrintResult()
        //{
        //    ContentResult result = new ContentResult();
        //    result.Content = "Welcome To Home Page";
        //    return result;
        //}
        //public JsonResult PrintJson()
        //{
        //    JsonResult result = new JsonResult(new { Id = 1, Name = "Mohamed" });
        //    return result;
        //} 
        #endregion

        public ViewResult PrintView()
        {
            ViewResult result = new ViewResult();
            result.ViewName = "View1";
            return result;
        }
    }
}
