namespace QuestRoomApp
{
    partial class ReservationWindow
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
            this.clndrDateSelector = new System.Windows.Forms.MonthCalendar();
            this.btnConfirmReserv = new System.Windows.Forms.Button();
            this.cboxTimeSelector = new System.Windows.Forms.ComboBox();
            this.ckBoxHasSertificate = new System.Windows.Forms.CheckBox();
            this.txtBoxsertifacateCode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // clndrDateSelector
            // 
            this.clndrDateSelector.Location = new System.Drawing.Point(18, 28);
            this.clndrDateSelector.MinDate = new System.DateTime(2018, 3, 16, 0, 0, 0, 0);
            this.clndrDateSelector.Name = "clndrDateSelector";
            this.clndrDateSelector.TabIndex = 0;
            this.clndrDateSelector.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.clndrDateSelector_DateSelected);
            // 
            // btnConfirmReserv
            // 
            this.btnConfirmReserv.Location = new System.Drawing.Point(154, 217);
            this.btnConfirmReserv.Name = "btnConfirmReserv";
            this.btnConfirmReserv.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmReserv.TabIndex = 1;
            this.btnConfirmReserv.Text = "OK";
            this.btnConfirmReserv.UseVisualStyleBackColor = true;
            this.btnConfirmReserv.Click += new System.EventHandler(this.btnConfirmReserv_Click);
            // 
            // cboxTimeSelector
            // 
            this.cboxTimeSelector.FormattingEnabled = true;
            this.cboxTimeSelector.Location = new System.Drawing.Point(207, 28);
            this.cboxTimeSelector.Name = "cboxTimeSelector";
            this.cboxTimeSelector.Size = new System.Drawing.Size(142, 21);
            this.cboxTimeSelector.TabIndex = 2;
            // 
            // ckBoxHasSertificate
            // 
            this.ckBoxHasSertificate.AutoSize = true;
            this.ckBoxHasSertificate.Location = new System.Drawing.Point(207, 72);
            this.ckBoxHasSertificate.Name = "ckBoxHasSertificate";
            this.ckBoxHasSertificate.Size = new System.Drawing.Size(114, 17);
            this.ckBoxHasSertificate.TabIndex = 3;
            this.ckBoxHasSertificate.Text = "I have a certificate";
            this.ckBoxHasSertificate.UseVisualStyleBackColor = true;
            this.ckBoxHasSertificate.CheckedChanged += new System.EventHandler(this.ckBoxHasSertificate_CheckedChanged);
            // 
            // txtBoxsertifacateCode
            // 
            this.txtBoxsertifacateCode.Location = new System.Drawing.Point(207, 97);
            this.txtBoxsertifacateCode.Name = "txtBoxsertifacateCode";
            this.txtBoxsertifacateCode.Size = new System.Drawing.Size(142, 20);
            this.txtBoxsertifacateCode.TabIndex = 4;
            this.txtBoxsertifacateCode.Visible = false;
            // 
            // ReservationWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 251);
            this.Controls.Add(this.txtBoxsertifacateCode);
            this.Controls.Add(this.ckBoxHasSertificate);
            this.Controls.Add(this.cboxTimeSelector);
            this.Controls.Add(this.btnConfirmReserv);
            this.Controls.Add(this.clndrDateSelector);
            this.Name = "ReservationWindow";
            this.Text = "ReservationWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar clndrDateSelector;
        private System.Windows.Forms.Button btnConfirmReserv;
        private System.Windows.Forms.ComboBox cboxTimeSelector;
        private System.Windows.Forms.CheckBox ckBoxHasSertificate;
        private System.Windows.Forms.TextBox txtBoxsertifacateCode;
    }
}