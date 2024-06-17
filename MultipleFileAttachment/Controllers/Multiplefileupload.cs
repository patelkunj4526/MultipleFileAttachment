using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleFileAttachment.Controllers
{
    public class Multiplefileupload : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(List<IFormFile> files)
        {
            // Save files and form entries here
            foreach (var file in files)
            {
                // Save file to disk or database
            }
            return View();
            // Redirect or return view
        }

        public IActionResult pulpload()
        {
            return View();
        }

        public IActionResult AutoTextBox()
        {
            return View();
        }

        public IActionResult DataTableColExp()
        {
            return View();
        }


        [HttpPost]
        public JsonResult StudentList(string prefix)
        {
            // Define static data here
            var staticData = new[] {
                new { Studentname = "John Doe" },
                new { Studentname = "Jane Smith" },
                new { Studentname = "Michael Johnson" },
                new { Studentname = "Emily Brown" },
                new { Studentname = "David Lee" }
            };

            // Filter static data based on the prefix
            //var filteredData = staticData.Where(s => s.Studentname.StartsWith(prefix)).ToList();
            var filteredData = staticData
        .Where(s => s.Studentname.Trim().StartsWith(prefix.Trim(), StringComparison.OrdinalIgnoreCase))
        .Select(s => s.Studentname)
        .ToList();

            return Json(filteredData);
        }
    }
}
