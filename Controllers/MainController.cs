using RPG.Jsons;
using RPG.Language;
using RPG.Util;
using System.Web.Http;

namespace RPG.Controllers
{
    public class MainController : ApiController
    {
        [HttpPost]
        public IHttpActionResult Main(JsonHero jsonRunHeroExecutor)
        {
            try
            {
                if (!ModelState.IsValid)
                    throw new RPGException(string.Format(RPGMsg.MSG001));

                return Json(new { Success = true });
            }
            catch
            {
                return Json(new { Success = false });
            }
        }
    }
}