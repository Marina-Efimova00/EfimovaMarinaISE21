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
        Dock<ILincor, ILincor> dock;
        public FormDock()
        {
            InitializeComponent();
            dock = new Dock<ILincor, ILincor>(20, pictureBoxDock.Width, pictureBoxDock.Height);
            Draw();
        }
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxDock.Width, pictureBoxDock.Height);
            Graphics gr = Graphics.FromImage(bmp);
            dock.Draw(gr);
            pictureBoxDock.Image = bmp;
        }
        private void buttonSetLincor_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var lin = new Lincor(100, 1000, dialog.Color, Color.Gray,LincorCount.TWO);
                int place = dock + lin;
                Draw();
            }
        }
        private void buttonSetWarShip_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var lin = new WarShip(100, 1000, dialog.Color, LincorCount.TWO);
                    int place = dock + lin;
                    Draw();
                }
            }
        }
        private void buttonTakeLincor_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxPlace.Text != "")
            {
                var lin = dock - Convert.ToInt32(maskedTextBoxPlace.Text);
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
        private void buttonCompare_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxPlace.Text != "")
            {
                if (dock < Convert.ToInt32(maskedTextBoxPlace.Text))
                {
                    if (dock > Convert.ToInt32(maskedTextBoxPlace.Text))
                    {
                        labelPlace.Text = "Свободных мест равно " + maskedTextBoxPlace.Text;
                    }
                    else
                    {
                        labelPlace.Text = "Свободных мест меньше " + maskedTextBoxPlace.Text;
                    }
                }
                else
                {
                    labelPlace.Text = "Свободных мест больше " + maskedTextBoxPlace.Text;
                }
            }
        }
    }
}
