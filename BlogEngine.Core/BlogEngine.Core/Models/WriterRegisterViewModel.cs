using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc.Rendering;
using FluentValidation;

namespace BlogEngine.Core.Models
{
    public class WriterRegisterViewModel 
    {
        public int WriterID { get; set; }
        public string WriterName { get; set; }
        public string WriterAbout { get; set; }
        public string WriterImage { get; set; }
        public string WriterMail { get; set; }
        public string WriterPassword { get; set; }
        public bool WriterStatus { get; set; }

        public string ConfirmPassword { get; set; }
        public string SelectedCity { get; set; }
        public List<SelectListItem> Cities { get; set; }
    }
}
