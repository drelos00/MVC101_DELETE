using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Mvc101.Controllers
{
    public class ProcessController : Controller
    {
        // GET: Process
        public ActionResult Index()
        {
            // Process[] procs = Process.GetProcesses();
            // ViewBag.procs = procs;
            // return View();
            
            // or you can also do this way

            return View(Process.GetProcesses());
            
            // then in the index, 
            // @model System.Diagnostics.Process[]
        }

        public ActionResult Display(int id)
        {
            return View(Process.GetProcessById(id));
        }

    }
}