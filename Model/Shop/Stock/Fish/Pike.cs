
namespace Курсовой_проект_2023
{
    /*
     Класс Щуки - наследник класса Рыбы
     */
    public class Pike : Fish
    {
        //  Конструктор класса
        public Pike(double weight) : base("Щука", 68 * (weight / 100), weight) { }
    }
}
