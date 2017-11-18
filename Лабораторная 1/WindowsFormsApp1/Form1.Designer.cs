namespace WindowsFormsApp1
{
    partial class FormKitchen
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDownSpice = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSugar = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownOrangeJuice = new System.Windows.Forms.NumericUpDown();
            this.countWine = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AddSpice = new System.Windows.Forms.Button();
            this.AddSugar = new System.Windows.Forms.Button();
            this.AddOrangeJuice = new System.Windows.Forms.Button();
            this.AddWine = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.GetPan = new System.Windows.Forms.Button();
            this.checkBoxOn = new System.Windows.Forms.CheckBox();
            this.Cook = new System.Windows.Forms.Button();
            this.AddPan = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.recipe = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSugar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOrangeJuice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countWine)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.recipe);
            this.groupBox1.Controls.Add(this.numericUpDownSpice);
            this.groupBox1.Controls.Add(this.numericUpDownSugar);
            this.groupBox1.Controls.Add(this.numericUpDownOrangeJuice);
            this.groupBox1.Controls.Add(this.countWine);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 270);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ингредиенты";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // numericUpDownSpice
            // 
            this.numericUpDownSpice.Location = new System.Drawing.Point(124, 92);
            this.numericUpDownSpice.Name = "numericUpDownSpice";
            this.numericUpDownSpice.Size = new System.Drawing.Size(38, 20);
            this.numericUpDownSpice.TabIndex = 7;
            // 
            // numericUpDownSugar
            // 
            this.numericUpDownSugar.Location = new System.Drawing.Point(124, 66);
            this.numericUpDownSugar.Name = "numericUpDownSugar";
            this.numericUpDownSugar.Size = new System.Drawing.Size(38, 20);
            this.numericUpDownSugar.TabIndex = 6;
            // 
            // numericUpDownOrangeJuice
            // 
            this.numericUpDownOrangeJuice.Location = new System.Drawing.Point(124, 40);
            this.numericUpDownOrangeJuice.Name = "numericUpDownOrangeJuice";
            this.numericUpDownOrangeJuice.Size = new System.Drawing.Size(38, 20);
            this.numericUpDownOrangeJuice.TabIndex = 5;
            // 
            // countWine
            // 
            this.countWine.Location = new System.Drawing.Point(124, 19);
            this.countWine.Name = "countWine";
            this.countWine.Size = new System.Drawing.Size(38, 20);
            this.countWine.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Специи";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Сахар";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Апельсиновый сок";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вино";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AddSpice);
            this.groupBox2.Controls.Add(this.AddSugar);
            this.groupBox2.Controls.Add(this.AddOrangeJuice);
            this.groupBox2.Controls.Add(this.AddWine);
            this.groupBox2.Location = new System.Drawing.Point(230, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(182, 265);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Кастрюля";
            // 
            // AddSpice
            // 
            this.AddSpice.Location = new System.Drawing.Point(40, 209);
            this.AddSpice.Name = "AddSpice";
            this.AddSpice.Size = new System.Drawing.Size(109, 40);
            this.AddSpice.TabIndex = 3;
            this.AddSpice.Text = "Добавить специи";
            this.AddSpice.UseVisualStyleBackColor = true;
            this.AddSpice.Click += new System.EventHandler(this.AddSpice_Click_1);
            // 
            // AddSugar
            // 
            this.AddSugar.Location = new System.Drawing.Point(39, 152);
            this.AddSugar.Name = "AddSugar";
            this.AddSugar.Size = new System.Drawing.Size(109, 40);
            this.AddSugar.TabIndex = 2;
            this.AddSugar.Text = "Добавить сахар";
            this.AddSugar.UseVisualStyleBackColor = true;
            this.AddSugar.Click += new System.EventHandler(this.button3_Click);
            // 
            // AddOrangeJuice
            // 
            this.AddOrangeJuice.Location = new System.Drawing.Point(39, 95);
            this.AddOrangeJuice.Name = "AddOrangeJuice";
            this.AddOrangeJuice.Size = new System.Drawing.Size(109, 40);
            this.AddOrangeJuice.TabIndex = 1;
            this.AddOrangeJuice.Text = "Налить сок";
            this.AddOrangeJuice.UseVisualStyleBackColor = true;
            this.AddOrangeJuice.Click += new System.EventHandler(this.AddOrangeJuice_Click_1);
            // 
            // AddWine
            // 
            this.AddWine.Location = new System.Drawing.Point(39, 35);
            this.AddWine.Name = "AddWine";
            this.AddWine.Size = new System.Drawing.Size(110, 44);
            this.AddWine.TabIndex = 0;
            this.AddWine.Text = "Налить вино";
            this.AddWine.UseVisualStyleBackColor = true;
            this.AddWine.Click += new System.EventHandler(this.AddWine_Click_1);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.GetPan);
            this.groupBox3.Controls.Add(this.checkBoxOn);
            this.groupBox3.Controls.Add(this.Cook);
            this.groupBox3.Controls.Add(this.AddPan);
            this.groupBox3.Location = new System.Drawing.Point(451, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(158, 256);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Плита";
            // 
            // GetPan
            // 
            this.GetPan.Location = new System.Drawing.Point(32, 162);
            this.GetPan.Name = "GetPan";
            this.GetPan.Size = new System.Drawing.Size(107, 42);
            this.GetPan.TabIndex = 3;
            this.GetPan.Text = "Убрать кастрюлю";
            this.GetPan.UseVisualStyleBackColor = true;
            this.GetPan.Click += new System.EventHandler(this.GetPan_Click);
            // 
            // checkBoxOn
            // 
            this.checkBoxOn.AutoSize = true;
            this.checkBoxOn.Location = new System.Drawing.Point(49, 19);
            this.checkBoxOn.Name = "checkBoxOn";
            this.checkBoxOn.Size = new System.Drawing.Size(75, 17);
            this.checkBoxOn.TabIndex = 2;
            this.checkBoxOn.Text = "Включить";
            this.checkBoxOn.UseVisualStyleBackColor = true;
            this.checkBoxOn.CheckedChanged += new System.EventHandler(this.checkBoxOn_CheckedChanged_1);
            // 
            // Cook
            // 
            this.Cook.Location = new System.Drawing.Point(31, 104);
            this.Cook.Name = "Cook";
            this.Cook.Size = new System.Drawing.Size(108, 40);
            this.Cook.TabIndex = 1;
            this.Cook.Text = "Готовить";
            this.Cook.UseVisualStyleBackColor = true;
            this.Cook.Click += new System.EventHandler(this.Cook_Click);
            // 
            // AddPan
            // 
            this.AddPan.Location = new System.Drawing.Point(31, 44);
            this.AddPan.Name = "AddPan";
            this.AddPan.Size = new System.Drawing.Size(109, 43);
            this.AddPan.TabIndex = 0;
            this.AddPan.Text = "Поставить кастрюлю";
            this.AddPan.UseVisualStyleBackColor = true;
            this.AddPan.Click += new System.EventHandler(this.AddPan_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(357, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "Разлить в бокалы";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(83, 298);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(218, 33);
            this.button2.TabIndex = 4;
            this.button2.Text = "Дать глинтвейну настояться";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // recipe
            // 
            this.recipe.Location = new System.Drawing.Point(34, 167);
            this.recipe.Name = "recipe";
            this.recipe.Size = new System.Drawing.Size(108, 42);
            this.recipe.TabIndex = 8;
            this.recipe.Text = "Посмотреть рецепт";
            this.recipe.UseVisualStyleBackColor = true;
            this.recipe.Click += new System.EventHandler(this.recipe_Click);
            // 
            // FormKitchen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 343);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormKitchen";
            this.Text = "Кухня";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSugar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOrangeJuice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countWine)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button AddSugar;
        private System.Windows.Forms.Button AddOrangeJuice;
        private System.Windows.Forms.Button AddWine;
        private System.Windows.Forms.NumericUpDown numericUpDownSpice;
        private System.Windows.Forms.NumericUpDown numericUpDownSugar;
        private System.Windows.Forms.NumericUpDown numericUpDownOrangeJuice;
        private System.Windows.Forms.NumericUpDown countWine;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddSpice;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button GetPan;
        private System.Windows.Forms.CheckBox checkBoxOn;
        private System.Windows.Forms.Button Cook;
        private System.Windows.Forms.Button AddPan;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button recipe;
    }
}

