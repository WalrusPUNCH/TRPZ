using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderMakingApp
{

    interface IModel
    {
        Order AcceptOrder(List<Dish> dishes);
        List<Dish> GetMenu();
    }
    public class Kitchen : IModel
    {
        private readonly IDataBase @base = new DataBase();
        List<Cook> Cooks = new List<Cook>();
        public Kitchen()
        {
            Cooks = @base.GetCooks();
        }

        public List<Dish> GetMenu()
        {
            return @base.GetDishes();
        }
        public Order AcceptOrder(List<Dish> DishesToCook)
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
                    return new Order(DishesToCook, DateTime.MinValue);
                }
            }

            return new Order(DishesToCook, ServingTime);
        }
    }
}
