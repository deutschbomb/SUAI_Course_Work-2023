
namespace Курсовой_проект_2023
{
    /*
     Интерфейс Представления
     */
    public interface IView
    {
        void DisplayMessage(string message);
        void basketList_Add(string brand, double price, string flavour);
        void basketList_Add(string brand, double price, double volume, double avb);
        void basketList_Add(string brand, double price, string type, double weight);
    }
}
