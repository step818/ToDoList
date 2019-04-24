using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using ToDoList.Models;

namespace ToDoList.Tests
{
    [TestClass]
    public class ItemTest : IDisposable
    {
        public void Dispose()
        {
            Item.ClearAll();
        }
        
        [TestMethod]
        public void ItemConstructor_CreatesInstanceOfItem_Item()
        {
            Item newItem = new Item("test");
            Assert.AreEqual(typeof(Item), newItem.GetType());
        }

        [TestMethod]
        public void GetDescription_ReturnDescription_String()
        {
            string description = "Walk the dog.";
            Item newItem = new Item(description);
            string result = newItem.Description;
            Assert.AreEqual(description, result);

        }

        [TestMethod]
        public void SetDescription_SetDescription_String()
        {
            string description = "Walk the dog.";
            Item newItem = new Item(description);
            
            string updatedDescription = "Do the dishes";
            newItem.Description = updatedDescription;
            string result = newItem.Description;

            Assert.AreEqual(updatedDescription, result);        
        }

        [TestMethod]
        public void GetAll_ReturnsAllItems_ItemList()
        {
            string description01 = "Walk the dog.";
            string description02 = "Wash the dishes.";
            Item newItem1 = new Item(description01);
            Item newItem2 = new Item(description02);
            
            // Arrange
            List<Item> newList = new List<Item> { newItem1, newItem2 };

            // Act
            List<Item> result = Item.GetAll();

            foreach (Item thisItem in result)
            {
                Console.WriteLine("Output from GetAll test: " + thisItem.Description);
            }

            CollectionAssert.AreEqual(newList, result);
        }
    }
}