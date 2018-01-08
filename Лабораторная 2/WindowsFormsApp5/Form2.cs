﻿using NLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form2 : Form
    {
        Port port;
        Form3 form;
        private Logger log;
        public Form2()
        {
            InitializeComponent();
            log = LogManager.GetCurrentClassLogger();
            port = new Port(5);
            for (int i = 1; i < 6; i++)
            {
                listBoxLevels.Items.Add("Уровень " + i);
            }
            listBoxLevels.SelectedIndex = port.getCurrentLevel;

            Draw();
        }

        private void Draw()
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics gr = Graphics.FromImage(bmp);
                port.Draw(gr, pictureBox1.Width, pictureBox1.Height);
                pictureBox1.Image = bmp;
            }
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }



        private void buttonTakeShip_Click(object sender, EventArgs e)
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                string level = listBoxLevels.Items[listBoxLevels.SelectedIndex].ToString();
                if (maskedTextBox1.Text != "")
                {
                    try
                    { 
                    ITransport ship = port.GetShipInPort(Convert.ToInt32(maskedTextBox1.Text));
                    
                        Bitmap bmp = new Bitmap(pictureBoxTakeShip.Width, pictureBoxTakeShip.Height);
                        Graphics gr = Graphics.FromImage(bmp);
                        ship.setPosition(5, 5);
                        ship.drawShip(gr);
                        pictureBoxTakeShip.Image = bmp;
                        log.Info("Забрать корабль" );
                        Draw();
                    }
                    catch (PortIndexOutOfRangeException ex)
                    {
                        MessageBox.Show(ex.Message, " Неверный номер", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, " Общая ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            port.LevelUp();
            listBoxLevels.SelectedIndex = port.getCurrentLevel;
            log.Info("Переход на уровень выше  Текущий уровень:" + port.getCurrentLevel);
            Draw();


        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            port.LevelDown();
            listBoxLevels.SelectedIndex = port.getCurrentLevel;
            log.Info("Переход на уровень ниже Текущий уровень:" + port.getCurrentLevel);
            Draw();

        }

        private void pictureBoxTakeShip_Click(object sender, EventArgs e)
        {

        }

        private void buttonSetShip_Click_1(object sender, EventArgs e)
        {
            form = new Form3();
            form.AddEvent(AddShip);
            form.Show();
            log.Info("Заказать корабль");
        }
        private void AddShip(ITransport ship)
        {
            if (ship != null)
            {
                try
                {
                    int place = port.PutShipInPort(ship);
                    Draw();
                    MessageBox.Show("Ваше место: " + place);
                }
                catch (PortOverflowException ex)
                {
                    MessageBox.Show(ex.Message, " Ошибка переполнения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (PortAlreadyHaveException ex)
                {
                    MessageBox.Show(ex.Message, " Ошибка совпадения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, " Общая ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (port.SaveData(saveFileDialog1.FileName))
                {
                    MessageBox.Show("Сохранение прошло успешно", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    log.Info("Сохранение прошло успешно");
                }
                else
                {
                    MessageBox.Show("Не сохранилось", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (port.LoadData(openFileDialog1.FileName))
                {
                    MessageBox.Show("Загрузили", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    log.Info("Загрузили");
                }
                else
                {
                    MessageBox.Show("Не загрузили", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Draw();
            }

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            port.Sort();
            Draw();
        }
    }
}
