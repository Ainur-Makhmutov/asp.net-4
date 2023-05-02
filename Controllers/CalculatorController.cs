using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Лабораторная_работа___4.Models;

namespace Лабораторная_работа___4.Controllers
{
    public class CalculatorController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Result(string Result)
        {
            return View();
        }

        [HttpPost]

        public ActionResult Calculate(CalculatorModel model, string action)
        {
            if (action == "calculate")
            {
                if (ModelState.IsValid)
                {
                    switch (model.Operation)
                    {
                        case "+":
                            model.Result = model.First_Number + model.Second_Number;
                            break;
                        case "-":
                            model.Result = model.First_Number - model.Second_Number;
                            break;
                        case "*":
                            model.Result = model.First_Number * model.Second_Number;
                            break;
                        case "/":
                            model.Result = model.First_Number / model.Second_Number;
                            break;
                    }

                    ViewBag.Message = "Вычисление успешно.";
                }
                else
                {
                    ViewBag.Message = "Введены неверные данные.";
                }

                return View("Index", model);
            }
            else if (action == "clearr")
            {
                model.First_Number = 0;
                model.Operation = "+";

                ViewBag.Message = "Поля очищены.";

                return View("Index", model);
            }
            else
            {
                return View("Index", model);
            }
        }
    }
}