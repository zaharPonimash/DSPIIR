using MetroFramework.Forms;
using System;
using System.Windows.Forms;

namespace FilterGenerator.Controls.Forms
{
    public partial class FreqRespForm : MetroForm
    {
        public FreqRespForm()
        {
            InitializeComponent();
        }

        private void EndFreq_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
