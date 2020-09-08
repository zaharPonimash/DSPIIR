using FilterGenLogic;
using MetroFramework.Controls;
using System;
using System.Windows.Forms;

namespace FilterGenerator.Controls.Filters
{
    public partial class LowFilter : MetroUserControl
    {
        public LowFilter()
        {
            InitializeComponent();
            Ok += LowFilter_Ok;
        }



        /// <summary>
        /// Имя фильтра
        /// </summary>
        public string NameF { get; private set; }


        /// <summary>
        /// Тип фильтра
        /// </summary>
        public FilterType FilterType
        {
            get => filterType;

            set
            {
                if (value == FilterType.LowPass)
                {
                    NameF = "ФНЧ";
                    filterType = FilterType.LowPass;
                    filtIcon.Image = Resources.lowPassFilter;
                }
                else if (value == FilterType.HPass)
                {
                    NameF = "ФВЧ";
                    filterType = FilterType.HPass;
                    filtIcon.Image = Resources.HPass;
                }
            }
        }

        private FilterType filterType;

        public double aPass = 0.9, aStop = 0.1, fPass, fStop;


        private void LowFilter_Load(object sender, EventArgs e)
        {

        }


        // Выбор коэфф в полосе заграждения
        private void AStopCh_Scroll(object sender, ScrollEventArgs e)
        {
            aStop = aStopCh.Value / 100.0;

            Ampl.Text = "APass: " + aPass + "   AStop: " + aStop;
        }


        // Ок
        private void MetroButton1_Click(object sender, EventArgs e)
        {
            fPass = ProjectSettings.ToDouble(fPassTxt.Text);
            fStop = ProjectSettings.ToDouble(fStopTxt.Text);
            Ok(true);
        }


        // Выбор коэфф в полосе пропускания
        private void APasCh_Scroll(object sender, ScrollEventArgs e)
        {
            aPass = aPasCh.Value / 100.0;

            Ampl.Text = "APass: " + aPass + "   AStop: " + aStop;
        }

        /// <summary>
        /// Нажатие на ok
        /// </summary>
        public event Action<bool> Ok;

        private void LowFilter_Ok(bool obj)
        {

        }
    }
}
