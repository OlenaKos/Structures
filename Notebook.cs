using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Structures
{
    struct Notebook
    {
        public string Model;
        public string Brand;
        public double Price;

        public Notebook(string model, string brand, double price)
        {
            this.Model = model;
            this.Brand = brand;
            this.Price = price;
        }

        public void PrintAll()
        { 
            Type notebookType = typeof(Notebook);
            FieldInfo [] fields = notebookType.GetFields();
            foreach (var field in fields)
            {
                Console.WriteLine("There is field {0} and its value {1}", field.Name, field.GetValue(this));
            }
        }
    }
}
