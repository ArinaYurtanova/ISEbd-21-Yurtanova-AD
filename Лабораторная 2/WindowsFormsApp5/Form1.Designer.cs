namespace WindowsFormsApp5
{
    partial class Form1
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
            this.buttonSetShip = new System.Windows.Forms.Button();
            this.buttonSetLiner = new System.Windows.Forms.Button();
            this.buttonMove = new System.Windows.Forms.Button();
            this.buttonSetColor = new System.Windows.Forms.Button();
            this.buttonSetDopColor = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMaxSpeed = new System.Windows.Forms.TextBox();
            this.textBoxMaxCountPassenget = new System.Windows.Forms.TextBox();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSetShip
            // 
            this.buttonSetShip.Location = new System.Drawing.Point(605, 41);
            this.buttonSetShip.Name = "buttonSetShip";
            this.buttonSetShip.Size = new System.Drawing.Size(97, 43);
            this.buttonSetShip.TabIndex = 0;
            this.buttonSetShip.Text = "Пассажирский корабль";
            this.buttonSetShip.UseVisualStyleBackColor = true;
            this.buttonSetShip.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonSetLiner
            // 
            this.buttonSetLiner.Location = new System.Drawing.Point(605, 107);
            this.buttonSetLiner.Name = "buttonSetLiner";
            this.buttonSetLiner.Size = new System.Drawing.Size(97, 43);
            this.buttonSetLiner.TabIndex = 1;
            this.buttonSetLiner.Text = "Лайнер";
            this.buttonSetLiner.UseVisualStyleBackColor = true;
            this.buttonSetLiner.Click += new System.EventHandler(this.buttonSetLiner_Click);
            // 
            // buttonMove
            // 
            this.buttonMove.Location = new System.Drawing.Point(605, 174);
            this.buttonMove.Name = "buttonMove";
            this.buttonMove.Size = new System.Drawing.Size(97, 43);
            this.buttonMove.TabIndex = 2;
            this.buttonMove.Text = "Движение";
            this.buttonMove.UseVisualStyleBackColor = true;
            this.buttonMove.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonSetColor
            // 
            this.buttonSetColor.Location = new System.Drawing.Point(504, 311);
            this.buttonSetColor.Name = "buttonSetColor";
            this.buttonSetColor.Size = new System.Drawing.Size(109, 49);
            this.buttonSetColor.TabIndex = 3;
            this.buttonSetColor.Text = "Цвет";
            this.buttonSetColor.UseVisualStyleBackColor = true;
            this.buttonSetColor.Click += new System.EventHandler(this.buttonSetColor_Click);
            // 
            // buttonSetDopColor
            // 
            this.buttonSetDopColor.Location = new System.Drawing.Point(504, 373);
            this.buttonSetDopColor.Name = "buttonSetDopColor";
            this.buttonSetDopColor.Size = new System.Drawing.Size(109, 49);
            this.buttonSetDopColor.TabIndex = 4;
            this.buttonSetDopColor.Text = "Дополнительный цвет";
            this.buttonSetDopColor.UseVisualStyleBackColor = true;
            this.buttonSetDopColor.Click += new System.EventHandler(this.buttonSetDopColor_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(26, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(543, 269);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 326);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Максимальная скрость";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Максимальное количество пассажиров";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 384);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Вес";
            // 
            // textBoxMaxSpeed
            // 
            this.textBoxMaxSpeed.Location = new System.Drawing.Point(261, 319);
            this.textBoxMaxSpeed.Name = "textBoxMaxSpeed";
            this.textBoxMaxSpeed.Size = new System.Drawing.Size(39, 20);
            this.textBoxMaxSpeed.TabIndex = 9;
            // 
            // textBoxMaxCountPassenget
            // 
            this.textBoxMaxCountPassenget.Location = new System.Drawing.Point(262, 347);
            this.textBoxMaxCountPassenget.Name = "textBoxMaxCountPassenget";
            this.textBoxMaxCountPassenget.Size = new System.Drawing.Size(38, 20);
            this.textBoxMaxCountPassenget.TabIndex = 10;
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Location = new System.Drawing.Point(262, 377);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(39, 20);
            this.textBoxWeight.TabIndex = 11;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(339, 320);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(69, 17);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Бассейн";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(339, 343);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(63, 17);
            this.checkBox2.TabIndex = 13;
            this.checkBox2.Text = "Палуба";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(339, 389);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(74, 17);
            this.checkBox4.TabIndex = 19;
            this.checkBox4.Text = "Ресторан";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(339, 389);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(75, 17);
            this.checkBox3.TabIndex = 18;
            this.checkBox3.Text = "Аквапарк";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(339, 366);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(75, 17);
            this.checkBox5.TabIndex = 20;
            this.checkBox5.Text = "Аквапарк";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 435);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBoxWeight);
            this.Controls.Add(this.textBoxMaxCountPassenget);
            this.Controls.Add(this.textBoxMaxSpeed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonSetDopColor);
            this.Controls.Add(this.buttonSetColor);
            this.Controls.Add(this.buttonMove);
            this.Controls.Add(this.buttonSetLiner);
            this.Controls.Add(this.buttonSetShip);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSetShip;
        private System.Windows.Forms.Button buttonSetLiner;
        private System.Windows.Forms.Button buttonMove;
        private System.Windows.Forms.Button buttonSetColor;
        private System.Windows.Forms.Button buttonSetDopColor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxMaxSpeed;
        private System.Windows.Forms.TextBox textBoxMaxCountPassenget;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox5;
    }
}

