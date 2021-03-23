using System;

namespace LashesShoppingCart
{
    class Program
    {
        static void Main(string[] args)

        {
            int integerVariable = 0;

            Lashes lashesObject = new Lashes();
            lashesObject.style = "Queen lashes";

            Lashes lashesObject2 = new Lashes();
            lashesObject2.style = "Doll lashes";

            Console.WriteLine($"Add {lashesObject2.style} and {lashesObject .style} to my shopping cart");
        }
           
     }

     public class Lashes
    {

       public string style { get; set; }

    }
  


 }

