
namespace Курсовой_проект_2023
{
    /*
     Интерфейс Презентера
     */
    public interface IPresenter
    {
        void Register_Customer(string Name, string Surname, int Age, string PhoneNumber,
            int WalletBalance, int CardNumber, int CardBalance);
        string Get_CustomerFullName();
        string Get_CustomerBalance();
        string Get_CustomerCardBalance();
        bool PayPurchases_Bonuses();
        bool PayPurchases_Wallet();
        void AddProduct(Product product);
        void RemoveProduct(int productIndex);
        void RemoveAll();
        double GetPurchasesSum();
    }
}
