
namespace Курсовой_проект_2023
{
    /*
     Класс Декоратора для добавления экземпляру класса Рыбы новых свойств
     */
    public abstract class FishDecotator : Fish
    {
        protected Fish fish;

        //  Конструктор Декоратора
        public FishDecotator(Fish fish, string name, double price, double weight) : base(name, price, weight)
        {
            this.fish = fish;
        }
    }
}
