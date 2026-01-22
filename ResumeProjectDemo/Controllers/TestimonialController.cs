using Microsoft.AspNetCore.Mvc;
using ResumeProjectDemo.Context;
using ResumeProjectDemo.Entities;

namespace ResumeProjectDemo.Controllers
{
    public class TestimonialController : Controller
    {
        private readonly ResumeContext _context;

        public TestimonialController(ResumeContext context)
        {
            _context = context;
        }

        // 1. Referans Listeleme
        public IActionResult TestimonialList()
        {
            var values = _context.Testimonials.ToList();
            return View(values);
        }

        // 2. Yeni Referans Ekleme (Sayfayı Açma)
        [HttpGet]
        public IActionResult CreateTestimonial()
        {
            return View();
        }

        // 3. Yeni Referans Ekleme (Kaydetme)
        [HttpPost]
        public IActionResult CreateTestimonial(Testimonial testimonial)
        {
            testimonial.Status = true; // Varsayılan olarak aktif gelsin
            _context.Testimonials.Add(testimonial);
            _context.SaveChanges();
            return RedirectToAction("TestimonialList");
        }

        // 4. Referans Silme (Yerine Durum Değiştirme)
        public IActionResult ChangeStatus(int id)
        {
            var value = _context.Testimonials.Find(id);
            if (value != null)
            {
                value.Status = !value.Status; // Durumu tersine çevir
                _context.SaveChanges();
            }
            return RedirectToAction("TestimonialList");
        }

        // 5. Referans Güncelleme Sayfasını Aç
        [HttpGet]
        public IActionResult UpdateTestimonial(int id)
        {
            var value = _context.Testimonials.Find(id);
            if (value == null)
            {
                return NotFound();
            }
            return View(value);
        }

        // 6. Referans Güncelleme İşlemini Yap
        [HttpPost]
        public IActionResult UpdateTestimonial(Testimonial testimonial)
        {
            _context.Testimonials.Update(testimonial);
            _context.SaveChanges();
            return RedirectToAction("TestimonialList");
        }
    }
}