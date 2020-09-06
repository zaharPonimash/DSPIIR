namespace FilterGenerator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creatProject = new System.Windows.Forms.ToolStripMenuItem();
            this.openProject = new System.Windows.Forms.ToolStripMenuItem();
            this.saveProj = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFilt = new System.Windows.Forms.ToolStripMenuItem();
            this.exitBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.analyseMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.freqResp = new System.Windows.Forms.ToolStripMenuItem();
            this.лЧМToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.аМКToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iirGenMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.butterFilt = new System.Windows.Forms.ToolStripMenuItem();
            this.BLowFilt = new System.Windows.Forms.ToolStripMenuItem();
            this.bHpass = new System.Windows.Forms.ToolStripMenuItem();
            this.пФToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.полоснозаграждающийToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.фильтрБесселяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lowPasGen = new System.Windows.Forms.ToolStripMenuItem();
            this.bessHPass = new System.Windows.Forms.ToolStripMenuItem();
            this.пФToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.полосноЗаграждающийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фильтрЧебышёваIгоРодаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cheb1Low = new System.Windows.Forms.ToolStripMenuItem();
            this.cheb1Hpass = new System.Windows.Forms.ToolStripMenuItem();
            this.пФToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.полоснозаграждающийToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.фильтрЧебышёваIIгоРодаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Cheb2Low = new System.Windows.Forms.ToolStripMenuItem();
            this.cheb2H = new System.Windows.Forms.ToolStripMenuItem();
            this.пФToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.полоснозаграждающийToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.эллиптическийФильтрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lowEllip = new System.Windows.Forms.ToolStripMenuItem();
            this.hPassEliptic = new System.Windows.Forms.ToolStripMenuItem();
            this.пФToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.полоснозаграждающийToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.биквадратичныйФильтрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фНЧToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.biQHPass = new System.Windows.Forms.ToolStripMenuItem();
            this.пФToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutProj = new System.Windows.Forms.ToolStripMenuItem();
            this.projectStatus = new System.Windows.Forms.Label();
            this.metroProgressSpinner1 = new MetroFramework.Controls.MetroProgressSpinner();
            this.chartVisual3 = new AI.Charts.Control.ChartVisual();
            this.chartVisual2 = new AI.Charts.Control.ChartVisual();
            this.chartVisual1 = new AI.Charts.Control.ChartVisual();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.analyseMenu,
            this.iirGenMenu,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(791, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creatProject,
            this.openProject,
            this.saveProj,
            this.saveAs,
            this.saveFilt,
            this.exitBtn});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // creatProject
            // 
            this.creatProject.Name = "creatProject";
            this.creatProject.Size = new System.Drawing.Size(177, 22);
            this.creatProject.Text = "Создать проект";
            this.creatProject.Click += new System.EventHandler(this.CreatProject_Click);
            // 
            // openProject
            // 
            this.openProject.Name = "openProject";
            this.openProject.Size = new System.Drawing.Size(177, 22);
            this.openProject.Text = "Открыть проект";
            this.openProject.Click += new System.EventHandler(this.OpenProject_Click);
            // 
            // saveProj
            // 
            this.saveProj.Name = "saveProj";
            this.saveProj.Size = new System.Drawing.Size(177, 22);
            this.saveProj.Text = "Сохранить проект";
            this.saveProj.Click += new System.EventHandler(this.СохранитьПроектToolStripMenuItem_Click);
            // 
            // saveAs
            // 
            this.saveAs.Name = "saveAs";
            this.saveAs.Size = new System.Drawing.Size(177, 22);
            this.saveAs.Text = "Сохранить как";
            this.saveAs.Click += new System.EventHandler(this.SaveAs_Click);
            // 
            // saveFilt
            // 
            this.saveFilt.Name = "saveFilt";
            this.saveFilt.Size = new System.Drawing.Size(177, 22);
            this.saveFilt.Text = "Сохранить фильтр";
            // 
            // exitBtn
            // 
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(177, 22);
            this.exitBtn.Text = "Выход";
            this.exitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // analyseMenu
            // 
            this.analyseMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.freqResp,
            this.лЧМToolStripMenuItem,
            this.аМКToolStripMenuItem});
            this.analyseMenu.Name = "analyseMenu";
            this.analyseMenu.Size = new System.Drawing.Size(95, 20);
            this.analyseMenu.Text = "Тестирование";
            // 
            // freqResp
            // 
            this.freqResp.Name = "freqResp";
            this.freqResp.Size = new System.Drawing.Size(101, 22);
            this.freqResp.Text = "АЧХ";
            this.freqResp.Click += new System.EventHandler(this.FreqResp_Click);
            // 
            // лЧМToolStripMenuItem
            // 
            this.лЧМToolStripMenuItem.Name = "лЧМToolStripMenuItem";
            this.лЧМToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.лЧМToolStripMenuItem.Text = "ЛЧМ";
            // 
            // аМКToolStripMenuItem
            // 
            this.аМКToolStripMenuItem.Name = "аМКToolStripMenuItem";
            this.аМКToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.аМКToolStripMenuItem.Text = "АМК";
            // 
            // iirGenMenu
            // 
            this.iirGenMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.butterFilt,
            this.фильтрБесселяToolStripMenuItem,
            this.фильтрЧебышёваIгоРодаToolStripMenuItem,
            this.фильтрЧебышёваIIгоРодаToolStripMenuItem,
            this.эллиптическийФильтрToolStripMenuItem,
            this.биквадратичныйФильтрToolStripMenuItem});
            this.iirGenMenu.Name = "iirGenMenu";
            this.iirGenMenu.Size = new System.Drawing.Size(83, 20);
            this.iirGenMenu.Text = "Бих фильтр";
            this.iirGenMenu.Click += new System.EventHandler(this.IirGenMenu_Click);
            // 
            // butterFilt
            // 
            this.butterFilt.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BLowFilt,
            this.bHpass,
            this.пФToolStripMenuItem5,
            this.полоснозаграждающийToolStripMenuItem4});
            this.butterFilt.Name = "butterFilt";
            this.butterFilt.Size = new System.Drawing.Size(232, 22);
            this.butterFilt.Text = "Фильтр Баттерворта";
            this.butterFilt.Click += new System.EventHandler(this.ButterFilt_Click);
            // 
            // BLowFilt
            // 
            this.BLowFilt.Name = "BLowFilt";
            this.BLowFilt.Size = new System.Drawing.Size(214, 22);
            this.BLowFilt.Text = "ФНЧ";
            this.BLowFilt.Click += new System.EventHandler(this.BLowFilt_Click);
            // 
            // bHpass
            // 
            this.bHpass.Name = "bHpass";
            this.bHpass.Size = new System.Drawing.Size(214, 22);
            this.bHpass.Text = "ФВЧ";
            this.bHpass.Click += new System.EventHandler(this.BHpass_Click);
            // 
            // пФToolStripMenuItem5
            // 
            this.пФToolStripMenuItem5.Name = "пФToolStripMenuItem5";
            this.пФToolStripMenuItem5.Size = new System.Drawing.Size(214, 22);
            this.пФToolStripMenuItem5.Text = "ПФ";
            // 
            // полоснозаграждающийToolStripMenuItem4
            // 
            this.полоснозаграждающийToolStripMenuItem4.Name = "полоснозаграждающийToolStripMenuItem4";
            this.полоснозаграждающийToolStripMenuItem4.Size = new System.Drawing.Size(214, 22);
            this.полоснозаграждающийToolStripMenuItem4.Text = "Полосно-заграждающий";
            // 
            // фильтрБесселяToolStripMenuItem
            // 
            this.фильтрБесселяToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lowPasGen,
            this.bessHPass,
            this.пФToolStripMenuItem,
            this.полосноЗаграждающийToolStripMenuItem});
            this.фильтрБесселяToolStripMenuItem.Name = "фильтрБесселяToolStripMenuItem";
            this.фильтрБесселяToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.фильтрБесселяToolStripMenuItem.Text = "Фильтр Бесселя";
            // 
            // lowPasGen
            // 
            this.lowPasGen.Name = "lowPasGen";
            this.lowPasGen.Size = new System.Drawing.Size(214, 22);
            this.lowPasGen.Text = "ФНЧ";
            this.lowPasGen.Click += new System.EventHandler(this.LowPasGen_Click);
            // 
            // bessHPass
            // 
            this.bessHPass.Name = "bessHPass";
            this.bessHPass.Size = new System.Drawing.Size(214, 22);
            this.bessHPass.Text = "ФВЧ";
            this.bessHPass.Click += new System.EventHandler(this.BessHPass_Click);
            // 
            // пФToolStripMenuItem
            // 
            this.пФToolStripMenuItem.Name = "пФToolStripMenuItem";
            this.пФToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.пФToolStripMenuItem.Text = "ПФ";
            // 
            // полосноЗаграждающийToolStripMenuItem
            // 
            this.полосноЗаграждающийToolStripMenuItem.Name = "полосноЗаграждающийToolStripMenuItem";
            this.полосноЗаграждающийToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.полосноЗаграждающийToolStripMenuItem.Text = "Полосно-заграждающий";
            // 
            // фильтрЧебышёваIгоРодаToolStripMenuItem
            // 
            this.фильтрЧебышёваIгоРодаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cheb1Low,
            this.cheb1Hpass,
            this.пФToolStripMenuItem1,
            this.полоснозаграждающийToolStripMenuItem1});
            this.фильтрЧебышёваIгоРодаToolStripMenuItem.Name = "фильтрЧебышёваIгоРодаToolStripMenuItem";
            this.фильтрЧебышёваIгоРодаToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.фильтрЧебышёваIгоРодаToolStripMenuItem.Text = "Фильтр Чебышёва I-го рода";
            // 
            // cheb1Low
            // 
            this.cheb1Low.Name = "cheb1Low";
            this.cheb1Low.Size = new System.Drawing.Size(214, 22);
            this.cheb1Low.Text = "ФНЧ";
            this.cheb1Low.Click += new System.EventHandler(this.Cheb1Low_Click);
            // 
            // cheb1Hpass
            // 
            this.cheb1Hpass.Name = "cheb1Hpass";
            this.cheb1Hpass.Size = new System.Drawing.Size(214, 22);
            this.cheb1Hpass.Text = "ФВЧ";
            this.cheb1Hpass.Click += new System.EventHandler(this.Cheb1Hpass_Click);
            // 
            // пФToolStripMenuItem1
            // 
            this.пФToolStripMenuItem1.Name = "пФToolStripMenuItem1";
            this.пФToolStripMenuItem1.Size = new System.Drawing.Size(214, 22);
            this.пФToolStripMenuItem1.Text = "ПФ";
            // 
            // полоснозаграждающийToolStripMenuItem1
            // 
            this.полоснозаграждающийToolStripMenuItem1.Name = "полоснозаграждающийToolStripMenuItem1";
            this.полоснозаграждающийToolStripMenuItem1.Size = new System.Drawing.Size(214, 22);
            this.полоснозаграждающийToolStripMenuItem1.Text = "Полосно-заграждающий";
            // 
            // фильтрЧебышёваIIгоРодаToolStripMenuItem
            // 
            this.фильтрЧебышёваIIгоРодаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Cheb2Low,
            this.cheb2H,
            this.пФToolStripMenuItem2,
            this.полоснозаграждающийToolStripMenuItem2});
            this.фильтрЧебышёваIIгоРодаToolStripMenuItem.Name = "фильтрЧебышёваIIгоРодаToolStripMenuItem";
            this.фильтрЧебышёваIIгоРодаToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.фильтрЧебышёваIIгоРодаToolStripMenuItem.Text = "Фильтр Чебышёва II-го рода";
            // 
            // Cheb2Low
            // 
            this.Cheb2Low.Name = "Cheb2Low";
            this.Cheb2Low.Size = new System.Drawing.Size(214, 22);
            this.Cheb2Low.Text = "ФНЧ";
            this.Cheb2Low.Click += new System.EventHandler(this.Cheb2Low_Click);
            // 
            // cheb2H
            // 
            this.cheb2H.Name = "cheb2H";
            this.cheb2H.Size = new System.Drawing.Size(214, 22);
            this.cheb2H.Text = "ФВЧ";
            this.cheb2H.Click += new System.EventHandler(this.Cheb2H_Click);
            // 
            // пФToolStripMenuItem2
            // 
            this.пФToolStripMenuItem2.Name = "пФToolStripMenuItem2";
            this.пФToolStripMenuItem2.Size = new System.Drawing.Size(214, 22);
            this.пФToolStripMenuItem2.Text = "ПФ";
            // 
            // полоснозаграждающийToolStripMenuItem2
            // 
            this.полоснозаграждающийToolStripMenuItem2.Name = "полоснозаграждающийToolStripMenuItem2";
            this.полоснозаграждающийToolStripMenuItem2.Size = new System.Drawing.Size(214, 22);
            this.полоснозаграждающийToolStripMenuItem2.Text = "Полосно-заграждающий";
            // 
            // эллиптическийФильтрToolStripMenuItem
            // 
            this.эллиптическийФильтрToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lowEllip,
            this.hPassEliptic,
            this.пФToolStripMenuItem3,
            this.полоснозаграждающийToolStripMenuItem3});
            this.эллиптическийФильтрToolStripMenuItem.Name = "эллиптическийФильтрToolStripMenuItem";
            this.эллиптическийФильтрToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.эллиптическийФильтрToolStripMenuItem.Text = "Эллиптический фильтр";
            // 
            // lowEllip
            // 
            this.lowEllip.Name = "lowEllip";
            this.lowEllip.Size = new System.Drawing.Size(214, 22);
            this.lowEllip.Text = "ФНЧ";
            this.lowEllip.Click += new System.EventHandler(this.LowEllip_Click);
            // 
            // hPassEliptic
            // 
            this.hPassEliptic.Name = "hPassEliptic";
            this.hPassEliptic.Size = new System.Drawing.Size(214, 22);
            this.hPassEliptic.Text = "ФВЧ";
            this.hPassEliptic.Click += new System.EventHandler(this.HPassEliptic_Click);
            // 
            // пФToolStripMenuItem3
            // 
            this.пФToolStripMenuItem3.Name = "пФToolStripMenuItem3";
            this.пФToolStripMenuItem3.Size = new System.Drawing.Size(214, 22);
            this.пФToolStripMenuItem3.Text = "ПФ";
            // 
            // полоснозаграждающийToolStripMenuItem3
            // 
            this.полоснозаграждающийToolStripMenuItem3.Name = "полоснозаграждающийToolStripMenuItem3";
            this.полоснозаграждающийToolStripMenuItem3.Size = new System.Drawing.Size(214, 22);
            this.полоснозаграждающийToolStripMenuItem3.Text = "Полосно-заграждающий";
            // 
            // биквадратичныйФильтрToolStripMenuItem
            // 
            this.биквадратичныйФильтрToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.фНЧToolStripMenuItem4,
            this.biQHPass,
            this.пФToolStripMenuItem4});
            this.биквадратичныйФильтрToolStripMenuItem.Name = "биквадратичныйФильтрToolStripMenuItem";
            this.биквадратичныйФильтрToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.биквадратичныйФильтрToolStripMenuItem.Text = "Биквадратный фильтр";
            // 
            // фНЧToolStripMenuItem4
            // 
            this.фНЧToolStripMenuItem4.Name = "фНЧToolStripMenuItem4";
            this.фНЧToolStripMenuItem4.Size = new System.Drawing.Size(100, 22);
            this.фНЧToolStripMenuItem4.Text = "ФНЧ";
            this.фНЧToolStripMenuItem4.Click += new System.EventHandler(this.ФНЧToolStripMenuItem4_Click);
            // 
            // biQHPass
            // 
            this.biQHPass.Name = "biQHPass";
            this.biQHPass.Size = new System.Drawing.Size(100, 22);
            this.biQHPass.Text = "ФВЧ";
            this.biQHPass.Click += new System.EventHandler(this.BiQHPass_Click);
            // 
            // пФToolStripMenuItem4
            // 
            this.пФToolStripMenuItem4.Name = "пФToolStripMenuItem4";
            this.пФToolStripMenuItem4.Size = new System.Drawing.Size(100, 22);
            this.пФToolStripMenuItem4.Text = "ПФ";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem,
            this.aboutProj});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.справкаToolStripMenuItem.Text = "Информация";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // aboutProj
            // 
            this.aboutProj.Name = "aboutProj";
            this.aboutProj.Size = new System.Drawing.Size(149, 22);
            this.aboutProj.Text = "О проекте";
            // 
            // projectStatus
            // 
            this.projectStatus.AutoSize = true;
            this.projectStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.projectStatus.ForeColor = System.Drawing.Color.Red;
            this.projectStatus.Location = new System.Drawing.Point(51, 482);
            this.projectStatus.Name = "projectStatus";
            this.projectStatus.Size = new System.Drawing.Size(144, 15);
            this.projectStatus.TabIndex = 4;
            this.projectStatus.Text = "Нет активного проекта";
            // 
            // metroProgressSpinner1
            // 
            this.metroProgressSpinner1.Location = new System.Drawing.Point(24, 482);
            this.metroProgressSpinner1.Maximum = 100;
            this.metroProgressSpinner1.Name = "metroProgressSpinner1";
            this.metroProgressSpinner1.Size = new System.Drawing.Size(21, 21);
            this.metroProgressSpinner1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroProgressSpinner1.TabIndex = 5;
            // 
            // chartVisual3
            // 
            this.chartVisual3.AutoScroll = true;
            this.chartVisual3.BackColor = System.Drawing.Color.White;
            this.chartVisual3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chartVisual3.ChartName = "График";
            this.chartVisual3.ForeColor = System.Drawing.Color.Black;
            this.chartVisual3.IsContextMenu = true;
            this.chartVisual3.IsLogScale = false;
            this.chartVisual3.IsMoove = true;
            this.chartVisual3.IsScale = true;
            this.chartVisual3.IsShowXY = true;
            this.chartVisual3.LabelX = "Ось Х";
            this.chartVisual3.LabelY = "Ось Y";
            this.chartVisual3.Location = new System.Drawing.Point(24, 99);
            this.chartVisual3.Name = "chartVisual3";
            this.chartVisual3.Size = new System.Drawing.Size(373, 175);
            this.chartVisual3.TabIndex = 6;
            // 
            // chartVisual2
            // 
            this.chartVisual2.AutoScroll = true;
            this.chartVisual2.BackColor = System.Drawing.Color.White;
            this.chartVisual2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chartVisual2.ChartName = "График";
            this.chartVisual2.ForeColor = System.Drawing.Color.Black;
            this.chartVisual2.IsContextMenu = true;
            this.chartVisual2.IsLogScale = false;
            this.chartVisual2.IsMoove = true;
            this.chartVisual2.IsScale = true;
            this.chartVisual2.IsShowXY = true;
            this.chartVisual2.LabelX = "Ось Х";
            this.chartVisual2.LabelY = "Ось Y";
            this.chartVisual2.Location = new System.Drawing.Point(24, 280);
            this.chartVisual2.Name = "chartVisual2";
            this.chartVisual2.Size = new System.Drawing.Size(373, 196);
            this.chartVisual2.TabIndex = 3;
            // 
            // chartVisual1
            // 
            this.chartVisual1.AutoScroll = true;
            this.chartVisual1.BackColor = System.Drawing.Color.White;
            this.chartVisual1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chartVisual1.ChartName = "График";
            this.chartVisual1.ForeColor = System.Drawing.Color.Black;
            this.chartVisual1.IsContextMenu = true;
            this.chartVisual1.IsLogScale = false;
            this.chartVisual1.IsMoove = true;
            this.chartVisual1.IsScale = true;
            this.chartVisual1.IsShowXY = true;
            this.chartVisual1.LabelX = "Ось Х";
            this.chartVisual1.LabelY = "Ось Y";
            this.chartVisual1.Location = new System.Drawing.Point(403, 99);
            this.chartVisual1.Name = "chartVisual1";
            this.chartVisual1.Size = new System.Drawing.Size(395, 377);
            this.chartVisual1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(831, 534);
            this.Controls.Add(this.chartVisual3);
            this.Controls.Add(this.metroProgressSpinner1);
            this.Controls.Add(this.projectStatus);
            this.Controls.Add(this.chartVisual2);
            this.Controls.Add(this.chartVisual1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(831, 534);
            this.MinimumSize = new System.Drawing.Size(831, 534);
            this.Name = "Form1";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "IIR Filter Designer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creatProject;
        private System.Windows.Forms.ToolStripMenuItem openProject;
        private System.Windows.Forms.ToolStripMenuItem saveProj;
        private System.Windows.Forms.ToolStripMenuItem saveFilt;
        private System.Windows.Forms.ToolStripMenuItem exitBtn;
        private System.Windows.Forms.ToolStripMenuItem analyseMenu;
        private System.Windows.Forms.ToolStripMenuItem freqResp;
        private System.Windows.Forms.ToolStripMenuItem лЧМToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem аМКToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iirGenMenu;
        private System.Windows.Forms.ToolStripMenuItem фильтрБесселяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lowPasGen;
        private System.Windows.Forms.ToolStripMenuItem bessHPass;
        private System.Windows.Forms.ToolStripMenuItem пФToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem полосноЗаграждающийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фильтрЧебышёваIгоРодаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cheb1Low;
        private System.Windows.Forms.ToolStripMenuItem cheb1Hpass;
        private System.Windows.Forms.ToolStripMenuItem пФToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem полоснозаграждающийToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem фильтрЧебышёваIIгоРодаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Cheb2Low;
        private System.Windows.Forms.ToolStripMenuItem cheb2H;
        private System.Windows.Forms.ToolStripMenuItem пФToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem полоснозаграждающийToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem эллиптическийФильтрToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lowEllip;
        private System.Windows.Forms.ToolStripMenuItem hPassEliptic;
        private System.Windows.Forms.ToolStripMenuItem пФToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem полоснозаграждающийToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem биквадратичныйФильтрToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фНЧToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem biQHPass;
        private System.Windows.Forms.ToolStripMenuItem пФToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private AI.Charts.Control.ChartVisual chartVisual1;
        private AI.Charts.Control.ChartVisual chartVisual2;
        private System.Windows.Forms.Label projectStatus;
        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner1;
        private System.Windows.Forms.ToolStripMenuItem saveAs;
        private System.Windows.Forms.ToolStripMenuItem aboutProj;
        private AI.Charts.Control.ChartVisual chartVisual3;
        private System.Windows.Forms.ToolStripMenuItem butterFilt;
        private System.Windows.Forms.ToolStripMenuItem BLowFilt;
        private System.Windows.Forms.ToolStripMenuItem bHpass;
        private System.Windows.Forms.ToolStripMenuItem пФToolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem полоснозаграждающийToolStripMenuItem4;
    }
}

