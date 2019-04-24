using System.Collections.Generic;

namespace ToDoList.Models
{
    public class Item
    {
        //Properties
        private string _description;
        public string Description
        {
            get { return _description;  }
            set { _description = value; }
        }

        private static List<Item> _instances = new List<Item> {};


        //Constructor
        public Item (string description)
        {
            _description = description;
            _instances.Add(this);
        }

        // //Getter
        // public string GetDescription()
        // {
        //     return _description;
        // }

        // //Setter
        // public void SetDescription(string newDescription)
        // {
        //     _description = newDescription;
        // }

        public static List<Item> GetAll()
        {
            return _instances;
        }

        public static void ClearAll()
        {
            _instances.Clear();
        }
    }
}