
namespace Курсовой_проект_2023
{
    /*
     Класс Модели
     */
    public class Model
    {
        public Client Customer { get; private set; } // экземпляр клиента

        //  Конструктор класса, инициализирующий экземпляр клиента
        public Model() { Customer = new Client(); }

        //  Метод для создания экземпляра клиента с указанными данными
        public void ClientConstructor(string Name, string Surname, int Age, string PhoneNumber,
            int WalletBalance, int CardNumber, int CardBalance)
        {
            //  Если переданный номер телефона не содержит пробелов, создаём экземпляр с номером телефона, иначе - без
            if (PhoneNumber.Contains(" ")) Customer = new Client(Name, Surname, Age, WalletBalance, CardNumber, CardBalance);
            else Customer = new Client(Name, Surname, Age, PhoneNumber, WalletBalance, CardNumber, CardBalance);
        }
    }
}
