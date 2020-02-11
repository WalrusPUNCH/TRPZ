using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderMakingApp
{

    public interface IPresenter
    {
        void MakeOrder(List<string> DishNames);
        List<Dish> GetMenu();
        string FormResponseForView(Order order);
    }

    class Presenter : IPresenter
    {
        readonly IModel Model; // kitchen
        readonly IView View; // form

        public Presenter(IView view)
        {
            Model = new Kitchen();
            this.View = view;
        }

        public List<Dish> GetMenu()
        {
            return Model.GetMenu();
        }
        public void MakeOrder(List<string> DishNames)
        {
            if (DishNames.Count == 0)
                View.ShowResponseError("Ви не обрали жодної страви");
            else
            {
                List<Dish> OrderedDishes = ConvertNamesToRealDishes(DishNames);
                Order NewOrder = Model.AcceptOrder(OrderedDishes);
                if (NewOrder.ServingTime < DateTime.Now)
                    View.ShowResponseError("На жаль, ми не можемо приготувати ваше замовлення");
                else
                {
                    string response = FormResponseForView(NewOrder);
                    View.ShowResponseOK(response);
                }
            }
        }

        private List<Dish> ConvertNamesToRealDishes(List<string> DishNames)
        {
            List<Dish> dishes = new List<Dish>();
            List<Dish> menu = GetMenu();
            foreach (string dishName in DishNames)
            {
                dishes.Add(menu.Where(dish => dish.Name == dishName).First());
            }
            return dishes;
        }    
        
        public string FormResponseForView(Order order)
        {
            string response = "";
            response += String.Format("Ваше замовлення буде готове о {0}\n", order.ServingTime.ToShortTimeString());
            foreach (Dish dish in order.OrderedDishes)
            {
                response += String.Format("Страва {0} буде готова о {1}\n", dish.Name, dish.CookedAt.ToShortTimeString());
            }
            return response;
        }
    }
}
