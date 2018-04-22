namespace QuestRoomApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlQuestInfo = new System.Windows.Forms.Panel();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblPlayersLimit = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblQuestName = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lstQuests = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cBoxPlayersLimit = new System.Windows.Forms.ComboBox();
            this.cBoxPrice = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cBoxDuration = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnResetFilter = new System.Windows.Forms.Button();
            this.pnlQuestInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlQuestInfo
            // 
            this.pnlQuestInfo.Controls.Add(this.lblDuration);
            this.pnlQuestInfo.Controls.Add(this.lblPrice);
            this.pnlQuestInfo.Controls.Add(this.lblPlayersLimit);
            this.pnlQuestInfo.Controls.Add(this.lblDescription);
            this.pnlQuestInfo.Controls.Add(this.lblQuestName);
            this.pnlQuestInfo.Controls.Add(this.button2);
            this.pnlQuestInfo.Location = new System.Drawing.Point(451, 51);
            this.pnlQuestInfo.Name = "pnlQuestInfo";
            this.pnlQuestInfo.Size = new System.Drawing.Size(359, 277);
            this.pnlQuestInfo.TabIndex = 3;
            this.pnlQuestInfo.Visible = false;
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDuration.Location = new System.Drawing.Point(17, 87);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(64, 17);
            this.lblDuration.TabIndex = 5;
            this.lblDuration.Text = "Duration";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPrice.Location = new System.Drawing.Point(17, 63);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(39, 17);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Price";
            // 
            // lblPlayersLimit
            // 
            this.lblPlayersLimit.AutoSize = true;
            this.lblPlayersLimit.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPlayersLimit.Location = new System.Drawing.Point(17, 39);
            this.lblPlayersLimit.Name = "lblPlayersLimit";
            this.lblPlayersLimit.Size = new System.Drawing.Size(82, 17);
            this.lblPlayersLimit.TabIndex = 3;
            this.lblPlayersLimit.Text = "Players limit";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDescription.Location = new System.Drawing.Point(18, 111);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(80, 17);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Description";
            // 
            // lblQuestName
            // 
            this.lblQuestName.AutoSize = true;
            this.lblQuestName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblQuestName.Location = new System.Drawing.Point(17, 14);
            this.lblQuestName.Name = "lblQuestName";
            this.lblQuestName.Size = new System.Drawing.Size(48, 17);
            this.lblQuestName.TabIndex = 1;
            this.lblQuestName.Text = "Name";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(272, 243);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Reserv";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(486, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(276, 237);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lstQuests
            // 
            this.lstQuests.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lstQuests.FormattingEnabled = true;
            this.lstQuests.ItemHeight = 17;
            this.lstQuests.Location = new System.Drawing.Point(21, 51);
            this.lstQuests.Name = "lstQuests";
            this.lstQuests.Size = new System.Drawing.Size(406, 276);
            this.lstQuests.TabIndex = 5;
            this.lstQuests.SelectedIndexChanged += new System.EventHandler(this.lstQuests_SelectedIndexChanged);
            this.lstQuests.SelectedValueChanged += new System.EventHandler(this.ItemSelected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Players <=";
            // 
            // cBoxPlayersLimit
            // 
            this.cBoxPlayersLimit.FormattingEnabled = true;
            this.cBoxPlayersLimit.Location = new System.Drawing.Point(83, 17);
            this.cBoxPlayersLimit.Name = "cBoxPlayersLimit";
            this.cBoxPlayersLimit.Size = new System.Drawing.Size(121, 21);
            this.cBoxPlayersLimit.TabIndex = 7;
            this.cBoxPlayersLimit.SelectedIndexChanged += new System.EventHandler(this.FilterResults);
            // 
            // cBoxPrice
            // 
            this.cBoxPrice.FormattingEnabled = true;
            this.cBoxPrice.Location = new System.Drawing.Point(262, 17);
            this.cBoxPrice.Name = "cBoxPrice";
            this.cBoxPrice.Size = new System.Drawing.Size(121, 21);
            this.cBoxPrice.TabIndex = 9;
            this.cBoxPrice.SelectedIndexChanged += new System.EventHandler(this.FilterResults);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Price <=";
            // 
            // cBoxDuration
            // 
            this.cBoxDuration.FormattingEnabled = true;
            this.cBoxDuration.Location = new System.Drawing.Point(462, 17);
            this.cBoxDuration.Name = "cBoxDuration";
            this.cBoxDuration.Size = new System.Drawing.Size(121, 21);
            this.cBoxDuration.TabIndex = 11;
            this.cBoxDuration.SelectionChangeCommitted += new System.EventHandler(this.FilterResults);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(400, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Duration <=";
            // 
            // btnResetFilter
            // 
            this.btnResetFilter.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnResetFilter.Location = new System.Drawing.Point(735, 15);
            this.btnResetFilter.Name = "btnResetFilter";
            this.btnResetFilter.Size = new System.Drawing.Size(75, 23);
            this.btnResetFilter.TabIndex = 12;
            this.btnResetFilter.Text = "Reset";
            this.btnResetFilter.UseVisualStyleBackColor = true;
            this.btnResetFilter.Click += new System.EventHandler(this.btnResetFilter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 347);
            this.Controls.Add(this.btnResetFilter);
            this.Controls.Add(this.cBoxDuration);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cBoxPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cBoxPlayersLimit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstQuests);
            this.Controls.Add(this.pnlQuestInfo);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "QuestRoom";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlQuestInfo.ResumeLayout(false);
            this.pnlQuestInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlQuestInfo;
        private System.Windows.Forms.Label lblQuestName;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblPlayersLimit;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.ListBox lstQuests;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBoxPlayersLimit;
        private System.Windows.Forms.ComboBox cBoxPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cBoxDuration;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnResetFilter;
    }
}

