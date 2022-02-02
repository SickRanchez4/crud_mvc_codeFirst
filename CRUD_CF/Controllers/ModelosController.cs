using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CRUD_CF.Models;

namespace CRUD_CF.Controllers
{
    public class ModelosController : Controller
    {
        private DevContext db = new DevContext();

        // GET: Modelos
        public ActionResult Index()
        {
            return View(db.Modelo.ToList());
        }

        // GET: Modelos/Details
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Modelo modelo = db.Modelo.Find(id);
            if (modelo == null)
            {
                return HttpNotFound();
            }
            return View(modelo);
        }

        // GET: Modelos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Modelos/Create
        [HttpPost]
        public ActionResult Create([Bind(Include = "Id,Description,File")] Modelo molde, HttpPostedFileBase file)
        {
            molde.FileName = file.FileName;
            molde.FileSize = file.ContentLength;

            byte[] data = new byte[file.ContentLength];
            file.InputStream.Read(data, 0, file.ContentLength);

            molde.FileData = data;

            if (ModelState.IsValid)
            {
                db.Modelo.Add(molde);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(molde);
        }


        // GET: Modelos/Download
        [HttpGet]
        public FileResult Download(int? id)
        {
            Modelo modelo = db.Modelo.Find(id);

            byte[] fileBytes = modelo.FileData;
            string fileName = modelo.FileName;

            return File(fileBytes, "application/pdf", fileName);
        }

        
        // GET: Modelos/Edit
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Modelo modelo = db.Modelo.Find(id);
            if (modelo == null)
            {
                return HttpNotFound();
            }
            return View(modelo);
        }

        // POST: Modelos/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Description,File")] Modelo molde, HttpPostedFileBase file)
        {
            molde.FileName = file.FileName;
            molde.FileSize = file.ContentLength;

            byte[] data = new byte[file.ContentLength];
            file.InputStream.Read(data, 0, file.ContentLength);

            molde.FileData = data;

            if (ModelState.IsValid)
            {
                db.Entry(molde).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(molde);
        }

        // GET: Modelos/Delete
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Modelo modelo = db.Modelo.Find(id);
            if (modelo == null)
            {
                return HttpNotFound();
            }
            return View(modelo);
        }

        // POST: Modelos/Delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Modelo modelo = db.Modelo.Find(id);
            db.Modelo.Remove(modelo);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
