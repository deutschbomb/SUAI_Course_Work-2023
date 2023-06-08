
namespace Курсовой_проект_2023
{
    /*
     Класс Воблы - наследник класса Рыбы
     */
    public class Roach : Fish
    {
        //  Конструктор класса
        public Roach(double weight) : base("Вобла", 61 * (weight / 100), weight) { }
    }
}
