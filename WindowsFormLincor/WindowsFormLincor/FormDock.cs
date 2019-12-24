using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLog;

namespace WindowsFormLincor
{
    public partial class FormDock : Form
    {
        MultiLevelDock dock;
        FormLincorConfig form;
        private const int countLevel = 5;
        private Logger logger;
        public FormDock()
        {
            InitializeComponent();
            logger = LogManager.GetCurrentClassLogger();
            dock = new MultiLevelDock(countLevel, pictureBoxDock.Width, pictureBoxDock.Height);
            for (int i = 0; i < countLevel; i++)
            {
                listBoxLevels.Items.Add("Уровень " + (i + 1));
            }
            listBoxLevels.SelectedIndex = 0;
        }
        private void Draw()
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(pictureBoxDock.Width, pictureBoxDock.Height);
                Graphics gr = Graphics.FromImage(bmp);
                dock[listBoxLevels.SelectedIndex].Draw(gr);
                pictureBoxDock.Image = bmp;
            }
        }
        private void buttonTakeLincor_Click(object sender, EventArgs e)
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                if (maskedTextBoxPlace.Text != "")
                {
                    try
                    {
                        var lin = dock[listBoxLevels.SelectedIndex] - Convert.ToInt32(maskedTextBoxPlace.Text);
                        Bitmap bmp = new Bitmap(pictureBoxTakeLincor.Width,
                       pictureBoxTakeLincor.Height);
                        Graphics gr = Graphics.FromImage(bmp);
                        lin.SetPosition(5, 5, pictureBoxTakeLincor.Width,
                       pictureBoxTakeLincor.Height);
                        lin.DrawLincor(gr);
                        pictureBoxTakeLincor.Image = bmp;
                        logger.Info("Изъят линкор " + lin.ToString() + " с места " + maskedTextBoxPlace.Text);
                        Draw();
                    }
                    catch (DockNotFoundException ex)
                    {
                        MessageBox.Show(ex.Message, "Не найдено", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                        Bitmap bmp = new Bitmap(pictureBoxTakeLincor.Width,
                       pictureBoxTakeLincor.Height);
                        pictureBoxTakeLincor.Image = bmp;
                        logger.Error("Не найдено");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Неизвестная ошибка",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                        logger.Error("Не изветсно");
                    }
                }
            }
        }
        private void listBoxLevels_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }
        private void buttonSetLincor_Click(object sender, EventArgs e)
        {
            form = new FormLincorConfig();
            form.AddEvent(AddLincor);
            form.Show();
        }
        private void AddLincor(ILincor lin)
        {
            if (lin != null && listBoxLevels.SelectedIndex > -1)
            {
                try
                {
                    int place = dock[listBoxLevels.SelectedIndex] + lin;
                    logger.Info("Добавлен линкор " + lin.ToString() + " на место " + place);
                    Draw();
                }
                catch (DockOverflowException ex)
                {
                    MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                    logger.Error("Переполнение");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Error("Неизвестная ошибка");
                }
            }
        }
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialogLevel.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    dock.SaveData(saveFileDialogLevel.FileName);
                    MessageBox.Show("Сохранение прошло успешно", "Результат",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Сохранено в файл " + saveFileDialogLevel.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Error("Неизвестная ошибка при сохранении");
                }
            }
        }
        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialogLevel.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    dock.LoadData(openFileDialogLevel.FileName);
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK,
    MessageBoxIcon.Information);
                    logger.Info("Загружено из файла " + openFileDialogLevel.FileName);
                }
                catch (DockOccupiedPlaceException ex)
                {
                    MessageBox.Show(ex.Message, "Занятое место", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                    logger.Error("Занятое место");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Error("Неизвестная ошибка при сохранении");
                }
                Draw();
            }
        }
        private void buttonSort_Click(object sender, EventArgs e)
        {
            dock.Sort();
            Draw();
            logger.Info("Сортировка уровней");
        }
    }
}
