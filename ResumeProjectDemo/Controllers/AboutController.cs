using Microsoft.AspNetCore.Mvc;
using ResumeProjectDemo.Context;
using ResumeProjectDemo.Entities;

namespace ResumeProjectDemo.Controllers
{
    public class AboutController : Controller
    {
        private readonly ResumeContext _context;

        public AboutController(ResumeContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var value = _context.Abouts.FirstOrDefault();

            if (value == null)
            {
                return View(new About());
            }

            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateAbout(About about)
        {
            var value = _context.Abouts.Find(about.AboutId);

            // Sadece formdan gelen alanları üzerine yazıyoruz
            value.NameSurname = about.NameSurname;
            value.Title = about.Title;
            value.Description = about.Description;
            value.ImageUrl = about.ImageUrl;

            // Eğer eğitim alanları boş geliyorsa eski değerlerini koruyoruz
            if (!string.IsNullOrEmpty(about.EducationDate1)) value.EducationDate1 = about.EducationDate1;
            if (!string.IsNullOrEmpty(about.EducationTitle1)) value.EducationTitle1 = about.EducationTitle1;

            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}