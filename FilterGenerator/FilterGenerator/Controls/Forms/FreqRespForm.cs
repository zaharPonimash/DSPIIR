using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
