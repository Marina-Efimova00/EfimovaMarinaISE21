namespace WindowsFormLincor
{
    partial class FormLincorConfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxTypeLincor = new System.Windows.Forms.GroupBox();
            this.Add = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.panelLincor = new System.Windows.Forms.Panel();
            this.MainColor = new System.Windows.Forms.Label();
            this.DopColor = new System.Windows.Forms.Label();
            this.pictureBoxTakeLincor = new System.Windows.Forms.PictureBox();
            this.labelLincor = new System.Windows.Forms.Label();
            this.labelWarShip = new System.Windows.Forms.Label();
            this.panelColor = new System.Windows.Forms.Panel();
            this.panelRed = new System.Windows.Forms.Panel();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.panelPink = new System.Windows.Forms.Panel();
            this.panelViolet = new System.Windows.Forms.Panel();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.panelDarkGreen = new System.Windows.Forms.Panel();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.panelDarkBlue = new System.Windows.Forms.Panel();
            this.groupBoxTypeLincor.SuspendLayout();
            this.panelLincor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeLincor)).BeginInit();
            this.panelColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTypeLincor
            // 
            this.groupBoxTypeLincor.Controls.Add(this.labelWarShip);
            this.groupBoxTypeLincor.Controls.Add(this.labelLincor);
            this.groupBoxTypeLincor.Location = new System.Drawing.Point(36, 27);
            this.groupBoxTypeLincor.Name = "groupBoxTypeLincor";
            this.groupBoxTypeLincor.Size = new System.Drawing.Size(120, 118);
            this.groupBoxTypeLincor.TabIndex = 0;
            this.groupBoxTypeLincor.TabStop = false;
            this.groupBoxTypeLincor.Text = "Тип линкора";
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(34, 162);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(121, 32);
            this.Add.TabIndex = 1;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(34, 214);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(121, 34);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // panelLincor
            // 
            this.panelLincor.AllowDrop = true;
            this.panelLincor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLincor.Controls.Add(this.pictureBoxTakeLincor);
            this.panelLincor.Controls.Add(this.DopColor);
            this.panelLincor.Controls.Add(this.MainColor);
            this.panelLincor.Location = new System.Drawing.Point(192, 27);
            this.panelLincor.Name = "panelLincor";
            this.panelLincor.Size = new System.Drawing.Size(164, 235);
            this.panelLincor.TabIndex = 2;
            this.panelLincor.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelLincor_DragDrop);
            this.panelLincor.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelLincor_DragEnter);
            // 
            // MainColor
            // 
            this.MainColor.AllowDrop = true;
            this.MainColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainColor.Location = new System.Drawing.Point(17, 144);
            this.MainColor.Name = "MainColor";
            this.MainColor.Size = new System.Drawing.Size(124, 32);
            this.MainColor.TabIndex = 1;
            this.MainColor.Text = "Основной цвет";
            this.MainColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragDrop);
            this.MainColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // DopColor
            // 
            this.DopColor.AllowDrop = true;
            this.DopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DopColor.Location = new System.Drawing.Point(17, 191);
            this.DopColor.Name = "DopColor";
            this.DopColor.Size = new System.Drawing.Size(124, 30);
            this.DopColor.TabIndex = 2;
            this.DopColor.Text = "Доп. цвет";
            this.DopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            this.DopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // pictureBoxTakeLincor
            // 
            this.pictureBoxTakeLincor.Location = new System.Drawing.Point(17, 3);
            this.pictureBoxTakeLincor.Name = "pictureBoxTakeLincor";
            this.pictureBoxTakeLincor.Size = new System.Drawing.Size(134, 117);
            this.pictureBoxTakeLincor.TabIndex = 2;
            this.pictureBoxTakeLincor.TabStop = false;
            // 
            // labelLincor
            // 
            this.labelLincor.AllowDrop = true;
            this.labelLincor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelLincor.Location = new System.Drawing.Point(9, 35);
            this.labelLincor.Name = "labelLincor";
            this.labelLincor.Size = new System.Drawing.Size(100, 22);
            this.labelLincor.TabIndex = 0;
            this.labelLincor.Text = "Линкор";
            this.labelLincor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelLincor_MouseDown);
            // 
            // labelWarShip
            // 
            this.labelWarShip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelWarShip.Location = new System.Drawing.Point(10, 78);
            this.labelWarShip.Name = "labelWarShip";
            this.labelWarShip.Size = new System.Drawing.Size(99, 24);
            this.labelWarShip.TabIndex = 1;
            this.labelWarShip.Text = "Военный корабль";
            this.labelWarShip.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelWarShip_MouseDown);
            // 
            // panelColor
            // 
            this.panelColor.AllowDrop = true;
            this.panelColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColor.Controls.Add(this.panelDarkBlue);
            this.panelColor.Controls.Add(this.panelBlue);
            this.panelColor.Controls.Add(this.panelDarkGreen);
            this.panelColor.Controls.Add(this.panelGreen);
            this.panelColor.Controls.Add(this.panelViolet);
            this.panelColor.Controls.Add(this.panelPink);
            this.panelColor.Controls.Add(this.panelYellow);
            this.panelColor.Controls.Add(this.panelRed);
            this.panelColor.Location = new System.Drawing.Point(378, 33);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(146, 228);
            this.panelColor.TabIndex = 4;
            this.panelColor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelRed
            // 
            this.panelRed.AllowDrop = true;
            this.panelRed.BackColor = System.Drawing.Color.Red;
            this.panelRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRed.Location = new System.Drawing.Point(11, 16);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(47, 34);
            this.panelRed.TabIndex = 0;
            // 
            // panelYellow
            // 
            this.panelYellow.BackColor = System.Drawing.Color.Yellow;
            this.panelYellow.Location = new System.Drawing.Point(82, 17);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(47, 34);
            this.panelYellow.TabIndex = 1;
            // 
            // panelPink
            // 
            this.panelPink.BackColor = System.Drawing.Color.Pink;
            this.panelPink.Location = new System.Drawing.Point(11, 72);
            this.panelPink.Name = "panelPink";
            this.panelPink.Size = new System.Drawing.Size(47, 34);
            this.panelPink.TabIndex = 2;
            // 
            // panelViolet
            // 
            this.panelViolet.BackColor = System.Drawing.Color.Violet;
            this.panelViolet.Location = new System.Drawing.Point(82, 72);
            this.panelViolet.Name = "panelViolet";
            this.panelViolet.Size = new System.Drawing.Size(47, 34);
            this.panelViolet.TabIndex = 3;
            // 
            // panelGreen
            // 
            this.panelGreen.BackColor = System.Drawing.Color.Green;
            this.panelGreen.Location = new System.Drawing.Point(11, 129);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(47, 34);
            this.panelGreen.TabIndex = 4;
            // 
            // panelDarkGreen
            // 
            this.panelDarkGreen.BackColor = System.Drawing.Color.DarkGreen;
            this.panelDarkGreen.Location = new System.Drawing.Point(82, 129);
            this.panelDarkGreen.Name = "panelDarkGreen";
            this.panelDarkGreen.Size = new System.Drawing.Size(47, 34);
            this.panelDarkGreen.TabIndex = 5;
            // 
            // panelBlue
            // 
            this.panelBlue.BackColor = System.Drawing.Color.Blue;
            this.panelBlue.Location = new System.Drawing.Point(11, 180);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(47, 34);
            this.panelBlue.TabIndex = 6;
            // 
            // panelDarkBlue
            // 
            this.panelDarkBlue.BackColor = System.Drawing.Color.DarkBlue;
            this.panelDarkBlue.Location = new System.Drawing.Point(82, 180);
            this.panelDarkBlue.Name = "panelDarkBlue";
            this.panelDarkBlue.Size = new System.Drawing.Size(47, 34);
            this.panelDarkBlue.TabIndex = 7;
            // 
            // FormLincorConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 313);
            this.Controls.Add(this.panelColor);
            this.Controls.Add(this.panelLincor);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.groupBoxTypeLincor);
            this.Name = "FormLincorConfig";
            this.Text = "FormLincorConfig";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            this.groupBoxTypeLincor.ResumeLayout(false);
            this.panelLincor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeLincor)).EndInit();
            this.panelColor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTypeLincor;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Panel panelLincor;
        private System.Windows.Forms.PictureBox pictureBoxTakeLincor;
        private System.Windows.Forms.Label DopColor;
        private System.Windows.Forms.Label MainColor;
        private System.Windows.Forms.Label labelWarShip;
        private System.Windows.Forms.Label labelLincor;
        private System.Windows.Forms.Panel panelColor;
        private System.Windows.Forms.Panel panelDarkBlue;
        private System.Windows.Forms.Panel panelBlue;
        private System.Windows.Forms.Panel panelDarkGreen;
        private System.Windows.Forms.Panel panelGreen;
        private System.Windows.Forms.Panel panelViolet;
        private System.Windows.Forms.Panel panelPink;
        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.Panel panelRed;
    }
}