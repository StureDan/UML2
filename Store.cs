using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace UML2
{
    public class Store
    {

        static MenuCatalog _menuCatalog = new MenuCatalog();

        public void Test()
        {
            

            

            

                Pizza p1 = new Pizza()
                { Name = "Calzone", Price = 65, ID = 1 };
                _menuCatalog.Create(p1);
                Pizza p2 = new Pizza()
                { Name = "Køddyret", Price = 80, ID = 2 };
                _menuCatalog.Create(p2);
                Pizza p3 = new Pizza()
                { Name = "Bernaisebæstet", Price = 90, ID = 3 };
                _menuCatalog.Create(p3);
            
          

        }
        

        
    }
}
