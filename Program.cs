using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML2
{
    public class Program
    {
        static void Main(string[] args)
        {
            MenuCatalog catalog = new MenuCatalog();
            Store store = new Store();
            store.Test();
            UserDialogue userdialog = new UserDialogue(catalog);
            userdialog.Run();
           
           
        }
    }
}
