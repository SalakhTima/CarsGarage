namespace Garage
{
    class Car
    {
        public string brand;
        public string model;
        public string color;
        public string number;

        public Car(string inputBrand = "Неизвестно", string inputModel = "Неизвестно", string inputColor = "Неизвестно", string inputNumber = "Неизвестно")
        {
            brand = inputBrand;
            model = inputModel;
            color = inputColor;
            number = inputNumber;
        }

        public override string ToString() => $"Марка: {brand}\nМодель: {model}\nЦвет: {color}\nНомер: {number}";   
    }
}
