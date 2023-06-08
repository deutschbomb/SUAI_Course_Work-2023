
namespace Курсовой_проект_2023
{
    /*
     Класс Пива - наследник Продукта/Товара
     */
    public class Beer : Product
    {
        public bool IsAlcohol { get; } = true;  // содержание алкоголя
        public double Volume { get; set; }      // объём
        public double AVB { get; set; }         // процент содержания алкоголя
        public bool Light { get; set; } = false;    // светлое
        public bool Dark { get; set; } = false;     // тёмное

        //  Конструктор класса
        public Beer() { }
    }
}
