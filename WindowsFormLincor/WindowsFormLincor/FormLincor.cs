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
    public partial class FormLincor : Form
    {
        private Lincor lin;
        public FormLincor()
        {
            InitializeComponent();
        }
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxLincor.Width, pictureBoxLincor.Height);
            Graphics gr = Graphics.FromImage(bmp);
            lin.DrawLincor(gr);
            pictureBoxLincor.Image = bmp;
        }
        private void buttonCreateLincor_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            lin = new Lincor(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Black, Color.Gray, LincorCount.TWO);
            lin.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxLincor.Width,
           pictureBoxLincor.Height);
            Draw();
        }
        private void buttonMove_Click(object sender, EventArgs e)
        {
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    lin.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    lin.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    lin.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    lin.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }
    }
}
