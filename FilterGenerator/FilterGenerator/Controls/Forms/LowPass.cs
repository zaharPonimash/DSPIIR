using FilterGenLogic;
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
    public partial class LowPass : MetroForm
    {
        public LowPass(FilterType filterType = FilterType.LowPass)
        {
            InitializeComponent();
            lowFilter1.FilterType = filterType;
            Text = lowFilter1.NameF;
            DialogResult = DialogResult.Abort;
            lowFilter1.Ok += LowFilter1_Ok;
        }

        private void LowFilter1_Ok(bool obj)
        {
            
            aPass = lowFilter1.aPass;
            aStop = lowFilter1.aStop;
            fPass = lowFilter1.fPass;
            fStop = lowFilter1.fStop;
            DialogResult = DialogResult.OK;
            Close();
        }

        public double aPass = 0.9, aStop = 0.1, fPass, fStop;
    }
}
