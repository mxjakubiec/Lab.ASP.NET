﻿using Microsoft.AspNetCore.Mvc;

namespace _2lab.Controllers
{
    public enum Operators
    {
        ADD, SUB, MUL, DIV
    }
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Form()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Result(Calculator model)
        {
            if (!model.IsValid())
            {
                return View("Error");
            }
            return View(model);
        }

        //public IActionResult Result([FromQuery(Name = "operator")] Operators? op, double? x, double? y)
        //{
        //    if(x == null || y == null)
        //    {
        //        return View("Error");
        //    }
        //    switch(op)
        //    {
        //            case Operators.ADD:
        //            ViewBag.result = x + y;
        //            break;
        //            case Operators.SUB:
        //            ViewBag.result = x - y;
        //            break;
        //            case Operators.MUL:
        //            ViewBag.result = x * y;
        //            break;
        //            case Operators.DIV:
        //            ViewBag.result = x / y;
        //            break;
        //        default: return View("Error");
        //    }
        //    return View();
        //}
    }
}
