namespace FilterGenerator.Controls.Forms
{
    partial class LowPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LowPass));
            this.lowFilter1 = new FilterGenerator.Controls.Filters.LowFilter();
            this.SuspendLayout();
            // 
            // lowFilter1
            // 
            this.lowFilter1.FilterType = FilterGenLogic.FilterType.BandPass;
            this.lowFilter1.Location = new System.Drawing.Point(23, 63);
            this.lowFilter1.MaximumSize = new System.Drawing.Size(341, 309);
            this.lowFilter1.MinimumSize = new System.Drawing.Size(341, 309);
            this.lowFilter1.Name = "lowFilter1";
            this.lowFilter1.Size = new System.Drawing.Size(341, 309);
            this.lowFilter1.TabIndex = 0;
            // 
            // LowPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 376);
            this.Controls.Add(this.lowFilter1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(374, 376);
            this.MinimumSize = new System.Drawing.Size(374, 376);
            this.Name = "LowPass";
            this.Text = "ФНЧ";
            this.ResumeLayout(false);

        }

        #endregion

        private Filters.LowFilter lowFilter1;
    }
}