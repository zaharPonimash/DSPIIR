namespace FilterGenerator.Controls.Forms
{
    partial class ProjectCreator
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.pName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.pDesc = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.fd = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(13, 77);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(95, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Имя проекта: ";
            // 
            // pName
            // 
            this.pName.Location = new System.Drawing.Point(14, 99);
            this.pName.MaxLength = 50;
            this.pName.Name = "pName";
            this.pName.Size = new System.Drawing.Size(247, 23);
            this.pName.TabIndex = 1;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(13, 135);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(128, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Описание проекта:";
            // 
            // pDesc
            // 
            this.pDesc.Location = new System.Drawing.Point(13, 157);
            this.pDesc.MaxLength = 327670;
            this.pDesc.Multiline = true;
            this.pDesc.Name = "pDesc";
            this.pDesc.Size = new System.Drawing.Size(247, 165);
            this.pDesc.TabIndex = 3;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(14, 325);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(187, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Частота дискретизации [Гц]*:";
            // 
            // fd
            // 
            this.fd.Location = new System.Drawing.Point(13, 347);
            this.fd.Name = "fd";
            this.fd.Size = new System.Drawing.Size(247, 23);
            this.fd.TabIndex = 5;
            this.fd.TextChanged += new System.EventHandler(this.Fd_TextChanged);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(209, 376);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(52, 26);
            this.metroButton1.TabIndex = 6;
            this.metroButton1.Text = "OK";
            this.metroButton1.Click += new System.EventHandler(this.MetroButton1_Click);
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.status.ForeColor = System.Drawing.Color.Red;
            this.status.Location = new System.Drawing.Point(26, 419);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(225, 15);
            this.status.TabIndex = 7;
            this.status.Text = "Введите частоту дискретизации";
            // 
            // ProjectCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(274, 438);
            this.Controls.Add(this.status);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.fd);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.pDesc);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.pName);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(274, 438);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(274, 438);
            this.Name = "ProjectCreator";
            this.Resizable = false;
            this.Text = "Создание проекта";
            this.Load += new System.EventHandler(this.ProjectCreator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox pName;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox pDesc;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox fd;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.Label status;
    }
}