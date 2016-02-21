﻿using ProProperty.DAL;
using ProProperty.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace ProProperty.Controllers
{
    public class PropertyController : Controller
    {
        private DataGateway<Property> propertyDataGateway = new DataGateway<Property>();
        private DataGateway<Town> townDataGateway = new DataGateway<Town>();
        private static List<PropertyWithPremises> propertyList = new List<PropertyWithPremises>();

        // GET: Property
        public ActionResult Index()
        {
            return View();
        }

        // GET: Property/Details/5
        public ActionResult PropertyDetails(int id)
        {
            PropertyWithPremises model = new PropertyWithPremises();
            model.property = propertyDataGateway.SelectById(id);
            return View(model);
        }

        // GET: Property/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Property/Create
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

        // GET: Property/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Property/Edit/5
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

        // GET: Property/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Property/Delete/5
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

        // Controller public methods
        public static void addProperty(PropertyWithPremises property)
        {
            propertyList.Add(property);
        }

        public static IEnumerable<PropertyWithPremises> getAllProperties()
        {
            return propertyList;
        }
    }
}
