using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Курсовой_проект_2023
{
    public partial class View : Form, IView
    {
        Presenter present;
        Dictionary<RadioButton, string> Beers;

        public View()
        {
            InitializeComponent();
            present = new Presenter(this);
            present.Notify += DisplayMessage;

            Beers = new Dictionary<RadioButton, string> { { zhigulevskoyeChooser, "Жигулёвское" }, { germanChooser, "Немецкое" },
                { rizhskoeChooser, "Рижское" }, { czechChooser, "Чешское" } };
            GraphicsPath pictureRegion = new GraphicsPath();
            pictureRegion.AddEllipse(new Rectangle(0, 0, 150, 150));
            germanLogo.Region = czechLogo.Region = new Region(pictureRegion);
            chips_brandChooser.SelectedIndex = 0;
            fish_typeChooser.SelectedIndex = 0;

            this.Hide();
            ClientForm client = new ClientForm(ref present);
            client.ShowDialog();
            this.Text += string.Format(": {0} ({1})", present.Get_CustomerFullName(), present.Get_CustomerBalance());
        }
        public void DisplayMessage(string message) { MessageBox.Show(message, "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information); }

        #region Дизайн
        private void chipsBrand_Chooser_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (chips_brandChooser.SelectedItem == "Lay's")
            {
                chipsList.Items.Clear();
                chipsList.Items.AddRange(new object[] {
                    "\"Шашлык\" - 75р.",
                    "\"Краб\" - 75р."});
            }
            if (chips_brandChooser.SelectedItem == "Pringles")
            {
                chipsList.Items.Clear();
                chipsList.Items.AddRange(new object[] {
                    "\"Сырный\" - 90р.",
                    "\"Паприка\" - 90р."});
            }
        }
        private void fish_weightEnter_Leave(object sender, EventArgs e)
        {
            fish_weightEnter.Text += " г";
        }
        private void fish_weightEnter_Enter(object sender, EventArgs e)
        {
            fish_weightEnter.Text = string.Empty;
        }
        private void zhigulevskoyeLogo_MouseEnter(object sender, EventArgs e)
        {
            beerTip.SetToolTip(zhigulevskoyeLogo, "Жигулёвское: Светлое (3.3%)");
        }
        private void germanLogo_MouseEnter(object sender, EventArgs e)
        {
            beerTip.SetToolTip(germanLogo, "Немецкое: Тёмное (8.25%)");
        }
        private void rizhskoeLogo_MouseEnter(object sender, EventArgs e)
        {
            beerTip.SetToolTip(rizhskoeLogo, "Рижское: Светлое (4.7%)");
        }
        private void czechLogo_MouseEnter(object sender, EventArgs e)
        {
            beerTip.SetToolTip(czechLogo, "Чешское: Тёмное (7.5%)");
        }
        private void chips_brandChooser_Enter(object sender, EventArgs e)
        {
            if (chips_brandChooser.Items.Count > 2)
            {
                this.chips_brandChooser.Items.RemoveAt(0);
                this.chips_brandChooser.Font = new System.Drawing.Font("Verdana", 10F);
                this.chips_brandChooser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            }
        }
        private void fish_typeChooser_Enter(object sender, EventArgs e)
        {
            if (fish_typeChooser.Items.Count > 2)
            {
                this.fish_typeChooser.Items.RemoveAt(0);
                this.fish_typeChooser.Font = new System.Drawing.Font("Verdana", 10F);
                this.fish_typeChooser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            }
        }
        #endregion

        #region Управление
        private void GetCardBalance_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format("Баланс вашей бонусной карты: {0}", present.Get_CustomerCardBalance()),
                "1 балл = 1 рубль", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void basketClear_Click(object sender, EventArgs e)
        {
            if (basketList.Items.Count != 0)
            {
                basketList.Items.Clear();
                present.RemoveAll();
                PurchaseAmount.Text = string.Format("{0} р.", present.GetPurchasesSum());
            }
            else MessageBox.Show("Корзина пуста.", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void beerAdd_Click(object sender, EventArgs e)
        {
            Beer Order;
            string brand = "", volume;
            double price = 0, value = 0;

            if (volumeList.SelectedItem != null) volume = volumeList.SelectedItem.ToString();
            else {
                MessageBox.Show("Выберите объём тары.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (var beer in Beers) {
                if (beer.Key.Checked) {
                    brand = beer.Value;
                    value = Convert.ToDouble(volume.Substring(0, volume.IndexOf(' ')));
                    price = Convert.ToDouble(beer.Key.Text.Substring(0, beer.Key.Text.IndexOf(' '))) * value;
                    break;
                }
            }

            switch (brand)
            {
                case "Чешское":
                    Order = new BeerDrafter()
                        .Brand(brand)
                        .Price(price + 3)
                        .Volume(value)
                        .AVB(7.5)
                        .Dark()
                        .Draft();
                    break;
                case "Немецкое":
                    Order = new BeerDrafter()
                        .Brand(brand)
                        .Price(price + 3)
                        .Volume(value)
                        .AVB(8.25)
                        .Dark()
                        .Draft();
                    break;
                case "Рижское":
                    Order = new BeerDrafter()
                        .Brand(brand)
                        .Price(price + 3)
                        .Volume(value)
                        .AVB(4.7)
                        .Light()
                        .Draft();
                    break;
                default:
                    Order = new BeerDrafter()
                        .Brand(brand)
                        .Price(price + 3)
                        .Volume(value)
                        .AVB(3.3)
                        .Light()
                        .Draft();
                    break;
            }
            present.AddProduct(Order);
            basketList_Add(Order.Name, Order.Price, Order.Volume, Order.AVB);
            PurchaseAmount.Text = string.Format("{0} р.", present.GetPurchasesSum());
        }
        private void chipsAdd_Click(object sender, EventArgs e)
        {
            Chips Order;
            string brand = chips_brandChooser.Text, flavour;

            if (chipsList.SelectedItem != null) flavour = chipsList.SelectedItem.ToString();
            else {
                MessageBox.Show("Выберите товар.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (brand == "Lay's") Order = new Lays(flavour.Substring(0, flavour.IndexOf(' ')));
            else Order = new Pringles(flavour.Substring(0, flavour.IndexOf(' ')));

            present.AddProduct(Order);
            basketList_Add(Order.Name, Order.Price, Order.Flavour);
            PurchaseAmount.Text = string.Format("{0} р.", present.GetPurchasesSum());
        }
        private void fishAdd_Click(object sender, EventArgs e)
        {
            Fish Order;
            string type, fish;
            int weight;

            if (fish_typeChooser.Text != string.Empty) type = fish_typeChooser.Text;
            else {
                MessageBox.Show("Выберите тип рыбы.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (fishesList.SelectedItem != null) fish = fishesList.SelectedItem.ToString();
            else {
                MessageBox.Show("Выберите рыбу.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try {
                weight = Convert.ToInt32(fish_weightEnter.Text.Substring(0, fish_weightEnter.Text.IndexOf(' ')));
                if (weight < 0) throw new Exception();
            }
            catch {
                MessageBox.Show("Укажите корректный вес.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (fish.Substring(0, fish.IndexOf(' ')) == "Щука") Order = new Pike(weight);
            else Order = new Roach(weight);
            if (type.Substring(0, type.IndexOf(' ')) == "Вяленая") Order = new Dried(Order);
            else Order = new Salted(Order);

            present.AddProduct(Order);
            basketList_Add(Order.Name, Order.Price, Order.Type, Order.Weight);
            PurchaseAmount.Text = string.Format("{0} р.", present.GetPurchasesSum());
        }
        private void bonusPay_Click(object sender, EventArgs e)
        {
            if (present.PayPurchases_Bonuses()) basketList.Items.Clear();
            this.Text = "Пивная жаба";
            this.Text += string.Format(": {0} ({1})", present.Get_CustomerFullName(), present.Get_CustomerBalance());
            PurchaseAmount.Text = string.Format("{0} р.", present.GetPurchasesSum());
        }
        private void walletPay_Click(object sender, EventArgs e)
        {
            if (present.PayPurchases_Wallet()) basketList.Items.Clear();
            this.Text = "Пивная жаба";
            this.Text += string.Format(": {0} ({1})", present.Get_CustomerFullName(), present.Get_CustomerBalance());
            PurchaseAmount.Text = string.Format("{0} р.", present.GetPurchasesSum());
        }
        private void basketList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (basketList.SelectedIndex >= 0)
            {
                present.RemoveProduct(basketList.SelectedIndex);
                PurchaseAmount.Text = string.Format("{0} р.", present.GetPurchasesSum());
                basketList.Items.RemoveAt(basketList.SelectedIndex);
            }
        }

        #region От интерфейса
        public void basketList_Add(string brand, double price, double volume, double avb)
        {
            basketList.Items.Add(string.Format(
                "{0} {1}% ({2} л.), {3} р.", brand, avb, volume, price));
        }
        public void basketList_Add(string brand, double price, string flavour)
        {
            basketList.Items.Add(string.Format(
                "{0} {1}, {2} р.", brand, flavour, price));
        }
        public void basketList_Add(string brand, double price, string type, double weight)
        {
            basketList.Items.Add(string.Format(
                "{0} {1} ({2} г), {3} р.", type, brand, weight, price));
        }
        #endregion

        #endregion

    }
}
