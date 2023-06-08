
namespace Курсовой_проект_2023
{
    /*
     Абстрактный класс Рыбы - наследник Продукта/Товара
     */
    public abstract class Fish : Product
    {
        public string Type { get; set; }    // тип рыбы
        public double Weight { get; set; }  // вес рыбы

        //  Конструктор класса
        public Fish(string name, double price, double weight) { this.Name = name; this.Price = price; this.Weight = weight; }
    }
}
