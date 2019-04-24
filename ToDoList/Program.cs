using System;
using System.Collections.Generic;
using ToDoList.Models;


namespace ConsoleApp
{
    public class Program
    {

        public static void Main()
        {

            if(Item.GetAll().Count <= 0)
            {
                Console.WriteLine("----Welcome to your To Do List----");                
            }
            Console.WriteLine("");
            Console.WriteLine("Would you like to add an item to your list or view your list? (add/view)");
            string command = Console.ReadLine();


            if(command == "add" || command == "Add")
            {
                Console.WriteLine("");
                Console.WriteLine("Please enter your description for the new To Do item.");
                Item item = new Item(Console.ReadLine());
                Console.WriteLine("You've succesfully added '" + item.Description + "' to your Todo list");
                Console.WriteLine("");

            }
            else if(command == "view" || command == "View")
            {
                List<Item> all = Item.GetAll();
                if(all.Count <= 0)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Sorry, you don't have anything To Do yet!");
                    Console.WriteLine("=========================================");
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("========================");
                    Console.WriteLine("Your ToDo's");
                    Console.WriteLine("========================");
    
                    foreach(Item item in all){
                        Console.WriteLine("- " + item.Description);
                    }

                    Console.WriteLine("========================");
                    
                }
            }
            else
            {
                Console.WriteLine("Unknown command, please enter add/view");
                Main();
            }

            Main();
        }
    }
}