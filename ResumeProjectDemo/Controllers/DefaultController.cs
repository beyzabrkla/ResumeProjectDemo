using Microsoft.AspNetCore.Mvc;
using ResumeProjectDemo.Context;
using ResumeProjectDemo.Entities;
namespace ResumeProjectDemo.Controllers
{
    public class DefaultController : Controller
    {
        private readonly ResumeContext _context;

        public DefaultController(ResumeContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var contactValues = _context.Contacts.FirstOrDefault();
            return View(contactValues);
        }

        [HttpPost]
        public IActionResult SendMessage(Message message)
        {
            if (ModelState.IsValid)
            {
                message.SendDate = DateTime.Now;
                message.IsRead = false;
                _context.Messages.Add(message);
                _context.SaveChanges();
                return Ok(); // AJAX bu "Ok" cevabını alınca 'success' fonksiyonunu çalıştırır
            }
            return BadRequest();
        }
    }
}
