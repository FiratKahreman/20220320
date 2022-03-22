using _01_Models.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace _01_Models.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OgrenciController : ControllerBase
    {
        // HTTP stateless

        public IActionResult OgrencileriGetir()
        {
            List<Ogrenci> ogrenciler = new List<Ogrenci>();
            ogrenciler.Add(new Ogrenci() { Ad = "Marty", Soyad = "McFly", DogumTarihi = DateTime.Now });
            ogrenciler.Add(new Ogrenci() { Ad = "Stanley", Soyad = "Ipkiss", DogumTarihi = DateTime.Now });

            return Ok(ogrenciler);
        }

        [HttpPost]
        public IActionResult OgrenciEkle(Ogrenci ogrenci)
        {
            //string soyad = Request.Form["soyad"];
            //string ad = Request.Form["ad"];

            return Ok();
        }
    }
}
