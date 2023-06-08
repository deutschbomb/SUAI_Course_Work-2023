using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Курсовой_проект_2023
{
    /*
     Класс Формы авторизации пользователя
     */
    public partial class ClientForm : Form
    {
        Presenter present;  // презентер

        //  Конструктор класса, в который по ссылке передаётся презентер из основной формы
        public ClientForm(ref Presenter present)
        {
            InitializeComponent();
            this.present = present;

            ActiveControl = maskHolder;
        }

        //  Метод, обрабатывающий событие загрузки формы
        private void ClientForm_Load(object sender, EventArgs e)
        {
            card_numberEnter.Text = String.Format(@"{0}", new Random().Next(100, 999)); // устанавливаем номер карты как случайное число
        }
        //  Метод, обрабатывающий событие закрытия формы
        private void clientForm_FormClosed(object sender, EventArgs e)
        {
            Application.Exit(); // завершаем работу всего приложения
        }
        //  Метод, обрабатывающий событие входа в поле ввода имени
        private void nameEnter_Enter(object sender, EventArgs e)
        {
            nameEnter.Text = string.Empty;  // очищаем поле
            nameEnter.Font = new Font(nameEnter.Font, FontStyle.Regular);   // изменияем шрифт
            nameEnter.ForeColor = Color.FromArgb(50, 44, 43);   // изменяем цвет
        }
        //  Метод, обрабатывающий событие входа в поле ввода фамилии
        private void surnameEnter_Enter(object sender, EventArgs e)
        {
            surnameEnter.Text = string.Empty;   // очищаем поле
            surnameEnter.Font = new Font(surnameEnter.Font, FontStyle.Regular); // изменияем шрифт
            surnameEnter.ForeColor = Color.FromArgb(50, 44, 43);    // изменяем цвет
        }
        //  Метод, обрабатывающий событие входа в поле ввода номера телефона
        private void phoneEnter_Enter(object sender, EventArgs e)
        {
            phoneEnter.Text = string.Empty; // очищаем поле
            phoneEnter.Font = new Font(phoneEnter.Font, FontStyle.Regular); // изменияем шрифт
            phoneEnter.ForeColor = Color.FromArgb(50, 44, 43);  // изменяем цвет
        }
        //  Метод, обрабатывающий событие клика по кнопке продолжения
        private void enterButton_Click(object sender, EventArgs e)
        {
            //  Запоминаем введённые значения в переменные
            string Name = nameEnter.Text, Surname = surnameEnter.Text, PhoneNumber;
            int WalletBalance, CardBalance, Age, CardNumber = Convert.ToInt32(card_numberEnter.Text);

            if (nameEnter.ForeColor == Color.FromArgb(139, 167, 171) || surnameEnter.ForeColor == Color.FromArgb(139, 167, 171))
            {   // Если цвет текста в полях ввода имени и фамилии не изменился, значит оно не было введено - ОШИБКА
                surnameEnter.Focus();
                nameEnter.Focus();
                MessageBox.Show("Укажите имя и/или фамилию!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Regex.Match(nameEnter.Text, "^[A-Я][а-я]+$").Success || !Regex.Match(surnameEnter.Text, "^[A-Я][а-я]+$").Success)
            {   // Если указанные имя и фамилия не соответсвуют регулярному выражению, значит они введены неверно - ОШИБКА
                surnameEnter.Focus();
                nameEnter.Focus();
                MessageBox.Show("Неверный ввод имени и/или фамилии!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Если цвет текста в поле ввода номера телефона не изменился, значит оно не было введено - приравниваем его пустой строке
            if (phoneEnter.ForeColor == Color.FromArgb(139, 167, 171)) phoneEnter.Text = string.Empty;
            PhoneNumber = phoneEnter.Text;  // Запоминаем значение в переменную

            //  Вычисляем возраст на основании указанной даты рождения
            Age = DateTime.Today.Year - date_of_birthPicker.Value.Year;
            if (date_of_birthPicker.Value.AddYears(Age) > DateTime.Today) Age--;
            if (Age < 18)
            {   // Если возраст меньше 18 лет - ОШИБКА
                MessageBox.Show("Регистрация несовершеннолетнего пользователя невозможна!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {   //  Если введённые значение денежного баланса и баланса бонусной карты нельзя привести к типу INT (введено не число),
                WalletBalance = Convert.ToInt32(balanceEnter.Text.Substring(0, balanceEnter.Text.Length - 3));
                CardBalance = Convert.ToInt32(card_balanceEnter.Text.Substring(0, card_balanceEnter.Text.Length - 3));
                if (WalletBalance < 0 || CardBalance < 0) throw new Exception();
            }
            catch
            {   //  Значит они указаны неккоректно
                card_balanceEnter.Focus();
                balanceEnter.Focus();
                MessageBox.Show("Неверный ввод баланса кошелька и/или карты!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //  Если всё указано верно, вызываем метод регистрации клиента
            present.Register_Customer(Name, Surname, Age, PhoneNumber, WalletBalance, CardNumber, CardBalance);
            this.Hide();    // Прячем форму авторизации, она больше не понадобится
        }
        //  Метод, обрабатывающий событие выхода из поля ввода денежного баланса
        private void balanceEnter_Leave(object sender, EventArgs e)
        {
            balanceEnter.Text += " р."; // приписываем условное обозначение к введённому значению
        }
        //  Метод, обрабатывающий событие выхода из поля ввода баланса бонусной карты
        private void card_balanceEnter_Leave(object sender, EventArgs e)
        {
            card_balanceEnter.Text += " б.";    // приписываем условное обозначение к введённому значению
        }
        //  Метод, обрабатывающий входа в поле ввода денежного баланса
        private void balanceEnter_Enter(object sender, EventArgs e)
        {
            balanceEnter.Text = string.Empty;   // очищаем имеющееся значение
        }
        //  Метод, обрабатывающий событие входа в поле ввода баланса бонусной карты
        private void card_balanceEnter_Enter(object sender, EventArgs e)
        {
            card_balanceEnter.Text = string.Empty;  // очищаем имеющееся значение
        }
    }
}
