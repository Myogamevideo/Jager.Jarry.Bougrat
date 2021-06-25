using BusinessLayer;
using ClassLibrary.Entity;
using System;
using System.Collections.Generic;
using System.Web.Mvc;
using WebApplication.Models;
using WebApplication.Services.EntityMapper;

namespace WebApplication.Controllers
{
    public class OffreController : Controller
    {
        OffreMapper offreMapper = new OffreMapper();

        // GET: Offre
        public ActionResult Index()
        {
            List<Offre> offres = BusinessManager.Instance.GetAllOffre();


            List<OffreViewModel> offreViewModels = new List<OffreViewModel>();

            foreach(var offre in offres)
            {
                OffreViewModel offreViewModel = new OffreViewModel();
                offreMapper.Map(offre, offreViewModel);
                offreViewModels.Add(offreViewModel);
            }

            return View(offreViewModels);
        }

        // GET: Offre/Details/5
        public ActionResult Details(int id)
        {
            Offre offre = BusinessManager.Instance.getOffreByID(id);
            OffreViewModel offreViewModel = new OffreViewModel();
            offreMapper.Map(offre, offreViewModel);

            return View(offreViewModel);
        }

        // GET: Offre/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Offre/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Offre/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Offre/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Offre/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Offre/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
