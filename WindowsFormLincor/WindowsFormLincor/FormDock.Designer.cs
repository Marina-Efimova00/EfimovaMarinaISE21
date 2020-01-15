namespace WindowsFormLincor
{
    partial class FormDock
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
            this.pictureBoxDock = new System.Windows.Forms.PictureBox();
            this.ParkLincor = new System.Windows.Forms.Button();
            this.ParkWarShip = new System.Windows.Forms.Button();
            this.groupBoxLincor = new System.Windows.Forms.GroupBox();
            this.pictureBoxTakeLincor = new System.Windows.Forms.PictureBox();
            this.PickUp = new System.Windows.Forms.Button();
            this.maskedTextBoxPlace = new System.Windows.Forms.MaskedTextBox();
            this.Place = new System.Windows.Forms.Label();
            this.labelPlace = new System.Windows.Forms.Label();
            this.buttonCompare = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDock)).BeginInit();
            this.groupBoxLincor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeLincor)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxDock
            // 
            this.pictureBoxDock.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxDock.Name = "pictureBoxDock";
            this.pictureBoxDock.Size = new System.Drawing.Size(746, 494);
            this.pictureBoxDock.TabIndex = 0;
            this.pictureBoxDock.TabStop = false;
            // 
            // ParkLincor
            // 
            this.ParkLincor.Location = new System.Drawing.Point(771, 17);
            this.ParkLincor.Name = "ParkLincor";
            this.ParkLincor.Size = new System.Drawing.Size(111, 47);
            this.ParkLincor.TabIndex = 1;
            this.ParkLincor.Text = "Припарковать линкор";
            this.ParkLincor.UseVisualStyleBackColor = true;
            this.ParkLincor.Click += new System.EventHandler(this.buttonSetLincor_Click);
            // 
            // ParkWarShip
            // 
            this.ParkWarShip.Location = new System.Drawing.Point(771, 81);
            this.ParkWarShip.Name = "ParkWarShip";
            this.ParkWarShip.Size = new System.Drawing.Size(111, 48);
            this.ParkWarShip.TabIndex = 2;
            this.ParkWarShip.Text = "Припарковать военный корабль";
            this.ParkWarShip.UseVisualStyleBackColor = true;
            this.ParkWarShip.Click += new System.EventHandler(this.buttonSetWarShip_Click);
            // 
            // groupBoxLincor
            // 
            this.groupBoxLincor.Controls.Add(this.pictureBoxTakeLincor);
            this.groupBoxLincor.Controls.Add(this.PickUp);
            this.groupBoxLincor.Controls.Add(this.maskedTextBoxPlace);
            this.groupBoxLincor.Controls.Add(this.Place);
            this.groupBoxLincor.Location = new System.Drawing.Point(755, 220);
            this.groupBoxLincor.Name = "groupBoxLincor";
            this.groupBoxLincor.Size = new System.Drawing.Size(147, 268);
            this.groupBoxLincor.TabIndex = 3;
            this.groupBoxLincor.TabStop = false;
            this.groupBoxLincor.Text = "Забрать линкор";
            // 
            // pictureBoxTakeLincor
            // 
            this.pictureBoxTakeLincor.Location = new System.Drawing.Point(3, 143);
            this.pictureBoxTakeLincor.Name = "pictureBoxTakeLincor";
            this.pictureBoxTakeLincor.Size = new System.Drawing.Size(137, 111);
            this.pictureBoxTakeLincor.TabIndex = 3;
            this.pictureBoxTakeLincor.TabStop = false;
            // 
            // PickUp
            // 
            this.PickUp.Location = new System.Drawing.Point(6, 70);
            this.PickUp.Name = "PickUp";
            this.PickUp.Size = new System.Drawing.Size(121, 24);
            this.PickUp.TabIndex = 2;
            this.PickUp.Text = "Забрать";
            this.PickUp.UseVisualStyleBackColor = true;
            this.PickUp.Click += new System.EventHandler(this.buttonTakeLincor_Click);
            // 
            // maskedTextBoxPlace
            // 
            this.maskedTextBoxPlace.Location = new System.Drawing.Point(77, 31);
            this.maskedTextBoxPlace.Name = "maskedTextBoxPlace";
            this.maskedTextBoxPlace.Size = new System.Drawing.Size(30, 20);
            this.maskedTextBoxPlace.TabIndex = 1;
            // 
            // Place
            // 
            this.Place.AutoSize = true;
            this.Place.Location = new System.Drawing.Point(32, 38);
            this.Place.Name = "Place";
            this.Place.Size = new System.Drawing.Size(39, 13);
            this.Place.TabIndex = 0;
            this.Place.Text = "Место";
            // 
            // labelPlace
            // 
            this.labelPlace.Location = new System.Drawing.Point(755, 192);
            this.labelPlace.Name = "labelPlace";
            this.labelPlace.Size = new System.Drawing.Size(147, 25);
            this.labelPlace.TabIndex = 4;
            // 
            // buttonCompare
            // 
            this.buttonCompare.Location = new System.Drawing.Point(771, 145);
            this.buttonCompare.Name = "buttonCompare";
            this.buttonCompare.Size = new System.Drawing.Size(110, 36);
            this.buttonCompare.TabIndex = 5;
            this.buttonCompare.Text = "Проверить места";
            this.buttonCompare.UseVisualStyleBackColor = true;
            this.buttonCompare.Click += new System.EventHandler(this.buttonCompare_Click);
            // 
            // FormDock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 489);
            this.Controls.Add(this.buttonCompare);
            this.Controls.Add(this.labelPlace);
            this.Controls.Add(this.groupBoxLincor);
            this.Controls.Add(this.ParkWarShip);
            this.Controls.Add(this.ParkLincor);
            this.Controls.Add(this.pictureBoxDock);
            this.Name = "FormDock";
            this.Text = "FormDock";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDock)).EndInit();
            this.groupBoxLincor.ResumeLayout(false);
            this.groupBoxLincor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeLincor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxDock;
        private System.Windows.Forms.Button ParkLincor;
        private System.Windows.Forms.Button ParkWarShip;
        private System.Windows.Forms.GroupBox groupBoxLincor;
        private System.Windows.Forms.PictureBox pictureBoxTakeLincor;
        private System.Windows.Forms.Button PickUp;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPlace;
        private System.Windows.Forms.Label Place;
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.Button buttonCompare;
    }
}