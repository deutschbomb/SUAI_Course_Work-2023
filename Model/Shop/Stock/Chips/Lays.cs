
namespace Курсовой_проект_2023
{
    /*
     Класс чипсов Lay's - наследник класса Чипсов
     */
    public class Lays : Chips
    {
        //  Конструктор класса
        public Lays(string flavour) : base("Lay's", 75) { this.Flavour = flavour; }
    }
}
