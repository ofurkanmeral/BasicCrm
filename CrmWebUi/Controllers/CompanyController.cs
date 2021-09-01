using CrmData.Abstract;
using CrmEntity;
using CrmWebUi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CrmWebUi.Controllers
{
    
    public class CompanyController : Controller
    {
        private ICompanyRepository _companyRepository;
        private ICategoryRepository _categoryRepository;
        private ICalisan _calisanRepository;
        private INotifyRepository _notifyRepository;
        public CompanyController(INotifyRepository notifyRepository,ICompanyRepository companyRepository,ICategoryRepository categoryRepository, ICalisan calisanRepository)
        {
            _companyRepository = companyRepository;
            _categoryRepository = categoryRepository;
            _calisanRepository = calisanRepository;
            _notifyRepository= notifyRepository;
        }
        public IActionResult Index(string? category )
        {
            List<Company> company = new List<Company>();
            if (category == null)
            {
                company = _companyRepository.getAll();
            }
            else
            {
                company = _companyRepository.CategoryListesi(category);
            }
            
            var categoryList = _categoryRepository.getAll();
            var liste = new CompanyList()
            {
                Companies = company,
                Categories= categoryList

            };
            return View(liste);
        }
        public IActionResult notePartial(int id)
        {
            var onur = _companyRepository.getCompanyNote(id);
            return PartialView("_notes",onur);
        }

        public IActionResult companyform(int? id)
        {
            Company company = _companyRepository.getById((int)id);
            return PartialView("_companyform",company);
        }
        [HttpPost]
        public IActionResult create(string d1,string d2,string d3)
        {
            var ekle = new Company()
            {
                Name = d1,
                Adress = d2,
                Number = d3
            };
            _companyRepository.Create(ekle);
            return Json(new { d1, d2, d3 });
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var company = _companyRepository.getById(id);
            _companyRepository.Delete(company);
            return Json(new { company });

        }
//---------------------------------------------------------------------------------------
        public IActionResult anasayfa(string? category,string? q)
        {
            List<Company> company = new List<Company>();
            if (category == null && q==null)
            {
                company = _companyRepository.getAll();
            }
            else if(category==null && q != null)
            {
                var companyim=_companyRepository.Search(q);
                var categoryListe = _categoryRepository.getAll();
                var listem = new CompanyList()
                {
                    Companies = companyim,
                    Categories = categoryListe
                };
                return View(listem);
            }
            else
            {
                company = _companyRepository.CategoryListesi(category);
            }

            var categoryList = _categoryRepository.getAll();
            var notify = _notifyRepository.getCalisan();
            var liste = new CompanyList()
            {
                Companies = company,
                Categories = categoryList,
                notifies=notify
            };
            return View(liste);
        }
        public IActionResult companyeditform(int? id)
        {
            Company company = _companyRepository.getById((int)id);
            var calisans = _calisanRepository.getAll();
            var model = new CompiCat()
            {
                calisanlar = calisans,
                Companies = company
            };
          
            return PartialView("_companyform", model);
        }
        public IActionResult companyaddform()
        {
            var calisans = _calisanRepository.getAll();
            var model = new CompiCat()
            {
                calisanlar = calisans
            };
            return PartialView("_companyform",model);
        }
        [HttpPost]
        public IActionResult createCompany(string Name,string Number,string Adres,string customer)
        {
            

            var company = new Company()
            {
                Adress = Adres,
                Name = Name,
                Number = Number,
                picture=customer,
            };
            _companyRepository.Create(company);
            company.picture = "https://www.pusulaplus.com/docs/uploads/2020/01/psllogo.png";
            return Json(new { Id = company.Id, Name = company.Name, Adress = company.Adress, Number = company.Number, Picture = company.picture });
        }
        [HttpPost]
        public IActionResult deletemCompany(int id)
        {
            var company = _companyRepository.getById(id);
            _companyRepository.Delete(company);
             company.picture = "";
            return Json(new { Id = company.Id, Name = company.Name, Adress = company.Adress, Number = company.Number, Picture = company.picture });
        }
        
        [HttpPost]
        public IActionResult editCompany(int id,string Name,string Adress,string Number)
        {
            var company = _companyRepository.getById(id);
            company.Adress = Adress;
            company.Name = Name;
            company.Number=Number;
            _companyRepository.Update(company);
            //return Json(new { company });
            company.picture = "https://www.pusulaplus.com/docs/uploads/2020/01/psllogo.png";
            return Json(new { Id = company.Id, Name = company.Name, Adress = company.Adress, Number = company.Number, Picture = company.picture });
        }
      

        public IActionResult Detail(string companyname)
        {
            var company = _companyRepository.getCalisan(companyname);
            var onur = new CompiCat()
            {
                Companies = company
            };
            return View(onur);
            //var company = _companyRepository.getById(id);
            //var category = _companyRepository.getCompanyByCategory(id);
            //CompiCat compi = new CompiCat()
            //{
            //    Companies = company,
            //    Categories = category.CompanyCategories.Select(x=>x.Category).ToList()
            //};
            //return View(compi);

        }
        //public IActionResult ListCategory(int id)
        //{
        //    var productlar = _categoryRepository.CategoryByCompany(id);
        //    var Company = new CompanyList()
        //    {
        //        Companies = productlar.CompanyCategories.Select(x => x.Company).ToList()
        //    };
        //    return View(Company);
        //}

        public IActionResult ListCategory(string category)
        {
            var company = _companyRepository.CategoryListesi(category);
            var model = new CompanyList()
            {
                Companies = company
            };
            return View(model);
        }
        public IActionResult search(string q)
        {
            return Json(new { q });
        }










        public IActionResult checkbox()
        {
            return View(_calisanRepository.getAll());
        }
        
        public IActionResult radio()
        {
            string path1 = Directory.GetCurrentDirectory();
            string path2 = @"wwwroot\images\img-01.png";
            string combinedPath = Path.Combine(path1,path2);

            ViewBag.code = combinedPath;
            return View();
        }
        public IActionResult kullanicimodal(int? id)
        {
            if (id == null)
            {
                return PartialView("_kullancimodal");
            }
            var model = _calisanRepository.getById((int)id);
            return PartialView("_kullanicimodal",model);
        }
        public IActionResult kullaniciekle()
        {
            return PartialView("_kullaniciekle");
        }
        [HttpPost]
        public IActionResult kullaniciekle(string f1,string f2,string f3,string f4,int f5)
        {
            var calisan = new calisan()
            {
                companyId = f5,
                Name = f1,
                Soyad = f2,
                Kanun = f3,
                Prim = f4

            };
            _calisanRepository.Create(calisan);
            return Json(new { calisan });
        }
    }
}
