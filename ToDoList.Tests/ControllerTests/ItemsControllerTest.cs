using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ToDoList.Controllers;
using ToDoList.Models;

namespace ToDoList.Tests
{
    [TestClass]
    public class ItemsControllerTest
    {
        [TestMethod]
        public void Index_ReturnsCorrectView_True()
        {
            ItemsController ic = new ItemsController();
            ActionResult indexView = ic.Index();
            Assert.IsInstanceOfType(indexView, typeof(ViewResult));

        }


        [TestMethod]
        public void Index_HasCorrectModelType_ItemList()
        {
            ItemsController ic = new ItemsController();
            ViewResult indexView = new ItemsController().Index() as ViewResult;

            var result = indexView.ViewData.Model;

            Assert.IsInstanceOfType(result, typeof(List<Item>));
        }

        [TestMethod]
        public void Create_ReturnsCorrectActionType_RedirectToActionResult()
        {
            ItemsController ic = new ItemsController();
            IActionResult view = ic.Create("Get a haircut");
            Assert.IsInstanceOfType(view, typeof(RedirectToActionResult));
        }

        [TestMethod]
        public void Create_RedirectsToCorrectAction_Index()
        {
            ItemsController ic = new ItemsController();
            RedirectToActionResult actionResult = ic.Create("sleep in") as RedirectToActionResult;
            string result = actionResult.ActionName;
            Assert.AreEqual(result, "Index");
        }
    }
}