using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP // Open–closed principle
{
    //this class implements OCP. OCP is:
    //"Software entities ... should be open for extension, but closed for modification."
    //The point of this principle is that the system should be built in such a way that all subsequent changes
    //to it should be implemented by adding new code, and not changing existing ones.
    //It helps when there is collective work, and everyone is responsible for their own part. 
    //when you need to add new functions you shouldn't change some other guy's code, better extend it with yours.

    //for Example: here we have an abstract class for MealBase.
    //In this class i described a standart 3-part process for cooking a meal: Prepare ingridients (Prepare());
    //Cook it (Cook());   and make some Final Steps (FinalSteps()).
    //For making any kind of meal we should make this steps. So, for every different meal we should just implement
    //this abstract class.
    class restaurant
    {
        public void makeDinner()
        {
            MealBase[] menu = new MealBase[] { new PotatoMeal(), new SaladMeal() };

            Cook bob = new Cook("Bob");
            bob.MakeDinner(menu);
        }


        class Cook
        {
            public string Name { get; set; }

            public Cook(string name)
            {
                this.Name = name;
            }

            public void MakeDinner(MealBase[] menu)
            {
                foreach (MealBase meal in menu)
                    meal.Make();
            }
        }

        abstract class MealBase
        {
            public void Make()
            {
                Prepare();
                Cook();
                FinalSteps();
            }
            protected abstract void Prepare();
            protected abstract void Cook();
            protected abstract void FinalSteps();
        }

        class PotatoMeal : MealBase
        {
            protected override void Cook()
            {
                Console.WriteLine("Put potato on fire");
                Console.WriteLine("Boil for 30 min");
                Console.WriteLine("Drain the remaining water, mash the boiled potatoes");
            }

            protected override void FinalSteps()
            {
                Console.WriteLine("Sprinkle mashed potatoes with spices and herbs");
                Console.WriteLine("Mashed potatoes are ready");
            }

            protected override void Prepare()
            {
                Console.WriteLine("Peel and wash the potatoes");
            }
        }

        class SaladMeal : MealBase
        {
            protected override void Cook()
            {
                Console.WriteLine("Slice tomatoes and cucumbers");
                Console.WriteLine("Sprinkle with herbs, salt and spices");
            }

            protected override void FinalSteps()
            {
                Console.WriteLine("Add oil");
                Console.WriteLine("The salad is ready");
            }

            protected override void Prepare()
            {
                Console.WriteLine("Wash tomatoes and cucumbers");
            }
        }
    }
}
