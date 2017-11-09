using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormKitchen : Form
    {
        private Wine[] wine;
        private Sugar sugar;
        private OrangeJuice[] orangeJuice;
        private Spice spice;
        private Pan pan;
        private Stove stove;

        public FormKitchen()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pan = new Pan();

            stove = new Stove();
            AddWine.Enabled = true;
            AddPan.Enabled = true;
            AddOrangeJuice.Enabled = false;
            AddSugar.Enabled = false;
            AddSpice.Enabled = false;
            button2.Enabled = false;
            Cook.Enabled = false;
            GetPan.Enabled = false;

        }

        
        
        private void AddPan_Click(object sender, EventArgs e)

        {
            AddPan.Enabled = true;
            stove.Pan = pan;

            Cook.Enabled = true;

            MessageBox.Show("Кастрюлька на плите", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void checkBoxOn_CheckedChanged(object sender, EventArgs e)

        {

            stove.State = checkBoxOn.Checked;

        }
        private void buttonCook_Click(object sender, EventArgs e)

        {

            if (!pan.ReadyToGo)

            {

                MessageBox.Show("У нас не все готово к приготовлению", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;

            }

            if (!stove.State)

            {

                MessageBox.Show("Варить собрались энергией космоса или все же включим плиту?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;

            }

            stove.Cook();

            if (stove.Pan.IsReady())

            {

                GetPan.Enabled = true;

                checkBoxOn.Checked = false;

                MessageBox.Show("Готово", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            else

            {

                MessageBox.Show("Что-то пошло не так", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;

            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            sugar = new Sugar();
            sugar.Count = Convert.ToInt32(numericUpDownSugar.Value);
            if (sugar.Count > 4)
            {
                pan.AddSugar(sugar);
                MessageBox.Show("Вы готовите сироп? будет слишком сладко ", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            if (sugar.Count > 0 && sugar.Count < 5)
            {
                pan.AddSugar(sugar);
                MessageBox.Show("Сахар добавили ", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AddSpice.Enabled = true;
            }
            if (sugar.Count==0)
            {
                MessageBox.Show("Сахара  нет", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void AddWine_Click_1(object sender, EventArgs e)
        {
            wine = new Wine[Convert.ToInt32(countWine.Value)];

            pan.Init(Convert.ToInt32(countWine.Value));

            if (wine == null)
            {
                MessageBox.Show("Без вина глинтвейн не получится", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (wine.Length == 0)
            {
                MessageBox.Show("Без вина глинтвейн не получится", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (wine.Length > 2)
            {
                MessageBox.Show("Кастрюля не резиновая, глинтвейн выльется ", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (countWine.Value > 0)

            {
                
                for (int i = 0; i < wine.Length; ++i)

                {

                    wine[i] = new Wine();

                }


                for (int i = 0; i < wine.Length; ++i)
                {

                    pan.AddWine(wine[i]);
                }
                MessageBox.Show("Вино добавили", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                AddOrangeJuice.Enabled = true;
            }

        }
        private void AddOrangeJuice_Click_1(object sender, EventArgs e)
        {
            orangeJuice = new OrangeJuice[Convert.ToInt32(numericUpDownOrangeJuice.Value)];
            pan.Init1(Convert.ToInt32(numericUpDownOrangeJuice.Value));
            if (orangeJuice == null)
            {
                MessageBox.Show("Без сока глинтвейн не получится", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (orangeJuice.Length == 0)
            {
                MessageBox.Show("Без сока глинтвейн не получится", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (orangeJuice.Length >2)
            {
                MessageBox.Show("Кастрюля не резиновая, глинтвейн выльется ", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            for (int i = 0; i < orangeJuice.Length; ++i)

            {

                orangeJuice[i] = new OrangeJuice();

            }


            for (int i = 0; i < orangeJuice.Length; ++i)
            {

                pan.AddOrangeJuice(orangeJuice[i]);
            }
            MessageBox.Show("Сок добавили", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
            AddSugar.Enabled = true;

        }

        private void AddSpice_Click_1(object sender, EventArgs e)
        {
            spice = new Spice();
            spice.Count = Convert.ToInt32(numericUpDownSpice.Value);
            if (spice.Count > 0)
            {
                pan.AddSpice(spice);
                MessageBox.Show("Специи добавили ", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Специй нет", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
        private void AddPan_Click_1(object sender, EventArgs e)
        {
            if (!pan.ReadyToGo)

            {

                MessageBox.Show("У нас не все готово к приготовлению", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;

            }
            else
            {

                stove.Pan = pan;

                Cook.Enabled = true;

                MessageBox.Show("Кастрюлька на плите", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void checkBoxOn_CheckedChanged_1(object sender, EventArgs e)
        {
            stove.State = checkBoxOn.Checked;
            

        }

       

        private void Cook_Click(object sender, EventArgs e)
        {
           /* if (!pan.ReadyToGo)

            {

                MessageBox.Show("У нас не все готово к приготовлению", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;

            }*/



            if (!stove.State)

                {

                    MessageBox.Show("Плиту необходимо включить перед тем, как начинаете готовить ", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;

                }

                stove.Cook();

                if (stove.Pan.IsReady())

                {

                    GetPan.Enabled = true;

                    checkBoxOn.Checked = false;

                    MessageBox.Show("Готово", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                else

                {

                    MessageBox.Show("Что-то пошло не так", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;

                }
            
            

        }

        private void GetPan_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Дайте глинтвейну настояться, затем подавайте ", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
            button2.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (GetPan.Enabled == true)

            {
                MessageBox.Show(" Наслаждайтесь напитком ", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Приготовьте напиток", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Можно разливать ", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void recipe_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Вылить в кастрюлю вино,добавить апельсиновый сок, сахар и специи(корица,гвоздика,ванилин) по вкусу.Дать настояться 10-15 минут.Пить горячим ", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
