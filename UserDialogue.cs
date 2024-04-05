using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML2
{
    public class UserDialogue
    {
        MenuCatalog _catalog;

        public UserDialogue(MenuCatalog menuCatalog)
        {
            _catalog = menuCatalog;
        }

        Pizza GetNewPizza()
        {
            Pizza pizza = new Pizza();
            Console.Clear();
            Console.WriteLine("Thanks for using our services. Please add a pizza to your menu.");
            Console.Write("Enter name");
            pizza.Name = Console.ReadLine();
            Console.Write("Enter ID)");
            pizza.ID = int.Parse(Console.ReadLine());
            Console.Write("Enter price");
            pizza.Price = int.Parse(Console.ReadLine());
            return pizza;
        }
        int MainMenuChoice(List<string> menuItems)
        {
            Console.Clear();
            Console.WriteLine("Deluxe Menu");
            Console.WriteLine();
            Console.WriteLine("Options");
            foreach (string choice in menuItems)
            {
                Console.WriteLine(choice);
            }
            Console.Write("Enter option#: ");
            string input = Console.ReadKey().KeyChar.ToString();

            try
            {
                int result = Int32.Parse(input);
                return result;
            }

            catch (FormatException)
            {
                Console.WriteLine($"Unable to parse '{input}'");
            }
            return -1;
        }
            public void Run()
        {
            bool proceed = true;
            List<string> mainMenulist = new List<string>
            {
                "0. Quit",
                "1. Create new pizza",
                "2. Print menu",
                "3. Update pizza",
                "4. Search pizza",
                "5. Delete pizza"
            };
            while (proceed)
            { 
                int menuChoice = MainMenuChoice(mainMenulist); 
                Console.WriteLine();
                switch (menuChoice) 
                {
                    case 0:
                    proceed = false;
                    Console.WriteLine("Quitting");
                    break;

                    case 1:
                        try
                        {
                            Pizza pizza = GetNewPizza();
                            _catalog.Create(pizza);
                            Console.WriteLine($"You have ordered: {pizza}");
                        }
                        catch (Exception)
                        {
                            Console.WriteLine($"No pizza has been ordered");
                        }
                        Console.Write("Press a key to continue");
                        Console.ReadKey();
                        break;

                        case 2:
                        _catalog.PrintMenu();
                        Console.Write("Press a key to continue");
                        Console.ReadKey();
                        break;

                        case 3:
                        _catalog.PrintMenu();
                        Console.Write("You have accessed the menu. Please choose a pizza.");
                        int pizzachoice = int.Parse( Console.ReadLine() );
                        Pizza ChoiceForUpdate = _catalog.Read(pizzachoice);
                        Console.WriteLine("give name");
                        string newname = Console.ReadLine();
                        Console.WriteLine("give price");
                        int newprice = int.Parse( Console.ReadLine() );
                        _catalog.Update(ChoiceForUpdate, newname, newprice);
                        Console.WriteLine("Your pizza has been updated");
                        Console.ReadKey();
                        break;

                        case 4:
                        _catalog.PrintMenu();
                        Console.Write("Search by name for your desired pizza");
                        string requiredsearch = Console.ReadLine();
                        Pizza foundpizza = _catalog.SearchPizza(requiredsearch);
                        Console.WriteLine($"This is the pizza \n{foundpizza}");
                        Console.ReadKey();
                        break;

                        case 5:
                        Console.Write("Insert the ID of the pizza you want to delete.");
                        _catalog.PrintMenu();
                        int pizzachoicedelete = int.Parse(Console.ReadLine());
                        Pizza ChoiceForDelete = _catalog.Read(pizzachoicedelete);
                        Console.WriteLine("give ID");
                        try
                        {
                            
                            _catalog.Delete(ChoiceForDelete);
                        }
                        catch (Exception e) 
                        {
                            Console.WriteLine(e.Message);
                        }
                        Console.WriteLine("You have deleted your pizza");
                        Console.ReadKey();
                        break;

                        default:
                        Console.Write("Press a key to continue");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
