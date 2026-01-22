using Microsoft.AspNetCore.Mvc;
using ResumeProjectDemo.Context;

namespace ResumeProjectDemo.ViewComponents.DefaultViewComponents
{
    public class _DefaultTestimonialComponentPartial : ViewComponent
    {
        private readonly ResumeContext _context = new ResumeContext();
        public IViewComponentResult Invoke()
        {
            // Sadece Status değeri true olanları getiriyoruz
            var values = _context.Testimonials.Where(x => x.Status == true).ToList();
            return View(values);
        }
    }
}
