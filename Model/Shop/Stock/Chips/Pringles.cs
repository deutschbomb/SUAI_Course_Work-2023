
namespace Курсовой_проект_2023
{
    /*
     Класс чипсов Pringles - наследник класса Чипсов
     */
    public class Pringles : Chips
    {
        //  Конструктор класса
        public Pringles(string flavour) : base("Pringles", 90) { this.Flavour = flavour; }
    }
}
