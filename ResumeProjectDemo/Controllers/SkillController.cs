using Microsoft.AspNetCore.Mvc;
using ResumeProjectDemo.Context;
using ResumeProjectDemo.Entities;

namespace ResumeProjectDemo.Controllers
{
    public class SkillController : Controller
    {
        private readonly ResumeContext _context = new ResumeContext();

        // 1. Listeleme
        public IActionResult SkillList()
        {
            var values = _context.Skills.ToList();
            return View(values);
        }

        // 2. Yeni Yetenek Ekleme (Sayfayı Açma)
        [HttpGet]
        public IActionResult CreateSkill()
        {
            return View();
        }

        // 3. Yeni Yetenek Ekleme (Kaydetme)
        [HttpPost]
        public IActionResult CreateSkill(Skill skill)
        {
            skill.Status = true; // Yeni yetenek varsayılan olarak AKTİF gelir
            _context.Skills.Add(skill);
            _context.SaveChanges();
            return RedirectToAction("SkillList");
        }

        // 4. Durum Değiştirme (Silme yerine Soft Delete / Toggle Status)
        public IActionResult ChangeStatus(int id)
        {
            var value = _context.Skills.Find(id);
            if (value != null)
            {
                value.Status = !value.Status; // Durumu tersine çevirir (True <-> False)
                _context.SaveChanges();
            }
            return RedirectToAction("SkillList");
        }

        // 5. Güncelleme Sayfasını Aç (Mevcut veriyi modele yükleyerek)
        [HttpGet]
        public IActionResult UpdateSkill(int id)
        {
            var value = _context.Skills.Find(id);
            return View(value); // Veriyi View'a gönderiyoruz ki inputlar dolsun
        }

        // 6. Güncelleme İşlemini Yap
        [HttpPost]
        public IActionResult UpdateSkill(Skill skill)
        {
            _context.Skills.Update(skill);
            _context.SaveChanges();
            return RedirectToAction("SkillList");
        }
    }
}
