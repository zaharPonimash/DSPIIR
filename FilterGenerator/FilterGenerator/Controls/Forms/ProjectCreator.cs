using FilterGenLogic;
using MetroFramework.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FilterGenerator.Controls.Forms
{
    public partial class ProjectCreator : MetroForm
    {
        public ProjectCreator()
        {
            InitializeComponent();
        }

        public ProjectSettings settings;
        private int fdValue = 0;
        private bool unCorrect = true; // Некорректная частота дискретизации

        // Ok
        private void MetroButton1_Click(object sender, EventArgs e)
        {
            if (!unCorrect)
            {
                settings = new ProjectSettings(pName.Text, pDesc.Text, fdValue);
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void ProjectCreator_Load(object sender, EventArgs e)
        {
            fd.Theme = MetroFramework.MetroThemeStyle.Dark;
        }

        // Ввод частоты дискр
        private void Fd_TextChanged(object sender, EventArgs e)
        {
            if (fd.Text != string.Empty)
            {
                try
                {

                    fdValue = Convert.ToInt32(fd.Text);
                    if (fdValue > 2)
                    {
                        unCorrect = false;
                        status.ForeColor = Color.Green;
                        status.Text = "Частота введена корректно!";
                        fd.Theme = MetroFramework.MetroThemeStyle.Light;
                    }
                    else
                    {
                        fdUnCorrect();
                    }
                }
                catch
                {
                    fdUnCorrect();
                }
            }
            else
            {
                fd.Theme = MetroFramework.MetroThemeStyle.Dark;
                status.ForeColor = Color.Red;
                unCorrect = true;
                status.Text = "Введите частоту дискретизации";
            }
        }

        private void fdUnCorrect()
        {
            fd.Theme = MetroFramework.MetroThemeStyle.Dark;
            status.ForeColor = Color.Red;
            unCorrect = true;
            status.Text = "Частота введена не корректно!";
        }
    }
}
