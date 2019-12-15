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
            this.groupBoxLincor = new System.Windows.Forms.GroupBox();
            this.pictureBoxTakeLincor = new System.Windows.Forms.PictureBox();
            this.PickUp = new System.Windows.Forms.Button();
            this.maskedTextBoxPlace = new System.Windows.Forms.MaskedTextBox();
            this.Place = new System.Windows.Forms.Label();
            this.listBoxLevels = new System.Windows.Forms.ListBox();
            this.buttonSetLincor = new System.Windows.Forms.Button();
            this.menuStripFile = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialogLevel = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialogLevel = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDock)).BeginInit();
            this.groupBoxLincor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeLincor)).BeginInit();
            this.menuStripFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxDock
            // 
            this.pictureBoxDock.Location = new System.Drawing.Point(3, 27);
            this.pictureBoxDock.Name = "pictureBoxDock";
            this.pictureBoxDock.Size = new System.Drawing.Size(783, 450);
            this.pictureBoxDock.TabIndex = 0;
            this.pictureBoxDock.TabStop = false;
            // 
            // groupBoxLincor
            // 
            this.groupBoxLincor.Controls.Add(this.pictureBoxTakeLincor);
            this.groupBoxLincor.Controls.Add(this.PickUp);
            this.groupBoxLincor.Controls.Add(this.maskedTextBoxPlace);
            this.groupBoxLincor.Controls.Add(this.Place);
            this.groupBoxLincor.Location = new System.Drawing.Point(792, 258);
            this.groupBoxLincor.Name = "groupBoxLincor";
            this.groupBoxLincor.Size = new System.Drawing.Size(147, 219);
            this.groupBoxLincor.TabIndex = 3;
            this.groupBoxLincor.TabStop = false;
            this.groupBoxLincor.Text = "Забрать линкор";
            // 
            // pictureBoxTakeLincor
            // 
            this.pictureBoxTakeLincor.Location = new System.Drawing.Point(6, 100);
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
            // listBoxLevels
            // 
            this.listBoxLevels.FormattingEnabled = true;
            this.listBoxLevels.Location = new System.Drawing.Point(809, 12);
            this.listBoxLevels.Name = "listBoxLevels";
            this.listBoxLevels.Size = new System.Drawing.Size(110, 82);
            this.listBoxLevels.TabIndex = 4;
            this.listBoxLevels.Click += new System.EventHandler(this.listBoxLevels_SelectedIndexChanged);
            // 
            // buttonSetLincor
            // 
            this.buttonSetLincor.Location = new System.Drawing.Point(813, 141);
            this.buttonSetLincor.Name = "buttonSetLincor";
            this.buttonSetLincor.Size = new System.Drawing.Size(106, 47);
            this.buttonSetLincor.TabIndex = 5;
            this.buttonSetLincor.Text = "Заказать линкор";
            this.buttonSetLincor.UseVisualStyleBackColor = true;
            this.buttonSetLincor.Click += new System.EventHandler(this.buttonSetLincor_Click);
            // 
            // menuStripFile
            // 
            this.menuStripFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStripFile.Location = new System.Drawing.Point(0, 0);
            this.menuStripFile.Name = "menuStripFile";
            this.menuStripFile.Size = new System.Drawing.Size(951, 24);
            this.menuStripFile.TabIndex = 6;
            this.menuStripFile.Text = "menuStrip";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.загрузитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.загрузитьToolStripMenuItem_Click);
            // 
            // openFileDialogLevel
            // 
            this.openFileDialogLevel.FileName = "openFileDialog";
            // 
            // FormDock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 489);
            this.Controls.Add(this.buttonSetLincor);
            this.Controls.Add(this.listBoxLevels);
            this.Controls.Add(this.groupBoxLincor);
            this.Controls.Add(this.pictureBoxDock);
            this.Controls.Add(this.menuStripFile);
            this.Name = "FormDock";
            this.Text = "FormDock";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDock)).EndInit();
            this.groupBoxLincor.ResumeLayout(false);
            this.groupBoxLincor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeLincor)).EndInit();
            this.menuStripFile.ResumeLayout(false);
            this.menuStripFile.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxDock;
        private System.Windows.Forms.GroupBox groupBoxLincor;
        private System.Windows.Forms.PictureBox pictureBoxTakeLincor;
        private System.Windows.Forms.Button PickUp;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPlace;
        private System.Windows.Forms.Label Place;
        private System.Windows.Forms.ListBox listBoxLevels;
        private System.Windows.Forms.Button buttonSetLincor;
        private System.Windows.Forms.MenuStrip menuStripFile;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialogLevel;
        private System.Windows.Forms.OpenFileDialog openFileDialogLevel;
    }
}