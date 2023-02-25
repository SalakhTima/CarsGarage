using Garage;

class Program
{

    static void Main()
    {
        List<Car> carGarage = new();
        bool flag = true;

        while (flag)
        {
            Console.WriteLine("Добавить автомобиль - 1\nВывод всех автомобилей - 2\nВыход - 3");
            int code = int.Parse(Console.ReadLine());
            switch (code)
            {
                case 1:
                    Console.WriteLine("Введите марку, модель, цвет и номер: ");
                    string brand = Console.ReadLine();
                    string model = Console.ReadLine();
                    string color = Console.ReadLine();
                    string number = Console.ReadLine();
                    carGarage.Add(new Car(brand, model, color, number));                  
                    break;

                case 2:
                    foreach (var car in carGarage)
                    {
                        Console.WriteLine(car);
                        Console.WriteLine();
                    }
                    break;

                case 3:
                    Console.WriteLine("Выход.");
                    flag = false;
                    break;
            }
        }
    }
}
