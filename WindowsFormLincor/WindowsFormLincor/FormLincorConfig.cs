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
    public partial class FormLincorConfig : Form
    {
        ILincor lin = null;
        private event linDelegate eventAddLincor;
        public FormLincorConfig()
        {
            InitializeComponent();
            panelYellow.MouseDown += panelColor_MouseDown;
            panelPink.MouseDown += panelColor_MouseDown;
            panelViolet.MouseDown += panelColor_MouseDown;
            panelGreen.MouseDown += panelColor_MouseDown;
            panelRed.MouseDown += panelColor_MouseDown;
            panelDarkGreen.MouseDown += panelColor_MouseDown;
            panelDarkBlue.MouseDown += panelColor_MouseDown;
            panelBlue.MouseDown += panelColor_MouseDown;
            buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
        }
        private void DrawLincor()
        {
            if (lin != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxTakeLincor.Width, pictureBoxTakeLincor.Height);
                Graphics gr = Graphics.FromImage(bmp);
                lin.SetPosition(5, 5, pictureBoxTakeLincor.Width, pictureBoxTakeLincor.Height);
                lin.DrawLincor(gr);
                pictureBoxTakeLincor.Image = bmp;
            }
        }
        public void AddEvent(linDelegate ev)
        {
            if (eventAddLincor == null)
            {
                eventAddLincor = new linDelegate(ev);
            }
            else
            {
                eventAddLincor += ev;
            }
        }
        private void labelLincor_MouseDown(object sender, MouseEventArgs e)
        {
            labelLincor.DoDragDrop(labelLincor.Text, DragDropEffects.Move |
           DragDropEffects.Copy);
        }
        private void labelWarShip_MouseDown(object sender, MouseEventArgs e)
        {
            labelWarShip.DoDragDrop(labelWarShip.Text, DragDropEffects.Move |
           DragDropEffects.Copy);
        }
        private void panelLincor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        private void panelLincor_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Линкор":
                    lin = new Lincor(100, 500, Color.Green, Color.Blue, LincorCount.TWO);
                    break;
                case "Военный корабль":
                    lin = new WarShip(100, 500, Color.Black);
                    break;
                case "DrawToolSquare":
                    if (lin is Lincor)
                    {
                        (lin as Lincor).SetLincorType(0);
                    }
                    break;
                case "DrawToolCircle":
                    if (lin is Lincor)
                    {
                        (lin as Lincor).SetLincorType(1);
                    }
                    break;
                case "DrawToolRectangle":
                    if (lin is Lincor)
                    {
                        (lin as Lincor).SetLincorType(2);
                    }
                    break;
            }
            DrawLincor();
        }
        private void labelBaseColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        private void labelBaseColor_DragDrop(object sender, DragEventArgs e)
        {
            if (lin != null)
            {
                lin.SetMainColor((Color)e.Data.GetData(typeof(Color)));
                DrawLincor();
            }
        }
        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (lin != null)
            {
                if (lin is Lincor)
                {
                    (lin as Lincor).SetDopColor((Color)e.Data.GetData(typeof(Color)));
                    DrawLincor();
                }
            }
        }
        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor,
DragDropEffects.Move | DragDropEffects.Copy);
        }        private void buttonOk_Click(object sender, EventArgs e)
        {
            eventAddLincor?.Invoke(lin);
            Close();
        }
        private void labelDrawToolSquare_MouseDown(object sender, MouseEventArgs e)
        {
            labelWarShip.DoDragDrop(labelDrawToolSquare.Text,
                DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void labelDrawToolCircle_MouseDown(object sender, MouseEventArgs e)
        {
            labelWarShip.DoDragDrop(labelDrawToolCircle.Text,
                DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void labelDrawToolRectangle_MouseDown(object sender, MouseEventArgs e)
        {
            labelWarShip.DoDragDrop(labelDrawToolRectangle.Text,
                DragDropEffects.Move | DragDropEffects.Copy);
        }
    }
}
