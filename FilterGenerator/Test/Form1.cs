using NWaves.Filters.Bessel;
using AI;
using AI.DSPCore;
using AI.DSP.Analyse;
using AI.DSP.IIR;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            double f0 = f / fd;
            double f1 = fe / fd;

            var lowPassFilter = new LowPassFilter(f1,10);
            lowPassFilter.Normalize();

            Vector a = new Vector(lowPassFilter._a);
            Vector b = new Vector(lowPassFilter._b);
            b = b.CutAndZero(b.Count / 2);
            a = a.CutAndZero(a.Count / 2);
            iIRFilter = new IIRFilter(a, b);



            FrequencyResponse frequencyResponse = new FrequencyResponse((int)fd);

            frequencyResponse.FStart = 0;
            frequencyResponse.FEnd = 400;
            frequencyResponse.Step = 0.5;
            frequencyResponse.Time = 2;

            var fSig = frequencyResponse.Test(vec2vec);

            chartVisual1.PlotBlack(frequencyResponse.Freq, fSig);

        }


        double fd = 800;
        double f = 45;
        double fe = 55;
        IIRFilter iIRFilter;

        Vector vec2vec(Vector sig)
        {
            Vector fSig = iIRFilter.FilterOutp(sig);
            return fSig;
        }

    }
}
