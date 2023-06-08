
namespace Курсовой_проект_2023
{
    /*
     Класс Презентера
     */
    public class Presenter : IPresenter
    {
        public IView view;  // представление
        public Model model;     // модель
        public delegate void PresenterHandler(string message);  // делегат события
        public event PresenterHandler Notify;   // событие

        //  Конструктор класса
        public Presenter(IView view)
        {
            this.view = view;   // представление равно переданному представлению
            model = new Model();    // инициализируем модель
        }

        //  Метод регистрации пользователя
        public void Register_Customer(string Name, string Surname, int Age, string PhoneNumber,
            int WalletBalance, int CardNumber, int CardBalance)
        {
            model.ClientConstructor(Name, Surname, Age, PhoneNumber, WalletBalance, CardNumber, CardBalance);
        }
        //  Метод, возвращающий полное имя пользователя
        public string Get_CustomerFullName() { return (model.Customer.Name + ' ' + model.Customer.Surname); }
        //  Метод, возвращающий денежный баланс пользователя
        public string Get_CustomerBalance() { return (model.Customer.WalletBalance.ToString() + " р."); }
        //  Метод, возвращающий баланс бонусной карты пользователя
        public string Get_CustomerCardBalance() { return (model.Customer.CardBalance.ToString() + " б."); }
        //  Метод оплаты покупок денежными средствами
        public bool PayPurchases_Wallet()
        {
            bool Success = false;
            Notify.Invoke(model.Customer.WalletPay(ref Success));
            return Success;
        }
        //  Метод оплаты покупок бонусами
        public bool PayPurchases_Bonuses()
        {
            bool Success = false;
            Notify.Invoke(model.Customer.BonusPay(ref Success));
            return Success;
        }

        //  Метод добавления товара в корзину
        public void AddProduct(Product product) { model.Customer.ToBasket(product); }
        //  Метод удаления товара из корзины
        public void RemoveProduct(int productIndex) { model.Customer.FromBasket(productIndex); }
        //  Метод полного очищения корзины
        public void RemoveAll() { model.Customer.AllFromBasket(); }
        //  Метод, возвращающий полную стоимость покупок
        public double GetPurchasesSum() { return model.Customer.GetPurchasesSum(); }
    }
}
