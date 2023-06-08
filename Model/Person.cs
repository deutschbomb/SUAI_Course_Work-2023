
namespace Курсовой_проект_2023
{
    /*
     Абстрактный класс Человека
     */
    public abstract class Person
    {
        public string Name { get; set; }    // имя
        public string Surname { get; set; }     // фамилия
        public string PhoneNumber { get; set; }     // номер телефона
        public int Age { get; set; }    // возраст

        //  Конструктор класса по умолчанию
        public Person() { }

        /// <summary>
        /// Конструктор класса для создания экземпляра без номера телефона
        /// </summary>
        /// <param name="Name"> Имя </param>
        /// <param name="Surname"> Фамилия </param>
        /// <param name="Age"> Возраст </param>
        public Person(string Name, string Surname, int Age)
        {
            this.Name = Name; this.Surname = Surname; this.Age = Age;
        }
        /// <summary>
        /// Конструктор класса для создания экземпляра с номером телефона
        /// </summary>
        /// <param name="Name"> Имя </param>
        /// <param name="Surname"> Фамилия </param>
        /// <param name="Age"> Возраст </param>
        /// <param name="PhoneNumber"> Номер телефона </param>
        public Person(string Name, string Surname, int Age, string PhoneNumber)
        {
            this.Name = Name; this.Surname = Surname; this.Age = Age; this.PhoneNumber = PhoneNumber;
        }
    }
}
