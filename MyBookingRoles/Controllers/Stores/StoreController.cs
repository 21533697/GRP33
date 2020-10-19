using MyBookingRoles.Models;
using MyBookingRoles.Models.Store;
using PagedList;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.IO ;


namespace Studio45.Controllers.Store
{

    public class StoreController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: StoreHome

        public ActionResult ProdCatalogue(int? page,  string searchWord)
        {
            int pageSize = 8;
            int pageNumber = (page ?? 1);
            return View(db.Products.Where(p => p.ProductName.Contains(searchWord) || searchWord == null && p.IsVisible == true).ToPagedList(pageNumber,pageSize));
        }

        // GET: ProductDetails
        public ActionResult ProductDetails(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

<<<<<<< HEAD
        //
        //GET:/StoreHome/Browse
        public ActionResult Search()
        {
            //Search Code....
            //

            return View("ProdCatalogue");
        }

        public ActionResult BrandCatalogue(int? page, string searchWord)
=======
        // GET: BrandCatalogue
        public ActionResult BrandCatalogue(string searchWord)
>>>>>>> cd0a5c4a35709a1601bdb0d32b24463ecf2defdc
        {
            int pageSize=8;
            int pageNumber = (page ?? 1);
            return View(db.Brands.Where(p => p.Name.Contains(searchWord) || searchWord == null).ToPagedList(pageNumber,pageSize));
        }

<<<<<<< HEAD
        public ActionResult CategoryCatalogue(string searchWordC, int? page)
=======
        // GET: CategoryCatalogue
        public ActionResult CategoryCatalogue(string searchWordC)
>>>>>>> cd0a5c4a35709a1601bdb0d32b24463ecf2defdc
        {
            int pageSize = 8;
            int pageNumber = (page ?? 1);
            return View(db.Category.Where(p => p.CategoryName.Contains(searchWordC) || searchWordC == null).ToPagedList(pageSize,pageNumber));
        }
    }
}