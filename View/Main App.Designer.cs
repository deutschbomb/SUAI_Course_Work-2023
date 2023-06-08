using System.Drawing;
using System.Drawing.Drawing2D;

namespace Курсовой_проект_2023
{
    partial class View
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View));
            this.zhigulevskoyeLogo = new System.Windows.Forms.PictureBox();
            this.germanLogo = new System.Windows.Forms.PictureBox();
            this.rizhskoeLogo = new System.Windows.Forms.PictureBox();
            this.czechLogo = new System.Windows.Forms.PictureBox();
            this.zhigulevskoyeChooser = new System.Windows.Forms.RadioButton();
            this.germanChooser = new System.Windows.Forms.RadioButton();
            this.rizhskoeChooser = new System.Windows.Forms.RadioButton();
            this.czechChooser = new System.Windows.Forms.RadioButton();
            this.beerPanel = new System.Windows.Forms.Panel();
            this.volumeList = new System.Windows.Forms.ListBox();
            this.chipsList = new System.Windows.Forms.ListBox();
            this.fishesList = new System.Windows.Forms.ListBox();
            this.chips_brandChooser = new System.Windows.Forms.ComboBox();
            this.fish_typeChooser = new System.Windows.Forms.ComboBox();
            this.bottle_priceLabel = new System.Windows.Forms.Label();
            this.fish_weightEnter = new System.Windows.Forms.TextBox();
            this.beerAdd = new System.Windows.Forms.Button();
            this.chipsAdd = new System.Windows.Forms.Button();
            this.fishAdd = new System.Windows.Forms.Button();
            this.basketList = new System.Windows.Forms.ListBox();
            this.purchase_amountLabel = new System.Windows.Forms.Label();
            this.bonusPay = new System.Windows.Forms.Button();
            this.walletPay = new System.Windows.Forms.Button();
            this.basketLabel = new System.Windows.Forms.Label();
            this.payment_wayLabel = new System.Windows.Forms.Label();
            this.PurchaseAmount = new System.Windows.Forms.TextBox();
            this.GetCardBalance = new System.Windows.Forms.Button();
            this.beerTip = new System.Windows.Forms.ToolTip(this.components);
            this.basketClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.zhigulevskoyeLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.germanLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rizhskoeLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.czechLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // zhigulevskoyeLogo
            // 
            this.zhigulevskoyeLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.zhigulevskoyeLogo.ImageLocation = ".\\media\\Жигулёвское.jpg";
            this.zhigulevskoyeLogo.Location = new System.Drawing.Point(30, 30);
            this.zhigulevskoyeLogo.Name = "zhigulevskoyeLogo";
            this.zhigulevskoyeLogo.Size = new System.Drawing.Size(150, 150);
            this.zhigulevskoyeLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.zhigulevskoyeLogo.TabIndex = 0;
            this.zhigulevskoyeLogo.TabStop = false;
            this.zhigulevskoyeLogo.MouseEnter += new System.EventHandler(this.zhigulevskoyeLogo_MouseEnter);
            // 
            // germanLogo
            // 
            this.germanLogo.BackColor = System.Drawing.SystemColors.Control;
            this.germanLogo.ImageLocation = ".\\media\\Немецкое.png";
            this.germanLogo.Location = new System.Drawing.Point(220, 30);
            this.germanLogo.Name = "germanLogo";
            this.germanLogo.Size = new System.Drawing.Size(150, 150);
            this.germanLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.germanLogo.TabIndex = 0;
            this.germanLogo.TabStop = false;
            this.germanLogo.MouseEnter += new System.EventHandler(this.germanLogo_MouseEnter);
            // 
            // rizhskoeLogo
            // 
            this.rizhskoeLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.rizhskoeLogo.ImageLocation = ".\\media\\Рижское.jpg";
            this.rizhskoeLogo.Location = new System.Drawing.Point(410, 30);
            this.rizhskoeLogo.Name = "rizhskoeLogo";
            this.rizhskoeLogo.Size = new System.Drawing.Size(150, 150);
            this.rizhskoeLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rizhskoeLogo.TabIndex = 0;
            this.rizhskoeLogo.TabStop = false;
            this.rizhskoeLogo.MouseEnter += new System.EventHandler(this.rizhskoeLogo_MouseEnter);
            // 
            // czechLogo
            // 
            this.czechLogo.BackColor = System.Drawing.SystemColors.Control;
            this.czechLogo.ImageLocation = ".\\media\\Чешское.png";
            this.czechLogo.Location = new System.Drawing.Point(600, 30);
            this.czechLogo.Name = "czechLogo";
            this.czechLogo.Size = new System.Drawing.Size(150, 150);
            this.czechLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.czechLogo.TabIndex = 0;
            this.czechLogo.TabStop = false;
            this.czechLogo.MouseEnter += new System.EventHandler(this.czechLogo_MouseEnter);
            // 
            // zhigulevskoyeChooser
            // 
            this.zhigulevskoyeChooser.AutoSize = true;
            this.zhigulevskoyeChooser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.zhigulevskoyeChooser.Font = new System.Drawing.Font("Verdana", 12F);
            this.zhigulevskoyeChooser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.zhigulevskoyeChooser.Location = new System.Drawing.Point(54, 190);
            this.zhigulevskoyeChooser.Name = "zhigulevskoyeChooser";
            this.zhigulevskoyeChooser.Size = new System.Drawing.Size(103, 22);
            this.zhigulevskoyeChooser.TabIndex = 1;
            this.zhigulevskoyeChooser.TabStop = true;
            this.zhigulevskoyeChooser.Text = "70 р. / л.";
            this.zhigulevskoyeChooser.UseVisualStyleBackColor = false;
            // 
            // germanChooser
            // 
            this.germanChooser.AutoSize = true;
            this.germanChooser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.germanChooser.Font = new System.Drawing.Font("Verdana", 12F);
            this.germanChooser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.germanChooser.Location = new System.Drawing.Point(244, 190);
            this.germanChooser.Name = "germanChooser";
            this.germanChooser.Size = new System.Drawing.Size(113, 22);
            this.germanChooser.TabIndex = 2;
            this.germanChooser.TabStop = true;
            this.germanChooser.Text = "110 р. / л.";
            this.germanChooser.UseVisualStyleBackColor = true;
            // 
            // rizhskoeChooser
            // 
            this.rizhskoeChooser.AutoSize = true;
            this.rizhskoeChooser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.rizhskoeChooser.Font = new System.Drawing.Font("Verdana", 12F);
            this.rizhskoeChooser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.rizhskoeChooser.Location = new System.Drawing.Point(434, 190);
            this.rizhskoeChooser.Name = "rizhskoeChooser";
            this.rizhskoeChooser.Size = new System.Drawing.Size(103, 22);
            this.rizhskoeChooser.TabIndex = 3;
            this.rizhskoeChooser.TabStop = true;
            this.rizhskoeChooser.Text = "80 р. / л.";
            this.rizhskoeChooser.UseVisualStyleBackColor = true;
            // 
            // czechChooser
            // 
            this.czechChooser.AutoSize = true;
            this.czechChooser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.czechChooser.Font = new System.Drawing.Font("Verdana", 12F);
            this.czechChooser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.czechChooser.Location = new System.Drawing.Point(624, 190);
            this.czechChooser.Name = "czechChooser";
            this.czechChooser.Size = new System.Drawing.Size(113, 22);
            this.czechChooser.TabIndex = 4;
            this.czechChooser.TabStop = true;
            this.czechChooser.Text = "100 р. / л.";
            this.czechChooser.UseVisualStyleBackColor = true;
            // 
            // beerPanel
            // 
            this.beerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.beerPanel.Location = new System.Drawing.Point(20, 20);
            this.beerPanel.Name = "beerPanel";
            this.beerPanel.Size = new System.Drawing.Size(740, 200);
            this.beerPanel.TabIndex = 0;
            // 
            // volumeList
            // 
            this.volumeList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.volumeList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.volumeList.Font = new System.Drawing.Font("Verdana", 10F);
            this.volumeList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.volumeList.FormattingEnabled = true;
            this.volumeList.ItemHeight = 16;
            this.volumeList.Items.AddRange(new object[] {
            "0,5 л.",
            "1 л.",
            "1,5 л.",
            "2 л."});
            this.volumeList.Location = new System.Drawing.Point(30, 266);
            this.volumeList.Name = "volumeList";
            this.volumeList.Size = new System.Drawing.Size(150, 64);
            this.volumeList.TabIndex = 5;
            // 
            // chipsList
            // 
            this.chipsList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.chipsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chipsList.Font = new System.Drawing.Font("Verdana", 10F);
            this.chipsList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.chipsList.FormattingEnabled = true;
            this.chipsList.ItemHeight = 16;
            this.chipsList.Location = new System.Drawing.Point(220, 266);
            this.chipsList.Name = "chipsList";
            this.chipsList.Size = new System.Drawing.Size(150, 32);
            this.chipsList.TabIndex = 8;
            // 
            // fishesList
            // 
            this.fishesList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.fishesList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fishesList.Font = new System.Drawing.Font("Verdana", 10F);
            this.fishesList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.fishesList.FormattingEnabled = true;
            this.fishesList.ItemHeight = 16;
            this.fishesList.Items.AddRange(new object[] {
            "Щука - 68р. / 100г",
            "Вобла - 61р. / 100г"});
            this.fishesList.Location = new System.Drawing.Point(410, 266);
            this.fishesList.Name = "fishesList";
            this.fishesList.Size = new System.Drawing.Size(150, 32);
            this.fishesList.TabIndex = 11;
            // 
            // chips_brandChooser
            // 
            this.chips_brandChooser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.chips_brandChooser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chips_brandChooser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chips_brandChooser.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic);
            this.chips_brandChooser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(167)))), ((int)(((byte)(171)))));
            this.chips_brandChooser.FormattingEnabled = true;
            this.chips_brandChooser.Items.AddRange(new object[] {
            "Чипсы:",
            "Lay\'s",
            "Pringles"});
            this.chips_brandChooser.Location = new System.Drawing.Point(220, 240);
            this.chips_brandChooser.Name = "chips_brandChooser";
            this.chips_brandChooser.Size = new System.Drawing.Size(150, 26);
            this.chips_brandChooser.TabIndex = 7;
            this.chips_brandChooser.SelectionChangeCommitted += new System.EventHandler(this.chipsBrand_Chooser_SelectionChangeCommitted);
            this.chips_brandChooser.Enter += new System.EventHandler(this.chips_brandChooser_Enter);
            // 
            // fish_typeChooser
            // 
            this.fish_typeChooser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.fish_typeChooser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fish_typeChooser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fish_typeChooser.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic);
            this.fish_typeChooser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(167)))), ((int)(((byte)(171)))));
            this.fish_typeChooser.FormattingEnabled = true;
            this.fish_typeChooser.Items.AddRange(new object[] {
            "Рыба:",
            "Вяленая (+5р.)",
            "Солёная (+10р.)"});
            this.fish_typeChooser.Location = new System.Drawing.Point(410, 240);
            this.fish_typeChooser.Name = "fish_typeChooser";
            this.fish_typeChooser.Size = new System.Drawing.Size(150, 24);
            this.fish_typeChooser.TabIndex = 10;
            this.fish_typeChooser.Enter += new System.EventHandler(this.fish_typeChooser_Enter);
            // 
            // bottle_priceLabel
            // 
            this.bottle_priceLabel.AutoSize = true;
            this.bottle_priceLabel.Font = new System.Drawing.Font("Verdana", 12F);
            this.bottle_priceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.bottle_priceLabel.Location = new System.Drawing.Point(59, 240);
            this.bottle_priceLabel.Name = "bottle_priceLabel";
            this.bottle_priceLabel.Size = new System.Drawing.Size(93, 18);
            this.bottle_priceLabel.TabIndex = 0;
            this.bottle_priceLabel.Text = "Тара +3р.";
            this.bottle_priceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fish_weightEnter
            // 
            this.fish_weightEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.fish_weightEnter.Font = new System.Drawing.Font("Verdana", 12F);
            this.fish_weightEnter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.fish_weightEnter.Location = new System.Drawing.Point(410, 310);
            this.fish_weightEnter.MaxLength = 3;
            this.fish_weightEnter.Name = "fish_weightEnter";
            this.fish_weightEnter.Size = new System.Drawing.Size(150, 27);
            this.fish_weightEnter.TabIndex = 12;
            this.fish_weightEnter.Text = "100 г";
            this.fish_weightEnter.Enter += new System.EventHandler(this.fish_weightEnter_Enter);
            this.fish_weightEnter.Leave += new System.EventHandler(this.fish_weightEnter_Leave);
            // 
            // beerAdd
            // 
            this.beerAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.beerAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.beerAdd.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.beerAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.beerAdd.Location = new System.Drawing.Point(59, 350);
            this.beerAdd.Name = "beerAdd";
            this.beerAdd.Size = new System.Drawing.Size(93, 40);
            this.beerAdd.TabIndex = 6;
            this.beerAdd.Text = "В корзину";
            this.beerAdd.UseVisualStyleBackColor = true;
            this.beerAdd.Click += new System.EventHandler(this.beerAdd_Click);
            // 
            // chipsAdd
            // 
            this.chipsAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.chipsAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chipsAdd.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chipsAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.chipsAdd.Location = new System.Drawing.Point(249, 350);
            this.chipsAdd.Name = "chipsAdd";
            this.chipsAdd.Size = new System.Drawing.Size(93, 40);
            this.chipsAdd.TabIndex = 9;
            this.chipsAdd.Text = "В корзину";
            this.chipsAdd.UseVisualStyleBackColor = true;
            this.chipsAdd.Click += new System.EventHandler(this.chipsAdd_Click);
            // 
            // fishAdd
            // 
            this.fishAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.fishAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fishAdd.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fishAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.fishAdd.Location = new System.Drawing.Point(438, 350);
            this.fishAdd.Name = "fishAdd";
            this.fishAdd.Size = new System.Drawing.Size(93, 40);
            this.fishAdd.TabIndex = 13;
            this.fishAdd.Text = "В корзину";
            this.fishAdd.UseVisualStyleBackColor = true;
            this.fishAdd.Click += new System.EventHandler(this.fishAdd_Click);
            // 
            // basketList
            // 
            this.basketList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.basketList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.basketList.Font = new System.Drawing.Font("Verdana", 11F);
            this.basketList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.basketList.FormattingEnabled = true;
            this.basketList.ItemHeight = 18;
            this.basketList.Location = new System.Drawing.Point(770, 45);
            this.basketList.Name = "basketList";
            this.basketList.Size = new System.Drawing.Size(300, 288);
            this.basketList.TabIndex = 0;
            this.basketList.TabStop = false;
            this.basketList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.basketList_MouseDoubleClick);
            // 
            // purchase_amountLabel
            // 
            this.purchase_amountLabel.AutoSize = true;
            this.purchase_amountLabel.Font = new System.Drawing.Font("Verdana", 12F);
            this.purchase_amountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.purchase_amountLabel.Location = new System.Drawing.Point(930, 340);
            this.purchase_amountLabel.Name = "purchase_amountLabel";
            this.purchase_amountLabel.Size = new System.Drawing.Size(140, 18);
            this.purchase_amountLabel.TabIndex = 0;
            this.purchase_amountLabel.Text = "Сумма покупки:";
            this.purchase_amountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bonusPay
            // 
            this.bonusPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.bonusPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bonusPay.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bonusPay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.bonusPay.Location = new System.Drawing.Point(1080, 50);
            this.bonusPay.Name = "bonusPay";
            this.bonusPay.Size = new System.Drawing.Size(140, 40);
            this.bonusPay.TabIndex = 14;
            this.bonusPay.Text = "Используя бонусы";
            this.bonusPay.UseVisualStyleBackColor = true;
            this.bonusPay.Click += new System.EventHandler(this.bonusPay_Click);
            // 
            // walletPay
            // 
            this.walletPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.walletPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.walletPay.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.walletPay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.walletPay.Location = new System.Drawing.Point(1080, 105);
            this.walletPay.Name = "walletPay";
            this.walletPay.Size = new System.Drawing.Size(140, 40);
            this.walletPay.TabIndex = 15;
            this.walletPay.Text = "Только деньгами";
            this.walletPay.UseVisualStyleBackColor = true;
            this.walletPay.Click += new System.EventHandler(this.walletPay_Click);
            // 
            // basketLabel
            // 
            this.basketLabel.AutoSize = true;
            this.basketLabel.Font = new System.Drawing.Font("Verdana", 12F);
            this.basketLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.basketLabel.Location = new System.Drawing.Point(770, 20);
            this.basketLabel.Name = "basketLabel";
            this.basketLabel.Size = new System.Drawing.Size(85, 18);
            this.basketLabel.TabIndex = 0;
            this.basketLabel.Text = "Корзина:";
            this.basketLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // payment_wayLabel
            // 
            this.payment_wayLabel.AutoSize = true;
            this.payment_wayLabel.Font = new System.Drawing.Font("Verdana", 12F);
            this.payment_wayLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.payment_wayLabel.Location = new System.Drawing.Point(1080, 20);
            this.payment_wayLabel.Name = "payment_wayLabel";
            this.payment_wayLabel.Size = new System.Drawing.Size(224, 18);
            this.payment_wayLabel.TabIndex = 0;
            this.payment_wayLabel.Text = "Выберите способ оплаты:";
            this.payment_wayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PurchaseAmount
            // 
            this.PurchaseAmount.BackColor = System.Drawing.SystemColors.Control;
            this.PurchaseAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PurchaseAmount.Font = new System.Drawing.Font("Verdana", 12F);
            this.PurchaseAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.PurchaseAmount.Location = new System.Drawing.Point(935, 365);
            this.PurchaseAmount.Name = "PurchaseAmount";
            this.PurchaseAmount.Size = new System.Drawing.Size(219, 20);
            this.PurchaseAmount.TabIndex = 0;
            this.PurchaseAmount.TabStop = false;
            this.PurchaseAmount.Text = "0 р.";
            // 
            // GetCardBalance
            // 
            this.GetCardBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.GetCardBalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GetCardBalance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GetCardBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.GetCardBalance.Location = new System.Drawing.Point(1080, 290);
            this.GetCardBalance.Name = "GetCardBalance";
            this.GetCardBalance.Size = new System.Drawing.Size(140, 40);
            this.GetCardBalance.TabIndex = 16;
            this.GetCardBalance.Text = "Баланс карты";
            this.GetCardBalance.UseVisualStyleBackColor = true;
            this.GetCardBalance.Click += new System.EventHandler(this.GetCardBalance_Click);
            // 
            // basketClear
            // 
            this.basketClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.basketClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.basketClear.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.basketClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.basketClear.Location = new System.Drawing.Point(770, 350);
            this.basketClear.Name = "basketClear";
            this.basketClear.Size = new System.Drawing.Size(150, 40);
            this.basketClear.TabIndex = 17;
            this.basketClear.Text = "Очистить корзину";
            this.basketClear.UseVisualStyleBackColor = true;
            this.basketClear.Click += new System.EventHandler(this.basketClear_Click);
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 410);
            this.Controls.Add(this.basketList);
            this.Controls.Add(this.walletPay);
            this.Controls.Add(this.GetCardBalance);
            this.Controls.Add(this.bonusPay);
            this.Controls.Add(this.basketClear);
            this.Controls.Add(this.fishAdd);
            this.Controls.Add(this.chipsAdd);
            this.Controls.Add(this.beerAdd);
            this.Controls.Add(this.PurchaseAmount);
            this.Controls.Add(this.fish_weightEnter);
            this.Controls.Add(this.zhigulevskoyeLogo);
            this.Controls.Add(this.germanLogo);
            this.Controls.Add(this.rizhskoeLogo);
            this.Controls.Add(this.zhigulevskoyeChooser);
            this.Controls.Add(this.germanChooser);
            this.Controls.Add(this.rizhskoeChooser);
            this.Controls.Add(this.czechLogo);
            this.Controls.Add(this.czechChooser);
            this.Controls.Add(this.basketLabel);
            this.Controls.Add(this.payment_wayLabel);
            this.Controls.Add(this.purchase_amountLabel);
            this.Controls.Add(this.bottle_priceLabel);
            this.Controls.Add(this.volumeList);
            this.Controls.Add(this.chips_brandChooser);
            this.Controls.Add(this.chipsList);
            this.Controls.Add(this.fish_typeChooser);
            this.Controls.Add(this.fishesList);
            this.Controls.Add(this.beerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "View";
            this.Text = "Пивная жаба";
            ((System.ComponentModel.ISupportInitialize)(this.zhigulevskoyeLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.germanLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rizhskoeLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.czechLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel beerPanel;
        private System.Windows.Forms.PictureBox zhigulevskoyeLogo;
        private System.Windows.Forms.PictureBox germanLogo;
        private System.Windows.Forms.PictureBox rizhskoeLogo;
        private System.Windows.Forms.PictureBox czechLogo;
        private System.Windows.Forms.RadioButton zhigulevskoyeChooser;
        private System.Windows.Forms.RadioButton germanChooser;
        private System.Windows.Forms.RadioButton rizhskoeChooser;
        private System.Windows.Forms.RadioButton czechChooser;
        private System.Windows.Forms.ListBox volumeList;
        private System.Windows.Forms.ListBox chipsList;
        private System.Windows.Forms.ListBox fishesList;
        private System.Windows.Forms.ComboBox fish_typeChooser;
        private System.Windows.Forms.ComboBox chips_brandChooser;
        private System.Windows.Forms.Label bottle_priceLabel;
        private System.Windows.Forms.TextBox fish_weightEnter;
        private System.Windows.Forms.Button beerAdd;
        private System.Windows.Forms.Button chipsAdd;
        private System.Windows.Forms.Button fishAdd;
        private System.Windows.Forms.ListBox basketList;
        private System.Windows.Forms.Label purchase_amountLabel;
        private System.Windows.Forms.Button bonusPay;
        private System.Windows.Forms.Button walletPay;
        private System.Windows.Forms.Label basketLabel;
        private System.Windows.Forms.Label payment_wayLabel;
        private System.Windows.Forms.TextBox PurchaseAmount;
        private System.Windows.Forms.Button GetCardBalance;
        private System.Windows.Forms.ToolTip beerTip;
        private System.Windows.Forms.Button basketClear;
    }
}

