namespace Clock
{
    partial class ClockForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBoxForClock = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForClock)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxForClock
            // 
            this.pictureBoxForClock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxForClock.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxForClock.MinimumSize = new System.Drawing.Size(400, 400);
            this.pictureBoxForClock.Name = "pictureBoxForClock";
            this.pictureBoxForClock.Size = new System.Drawing.Size(400, 400);
            this.pictureBoxForClock.TabIndex = 1;
            this.pictureBoxForClock.TabStop = false;
            this.pictureBoxForClock.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxForClock_Paint);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 25;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ClockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.pictureBoxForClock);
            this.MinimumSize = new System.Drawing.Size(416, 439);
            this.Name = "ClockForm";
            this.Text = "Clock";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForClock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxForClock;
        private System.Windows.Forms.Timer timer1;
    }
}

