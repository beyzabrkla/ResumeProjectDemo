using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ResumeProjectDemo.Context;

namespace ResumeProjectDemo.ViewComponents.DefaultViewComponents
{
    public class _DefaultContactComponentPartial : ViewComponent
    {
        private readonly ResumeContext _context;

        public _DefaultContactComponentPartial(ResumeContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            var value = _context.Contacts.FirstOrDefault(); // İlk iletişim bilgisini getir
            return View(value);
        }
    }

}
