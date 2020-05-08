using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SquareRootWeb.Models;

namespace SquareRootWeb.Controllers
{
    public class SquareRootController : Controller
    {
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(string firstNumber, string secondNumber)
        {
            ViewBag.firstNumber = firstNumber;
            ViewBag.secondNumber =secondNumber;

            int No1 = 0;
            bool isConverted1 = int.TryParse(firstNumber, out No1);
            int No2 = 0;
            bool isConverted2 = int.TryParse(secondNumber, out No2);

            int SQNo1 = (int)Math.Sqrt(No1);
            int SQNo2 = (int)Math.Sqrt(No2);

            ViewBag.SQNo1 = SQNo1;
            ViewBag.SQNo2 = SQNo2;
                
            ViewBag.isConverted1 = isConverted1;
            ViewBag.isConverted2 = isConverted2;

            ViewBag.No1 = No1;
            ViewBag.No2 = No2;

            return View();
       }
       
    }
}