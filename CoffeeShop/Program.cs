using CoffeeShop.Abstract;
using CoffeeShop.Adapters;
using CoffeeShop.Concrete;
using CoffeeShop.Entities;
using System;

namespace CoffeeShop
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager1 = new NeroCustomerManager();
            customerManager1.Save(new Customer());
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer { DateOfBirth = new DateTime(1985, 1, 6), FirstName = "Engin", LastName = "Demiroğ", NationalityId = "28861499108" });
            Console.ReadLine();
        }
    }
}
