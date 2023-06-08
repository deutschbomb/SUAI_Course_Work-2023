
namespace Курсовой_проект_2023
{
    /*
     Класс Билдера для создания экземпляра Пива
     */
    public class BeerDrafter
    {
        Beer beer;

        public BeerDrafter() { this.beer = new Beer(); }

        public BeerDrafter Brand(string name)
        {
            this.beer.Name = name;
            return this;
        }
        public BeerDrafter Price(double price)
        {
            this.beer.Price = price;
            return this;
        }
        public BeerDrafter Volume(double volume)
        {
            this.beer.Volume = volume;
            return this;
        }
        public BeerDrafter AVB(double degree)
        {
            this.beer.AVB = degree;
            return this;
        }
        public BeerDrafter Light()
        {
            this.beer.Dark = false;
            this.beer.Light = true;
            return this;
        }
        public BeerDrafter Dark()
        {
            this.beer.Dark = true;
            this.beer.Light = false;
            return this;
        }

        public Beer Draft() { return this.beer; }
    }
}
