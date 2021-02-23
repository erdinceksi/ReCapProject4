using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarTest();

            //UserTest();

            RentalTest();

        }

        private static void RentalTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            var result = rentalManager.GetRentalDetails();

            if (result.Success)
            {
                foreach (var rent in result.Data)
                {
                    Console.WriteLine("FirstName: {0}, LastName: {1}, Email: {2}, ModelYear: {3}, " +
                        "DailyPrice: {4}, Description: {5}, BrandName: {6}, ColorName: {7}, " +
                        "RentDate: {8}, ReturnDate: {9}",
                        rent.FirstName,
                        rent.LastName, rent.Email, rent.ModelYear, rent.DailyPrice, rent.Description, rent.BrandName,
                        rent.ColorName, rent.RentDate, rent.ReturnDate);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void UserTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());

            var result = userManager.GetUserDetails();

            if (result.Success)
            {
                foreach (var user in result.Data)
                {
                    Console.WriteLine("FirstName: {0}, LastName: {1}, Email: {2}, CompanyName: {3}",
                        user.FirstName, user.LastName, user.Email, user.CompanyName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetCarDetails();

            if (result.Success)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine("Description: {0}, BrandName: {1}, ColorName: {2}, DailyPrice: {3}",
                        car.Description, car.BrandName, car.ColorName, car.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
            
        }
    }
}
