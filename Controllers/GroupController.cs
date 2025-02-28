using System.Collections.Generic;
using System.Reflection;
using System.Web.Mvc;

namespace lukasStudyGroup.Controllers
{
    public class GroupController : Controller
    {

        public ActionResult ListMembers()
        {
            List<Models.GroupModel> members = new List<Models.GroupModel>();

            members.Add(new Models.GroupModel { StudentNumber = "u24616185", FirstName = "Lukas", LastName = "Brink", EmailAddress = "u24616185@tuks.co.za" });
            members.Add(new Models.GroupModel { StudentNumber = "u24607364", FirstName = "Helena", LastName = "van der Merwe", EmailAddress = "u24607364@tuks.co.za" });
            members.Add(new Models.GroupModel { StudentNumber = "u24647502", FirstName = "Kelly", LastName = "Johnson", EmailAddress = "u24647502@tuks.co.za" });
            members.Add(new Models.GroupModel { StudentNumber = "u24679438", FirstName = "Rayhan", LastName = "Ounaceur", EmailAddress = "u24679438@tuks.co.za" });
            members.Add(new Models.GroupModel { StudentNumber = "u24616827", FirstName = "Luan", LastName = "Fourie", EmailAddress = "u24616827@tuks.co.za" });

            return View(members);

        }
    }
}