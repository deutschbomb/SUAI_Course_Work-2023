using System;

namespace Курсовой_проект_2023
{
    /*
     Класс Клиента - наследник класса Человека
     */
    public class Client : Person
    {
        BonusCard bonus_card;   // бонусная карта
        Basket basket;  // корзина

        public double WalletBalance { get; set; }   // денежный баланс
        public int CardNumber { get => bonus_card.Number; }     // номер карты
        public int CardBalance { get => bonus_card.Balance; private set => bonus_card.Balance = value; }    // баланс бонусной карты

        //  Метода добавления товара в корзину клиента
        public void ToBasket(Product product) { basket.AddProduct(product); }
        //  Метод удаления товара из корзины клиента
        public void FromBasket(int productIndex) { basket.RemovePurchase(productIndex); }
        //  Метод полного очищения корзины клиента
        public void AllFromBasket() { basket.ClearBasket(); }

        //  Метод, возвращающий общую стоимость покупок
        public double GetPurchasesSum() { return basket.PurchasesSum; }
        //  Метод оплаты покупок деньгами
        public string WalletPay(ref bool PaySuccess)
        {
            if (basket.PurchasesSum == 0) return "Корзина пуста.";  // проверка, не пуста ли корзина
            if (basket.PurchasesSum <= WalletBalance)   // Если общая стоимость покупок не превышает денежный баланс,
            {
                WalletBalance -= basket.PurchasesSum;   // вычитаем стоимость покупок из баланса,
                basket.ClearBasket();                   // очищаем корзину
                PaySuccess = true;                      // и отмечаем успешность оплаты
                return "Вы успешно оплатили покупку.";  // Текст уведомления
            }
            return "У вас недостаточно средств.\n" +    // Текст уведомления
                    "Оплатите часть баллами или уберите из корзины некоторые товары.";
        }
        //  Метод для оплаты покупок бонусами
        public string BonusPay(ref bool PaySuccess)
        {
            if (basket.PurchasesSum == 0) return "Корзина пуста.";  // проверка, не пуста ли корзина
            if (basket.PurchasesSum <= CardBalance)     // Если общая стоимость покупок не превышает баланс бонусов,
            {
                CardBalance -= Convert.ToInt32(basket.PurchasesSum);    // вычитаем стоимость покупок из баланса,
                basket.ClearBasket();                                   // очищаем корзину
                PaySuccess = true;                                      // и отмечаем успешность оплаты
                return "Вы успешно оплатили покупку баллами.";  // Текст уведомления
            }
            if (basket.PurchasesSum <= WalletBalance + CardBalance)     // Если общая стоимость покупок не превышает сумму денежных средств и бонусов,
            {
                basket.PurchasesSum -= CardBalance;     // вычитаем из стоимости покупок баланс баллов,
                CardBalance = 0;                        // обнуляем баланс баллов,
                WalletBalance -= basket.PurchasesSum;   // вычитаем стоимость покупок из баланса денежных средств,
                basket.ClearBasket();                   // очищаем корзину
                PaySuccess = true;                      // и отмечаем успешность оплаты
                return "Вы успешно оплатили покупку, используя бонусы.";    // Текст уведомления

            }
            return "У вас недостаточно средств.\n" +    // Текст уведомления
                    "Уберите из корзины некоторые товары.";
        }

        //  Конструктор класса по умолчанию
        public Client() : base() { }
        /// <summary>
        /// Конструктор класса для создания экземпляра без номера телефона 
        /// </summary>
        /// <param name="Name"> Имя </param>
        /// <param name="Surname"> Фамилия </param>
        /// <param name="Age"> Возраст </param>
        /// <param name="WalletBalance"> Денежный баланс </param>
        /// <param name="CardNumber"> Номер карты </param>
        /// <param name="CardBalance"> Баланс карты </param>
        public Client(string Name, string Surname, int Age, double WalletBalance,
            int CardNumber, int CardBalance)
            : base(Name, Surname, Age)
        {
            this.WalletBalance = WalletBalance;
            bonus_card = new BonusCard(CardNumber, CardBalance);
            basket = new Basket();
        }
        /// <summary>
        /// Конструктор класса для создания экземпляра с номером телефона
        /// </summary>
        /// <param name="Name"> Имя </param>
        /// <param name="Surname"> Фамилия </param>
        /// <param name="Age"> Возраст </param>
        /// <param name="PhoneNumber"> Номер телефона </param>
        /// <param name="WalletBalance"> Денежный баланс </param>
        /// <param name="CardNumber"> Номер карты </param>
        /// <param name="CardBalance"> Баланс карты </param>
        public Client(string Name, string Surname, int Age, string PhoneNumber, double WalletBalance,
            int CardNumber, int CardBalance)
            : base(Name, Surname, Age, PhoneNumber)
        {
            this.WalletBalance = WalletBalance;
            bonus_card = new BonusCard(CardNumber, CardBalance);
            basket = new Basket();
        }
    }
}
