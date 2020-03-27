using System;
using System.Collections.Generic;
namespace PersProj
{
    class Program
    {
        static void Main(string[] args)
        {
            CarShop carShop = new CarShop();
            carShop.Input();

            Console.WriteLine($"Total sum: {carShop.TotalSum()} lv.");
            carShop.Output();
        }
    }
}
public class CarShop
{
    public string carBrand; // MERCEDES - AUDI - BMW - VW
    public string carColor; // RED - WHITE - BLACK
    public string carType; // CABRIO - SEDAN
    public double charity; // percent from totalPrice for charity!
    public double price, discount; // price and discount ... if charity >= 25% ! ... company gives 5% from carPrice as discount for charity! charity is 25% from carPrice , for < 25 1%!!
    public int numberToBuy; // number of cars to buy
    public double charityFromCompany; // money for charity from the car company
    public void Input()
    {
        carBrand = Console.ReadLine();
        carColor = Console.ReadLine();
        carType = Console.ReadLine();
        charity = double.Parse(Console.ReadLine());
        numberToBuy = int.Parse(Console.ReadLine());
    }
    public double TotalSum()
    {
        if (carBrand == "Mercedes")
        {
            if (carColor == "red" && carType == "cabrio")
            {
                price = 2500;
            }
            else if (carColor == "red" && carType == "sedan")
            {
                price = 2000;
            }

            if (carColor == "white" && carType == "cabrio")
            {
                price = 4500;
            }
            else if (carColor == "white" && carType == "sedan")
            {
                price = 3500;
            }

            if (carColor == "black" && carType == "cabrio")
            {
                price = 5000;
            }
            else if (carColor == "black" && carType == "sedan")
            {
                price = 4400;
            }
        }
        else if (carBrand == "Audi")
        {
            if (carColor == "red" && carType == "cabrio")
            {
                price = 5000;
            }
            else if (carColor == "red" && carType == "sedan")
            {
                price = 3000;
            }

            if (carColor == "white" && carType == "cabrio")
            {
                price = 6000;
            }
            else if (carColor == "white" && carType == "sedan")
            {
                price = 4000;
            }

            if (carColor == "black" && carType == "cabrio")
            {
                price = 9000;
            }
            else if (carColor == "black" && carType == "sedan")
            {
                price = 7500;
            }
        }
        else if (carBrand == "BMW")
        {
            if (carColor == "red" && carType == "cabrio")
            {
                price = 3000;
            }
            else if (carColor == "red" && carType == "sedan")
            {
                price = 1200;
            }

            if (carColor == "white" && carType == "cabrio")
            {
                price = 6000;
            }
            else if (carColor == "white" && carType == "sedan")
            {
                price = 3150;
            }

            if (carColor == "black" && carType == "cabrio")
            {
                price = 7600;
            }
            else if (carColor == "black" && carType == "sedan")
            {
                price = 4000;
            }
        }
        else if (carBrand == "VW")
        {
            if (carColor == "red" && carType == "cabrio")
            {
                price = 2500;
            }
            else if (carColor == "red" && carType == "sedan")
            {
                price = 3550;
            }

            if (carColor == "white" && carType == "cabrio")
            {
                price = 4300;
            }
            else if (carColor == "white" && carType == "sedan")
            {
                price = 2350;
            }

            if (carColor == "black" && carType == "cabrio")
            {
                price = 6700;
            }
            else if (carColor == "black" && carType == "sedan")
            {
                price = 5500;
            }
        }

        double sum = price * numberToBuy;

        if (charity >= 25)
        {
            discount = 0.05;
            sum = sum + (price * (charity / 100));
            charityFromCompany = price * numberToBuy * discount;
            sum = sum - charityFromCompany;
            Console.WriteLine($"Company gives {charityFromCompany} lv.");
        }
        else if (charity < 25)
        {
            sum = sum + (price * (charity / 100));
            charityFromCompany = price * 0.01;
            sum = sum - charityFromCompany;
            Console.WriteLine($"Company gives {charityFromCompany} lv.");
        }

        return sum;

    }

    public void Output()
    {
        Console.WriteLine($"You bought {numberToBuy}x{carBrand} - {carType} - {carColor} color for total money of {price*numberToBuy} with discount {discount*100}%");
    }
}
