namespace Tamagochi
{
    partial class Form1
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
            this.lblEatCur = new System.Windows.Forms.Label();
            this.lblEatMax = new System.Windows.Forms.Label();
            this.lblSleepMax = new System.Windows.Forms.Label();
            this.lblSleepCur = new System.Windows.Forms.Label();
            this.lblHappyMax = new System.Windows.Forms.Label();
            this.lblHappyCur = new System.Windows.Forms.Label();
            this.lblClearMax = new System.Windows.Forms.Label();
            this.lblClearCur = new System.Windows.Forms.Label();
            this.lblHPMax = new System.Windows.Forms.Label();
            this.lblHPCur = new System.Windows.Forms.Label();
            this.lblGameOver = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnHappy = new System.Windows.Forms.Button();
            this.btnSleep = new System.Windows.Forms.Button();
            this.btnEat = new System.Windows.Forms.Button();
            this.lblHP = new System.Windows.Forms.PictureBox();
            this.lblClear = new System.Windows.Forms.PictureBox();
            this.lblHappy = new System.Windows.Forms.PictureBox();
            this.lblSleep = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pbImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.lblHP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblClear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblHappy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblSleep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEatCur
            // 
            this.lblEatCur.AutoSize = true;
            this.lblEatCur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEatCur.Location = new System.Drawing.Point(91, 63);
            this.lblEatCur.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEatCur.Name = "lblEatCur";
            this.lblEatCur.Size = new System.Drawing.Size(29, 20);
            this.lblEatCur.TabIndex = 2;
            this.lblEatCur.Text = "95";
            // 
            // lblEatMax
            // 
            this.lblEatMax.AutoSize = true;
            this.lblEatMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEatMax.ForeColor = System.Drawing.Color.Black;
            this.lblEatMax.Location = new System.Drawing.Point(91, 93);
            this.lblEatMax.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEatMax.Name = "lblEatMax";
            this.lblEatMax.Size = new System.Drawing.Size(39, 20);
            this.lblEatMax.TabIndex = 3;
            this.lblEatMax.Text = "100";
            // 
            // lblSleepMax
            // 
            this.lblSleepMax.AutoSize = true;
            this.lblSleepMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSleepMax.Location = new System.Drawing.Point(218, 93);
            this.lblSleepMax.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSleepMax.Name = "lblSleepMax";
            this.lblSleepMax.Size = new System.Drawing.Size(39, 20);
            this.lblSleepMax.TabIndex = 6;
            this.lblSleepMax.Text = "100";
            // 
            // lblSleepCur
            // 
            this.lblSleepCur.AutoSize = true;
            this.lblSleepCur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSleepCur.Location = new System.Drawing.Point(218, 63);
            this.lblSleepCur.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSleepCur.Name = "lblSleepCur";
            this.lblSleepCur.Size = new System.Drawing.Size(29, 20);
            this.lblSleepCur.TabIndex = 5;
            this.lblSleepCur.Text = "95";
            // 
            // lblHappyMax
            // 
            this.lblHappyMax.AutoSize = true;
            this.lblHappyMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHappyMax.Location = new System.Drawing.Point(353, 93);
            this.lblHappyMax.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHappyMax.Name = "lblHappyMax";
            this.lblHappyMax.Size = new System.Drawing.Size(39, 20);
            this.lblHappyMax.TabIndex = 9;
            this.lblHappyMax.Text = "100";
            // 
            // lblHappyCur
            // 
            this.lblHappyCur.AutoSize = true;
            this.lblHappyCur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHappyCur.Location = new System.Drawing.Point(353, 63);
            this.lblHappyCur.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHappyCur.Name = "lblHappyCur";
            this.lblHappyCur.Size = new System.Drawing.Size(29, 20);
            this.lblHappyCur.TabIndex = 8;
            this.lblHappyCur.Text = "95";
            // 
            // lblClearMax
            // 
            this.lblClearMax.AutoSize = true;
            this.lblClearMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblClearMax.Location = new System.Drawing.Point(478, 93);
            this.lblClearMax.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClearMax.Name = "lblClearMax";
            this.lblClearMax.Size = new System.Drawing.Size(39, 20);
            this.lblClearMax.TabIndex = 12;
            this.lblClearMax.Text = "100";
            // 
            // lblClearCur
            // 
            this.lblClearCur.AutoSize = true;
            this.lblClearCur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblClearCur.Location = new System.Drawing.Point(478, 63);
            this.lblClearCur.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClearCur.Name = "lblClearCur";
            this.lblClearCur.Size = new System.Drawing.Size(29, 20);
            this.lblClearCur.TabIndex = 11;
            this.lblClearCur.Text = "95";
            // 
            // lblHPMax
            // 
            this.lblHPMax.AutoSize = true;
            this.lblHPMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHPMax.Location = new System.Drawing.Point(691, 93);
            this.lblHPMax.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHPMax.Name = "lblHPMax";
            this.lblHPMax.Size = new System.Drawing.Size(39, 20);
            this.lblHPMax.TabIndex = 15;
            this.lblHPMax.Text = "100";
            // 
            // lblHPCur
            // 
            this.lblHPCur.AutoSize = true;
            this.lblHPCur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHPCur.Location = new System.Drawing.Point(691, 63);
            this.lblHPCur.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHPCur.Name = "lblHPCur";
            this.lblHPCur.Size = new System.Drawing.Size(29, 20);
            this.lblHPCur.TabIndex = 14;
            this.lblHPCur.Text = "95";
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGameOver.Location = new System.Drawing.Point(144, 494);
            this.lblGameOver.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(190, 18);
            this.lblGameOver.TabIndex = 20;
            this.lblGameOver.Text = "Он умер! Это ужасно :(";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.BackgroundImage = global::Tamagochi.Properties.Resources._10;
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClear.Location = new System.Drawing.Point(613, 355);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(116, 120);
            this.btnClear.TabIndex = 19;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnHappy
            // 
            this.btnHappy.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHappy.BackgroundImage = global::Tamagochi.Properties.Resources._9;
            this.btnHappy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHappy.Location = new System.Drawing.Point(470, 355);
            this.btnHappy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHappy.Name = "btnHappy";
            this.btnHappy.Size = new System.Drawing.Size(116, 120);
            this.btnHappy.TabIndex = 18;
            this.btnHappy.UseVisualStyleBackColor = false;
            this.btnHappy.Click += new System.EventHandler(this.btnHappy_Click);
            // 
            // btnSleep
            // 
            this.btnSleep.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSleep.BackgroundImage = global::Tamagochi.Properties.Resources._8;
            this.btnSleep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSleep.Location = new System.Drawing.Point(613, 155);
            this.btnSleep.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSleep.Name = "btnSleep";
            this.btnSleep.Size = new System.Drawing.Size(116, 120);
            this.btnSleep.TabIndex = 17;
            this.btnSleep.UseVisualStyleBackColor = false;
            this.btnSleep.Click += new System.EventHandler(this.btnSleep_Click);
            // 
            // btnEat
            // 
            this.btnEat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEat.BackgroundImage = global::Tamagochi.Properties.Resources._7;
            this.btnEat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEat.Location = new System.Drawing.Point(470, 155);
            this.btnEat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEat.Name = "btnEat";
            this.btnEat.Size = new System.Drawing.Size(116, 120);
            this.btnEat.TabIndex = 16;
            this.btnEat.UseVisualStyleBackColor = false;
            this.btnEat.Click += new System.EventHandler(this.btnEat_Click);
            // 
            // lblHP
            // 
            this.lblHP.BackgroundImage = global::Tamagochi.Properties.Resources._6;
            this.lblHP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.lblHP.Location = new System.Drawing.Point(636, 63);
            this.lblHP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lblHP.Name = "lblHP";
            this.lblHP.Size = new System.Drawing.Size(50, 50);
            this.lblHP.TabIndex = 13;
            this.lblHP.TabStop = false;
            // 
            // lblClear
            // 
            this.lblClear.BackgroundImage = global::Tamagochi.Properties.Resources._4;
            this.lblClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.lblClear.Location = new System.Drawing.Point(424, 63);
            this.lblClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lblClear.Name = "lblClear";
            this.lblClear.Size = new System.Drawing.Size(50, 50);
            this.lblClear.TabIndex = 10;
            this.lblClear.TabStop = false;
            // 
            // lblHappy
            // 
            this.lblHappy.BackgroundImage = global::Tamagochi.Properties.Resources._3;
            this.lblHappy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.lblHappy.Location = new System.Drawing.Point(298, 63);
            this.lblHappy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lblHappy.Name = "lblHappy";
            this.lblHappy.Size = new System.Drawing.Size(50, 50);
            this.lblHappy.TabIndex = 7;
            this.lblHappy.TabStop = false;
            // 
            // lblSleep
            // 
            this.lblSleep.BackgroundImage = global::Tamagochi.Properties.Resources._2;
            this.lblSleep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.lblSleep.Location = new System.Drawing.Point(164, 63);
            this.lblSleep.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lblSleep.Name = "lblSleep";
            this.lblSleep.Size = new System.Drawing.Size(50, 50);
            this.lblSleep.TabIndex = 4;
            this.lblSleep.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Tamagochi.Properties.Resources._1;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(36, 63);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pbImage
            // 
            this.pbImage.BackgroundImage = global::Tamagochi.Properties.Resources._5;
            this.pbImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbImage.Location = new System.Drawing.Point(36, 155);
            this.pbImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(405, 320);
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(766, 542);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnHappy);
            this.Controls.Add(this.btnSleep);
            this.Controls.Add(this.btnEat);
            this.Controls.Add(this.lblHPMax);
            this.Controls.Add(this.lblHPCur);
            this.Controls.Add(this.lblHP);
            this.Controls.Add(this.lblClearMax);
            this.Controls.Add(this.lblClearCur);
            this.Controls.Add(this.lblClear);
            this.Controls.Add(this.lblHappyMax);
            this.Controls.Add(this.lblHappyCur);
            this.Controls.Add(this.lblHappy);
            this.Controls.Add(this.lblSleepMax);
            this.Controls.Add(this.lblSleepCur);
            this.Controls.Add(this.lblSleep);
            this.Controls.Add(this.lblEatMax);
            this.Controls.Add(this.lblEatCur);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pbImage);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.lblHP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblClear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblHappy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblSleep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblEatCur;
        private System.Windows.Forms.Label lblEatMax;
        private System.Windows.Forms.Label lblSleepMax;
        private System.Windows.Forms.Label lblSleepCur;
        private System.Windows.Forms.PictureBox lblSleep;
        private System.Windows.Forms.Label lblHappyMax;
        private System.Windows.Forms.Label lblHappyCur;
        private System.Windows.Forms.PictureBox lblHappy;
        private System.Windows.Forms.Label lblClearMax;
        private System.Windows.Forms.Label lblClearCur;
        private System.Windows.Forms.PictureBox lblClear;
        private System.Windows.Forms.Label lblHPMax;
        private System.Windows.Forms.Label lblHPCur;
        private System.Windows.Forms.PictureBox lblHP;
        private System.Windows.Forms.Button btnEat;
        private System.Windows.Forms.Button btnSleep;
        private System.Windows.Forms.Button btnHappy;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblGameOver;
    }
}

