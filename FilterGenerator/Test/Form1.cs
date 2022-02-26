using AI.BackEnds.DSP.NWaves.Filters.Bessel;
using AI.DataStructs.Algebraic;
using AI.DSP.Analyse;
using AI.DSP.IIR;
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

            LowPassFilter lowPassFilter = new LowPassFilter(f1, 10);
            lowPassFilter.Normalize();

            Vector a = new Vector(lowPassFilter._a);
            Vector b = new Vector(lowPassFilter._b);
            b = b.CutAndZero(b.Count / 2);
            a = a.CutAndZero(a.Count / 2);
            iIRFilter = new IIRFilter(a, b);



            FrequencyResponse frequencyResponse = new FrequencyResponse((int)fd)
            {
                FStart = 0,
                FEnd = 300,
                Step = 1.5,
                Time = 0.8
            };

            Vector fSig = frequencyResponse.Test(vec2vec);

            chartVisual1.PlotBlack(frequencyResponse.Freq, fSig);

        }

        private readonly double fd = 600;
        private readonly double f = 45;
        private readonly double fe = 55;
        private readonly IIRFilter iIRFilter;

        private Vector vec2vec(Vector sig)
        {
            Vector fSig = iIRFilter.FilterOutp(sig);
            return fSig;
        }

    }
}
