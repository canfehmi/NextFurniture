using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NextFurniture.Models.DAL.Entities;
using NextFurniture.Repositories;

namespace NextFurniture.Controllers
{
	[Authorize(Roles = "Admin")]
	public class CommentController : Controller
    {
        GenericRepository<Comment> repo = new GenericRepository<Comment>();
        public IActionResult Index()
        {
            var values = repo.List();
            values.Reverse();
            return View(values);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var comment = repo.Find(x=>x.Id == id);
            return View(comment);
        }
        [HttpPost]
        public IActionResult Edit(Comment c)
        {
            if(!ModelState.IsValid)
            {
                return RedirectToAction("Edit");
            }
            var comment = repo.Find(x=> x.Id == c.Id);
            comment.Name = c.Name;
            comment.Description = c.Description;
            comment.Title = c.Title;
            comment.Star = c.Star;
            comment.ImgUrl = c.ImgUrl;
            repo.TUpdate(comment);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var t = repo.Find(x=>x.Id == id);
            repo.TRemove(t);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult NewComment()
        {
            return View();
        }
        [HttpPost]
        public IActionResult NewComment(Comment c)
        {
            if(!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            repo.TAdd(c);
            return RedirectToAction("Index");
        }
    }
}
