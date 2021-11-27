using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VizeÖdevi.Controllers
{
    public class KamyoncuController : Controller
    {
        public IActionResult Listele()
        {
            return View(Models.KamyoncuVeri.Kamyoncular);
        }

        public IActionResult Yeni()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Yeni(Models.Kamyoncu Yenikamyoncu)
        {
            Models.KamyoncuVeri.Kamyoncular.Add(Yenikamyoncu);
            return RedirectToAction("Listele");
        }

        public IActionResult Guncelle(int id)
        {
            var r = Models.KamyoncuVeri.Kamyoncular.FirstOrDefault(x => x.Id == id);
            return View(r);
        }

        [HttpPost]
        public IActionResult Guncelle(Models.Kamyoncu GüncelleKamyoncu)
        {
            var c = Models.KamyoncuVeri.Kamyoncular.FirstOrDefault(x => x.Id == GüncelleKamyoncu.Id);
            var r = Models.KamyoncuVeri.Kamyoncular.FirstOrDefault(x => x.Id == GüncelleKamyoncu.Id);
            r.Ad = GüncelleKamyoncu.Ad;
            r.Soyad = GüncelleKamyoncu.Soyad;
            r.Tckimlik = GüncelleKamyoncu.Tckimlik;

            Models.KamyoncuVeri.Kamyoncular.Remove(c);
            Models.KamyoncuVeri.Kamyoncular.Add(r);

            return RedirectToAction("Listele");
        }

        public IActionResult Detay(int id)
        {
            var r = Models.KamyoncuVeri.Kamyoncular.FirstOrDefault(x => x.Id == id);
            return View(r);
        }

        public IActionResult Sil(int id)
        {
            var r = Models.KamyoncuVeri.Kamyoncular.FirstOrDefault(x => x.Id == id);
            return View(r);
        }

        [HttpPost]
        public IActionResult Sil(Models.Kamyoncu SilKamyoncu)
        {
            var r = Models.KamyoncuVeri.Kamyoncular.FirstOrDefault(x => x.Id == SilKamyoncu.Id);
            Models.KamyoncuVeri.Kamyoncular.Remove(r);
            return RedirectToAction("Listele");

        }
    }
}
