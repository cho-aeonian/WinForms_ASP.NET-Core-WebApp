using Microsoft.AspNetCore.Mvc;

namespace borrow산_우산현황.Areas.Admin.Controllers
{
    public class ReturnScreenController : Controller
    {
        public IActionResult Index(int box)
        {
            // Box 번호를 뷰에 전달
            ViewData["BoxNumber"] = box;
            return View("ReturnScreen");  // return-screen.cshtml로 이동
        }
    }
}
