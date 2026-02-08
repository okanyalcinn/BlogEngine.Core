using BlogEngine.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlogEngine.Core.ViewComponents
{
    public class CommentList: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentValues = new List<UserComment>
            {
                new UserComment
                {
                    Id = 1,
                    UserName="Test",
                },
                new UserComment {
                    Id = 2,
                    UserName="Test2",
                },
                new UserComment
                {
                    Id = 3,
                    UserName="Test3",
                }
            };
            return View(commentValues); 
        }
    }
}
