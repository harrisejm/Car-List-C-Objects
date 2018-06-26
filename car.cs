using System;
using System.Collections.Generic;

class Car
{
  private string MakeModel;
  private int Price;
  private int Miles;
  // private Car(string carMakeModel, int carPrice, int carMiles)
  // {
  //   MakeModel = carMakeModel;
  //   Price = carPrice;
  //   Miles = carMiles;
  // }

  public void SetMakeModel(string newMake)
  {
    MakeModel = newMake;
  }
  public string GetMakeModel()
  {
    return MakeModel;
  }

  public void SetPrice(int newPrice)
  {
    Price = newPrice;
  }
  public int GetPrice(){
    return Price;
  }
  public void SetMiles(int newMiles)
  {
    Miles = newMiles;
  }
  public int GetMiles()
  {
    return Miles;
  }
}

public class Program
{
 public static void Main()
  {

  Car porsche = new Car();
  porsche.SetMakeModel("2014 Porsche 911");
  porsche.SetPrice(114991);
  porsche.SetMiles(7864);


  Car ford = new Car();
  ford.SetMakeModel("2011 Ford F450");
  ford.SetPrice(55995);
  ford.SetMiles(14241);

  Car batMobil = new Car();
  batMobil.SetMakeModel("The Batmobil");
  batMobil.SetPrice(100000000);
  batMobil.SetMiles(1000);

  List<Car> allCars = new List<Car>{porsche, ford, batMobil};

  foreach(Car carType in allCars)
  {
    Console.WriteLine("Car Type: " + carType.GetMakeModel());
    Console.WriteLine("Price: " + carType.GetPrice());
    Console.WriteLine("Mileage: " + carType.GetMiles());
  }

  Console.WriteLine("Enter Max Price");
  string maxPrice1 = Console.ReadLine();
  int maxPrice = int.Parse(maxPrice1);

  Console.WriteLine("Enter Max Mileage");
  string maxMiles1 = Console.ReadLine();
  int maxMiles = int.Parse(maxMiles1);

  List<Car> priceMiles = new List<Car>(){};

  foreach(Car carType in allCars)
  {
    if (carType.GetPrice() > maxPrice && carType.GetMiles() > maxMiles)
    {
    //  Console.WriteLine(carType.GetMakeModel());
      priceMiles.Add(carType);
    }
  }

  foreach(Car carType in priceMiles)
  {
    Console.WriteLine(carType.GetMakeModel());
  }

  }
}
