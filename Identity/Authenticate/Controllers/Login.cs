using Authenticate.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Authenticate.Controllers
{
    public class Login : Controller
    {
        Context c = new Context();


        [HttpGet]
        public IActionResult GirisYap()
        {


            return View();

        }

        [HttpPost]
        public async Task<IActionResult> GirisYap(Admin p) //giriş yap sayfamın ekrana gelmesinin ardından post işlemini
                                                            //gerçekleştirecek yap
        {
            var bilgiler = c.Admins.FirstOrDefault(x => x.Kullanici == p.Kullanici && x.sifre == p.sifre);//textboxta yazilanları cookie tarafında eşliyorum

            if (bilgiler != null)//eğer textler boş gelmezse
            {
                var claims = new List<Claim>  //Claim yapımı oluşturuyorum
                { 
                    new Claim(ClaimTypes.Name,p.Kullanici)


                };

                var useridentity = new ClaimsIdentity(claims, "Login");//identity tanımlamamı yapıp loginden aldırıyorum

           
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);//buradaki principal benim sorgu alanım
                                                                              //ve bu alanda ben loginden gelen şeyleri sorguluyorum


                await HttpContext.SignInAsync(principal);//await kullanıp işlem sıramı düzenledim 

                return RedirectToAction("Index","Login");// eğer pri.buradan gelen veri dogruysa yonlendirme yapsın personel controller index
            
            
            }

            return View();

        }




        public IActionResult Index()
        {
            return View();
        }

    }
    }

