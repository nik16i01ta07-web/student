using System;

class Car
{
    public string Brand = "";
    public string Number = "";

    public virtual void Show()
    {
        Console.WriteLine($"Автомобиль: марка - {Brand}, номер - {Number}");
    }
}

class PassengerCar : Car
{
    public int NumberOfSeats;

    public override void Show()
    {
        Console.WriteLine(
            $"Легковой автомобиль: марка - {Brand}, номер - {Number}, " +
            $"число пассажирских мест - {NumberOfSeats}"
        );
    }
}

class Truck : Car
{
    public double LoadCapacity;

    public override void Show()
    {
        Console.WriteLine(
            $"Грузовой автомобиль: марка - {Brand}, номер - {Number}, " +
            $"грузоподъемность - {LoadCapacity}"
        );
    }
}

class Program
{
    static void Main(string[] args)
    {
        PassengerCar passengerCar = new PassengerCar();
        passengerCar.Brand = "Toyota";
        passengerCar.Number = "A123BC";
        passengerCar.NumberOfSeats = 5;

        Truck truck = new Truck();
        truck.Brand = "КамАЗ";
        truck.Number = "B456CD";
        truck.LoadCapacity = 10;

        passengerCar.Show();
        truck.Show();
    }
}
