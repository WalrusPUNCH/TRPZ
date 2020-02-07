using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderMakingApp
{
    public class Kitchen
    {
        private readonly DataBase @base = new DataBase();
        List<Cook> Cooks = new List<Cook>();
        public readonly List<Dish> Dishes = new List<Dish>();
        public Kitchen()
        {
            Cooks = @base.GetCooks();
            Dishes = @base.GetDishes();
        }

        public DateTime AcceptOrder(List<Dish> DishesToCook)
        {
            DateTime ServingTime = DateTime.Now;
            foreach (Dish dish in DishesToCook)
            {
                List<Cook> AvaliableCooks = Cooks.Where(cook => cook.Specialization_ == dish.Cuisine).ToList();
                AvaliableCooks = AvaliableCooks.OrderBy(cook => cook.EndOfWorkTime).ThenByDescending( cook => (int)((Qualification)Enum.Parse(typeof(Qualification), cook.Qualification_.ToString()))).ToList();
                try
                {
                    DateTime DishReadyTime = AvaliableCooks.First().CookDish(dish);
                    if (DishReadyTime > ServingTime)
                        ServingTime = DishReadyTime;
                }
                catch (NullReferenceException)
                {
                    return DateTime.MinValue;
                }
            }

            return ServingTime;
        }
    }
}
