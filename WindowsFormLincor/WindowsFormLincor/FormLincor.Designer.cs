namespace WindowsFormLincor
{
    partial class FormLincor
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxLincor = new System.Windows.Forms.PictureBox();
            this.CreateLincor = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLincor)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLincor
            // 
            this.pictureBoxLincor.Location = new System.Drawing.Point(2, 4);
            this.pictureBoxLincor.Name = "pictureBoxLincor";
            this.pictureBoxLincor.Size = new System.Drawing.Size(886, 496);
            this.pictureBoxLincor.TabIndex = 0;
            this.pictureBoxLincor.TabStop = false;
            // 
            // CreateLincor
            // 
            this.CreateLincor.Location = new System.Drawing.Point(25, 19);
            this.CreateLincor.Name = "CreateLincor";
            this.CreateLincor.Size = new System.Drawing.Size(130, 27);
            this.CreateLincor.TabIndex = 1;
            this.CreateLincor.Text = "Создать линкор";
            this.CreateLincor.UseVisualStyleBackColor = true;
            this.CreateLincor.Click += new System.EventHandler(this.buttonCreateLincor_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.BackgroundImage = global::WindowsFormLincor.Properties.Resources.Left;
            this.buttonLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLeft.Location = new System.Drawing.Point(783, 441);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(32, 33);
            this.buttonLeft.TabIndex = 2;
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.BackgroundImage = global::WindowsFormLincor.Properties.Resources.Down;
            this.buttonDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDown.Location = new System.Drawing.Point(812, 441);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(32, 33);
            this.buttonDown.TabIndex = 3;
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.BackgroundImage = global::WindowsFormLincor.Properties.Resources.Right;
            this.buttonRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRight.Location = new System.Drawing.Point(841, 441);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(37, 33);
            this.buttonRight.TabIndex = 4;
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.BackgroundImage = global::WindowsFormLincor.Properties.Resources.Up;
            this.buttonUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonUp.Location = new System.Drawing.Point(812, 414);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(32, 30);
            this.buttonUp.TabIndex = 5;
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // FormLincor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.CreateLincor);
            this.Controls.Add(this.pictureBoxLincor);
            this.Name = "FormLincor";
            this.Text = "FormLincor";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLincor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLincor;
        private System.Windows.Forms.Button CreateLincor;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonUp;
    }
}

