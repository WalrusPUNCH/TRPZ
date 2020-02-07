﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderMakingApp
{
    class DataBase
    {
        public List<Cook> GetCooks()
        {
            List<Cook> cooks = new List<Cook>()
            {
                new Cook(Qualification.Junior, Specialization.American),
                new Cook(Qualification.Senior, Specialization.American),

                new Cook(Qualification.Junior, Specialization.European),
                new Cook(Qualification.Middle, Specialization.European),
                new Cook(Qualification.Senior, Specialization.European),

                new Cook(Qualification.Middle, Specialization.Asian),
                new Cook(Qualification.Senior, Specialization.Asian)
            };

            return cooks;
        }

        public List<Dish> GetDishes()
        {

            List<Dish> dishes = new List<Dish>();
            List<Ingridient> ingridients = new List<Ingridient>() {
                new Ingridient("Dough"), 
                new Ingridient("Sauce"), 
                new Ingridient("Meat"),
                new Ingridient("Spices")
            };

            dishes.Add(new Dish("Pizza", Specialization.European, new TimeSpan(0,30,0), 500, ingridients));

            ingridients = new List<Ingridient>()
            {
                new Ingridient("Dough"),
                new Ingridient("Sauce"),
                new Ingridient("Meat"),
            };

            dishes.Add(new Dish("Pasta", Specialization.European, new TimeSpan(1, 0, 0), 700, ingridients));

            ingridients = new List<Ingridient>()
            {
                new Ingridient("Chicken"),
                new Ingridient("Oil"),
                new Ingridient("Spices")
            };

            dishes.Add(new Dish("Fried Chicken", Specialization.American, new TimeSpan(0, 10, 0), 300, ingridients));

            ingridients = new List<Ingridient>()
            {
                new Ingridient("Vegetables"),
                new Ingridient("Oil"),
                new Ingridient("Spices")
            };

            dishes.Add(new Dish("French fries", Specialization.American, new TimeSpan(0, 10, 0), 300, ingridients));

            ingridients = new List<Ingridient>()
            {
                new Ingridient("Fish"),
                new Ingridient("Rice")
            };

            dishes.Add(new Dish("Sushi", Specialization.Asian, new TimeSpan(0, 40, 0), 500, ingridients));


            ingridients = new List<Ingridient>()
            {
                new Ingridient("Chicken"),
                new Ingridient("Spices")
            };

            dishes.Add(new Dish("Chicken curry", Specialization.Asian, new TimeSpan(1, 5, 0), 750, ingridients));

            return dishes;
        }
        /*
        public List<Ingridient> GetIngridients()
        {
            List<Ingridient> ingridients = new List<Ingridient>()
            {
                new Ingridient("Vegetables"),
                new Ingridient("Fruits"),
                new Ingridient("Meat"),
                new Ingridient("Fish"),
                new Ingridient("Chicken"),
                new Ingridient("Sauce"),
                new Ingridient("Dough"),

                new Ingridient("Oil"),
                new Ingridient("Rice"),
                new Ingridient("Spices")
            };

            return ingridients;
        }*/
    }
}
