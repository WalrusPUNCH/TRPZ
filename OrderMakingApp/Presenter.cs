using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderMakingApp
{
    class Presenter
    {
        readonly Kitchen Kitchen_;
        public readonly List<Dish> Menu;

        public Presenter()
        {
            Kitchen_ = new Kitchen();
            Menu = Kitchen_.Dishes;
        }

        public Order MakeOrder(List<string> DishNames)
        {
            List<Dish> OrderedDishes = ConvertNamesToRealDishes(DishNames);
            DateTime ServingTime = Kitchen_.AcceptOrder(OrderedDishes);
            Order NewOrder = new Order(OrderedDishes, ServingTime);
            return NewOrder;
        }

        private List<Dish> ConvertNamesToRealDishes(List<string> DishNames)
        {
            List<Dish> dishes = new List<Dish>();
            foreach (string dishName in DishNames)
            {
                dishes.Add(Menu.Where(dish => dish.Name == dishName).First());
            }
            return dishes;
        }
    }
}
