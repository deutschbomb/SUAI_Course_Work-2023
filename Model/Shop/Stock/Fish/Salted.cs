
namespace Курсовой_проект_2023
{
    /*
     Класс Солёной рыбы - наследник Декоратора
     */
    public class Salted : FishDecotator
    {
        //  Конструктор класса, добавляющий название типа рыбы и изменяющий её стоимость
        public Salted(Fish fish) : base(fish, fish.Name, fish.Price, fish.Weight) { this.Type = "Солёная"; this.Price += 10 * (this.Weight / 100); }
    }
}
