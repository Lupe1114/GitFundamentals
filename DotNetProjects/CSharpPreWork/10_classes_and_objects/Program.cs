using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_classes_and_objects
{
    class Program
    {
        static void Main(string[] args)
        {
            //1  //2  //3  //4
            Donuts dougDonut = new Donuts();
        }

        class Program
        {
            static void Main(string[] args)
            {
                Donuts dougDonut = new Donuts();
                Donuts chrisDonut = new Donuts();
                Donuts nickDonut = new Donuts();
            }


            {
                static void Main(string[] args)
            {
                //Instantiating the objects
                Donuts dougDonut = new Donuts();
                Donuts chrisDonut = new Donuts();
                Donuts nickDonut = new Donuts();

                //setting property values
                //1 //2 //3
                dougDonut.Filling = "cherry";
                dougDonut.Price = 3;
                dougDonut.GetType = "normal";
                dougDonut.IsSpecial = true;

                chrisDonut.Filling = "cherry";
                chrisDonut.Price = 2;
                chrisDonut.GetType = "small";
                chrisDonut.IsSpecial = false;

                nickDonut.Filling = "chocolate";
                nickDonut.Price = 3;
                nickDonut.GetType = "normal";
                nickDonut.IsSpecial = true;

                Console.WriteLine(nickDonut.Filling);

            }
        }
}
