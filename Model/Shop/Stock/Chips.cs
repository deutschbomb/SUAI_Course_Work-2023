
namespace Курсовой_проект_2023
{
    /*
     Абстрактный класс Чипсы - наследник Продукта/Товара
     */
    public abstract class Chips : Product
    {
        public string Flavour { get; set; } // вкус чипсов

        //  Конструктор класса
        public Chips(string name, double price) { this.Name = name; this.Price = price; }
    }
}
