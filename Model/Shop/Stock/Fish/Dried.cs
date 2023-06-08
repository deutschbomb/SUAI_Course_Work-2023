
namespace Курсовой_проект_2023
{
    /*
     Класс Вяленой рыбы - наследник Декоратора
     */
    public class Dried : FishDecotator
    {
        //  Конструктор класса, добавляющий название типа рыбы и изменяющий её стоимость
        public Dried(Fish fish) : base(fish, fish.Name, fish.Price, fish.Weight) { this.Type = "Вяленая"; this.Price += 5 * (this.Weight / 100); }
    }
}
