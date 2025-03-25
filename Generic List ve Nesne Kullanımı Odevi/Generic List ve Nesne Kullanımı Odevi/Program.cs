using System;
using System.Collections.Generic;

class Car
{
    public string Marka { get; set; }
    public string Model { get; set; }
    public double FuelConsumption { get; set; }
    public double TotalDistance { get; set; }
    public double TotalFuelConsumption()
    {
        return (TotalDistance / 100) * FuelConsumption;
    }
}

class Program
{
    static void Main()
    {
        List<Car> arabalar = new List<Car>
        {
            new Car { Marka = " Toyota ", Model = " Corolla ", FuelConsumption = 6.5, TotalDistance = 5000 },
            new Car { Marka = "BMW", Model = "X5", FuelConsumption = 9.0, TotalDistance = 5000 },
            new Car { Marka = "Mercedes", Model = "C200", FuelConsumption = 8.2, TotalDistance = 5000 }
        };

        foreach (var araba in arabalar)
        {
            Console.WriteLine("Marka: " + araba.Marka + 
                              " Model: " + araba.Model+
                              " 100 km'de Yaktığı Yakıt: " +araba.FuelConsumption + " litre, Toplam Yakıt Tüketimi: " + araba.TotalFuelConsumption()+ " litre");
        }
    }
}
