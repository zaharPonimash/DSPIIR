namespace FilterGenerator.Controls.Filters
{
    partial class LowFilter
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LowFilter));
            this.filtIcon = new System.Windows.Forms.PictureBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.aPasCh = new MetroFramework.Controls.MetroTrackBar();
            this.aStopCh = new MetroFramework.Controls.MetroTrackBar();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.fPassTxt = new MetroFramework.Controls.MetroTextBox();
            this.fStopTxt = new MetroFramework.Controls.MetroTextBox();
            this.Ampl = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.filtIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // filtIcon
            // 
            this.filtIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filtIcon.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.filtIcon.Image = ((System.Drawing.Image)(resources.GetObject("filtIcon.Image")));
            this.filtIcon.InitialImage = null;
            this.filtIcon.Location = new System.Drawing.Point(0, 0);
            this.filtIcon.Name = "filtIcon";
            this.filtIcon.Size = new System.Drawing.Size(341, 210);
            this.filtIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.filtIcon.TabIndex = 0;
            this.filtIcon.TabStop = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 216);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(42, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "APass";
            // 
            // aPasCh
            // 
            this.aPasCh.BackColor = System.Drawing.Color.Transparent;
            this.aPasCh.Location = new System.Drawing.Point(51, 217);
            this.aPasCh.Name = "aPasCh";
            this.aPasCh.Size = new System.Drawing.Size(71, 18);
            this.aPasCh.TabIndex = 2;
            this.aPasCh.Text = "metroTrackBar1";
            this.aPasCh.Value = 90;
            this.aPasCh.Scroll += new System.Windows.Forms.ScrollEventHandler(this.APasCh_Scroll);
            // 
            // aStopCh
            // 
            this.aStopCh.BackColor = System.Drawing.Color.Transparent;
            this.aStopCh.Location = new System.Drawing.Point(51, 251);
            this.aStopCh.Name = "aStopCh";
            this.aStopCh.Size = new System.Drawing.Size(71, 18);
            this.aStopCh.TabIndex = 4;
            this.aStopCh.Text = "metroTrackBar2";
            this.aStopCh.Value = 10;
            this.aStopCh.Scroll += new System.Windows.Forms.ScrollEventHandler(this.AStopCh_Scroll);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(3, 250);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(45, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "AStop";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(159, 254);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(43, 19);
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "FStop";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(159, 220);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(40, 19);
            this.metroLabel4.TabIndex = 5;
            this.metroLabel4.Text = "FPass";
            // 
            // fPassTxt
            // 
            this.fPassTxt.Location = new System.Drawing.Point(208, 216);
            this.fPassTxt.Name = "fPassTxt";
            this.fPassTxt.Size = new System.Drawing.Size(79, 23);
            this.fPassTxt.TabIndex = 9;
            this.fPassTxt.Text = "0";
            // 
            // fStopTxt
            // 
            this.fStopTxt.Location = new System.Drawing.Point(208, 250);
            this.fStopTxt.Name = "fStopTxt";
            this.fStopTxt.Size = new System.Drawing.Size(79, 23);
            this.fStopTxt.TabIndex = 10;
            this.fStopTxt.Text = "0";
            // 
            // Ampl
            // 
            this.Ampl.AutoSize = true;
            this.Ampl.Location = new System.Drawing.Point(3, 290);
            this.Ampl.Name = "Ampl";
            this.Ampl.Size = new System.Drawing.Size(144, 19);
            this.Ampl.TabIndex = 11;
            this.Ampl.Text = "APass: 0.9     AStop: 0.1";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(301, 283);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(37, 23);
            this.metroButton1.TabIndex = 12;
            this.metroButton1.Text = "OK";
            this.metroButton1.Click += new System.EventHandler(this.MetroButton1_Click);
            // 
            // LowFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.Ampl);
            this.Controls.Add(this.fStopTxt);
            this.Controls.Add(this.fPassTxt);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.aStopCh);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.aPasCh);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.filtIcon);
            this.MaximumSize = new System.Drawing.Size(341, 309);
            this.MinimumSize = new System.Drawing.Size(341, 309);
            this.Name = "LowFilter";
            this.Size = new System.Drawing.Size(341, 309);
            this.Load += new System.EventHandler(this.LowFilter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.filtIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox filtIcon;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTrackBar aPasCh;
        private MetroFramework.Controls.MetroTrackBar aStopCh;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox fPassTxt;
        private MetroFramework.Controls.MetroTextBox fStopTxt;
        private MetroFramework.Controls.MetroLabel Ampl;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}
