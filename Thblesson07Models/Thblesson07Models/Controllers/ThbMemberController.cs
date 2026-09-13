using Microsoft.AspNetCore.Mvc;
using Thblesson07Models.Models.DataModels;

public class ThbMemberController : Controller
{
    protected List<ThbMember> _Members = new List<ThbMember>
    {
        new ThbMember
        {
            ThbMemberId = Guid.NewGuid().ToString(),
            ThbUserName = "thbach",
            ThbPassword = "123456",
            ThbFullName = "Trịnh Hoàng Bách",
            ThbEmail = "tbach0801@gmail.com"
        },

        new ThbMember
        {
            ThbMemberId = Guid.NewGuid().ToString(),
            ThbUserName = "nguyenan",
            ThbPassword = "123456",
            ThbFullName = "Nguyen Van An",
            ThbEmail = "nguyenan@gmail.com"
        },

        new ThbMember
        {
            ThbMemberId = Guid.NewGuid().ToString(),
            ThbUserName = "tranminh",
            ThbPassword = "123456",
            ThbFullName = "Tran Minh Duc",
            ThbEmail = "tranminh@gmail.com"
        },

        new ThbMember
        {
            ThbMemberId = Guid.NewGuid().ToString(),
            ThbUserName = "lehoa",
            ThbPassword = "123456",
            ThbFullName = "Le Thi Hoa",
            ThbEmail = "lehoa@gmail.com"
        },

        new ThbMember
        {
            ThbMemberId = Guid.NewGuid().ToString(),
            ThbUserName = "phamnam",
            ThbPassword = "123456",
            ThbFullName = "Pham Van Nam",
            ThbEmail = "phamnam@gmail.com"
        }
    };

    public IActionResult Index()
    {
        return View(_Members);
    }

    public IActionResult GetMember()
    {
        var member = new ThbMember
        {
            ThbMemberId = Guid.NewGuid().ToString(),
            ThbUserName = "Tbach",
            ThbPassword = "password555",
            ThbFullName = "Trịnh Hoàng Bách",
            ThbEmail = "tbach0801@gmail.com"
        };

        //ViewBag.Member = member;
        return View(member);
    }

    public IActionResult GetMembers()
    {
        ViewBag.Members = _Members;
        return View();
    }
    public IActionResult Create()
    {
        return View();
    }
}