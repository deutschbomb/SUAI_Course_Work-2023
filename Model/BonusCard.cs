
namespace Курсовой_проект_2023
{
    /*
     Класс Бонусной карты
     */
    public class BonusCard
    {
        public int Number { get; set; }     // номер карты
        public int Balance { get; set; }    // баланс карты

        //  Конструктор класса
        public BonusCard(int Number, int Balance)
        {
            this.Number = Number; this.Balance = Balance;
        }
    }
}
