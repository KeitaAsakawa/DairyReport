using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//todo ここあとで切り出す
using MySql.Data.MySqlClient;
using System.Data;

namespace DairyReport.Controllers
{
    public class DayReportController : Controller
    {
        // GET: DayReport
        public ActionResult Index()
        {
            // test code
            MySqlConnection cn = new MySqlConnection("Data Source=localhost;Database=shoyohkai;User ID=root;password=pass");

            MySqlDataAdapter da = new MySqlDataAdapter("select * from msstaff",cn);
            // datareader系でやった方がいいな、よんでくるだけだし
            DataTable dt = new DataTable();

            da.Fill(dt);

            

            var xxx = dt;


            return View();
        }

        // GET: DayReport/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DayReport/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DayReport/Create
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

        // GET: DayReport/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DayReport/Edit/5
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

        // GET: DayReport/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DayReport/Delete/5
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
