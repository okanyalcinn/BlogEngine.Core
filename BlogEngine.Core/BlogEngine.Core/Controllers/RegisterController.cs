using BlogEngine.Core.Models;
using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BlogEngine.Core.Controllers
{
    public class RegisterController : Controller
    {
        WriterManager wm = new WriterManager(new EfWriterRepository());

        [HttpGet]
        public IActionResult Index()
        {
            //WriterRegisterViewModel model = new WriterRegisterViewModel();

            //model.Cities = new List<SelectListItem>
            //{
            //    new SelectListItem { Text = "İstanbul", Value = "İstanbul" },
            //    new SelectListItem { Text = "Ankara", Value = "Ankara" },
            //    new SelectListItem { Text = "İzmir", Value = "İzmir" },
            //    new SelectListItem { Text = "Bursa", Value = "Bursa" }
            //};
            //return View(model);

            return View();
        }

        [HttpPost]
        public IActionResult Index(Writer model)
        {
            WriterValidator wv = new WriterValidator();
            ValidationResult result = wv.Validate(model);
            if (result.IsValid)
            {
                model.WriterStatus = true;
                model.WriterAbout = "Test";
                wm.Add(model);
                return RedirectToAction("Index", "Blog");
            }
            else 
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }

        //public IActionResult Index(WriterRegisterViewModel model)
        //{
        //    WriterValidator wv = new WriterValidator();
        //    ValidationResult result = wv.Validate(model);

        //    if (model.WriterPassword != model.ConfirmPassword)
        //    {
        //        ModelState.AddModelError("ConfirmPassword", "Şifreler eşleşmiyor");
        //        return View(model);
        //    }
        //    Writer w = new Writer
        //    {
        //        WriterName = model.WriterName,
        //        WriterMail = model.WriterMail,
        //        WriterPassword = model.WriterPassword,
        //        WriterImage = model.WriterImage,

        //        WriterStatus = true,
        //        WriterAbout = "Test"
        //    };
        //    wm.Add(w);
        //    return RedirectToAction("Index", "Blog");
        //}
    }
}
