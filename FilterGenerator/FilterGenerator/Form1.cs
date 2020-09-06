using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.Forms;
using MetroFramework.Forms;
using FilterGenerator.Controls.Forms;
using AI;
using FilterGenLogic;
using MetroFramework;
using AI.Charts.Forms;
using AI.DSP.Analyse;

namespace FilterGenerator
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        ProjectSettings project;
        MainLogic logic;
        SaveFileDialog saveFileDialog = new SaveFileDialog();
        OpenFileDialog openFileDialog = new OpenFileDialog();



        #region Файл
        // Создание проекта
        private void CreatProject_Click(object sender, EventArgs e)
        {
            ProjectCreator projectCreator = new ProjectCreator();
            if (projectCreator.ShowDialog() == DialogResult.OK)
            {
                project = projectCreator.settings;
                LoadProject();
            }
        }

        // Загрузка проекта
        private void OpenProject_Click(object sender, EventArgs e)
        {

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                project = ProjectSettings.Open(openFileDialog.FileName);
                LoadProject();
            }
        }

        // Сохранение
        private void СохранитьПроектToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                project.Save();
            }
            catch
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        project.Save(saveFileDialog.FileName);
                    }
                    catch { }
                }
            }

        }

        // Сохранить как
        private void SaveAs_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    project.Save(saveFileDialog.FileName);
                }
                catch { }
            }
        }

        // Выход
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Сохранить фильтр
        private void SaveFilt_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                logic.SaveAsBinary(saveFile.FileName, project.Name);
            }
        }


        // Загрузить фильтр
        private void LoadFilt_Click(object sender, EventArgs e)
        {
            OpenFileDialog saveFile = new OpenFileDialog();

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                logic.LoadAsBinary(saveFile.FileName);
            }
        }
        #endregion

        #region Фильтры

        #region Фильтр Бесселя

        // ФНЧ
        private void LowPasGen_Click(object sender, EventArgs e)
        {
            LowPass lowPass = new LowPass();
            if (DialogResult.OK == lowPass.ShowDialog())
            {
                logic.CalcLowFiltBess(lowPass.fPass, lowPass.fStop);
            }
            GenF();
        }
        // ФВЧ
        private void BessHPass_Click(object sender, EventArgs e)
        {
            LowPass lowPass = new LowPass(FilterType.HPass);
            if (DialogResult.OK == lowPass.ShowDialog())
            {
                logic.CalcHiFiltBess(lowPass.fPass, lowPass.fStop);
            }
            GenF();
        }



        #endregion


        #region Баттерворта
        private void ButterFilt_Click(object sender, EventArgs e)
        {

        }

        private void BLowFilt_Click(object sender, EventArgs e)
        {
            LowPass lowPass = new LowPass();
            if (DialogResult.OK == lowPass.ShowDialog())
            {
                logic.CalcLowFiltB(lowPass.aPass, lowPass.aStop, lowPass.fPass, lowPass.fStop);
            }
            GenF();
        }

        private void BHpass_Click(object sender, EventArgs e)
        {
            LowPass lowPass = new LowPass(FilterType.HPass);
            if (DialogResult.OK == lowPass.ShowDialog())
            {
                logic.CalcHiFiltB(lowPass.aPass, lowPass.aStop, lowPass.fPass, lowPass.fStop);
            }
            GenF();
        }

        #endregion

        #region Фильтр Чебышёва 1

        // ФВЧ
        private void Cheb1Hpass_Click(object sender, EventArgs e)
        {
            LowPass lowPass = new LowPass(FilterType.HPass);
            if (DialogResult.OK == lowPass.ShowDialog())
            {
                logic.CalcHiFiltCheb1(lowPass.aPass, lowPass.aStop, lowPass.fPass, lowPass.fStop);
            }
            GenF();
        }

        //ФНЧ
        private void Cheb1Low_Click(object sender, EventArgs e)
        {
            LowPass lowPass = new LowPass();
            if (DialogResult.OK == lowPass.ShowDialog())
            {
                logic.CalcLowFiltCheb1(lowPass.aPass, lowPass.aStop, lowPass.fPass, lowPass.fStop);
            }
            GenF();
        }

        #endregion


        #region Фильтр Чебышёва 2

        //ФНЧ
        private void Cheb2Low_Click(object sender, EventArgs e)
        {
            LowPass lowPass = new LowPass();
            if (DialogResult.OK == lowPass.ShowDialog())
            {
                logic.CalcLowFiltCheb2(lowPass.aPass, lowPass.aStop, lowPass.fPass, lowPass.fStop);
            }
            GenF();
        }

        //ФВЧ
        private void Cheb2H_Click(object sender, EventArgs e)
        {
            LowPass lowPass = new LowPass(FilterType.HPass);
            if (DialogResult.OK == lowPass.ShowDialog())
            {
                logic.CalcHiFiltCheb2(lowPass.aPass, lowPass.aStop, lowPass.fPass, lowPass.fStop);
            }
            GenF();
        }

        #endregion


        #region beQ

        //ФНЧ
        private void ФНЧToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            LowPass lowPass = new LowPass();
            if (DialogResult.OK == lowPass.ShowDialog())
            {
                logic.CalcLowFiltBeQ(lowPass.fPass);
            }
            GenF();
        }

        // ФВЧ
        private void BiQHPass_Click(object sender, EventArgs e)
        {
            LowPass lowPass = new LowPass(FilterType.HPass);
            if (DialogResult.OK == lowPass.ShowDialog())
            {
                logic.CalcHiFiltBeQ(lowPass.fPass);
            }
            GenF();
        }
        #endregion


        #region Эллиптический
        //ФНЧ
        private void LowEllip_Click(object sender, EventArgs e)
        {
            LowPass lowPass = new LowPass();
            if (DialogResult.OK == lowPass.ShowDialog())
            {
                logic.CalcLowFiltEll(lowPass.aPass, lowPass.aStop, lowPass.fPass, lowPass.fStop);
            }
            GenF();
        }

        //ФВЧ
        private void HPassEliptic_Click(object sender, EventArgs e)
        {
            LowPass lowPass = new LowPass(FilterType.HPass);
            if (DialogResult.OK == lowPass.ShowDialog())
            {
                logic.CalcHiFiltEll(lowPass.aPass, lowPass.aStop, lowPass.fPass, lowPass.fStop);
            }
            GenF();
        }

        #endregion

        #endregion

        // Тестирование АЧХ фильтра
        private void FreqResp_Click(object sender, EventArgs e)
        {
            var frequency = new FrequencyResponse(project.Fd);

            FreqRespForm freqRespForm = new FreqRespForm();

            if (DialogResult.OK == freqRespForm.ShowDialog())
            {
                frequency.FStart = int.Parse(freqRespForm.StartFreq.Text.Replace('.', ','));
                frequency.FEnd = int.Parse(freqRespForm.EndFreq.Text.Replace('.', ','));
                frequency.Step = double.Parse(freqRespForm.fStep.Text.Replace('.', ','));
                frequency.Time = double.Parse(freqRespForm.Time.Text.Replace('.', ','));

                FormChart form = new FormChart();
                form.ChartName = "АЧХ";
                form.LabelX = "Частота Гц";
                form.LabelY = "Коэффициент передачи";
                var dat = logic.FreqRespFilt(frequency);
                form.PlotBlack(dat.Item1, dat.Item2, "АЧХ");
                form.ShowDialog();
            }
        }


















        //Загрузка формы
        private void Form1_Load(object sender, EventArgs e)
        {

            // Подписи графиков
            chartVisual2.ChartName = "АЧХ";
            chartVisual2.LabelX = "Частота [Гц]";
            chartVisual2.LabelY = "Коэф. передачи";
            Vector f = Vector.Seq0(0.0001, 0.0004);
            Vector A = new Vector(f.Count) + 1;
            chartVisual2.AddPlot(f, A, "", Color.Blue);

            chartVisual3.ChartName = "ФЧХ";
            chartVisual3.LabelX = "Частота [Гц]";
            chartVisual3.LabelY = "Фаза [Град]";
            Vector ph = new Vector(f.Count) + 1;
            chartVisual3.AddPlot(f, ph, "", Color.Blue);


            chartVisual1.IsScale = false;
            chartVisual1.IsMoove = false;
            chartVisual1.IsShowXY = false;
            chartVisual1.IsContextMenu = false;
            ComplexVector c = new ComplexVector(new Vector(0.0));
            chartVisual1.ScatterComplexPlaneWithRing1(c, "Полюсы фильтра");
            MenuLock();
        }








        // Загрузка / создание проекта
        void LoadProject()
        {

            double step = project.Fd / 200.0;
            Vector f = Vector.Seq0(step, project.Fd / 2.0);
            Vector A = new Vector(f.Count) + 1;
            chartVisual2.Clear();
            chartVisual2.AddPlot(f, A, "", Color.Blue);

            projectStatus.Text = "Проект: \"" + project.Name + "\", частота дискретизации проекта: " + project.Fd + " [Гц]";
            projectStatus.ForeColor = Color.Green;
            metroProgressSpinner1.Value = 100;
            metroProgressSpinner1.Style = MetroColorStyle.Green;
            logic = new MainLogic(project.Fd); // Создание основной логики
            MenuUnLock();
        }

        // Блокировка меню при отсутствии проекта
        void MenuLock()
        {
            saveAs.Enabled = false;
            saveProj.Enabled = false;
            saveFilt.Enabled = false;
            iirGenMenu.Enabled = false;
            aboutProj.Enabled = false;
            analyseMenu.Enabled = false;
            loadFilt.Enabled = false;
        }

        // Разблокировка меню при отсутствии проекта
        void MenuUnLock()
        {
            saveAs.Enabled = true;
            saveProj.Enabled = true;
            saveFilt.Enabled = true;
            iirGenMenu.Enabled = true;
            aboutProj.Enabled = true;
            analyseMenu.Enabled = true;
            loadFilt.Enabled = true;
        }

        // Создание фильтра
        void GenF()
        {
            var f = Vector.Seq0(project.Fd / 512.0, project.Fd + 256);

            chartVisual2.Clear();
            chartVisual2.AddPlot(f, logic.FreqResp, "", Color.Blue, 1);

            chartVisual3.Clear();
            chartVisual3.AddPlot(f, logic.FreqRespPh, "", Color.Red, 1);


            chartVisual1.ScatterComplexPlaneWithRing1(logic.Pol, "Полюсы фильтра");
        }

        private void IirGenMenu_Click(object sender, EventArgs e)
        {

        }

      
    }
}
