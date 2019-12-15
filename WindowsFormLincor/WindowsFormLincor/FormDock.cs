using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormLincor
{
    public partial class FormDock : Form
    {
        MultiLevelDock dock;
        FormLincorConfig form;
        private const int countLevel = 5;
        public FormDock()
        {
            InitializeComponent();
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
                    var lin = dock[listBoxLevels.SelectedIndex] - Convert.ToInt32(maskedTextBoxPlace.Text);
                    if (lin != null)
                    {
                        Bitmap bmp = new Bitmap(pictureBoxTakeLincor.Width,
                       pictureBoxTakeLincor.Height);
                        Graphics gr = Graphics.FromImage(bmp);
                        lin.SetPosition(5, 5, pictureBoxTakeLincor.Width,
                       pictureBoxTakeLincor.Height);
                        lin.DrawLincor(gr);
                        pictureBoxTakeLincor.Image = bmp;
                    }
                    else
                    {
                        Bitmap bmp = new Bitmap(pictureBoxTakeLincor.Width, pictureBoxTakeLincor.Height);
                        pictureBoxTakeLincor.Image = bmp;
                    }
                    Draw();
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
                int place = dock[listBoxLevels.SelectedIndex] + lin;
                if (place > -1)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Линкор не удалось поставить");
                }
            }
        }
    }
}
