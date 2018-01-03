using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7LabInterface
{
    /* Create an application that does the following. Submit the complete application:

    Create an interface of your choosing with at least one property and one method. Cannot be IAnimal  DONE
    Create a class that uses the interface you created. The method must write to the screen  DONE
    In your Main() method, create an instance of that class. Call the method and use the property you defined in the class.  DONE
    */

        interface IDrink
    {
        //PROPERTIES

        string DrinkName { get; set; }
        string MainIngredient { get; set; }
        double Ounces { get; set; }

        //METHODS

        void MixDrink();
    }

    class VodkaBased : IDrink
    {
        //PROPERTIES

        public string DrinkName { get; set; }
        public string MainIngredient { get; set; }
        public double Ounces { get; set; }

        //METHODS

        public void MixDrink()
        {
            Console.WriteLine($"A {DrinkName} starts with {Ounces} ounces of {MainIngredient}.");
        }

        //CONSTRUTORS

        public VodkaBased()
        {
            DrinkName = "martini";
            MainIngredient = "vodka";
            Ounces = 1;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How to make cocktail drinks.\n");

            VodkaBased moscowMule = new VodkaBased();

            moscowMule.DrinkName = "Moscow Mule";
            moscowMule.Ounces = 1.5;

            moscowMule.MixDrink();

            Console.ReadLine();
        }
    }
}
