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

            members.Add(new Models.GroupModel { StudentNumber = "u01234567", FirstName = "Jane", LastName = "Doe", EmailAddress = "jane.doe@tuks.co.za" });
            members.Add(new Models.GroupModel { StudentNumber = "u12345678", FirstName = "John", LastName = "Doe", EmailAddress = "john.doe@tuks.co.za" });
            members.Add(new Models.GroupModel { StudentNumber = "u23456789", FirstName = "Jeff", LastName = "Winters", EmailAddress = "jeff.winters@tuks.co.za" });
            members.Add(new Models.GroupModel { StudentNumber = "u76543210", FirstName = "Jack", LastName = "Hugo", EmailAddress = "jack.hugo@tuks.co.za" });
            members.Add(new Models.GroupModel { StudentNumber = "u87654321", FirstName = "Jenna", LastName = "White", EmailAddress = "jenna.white@tuks.co.za" });

            return View(members);

        }
    }
}