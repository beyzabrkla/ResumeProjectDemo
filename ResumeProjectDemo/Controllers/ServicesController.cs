using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ResumeProjectDemo.Context;
using ResumeProjectDemo.Entities;

namespace ResumeProjectDemo.Controllers
{
    public class ServicesController : Controller
    {
        private readonly ResumeContext _context = new ResumeContext();
        public IActionResult ServicesList()
        {
            var values = _context.Services.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateService() => View();

        [HttpPost]
        public IActionResult CreateService(Service service)
        {
            service.Status = true; // Yeni eklenen hizmet aktif başlasın
            _context.Services.Add(service);
            _context.SaveChanges();
            return RedirectToAction("ServicesList");
        }

        [HttpGet]
        public IActionResult UpdateService(int id)
        {
            var value = _context.Services.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateService(Service service)
        {
            _context.Services.Update(service);
            _context.SaveChanges();
            return RedirectToAction("ServicesList");
        }

        // Silme yerine Durum Değiştirme (Toggle Status)
        public IActionResult ChangeStatus(int id)
        {
            var value = _context.Services.Find(id);
            if (value != null)
            {
                value.Status = !value.Status; // Durumu tersine çevir
                _context.SaveChanges();
            }
            return RedirectToAction("ServicesList");
        }
    }
}
