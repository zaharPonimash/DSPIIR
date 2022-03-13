namespace FilterGenerator.Controls.Forms
{
    partial class FreqRespForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FreqRespForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.StartFreq = new System.Windows.Forms.TextBox();
            this.EndFreq = new System.Windows.Forms.TextBox();
            this.fStep = new System.Windows.Forms.TextBox();
            this.Time = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Начальная частота:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Конечная частота:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Шаг по частоте:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Длительность реализации:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(249, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // StartFreq
            // 
            this.StartFreq.Location = new System.Drawing.Point(175, 79);
            this.StartFreq.Name = "StartFreq";
            this.StartFreq.Size = new System.Drawing.Size(122, 20);
            this.StartFreq.TabIndex = 3;
            this.StartFreq.Text = "0";
            // 
            // EndFreq
            // 
            this.EndFreq.Location = new System.Drawing.Point(175, 113);
            this.EndFreq.Name = "EndFreq";
            this.EndFreq.Size = new System.Drawing.Size(122, 20);
            this.EndFreq.TabIndex = 4;
            this.EndFreq.Text = "100";
            // 
            // fStep
            // 
            this.fStep.Location = new System.Drawing.Point(175, 149);
            this.fStep.Name = "fStep";
            this.fStep.Size = new System.Drawing.Size(122, 20);
            this.fStep.TabIndex = 5;
            this.fStep.Text = "1";
            // 
            // Time
            // 
            this.Time.Location = new System.Drawing.Point(175, 189);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(122, 20);
            this.Time.TabIndex = 6;
            this.Time.Text = "1";
            // 
            // FreqRespForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 270);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.fStep);
            this.Controls.Add(this.EndFreq);
            this.Controls.Add(this.StartFreq);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FreqRespForm";
            this.Resizable = false;
            this.Text = "АЧХ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox StartFreq;
        public System.Windows.Forms.TextBox EndFreq;
        public System.Windows.Forms.TextBox fStep;
        public System.Windows.Forms.TextBox Time;
    }
}