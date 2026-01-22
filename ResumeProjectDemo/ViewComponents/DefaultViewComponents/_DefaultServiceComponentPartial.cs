using Microsoft.AspNetCore.Mvc;
using ResumeProjectDemo.Context;

namespace ResumeProjectDemo.ViewComponents.DefaultViewComponents
{
    public class _DefaultServiceComponentPartial : ViewComponent
    {
        private readonly ResumeContext _context;

        public _DefaultServiceComponentPartial(ResumeContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values = _context.Services.Where(x => x.Status == true).ToList(); 
            return View(values);
        }
    }
}
