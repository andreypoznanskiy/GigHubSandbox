using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace GigHub.Controllers
{
    public class GigsController : Controller
    {
        public ActionResult Create()
        {
            return new ViewResult();
        }
    } 
}
