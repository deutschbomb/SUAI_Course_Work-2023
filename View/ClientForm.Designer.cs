
namespace Курсовой_проект_2023
{
    partial class ClientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientForm));
            this.maskHolder = new System.Windows.Forms.PictureBox();
            this.nameEnter = new System.Windows.Forms.TextBox();
            this.surnameEnter = new System.Windows.Forms.TextBox();
            this.phoneEnter = new System.Windows.Forms.MaskedTextBox();
            this.date_of_birthPicker = new System.Windows.Forms.DateTimePicker();
            this.balanceEnter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.card_numberEnter = new System.Windows.Forms.TextBox();
            this.card_balanceEnter = new System.Windows.Forms.TextBox();
            this.enterButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.maskHolder)).BeginInit();
            this.SuspendLayout();
            // 
            // maskHolder
            // 
            this.maskHolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.maskHolder.ImageLocation = ".\\media\\mask.png";
            this.maskHolder.Location = new System.Drawing.Point(20, 20);
            this.maskHolder.Name = "maskHolder";
            this.maskHolder.Size = new System.Drawing.Size(170, 170);
            this.maskHolder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.maskHolder.TabIndex = 0;
            this.maskHolder.TabStop = false;
            // 
            // nameEnter
            // 
            this.nameEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.nameEnter.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameEnter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(167)))), ((int)(((byte)(171)))));
            this.nameEnter.Location = new System.Drawing.Point(210, 40);
            this.nameEnter.Name = "nameEnter";
            this.nameEnter.Size = new System.Drawing.Size(200, 27);
            this.nameEnter.TabIndex = 1;
            this.nameEnter.Text = "Алексей";
            this.nameEnter.Enter += new System.EventHandler(this.nameEnter_Enter);
            // 
            // surnameEnter
            // 
            this.surnameEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.surnameEnter.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surnameEnter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(167)))), ((int)(((byte)(171)))));
            this.surnameEnter.Location = new System.Drawing.Point(430, 40);
            this.surnameEnter.Name = "surnameEnter";
            this.surnameEnter.Size = new System.Drawing.Size(200, 27);
            this.surnameEnter.TabIndex = 2;
            this.surnameEnter.Text = "Левицкий";
            this.surnameEnter.Enter += new System.EventHandler(this.surnameEnter_Enter);
            // 
            // phoneEnter
            // 
            this.phoneEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.phoneEnter.BeepOnError = true;
            this.phoneEnter.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneEnter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(167)))), ((int)(((byte)(171)))));
            this.phoneEnter.Location = new System.Drawing.Point(210, 100);
            this.phoneEnter.Mask = "+7(000)000-00-00";
            this.phoneEnter.Name = "phoneEnter";
            this.phoneEnter.Size = new System.Drawing.Size(200, 27);
            this.phoneEnter.TabIndex = 3;
            this.phoneEnter.Text = "8005553535";
            this.phoneEnter.Enter += new System.EventHandler(this.phoneEnter_Enter);
            // 
            // date_of_birthPicker
            // 
            this.date_of_birthPicker.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_of_birthPicker.Location = new System.Drawing.Point(210, 160);
            this.date_of_birthPicker.MaxDate = new System.DateTime(2023, 5, 29, 0, 0, 0, 0);
            this.date_of_birthPicker.Name = "date_of_birthPicker";
            this.date_of_birthPicker.Size = new System.Drawing.Size(200, 27);
            this.date_of_birthPicker.TabIndex = 4;
            this.date_of_birthPicker.Value = new System.DateTime(2023, 5, 29, 0, 0, 0, 0);
            // 
            // balanceEnter
            // 
            this.balanceEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.balanceEnter.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.balanceEnter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.balanceEnter.Location = new System.Drawing.Point(20, 230);
            this.balanceEnter.MaxLength = 9;
            this.balanceEnter.Name = "balanceEnter";
            this.balanceEnter.Size = new System.Drawing.Size(200, 27);
            this.balanceEnter.TabIndex = 5;
            this.balanceEnter.Text = "0 р.";
            this.balanceEnter.Enter += new System.EventHandler(this.balanceEnter_Enter);
            this.balanceEnter.Leave += new System.EventHandler(this.balanceEnter_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.label1.Location = new System.Drawing.Point(210, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите имя:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.label2.Location = new System.Drawing.Point(430, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Введите фамилию:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.label3.Location = new System.Drawing.Point(210, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(270, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Введите номер телефона (по желанию):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.label4.Location = new System.Drawing.Point(210, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Укажите дату рождения:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.label5.Location = new System.Drawing.Point(20, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Номер карты:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.label6.Location = new System.Drawing.Point(20, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Баланс карты:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.label7.Location = new System.Drawing.Point(20, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Денежный баланс:";
            // 
            // card_numberEnter
            // 
            this.card_numberEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.card_numberEnter.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.card_numberEnter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.card_numberEnter.Location = new System.Drawing.Point(20, 290);
            this.card_numberEnter.Name = "card_numberEnter";
            this.card_numberEnter.ReadOnly = true;
            this.card_numberEnter.Size = new System.Drawing.Size(200, 27);
            this.card_numberEnter.TabIndex = 0;
            this.card_numberEnter.TabStop = false;
            // 
            // card_balanceEnter
            // 
            this.card_balanceEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.card_balanceEnter.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.card_balanceEnter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.card_balanceEnter.Location = new System.Drawing.Point(20, 350);
            this.card_balanceEnter.MaxLength = 9;
            this.card_balanceEnter.Name = "card_balanceEnter";
            this.card_balanceEnter.Size = new System.Drawing.Size(200, 27);
            this.card_balanceEnter.TabIndex = 6;
            this.card_balanceEnter.Text = "0 б.";
            this.card_balanceEnter.Enter += new System.EventHandler(this.card_balanceEnter_Enter);
            this.card_balanceEnter.Leave += new System.EventHandler(this.card_balanceEnter_Leave);
            // 
            // enterButton
            // 
            this.enterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.enterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enterButton.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enterButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.enterButton.Location = new System.Drawing.Point(345, 270);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(180, 70);
            this.enterButton.TabIndex = 7;
            this.enterButton.Text = "ПРОДОЛЖИТЬ";
            this.enterButton.UseVisualStyleBackColor = false;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(650, 400);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.maskHolder);
            this.Controls.Add(this.nameEnter);
            this.Controls.Add(this.surnameEnter);
            this.Controls.Add(this.phoneEnter);
            this.Controls.Add(this.date_of_birthPicker);
            this.Controls.Add(this.balanceEnter);
            this.Controls.Add(this.card_numberEnter);
            this.Controls.Add(this.card_balanceEnter);
            this.Controls.Add(this.enterButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ClientForm";
            this.Text = "Авторизация клиента";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.clientForm_FormClosed);
            this.Load += new System.EventHandler(this.ClientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.maskHolder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox maskHolder;
        private System.Windows.Forms.TextBox nameEnter;
        private System.Windows.Forms.TextBox surnameEnter;
        private System.Windows.Forms.MaskedTextBox phoneEnter;
        private System.Windows.Forms.DateTimePicker date_of_birthPicker;
        private System.Windows.Forms.TextBox balanceEnter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox card_numberEnter;
        private System.Windows.Forms.TextBox card_balanceEnter;
        private System.Windows.Forms.Button enterButton;
    }
}

