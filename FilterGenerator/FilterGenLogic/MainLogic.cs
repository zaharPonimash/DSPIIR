using AI;
using AI.DSP.Analyse;
using AI.DSP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AI.DSP.IIR;
using AI.SpecialFunction;

namespace FilterGenLogic
{
    // Основная логика
    public class MainLogic
    {
        // Параметры фильтра
        public Vector a { get; set; }
        public Vector b { get; set; }
        public Vector FreqResp { get; set; }
        // ФЧХ
        public Vector FreqRespPh { get; set; }
        //Груповая задержка
        public Vector GroupDel { get; set; }


        /// <summary>
        /// Полюса фильтров
        /// </summary>
        public ComplexVector Pol { get; set; }

        int _fd;


        /// <summary>
        /// Основная логика проекта
        /// </summary>
        /// <param name="fd">Частота дискретизации</param>
        public MainLogic(int fd)
        {
            _fd = fd;
            a = new Vector();
            b = new Vector();
        }


        #region ФНЧ

        /// <summary>
        /// Расчет ФНЧ Бесселя
        /// </summary>
        /// <param name="fPass">Полоса пропускания</param>
        /// <param name="fStop">Полоса заграждения</param>
        public void CalcLowFiltBess(double fPass, double fStop)
        {
            //TODO: Доработать
            double fCNorm =  (fStop+fPass)/(2.0*_fd);
            CreateF(new NWaves.Filters.Bessel.LowPassFilter(fCNorm, 5));
        }


        /// <summary>
        /// Расчет ФНЧ Чебышева 1-рода
        /// </summary>
        /// <param name="aPass"></param>
        /// <param name="aStop"></param>
        /// <param name="fPass"></param>
        /// <param name="fStop"></param>
        public void CalcLowFiltCheb1(double aPass, double aStop, double fPass, double fStop)
        {
            
            double fCNorm = fPass / _fd;

            double eps = 1 - aPass;
            double g = Math.Sqrt((Math.Pow(aPass / aStop, 2) - 1) / (eps * eps));
            double omega = fStop / fPass;

            double nom = g+ Math.Sqrt(g*g-1);
            nom = Math.Log(nom > 1e+9 ? 1e+9 : nom);

            double denom = Math.Log(omega + Math.Sqrt(omega * omega - 1)); ;

            int order = (int)(nom / denom + 0.9999);

            CreateF(new NWaves.Filters.ChebyshevI.LowPassFilter(fCNorm, order));
        }



        /// <summary>
        /// Расчет ФНЧ Чебышева 2-рода
        /// </summary>
        /// <param name="aPass"></param>
        /// <param name="aStop"></param>
        /// <param name="fPass"></param>
        /// <param name="fStop"></param>
        public void CalcLowFiltCheb2(double aPass, double aStop, double fPass, double fStop)
        {
            double fCNorm = fPass / _fd;

            double eps =  aStop;
            double g = Math.Sqrt((Math.Pow(aPass / aStop, 2) - 1) / (eps * eps));
            double omega = fStop / fPass;

            double nom = g + Math.Sqrt(g * g - 1);
            nom = Math.Log(nom > 1e+9 ? 1e+9 : nom);

            double denom = Math.Log(omega + Math.Sqrt(omega * omega - 1)); ;

            int order = (int)(nom / denom + 0.9999);

            CreateF(new NWaves.Filters.ChebyshevII.LowPassFilter(fCNorm, order));
        }


        /// <summary>
        /// Расчет ФНЧ Батервордта
        /// </summary>
        /// <param name="aPass"></param>
        /// <param name="aStop"></param>
        /// <param name="fPass"></param>
        /// <param name="fStop"></param>
        public void CalcLowFiltB(double aPass, double aStop, double fPass, double fStop)
        {
            double fCNorm = fPass / _fd;
            double nom = Math.Pow(aPass / aStop, 2);
            nom = Math.Log10(nom > 1e+9 ? 1e+9 : nom);
            double denom = 2.0 * Math.Log10(fStop/fPass);
            int order = (int)(nom / denom + 0.9999);

            CreateF(new NWaves.Filters.Butterworth.LowPassFilter(fCNorm, order));
            
        }


        /// <summary>
        /// Расчет ФНЧ Эллиптич
        /// </summary>
        /// <param name="aPass"></param>
        /// <param name="aStop"></param>
        /// <param name="fPass"></param>
        /// <param name="fStop"></param>
        public void CalcLowFiltEll(double aPass, double aStop, double fPass, double fStop)
        {
            //Func<double, double> K = EllipticIntegral.CompleteEllipticIntegral_I; // Эллип. интеграл 1-го рода

            //double fCNorm = fPass / _fd;

            //double eps = aStop;
            //double k1 = eps/(Math.Sqrt(Math.Pow(aPass / aStop, 2)-1));
            //double k = fPass/ fStop;

            //double nom = K(k)*K(Math.Sqrt(1-k1*k1));// Числитель
            //double denom = K(k1) * K(Math.Sqrt(1 - k * k)); // Знаменатель

            //int order = (int)(nom / denom + 0.9999);

            //CreateF(new NWaves.Filters.Elliptic.LowPassFilter(fCNorm, order));


            double fCNorm = fPass / _fd;

            double eps = aStop;
            double g = Math.Sqrt((Math.Pow(aPass / aStop, 2) - 1) / (eps * eps));
            double omega = fStop / fPass;

            double nom = g + Math.Sqrt(g * g - 1);
            nom = Math.Log(nom > 1e+9 ? 1e+9 : nom);

            double denom = Math.Log(omega + Math.Sqrt(omega * omega - 1)); ;

            int order = (int)(nom / denom + 0.9999);
            CreateF(new NWaves.Filters.Elliptic.LowPassFilter(fCNorm, order));
        }



        /// <summary>
        /// Расчет ФНЧ Биквадр
        /// </summary>
        /// <param name="fPass"></param>
        public void CalcLowFiltBeQ( double fPass)
        {
            double fCNorm = fPass / _fd;
            CreateF(new NWaves.Filters.BiQuad.LowPassFilter(fCNorm));
        }

        #endregion


        #region ФВЧ

        /// <summary>
        /// Расчет ФВЧ Бесселя
        /// </summary>
        /// <param name="fStop"></param>
        public void CalcHiFiltBess(double fPass, double fStop)
        {
            //TODO: Доработать
            double fCNorm = (fStop+fPass) / (2*_fd);
            CreateF(new NWaves.Filters.Bessel.HighPassFilter(fCNorm, 5));
        }


        /// <summary>
        /// Расчет ФВЧ Чебышева 1-рода
        /// </summary>
        /// <param name="aPass"></param>
        /// <param name="aStop"></param>
        /// <param name="fPass"></param>
        /// <param name="fStop"></param>
        public void CalcHiFiltCheb1(double aPass, double aStop, double fPass, double fStop)
        {
            double fCNorm = fPass / _fd;

            double eps = 1 - aStop;
            double g = Math.Sqrt((Math.Pow(aPass / aStop, 2) - 1) / (eps * eps));
            double omega = fStop / fPass;
            omega = 1.0 / omega;

            double nom = g + Math.Sqrt(g * g - 1);
            nom = Math.Log(nom > 1e+9 ? 1e+9 : nom);

            double denom = Math.Log(omega + Math.Sqrt(omega * omega - 1)); ;

            int order = (int)(nom / denom + 0.9999);

            CreateF(new NWaves.Filters.ChebyshevI.HighPassFilter(fCNorm, order));
        }



        /// <summary>
        /// Расчет ФВЧ Чебышева 2-рода
        /// </summary>
        /// <param name="aPass"></param>
        /// <param name="aStop"></param>
        /// <param name="fPass"></param>
        /// <param name="fStop"></param>
        public void CalcHiFiltCheb2(double aPass, double aStop, double fPass, double fStop)
        {
            double fCNorm = fPass / _fd;

            double eps = 1 - aStop;
            double g = Math.Sqrt((Math.Pow(aPass / aStop, 2) - 1) / (eps * eps));
            double omega = fStop / fPass;
            omega = 1.0 / omega;

            double nom = g + Math.Sqrt(g * g - 1);
            nom = Math.Log(nom > 1e+9 ? 1e+9 : nom);

            double denom = Math.Log(omega + Math.Sqrt(omega * omega - 1)); ;

            int order = (int)(nom / denom + 0.9999);

            CreateF(new NWaves.Filters.ChebyshevII.HighPassFilter(fCNorm, order));
        }


        /// <summary>
        /// Расчет ФВЧ Батервордта
        /// </summary>
        /// <param name="aPass"></param>
        /// <param name="aStop"></param>
        /// <param name="fPass"></param>
        /// <param name="fStop"></param>
        public void CalcHiFiltB(double aPass, double aStop, double fPass, double fStop)
        {
            double fCNorm = fPass / _fd;
            double nom = Math.Pow(aPass / aStop, 2);
            nom = Math.Log10(nom>1e+9?1e+9:nom);
            double denom = 2.0 * Math.Log10(fPass/ fStop);
            int order = (int)(nom / denom + 0.9999);

            CreateF(new NWaves.Filters.Butterworth.HighPassFilter(fCNorm, order));
        }


        /// <summary>
        /// Расчет ФВЧ Эллиптич
        /// </summary>
        public void CalcHiFiltEll(double aPass, double aStop, double fPass, double fStop)
        {
            //Func<double, double> K = EllipticIntegral.CompleteEllipticIntegral_I; // Эллип. интеграл 1-го рода

            //double fCNorm = fPass / _fd;

            //double eps = 1 - aStop;
            //double k1 = eps / (Math.Sqrt(Math.Pow(aPass / aStop, 2) - 1));
            //double k = fStop/ fPass;

            //double nom = K(k) * K(Math.Sqrt(1 - k1 * k1));// Числитель
            //double denom = K(k1) * K(Math.Sqrt(1 - k * k)); // Знаменатель

            //int order = (int)(nom / denom + 0.9999);

            //CreateF(new NWaves.Filters.Elliptic.LowPassFilter(fCNorm, order));

            double fCNorm = fPass / _fd;

            double eps = aStop;
            double g = Math.Sqrt((Math.Pow(aPass / aStop, 2) - 1) / (eps * eps));
            double omega = fStop / fPass;
            omega = 1.0 / omega;

            double nom = g + Math.Sqrt(g * g - 1);
            nom = Math.Log(nom > 1e+9 ? 1e+9 : nom);

            double denom = Math.Log(omega + Math.Sqrt(omega * omega - 1)); ;

            int order = (int)(nom / denom + 0.9999);

            CreateF(new NWaves.Filters.Elliptic.HighPassFilter(fCNorm, order));
        }



        /// <summary>
        /// Расчет ФВЧ Биквадр
        /// </summary>
        /// <param name="fPass"></param>
        public void CalcHiFiltBeQ(double fPass)
        {
            double fCNorm = fPass / _fd;
            CreateF(new NWaves.Filters.BiQuad.HighPassFilter(fCNorm));
        }

        #endregion
        

        #region Тесты
        /// <summary>
        /// АЧХ, возвращает 2 вектора, частоту и коэффициенты АЧХ
        /// </summary>
        /// <param name="frequencyResponse">Настройки тестировщика АЧХ</param>
        /// <returns>Частота и коэффициенты АЧХ</returns>
        public Tuple<Vector, Vector> FreqRespFilt(FrequencyResponse frequencyResponse)
        {
            IIRFilter iIRFilter = new IIRFilter(a, b);
            Vector ampl = frequencyResponse.Test(iIRFilter.FilterOutp);
            return new Tuple<Vector, Vector>(frequencyResponse.Freq, ampl);
        }
        #endregion


        // Фильтр
        public void CreateF(NWaves.Filters.Base64.IirFilter64 filter)
        {
            Vector a1 = new Vector(filter._a);
            Vector b1 = new Vector(filter._b);
            b = b1.CutAndZero(b1.Count / 2);
            a = a1.CutAndZero(a1.Count / 2);
            Pol = new ComplexVector(filter.Tf.Poles.Real, filter.Tf.Poles.Imag);
            FreqResp = filter.Tf.FrequencyResponse().Magnitude;
            FreqRespPh = filter.Tf.FrequencyResponse().PhaseUnwrapped;
            FreqRespPh *= 180.0 / Math.PI;
            GroupDel = filter.Tf.GroupDelay();
        }
    }
}
