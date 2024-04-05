using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML2
{
    public class MenuCatalog
    {
        public List<Pizza> _pizzas = new List<Pizza> ();
        

        public void Create(Pizza pizza)
        {
            //List: _pizzas.Add(pizza); 
            _pizzas.Add(pizza);
        }
        public void PrintMenu()
        {

            foreach (Pizza p in _pizzas)
            {
                Console.WriteLine(p);
            }
        }
                                
        public Pizza Read(int ID)
        { 
            foreach (Pizza p in _pizzas)
            { if (p.ID == ID) return p; }
            return null; 
        }
        public Pizza SearchPizza(string pname)
        {
            bool foundpizza = false;
            foreach (Pizza p in _pizzas)
            {
                if (p.Name == pname )
                {
                    return p;
                    foundpizza = true;
                }
            }
            if (foundpizza == false) { throw new FormatException("Pizza doesn't exist"); }
            return null;
        }
        public void Update(Pizza pizza, string newname, int newprice)
        {
            if (pizza.ID <= 0)
            {
                throw new FormatException("No ID");
            }
            pizza.Price = newprice;
            pizza.Name = newname;

       
        }
        

        public void Delete(Pizza pizza)
        {
            foreach (var p in _pizzas)
            {
                if (p.ID == pizza.ID)
                {
                    _pizzas.Remove(p);

                }
                else throw new FormatException("This pizza does not match the ID");
            }
        }
    }
}