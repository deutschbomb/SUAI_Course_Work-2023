using System.Collections.Generic;

namespace Курсовой_проект_2023
{
    /*
     Класс Корзины
     */
    public class Basket
    {
        List<Product> Purchases;    // List покупок
        public double PurchasesSum { get; set; }    // общая стоимость покупок

        //  Метод добавления товара в список покупок
        public void AddProduct(Product product)
        {
            PurchasesSum += product.Price;  // увеличиваем общую стоимость на стоимость товара
            Purchases.Add(product);         // добавляем товар в список 
        }
        //  Метод удаления товара из списка покупок
        public void RemovePurchase(int productIndex)
        {
            PurchasesSum -= Purchases[productIndex].Price;  // уменьшаем общую стоимость на стоимость товара
            Purchases.Remove(Purchases[productIndex]);      // удаляем товар из списка
        }
        //  Метод полного очищения списка покупок
        public void ClearBasket()
        {
            Purchases.Clear();  // очищаем список покупок
            PurchasesSum = 0;   // общая стоимость равна нулю
        }

        //  Конструктор класса
        public Basket()
        {
            Purchases = new List<Product>();    // инициализируем List
        }
    }
}
