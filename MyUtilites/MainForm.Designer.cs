namespace MyUtilites
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.блокнотToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiInsertDate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiInsertTime = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tbTo = new System.Windows.Forms.TextBox();
            this.tbFrom = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.cbTo = new System.Windows.Forms.ComboBox();
            this.cbFrom = new System.Windows.Forms.ComboBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnAddToList = new System.Windows.Forms.Button();
            this.tbAddToList = new System.Windows.Forms.TextBox();
            this.btnAddCountToList = new System.Windows.Forms.Button();
            this.lbCountList = new System.Windows.Forms.ListBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbAutoCopy = new System.Windows.Forms.CheckBox();
            this.cbAutoClear = new System.Windows.Forms.CheckBox();
            this.lblCheatNum = new System.Windows.Forms.Label();
            this.lblCheatLvl = new System.Windows.Forms.Label();
            this.nudCheatLvl = new System.Windows.Forms.NumericUpDown();
            this.nudCheatNum = new System.Windows.Forms.NumericUpDown();
            this.btnAboutModes = new System.Windows.Forms.Button();
            this.cbBalanceMode = new System.Windows.Forms.CheckBox();
            this.cbCheatMode = new System.Windows.Forms.CheckBox();
            this.cbAutoGen = new System.Windows.Forms.CheckBox();
            this.nudNumGen = new System.Windows.Forms.NumericUpDown();
            this.lblNumGen = new System.Windows.Forms.Label();
            this.cbNonRepiteMode = new System.Windows.Forms.CheckBox();
            this.btRanCopy = new System.Windows.Forms.Button();
            this.tbRanClear = new System.Windows.Forms.Button();
            this.tbRandom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudMax = new System.Windows.Forms.NumericUpDown();
            this.nudMin = new System.Windows.Forms.NumericUpDown();
            this.lblRandom = new System.Windows.Forms.Label();
            this.btnRandom = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.rtbNotepad = new System.Windows.Forms.RichTextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.btnCreatePass = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nudPassLength = new System.Windows.Forms.NumericUpDown();
            this.clbPass = new System.Windows.Forms.CheckedListBox();
            this.btnSwap = new System.Windows.Forms.Button();
            this.cbMertric = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCheatLvl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCheatNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumGen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPassLength)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.блокнотToolStripMenuItem,
            this.помощьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(436, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiExit});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(108, 22);
            this.tsmiExit.Text = "Выход";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // блокнотToolStripMenuItem
            // 
            this.блокнотToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiInsertDate,
            this.tsmiInsertTime,
            this.toolStripMenuItem1,
            this.tsmiSave,
            this.tsmiLoad});
            this.блокнотToolStripMenuItem.Name = "блокнотToolStripMenuItem";
            this.блокнотToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.блокнотToolStripMenuItem.Text = "Блокнот";
            // 
            // tsmiInsertDate
            // 
            this.tsmiInsertDate.Name = "tsmiInsertDate";
            this.tsmiInsertDate.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D)));
            this.tsmiInsertDate.Size = new System.Drawing.Size(232, 22);
            this.tsmiInsertDate.Text = "Вставить дату";
            this.tsmiInsertDate.Click += new System.EventHandler(this.tsmiInsertDate_Click);
            // 
            // tsmiInsertTime
            // 
            this.tsmiInsertTime.Name = "tsmiInsertTime";
            this.tsmiInsertTime.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.T)));
            this.tsmiInsertTime.Size = new System.Drawing.Size(232, 22);
            this.tsmiInsertTime.Text = "Вставить время";
            this.tsmiInsertTime.Click += new System.EventHandler(this.tsmiInsertTime_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(229, 6);
            // 
            // tsmiSave
            // 
            this.tsmiSave.Name = "tsmiSave";
            this.tsmiSave.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.tsmiSave.Size = new System.Drawing.Size(232, 22);
            this.tsmiSave.Text = "Сохранить";
            this.tsmiSave.Click += new System.EventHandler(this.tsmiSave_Click);
            // 
            // tsmiLoad
            // 
            this.tsmiLoad.Name = "tsmiLoad";
            this.tsmiLoad.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.L)));
            this.tsmiLoad.Size = new System.Drawing.Size(232, 22);
            this.tsmiLoad.Text = "Загрузить";
            this.tsmiLoad.Click += new System.EventHandler(this.tsmiLoad_Click);
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAbout});
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.помощьToolStripMenuItem.Text = "Помощь";
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(149, 22);
            this.tsmiAbout.Text = "О программе";
            this.tsmiAbout.Click += new System.EventHandler(this.tsmiAbout_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(436, 380);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.cbMertric);
            this.tabPage5.Controls.Add(this.btnSwap);
            this.tabPage5.Controls.Add(this.tbTo);
            this.tabPage5.Controls.Add(this.tbFrom);
            this.tabPage5.Controls.Add(this.btnConvert);
            this.tabPage5.Controls.Add(this.cbTo);
            this.tabPage5.Controls.Add(this.cbFrom);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(428, 354);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Конвертер";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tbTo
            // 
            this.tbTo.Location = new System.Drawing.Point(219, 130);
            this.tbTo.Name = "tbTo";
            this.tbTo.ReadOnly = true;
            this.tbTo.Size = new System.Drawing.Size(100, 20);
            this.tbTo.TabIndex = 6;
            // 
            // tbFrom
            // 
            this.tbFrom.Location = new System.Drawing.Point(8, 130);
            this.tbFrom.Name = "tbFrom";
            this.tbFrom.Size = new System.Drawing.Size(100, 20);
            this.tbFrom.TabIndex = 4;
            this.tbFrom.Text = "1";
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(114, 130);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(99, 23);
            this.btnConvert.TabIndex = 3;
            this.btnConvert.Text = "Конвертировать";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // cbTo
            // 
            this.cbTo.FormattingEnabled = true;
            this.cbTo.Items.AddRange(new object[] {
            "mm",
            "cm",
            "dm",
            "m",
            "km",
            "mile"});
            this.cbTo.Location = new System.Drawing.Point(219, 89);
            this.cbTo.Name = "cbTo";
            this.cbTo.Size = new System.Drawing.Size(100, 21);
            this.cbTo.TabIndex = 2;
            this.cbTo.Text = "mm";
            // 
            // cbFrom
            // 
            this.cbFrom.FormattingEnabled = true;
            this.cbFrom.Items.AddRange(new object[] {
            "mm",
            "cm",
            "dm",
            "m",
            "km",
            "mile"});
            this.cbFrom.Location = new System.Drawing.Point(8, 89);
            this.cbFrom.Name = "cbFrom";
            this.cbFrom.Size = new System.Drawing.Size(100, 21);
            this.cbFrom.TabIndex = 0;
            this.cbFrom.Text = "mm";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnAddToList);
            this.tabPage1.Controls.Add(this.tbAddToList);
            this.tabPage1.Controls.Add(this.btnAddCountToList);
            this.tabPage1.Controls.Add(this.lbCountList);
            this.tabPage1.Controls.Add(this.lblCount);
            this.tabPage1.Controls.Add(this.btnReset);
            this.tabPage1.Controls.Add(this.btnMinus);
            this.tabPage1.Controls.Add(this.btnPlus);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(428, 354);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Счетчик";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnAddToList
            // 
            this.btnAddToList.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddToList.Location = new System.Drawing.Point(267, 158);
            this.btnAddToList.Name = "btnAddToList";
            this.btnAddToList.Size = new System.Drawing.Size(153, 36);
            this.btnAddToList.TabIndex = 9;
            this.btnAddToList.Text = "Добавить в список";
            this.btnAddToList.UseVisualStyleBackColor = true;
            this.btnAddToList.Click += new System.EventHandler(this.btnAddToList_Click);
            // 
            // tbAddToList
            // 
            this.tbAddToList.Location = new System.Drawing.Point(267, 132);
            this.tbAddToList.Name = "tbAddToList";
            this.tbAddToList.Size = new System.Drawing.Size(153, 20);
            this.tbAddToList.TabIndex = 8;
            this.tbAddToList.TextChanged += new System.EventHandler(this.tbAddToList_TextChanged);
            // 
            // btnAddCountToList
            // 
            this.btnAddCountToList.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddCountToList.Location = new System.Drawing.Point(180, 48);
            this.btnAddCountToList.Name = "btnAddCountToList";
            this.btnAddCountToList.Size = new System.Drawing.Size(80, 36);
            this.btnAddCountToList.TabIndex = 7;
            this.btnAddCountToList.Text = "Добавить";
            this.btnAddCountToList.UseVisualStyleBackColor = true;
            this.btnAddCountToList.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbCountList
            // 
            this.lbCountList.FormattingEnabled = true;
            this.lbCountList.Location = new System.Drawing.Point(8, 132);
            this.lbCountList.Name = "lbCountList";
            this.lbCountList.Size = new System.Drawing.Size(252, 173);
            this.lbCountList.TabIndex = 6;
            this.lbCountList.SelectedIndexChanged += new System.EventHandler(this.lbCountList_SelectedIndexChanged);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCount.Location = new System.Drawing.Point(120, 49);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(26, 30);
            this.lblCount.TabIndex = 5;
            this.lblCount.Text = "0";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReset.Location = new System.Drawing.Point(8, 48);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(80, 36);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Сброс";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMinus.Location = new System.Drawing.Point(94, 90);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(80, 36);
            this.btnMinus.TabIndex = 2;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPlus.Location = new System.Drawing.Point(94, 6);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(80, 36);
            this.btnPlus.TabIndex = 0;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cbAutoCopy);
            this.tabPage2.Controls.Add(this.cbAutoClear);
            this.tabPage2.Controls.Add(this.lblCheatNum);
            this.tabPage2.Controls.Add(this.lblCheatLvl);
            this.tabPage2.Controls.Add(this.nudCheatLvl);
            this.tabPage2.Controls.Add(this.nudCheatNum);
            this.tabPage2.Controls.Add(this.btnAboutModes);
            this.tabPage2.Controls.Add(this.cbBalanceMode);
            this.tabPage2.Controls.Add(this.cbCheatMode);
            this.tabPage2.Controls.Add(this.cbAutoGen);
            this.tabPage2.Controls.Add(this.nudNumGen);
            this.tabPage2.Controls.Add(this.lblNumGen);
            this.tabPage2.Controls.Add(this.cbNonRepiteMode);
            this.tabPage2.Controls.Add(this.btRanCopy);
            this.tabPage2.Controls.Add(this.tbRanClear);
            this.tabPage2.Controls.Add(this.tbRandom);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.nudMax);
            this.tabPage2.Controls.Add(this.nudMin);
            this.tabPage2.Controls.Add(this.lblRandom);
            this.tabPage2.Controls.Add(this.btnRandom);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(428, 354);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Генератор";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cbAutoCopy
            // 
            this.cbAutoCopy.AutoSize = true;
            this.cbAutoCopy.Location = new System.Drawing.Point(13, 198);
            this.cbAutoCopy.Name = "cbAutoCopy";
            this.cbAutoCopy.Size = new System.Drawing.Size(116, 17);
            this.cbAutoCopy.TabIndex = 21;
            this.cbAutoCopy.Text = "Автокопирование";
            this.cbAutoCopy.UseVisualStyleBackColor = true;
            // 
            // cbAutoClear
            // 
            this.cbAutoClear.AutoSize = true;
            this.cbAutoClear.Location = new System.Drawing.Point(13, 175);
            this.cbAutoClear.Name = "cbAutoClear";
            this.cbAutoClear.Size = new System.Drawing.Size(90, 17);
            this.cbAutoClear.TabIndex = 20;
            this.cbAutoClear.Text = "Автоочистка";
            this.cbAutoClear.UseVisualStyleBackColor = true;
            // 
            // lblCheatNum
            // 
            this.lblCheatNum.AutoSize = true;
            this.lblCheatNum.Location = new System.Drawing.Point(138, 304);
            this.lblCheatNum.Name = "lblCheatNum";
            this.lblCheatNum.Size = new System.Drawing.Size(78, 13);
            this.lblCheatNum.TabIndex = 19;
            this.lblCheatNum.Text = "Нужное число";
            // 
            // lblCheatLvl
            // 
            this.lblCheatLvl.AutoSize = true;
            this.lblCheatLvl.Location = new System.Drawing.Point(138, 330);
            this.lblCheatLvl.Name = "lblCheatLvl";
            this.lblCheatLvl.Size = new System.Drawing.Size(123, 13);
            this.lblCheatLvl.TabIndex = 18;
            this.lblCheatLvl.Text = "Степень жульничества";
            // 
            // nudCheatLvl
            // 
            this.nudCheatLvl.Location = new System.Drawing.Point(13, 328);
            this.nudCheatLvl.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudCheatLvl.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCheatLvl.Name = "nudCheatLvl";
            this.nudCheatLvl.Size = new System.Drawing.Size(120, 20);
            this.nudCheatLvl.TabIndex = 17;
            this.nudCheatLvl.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudCheatNum
            // 
            this.nudCheatNum.Location = new System.Drawing.Point(13, 302);
            this.nudCheatNum.Name = "nudCheatNum";
            this.nudCheatNum.Size = new System.Drawing.Size(120, 20);
            this.nudCheatNum.TabIndex = 16;
            this.nudCheatNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAboutModes
            // 
            this.btnAboutModes.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAboutModes.Location = new System.Drawing.Point(336, 279);
            this.btnAboutModes.Name = "btnAboutModes";
            this.btnAboutModes.Size = new System.Drawing.Size(84, 67);
            this.btnAboutModes.TabIndex = 15;
            this.btnAboutModes.Text = "О\r\nрежимах";
            this.btnAboutModes.UseVisualStyleBackColor = true;
            this.btnAboutModes.Click += new System.EventHandler(this.btnAboutModes_Click);
            // 
            // cbBalanceMode
            // 
            this.cbBalanceMode.AutoSize = true;
            this.cbBalanceMode.Location = new System.Drawing.Point(13, 256);
            this.cbBalanceMode.Name = "cbBalanceMode";
            this.cbBalanceMode.Size = new System.Drawing.Size(124, 17);
            this.cbBalanceMode.TabIndex = 14;
            this.cbBalanceMode.Text = "Режим равновесия";
            this.cbBalanceMode.UseVisualStyleBackColor = true;
            this.cbBalanceMode.CheckedChanged += new System.EventHandler(this.cbBalanceMode_CheckedChanged);
            // 
            // cbCheatMode
            // 
            this.cbCheatMode.AutoSize = true;
            this.cbCheatMode.Location = new System.Drawing.Point(13, 279);
            this.cbCheatMode.Name = "cbCheatMode";
            this.cbCheatMode.Size = new System.Drawing.Size(101, 17);
            this.cbCheatMode.TabIndex = 13;
            this.cbCheatMode.Text = "Режим жулика";
            this.cbCheatMode.UseVisualStyleBackColor = true;
            this.cbCheatMode.CheckedChanged += new System.EventHandler(this.cbCheatMode_CheckedChanged);
            // 
            // cbAutoGen
            // 
            this.cbAutoGen.AutoSize = true;
            this.cbAutoGen.Location = new System.Drawing.Point(11, 50);
            this.cbAutoGen.Name = "cbAutoGen";
            this.cbAutoGen.Size = new System.Drawing.Size(140, 17);
            this.cbAutoGen.TabIndex = 12;
            this.cbAutoGen.Text = "Режим автогенерации";
            this.cbAutoGen.UseVisualStyleBackColor = true;
            this.cbAutoGen.CheckedChanged += new System.EventHandler(this.cbNumGen_CheckedChanged);
            // 
            // nudNumGen
            // 
            this.nudNumGen.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudNumGen.Location = new System.Drawing.Point(247, 18);
            this.nudNumGen.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudNumGen.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumGen.Name = "nudNumGen";
            this.nudNumGen.Size = new System.Drawing.Size(81, 34);
            this.nudNumGen.TabIndex = 11;
            this.nudNumGen.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // lblNumGen
            // 
            this.lblNumGen.AutoSize = true;
            this.lblNumGen.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNumGen.Location = new System.Drawing.Point(6, 20);
            this.lblNumGen.Name = "lblNumGen";
            this.lblNumGen.Size = new System.Drawing.Size(235, 27);
            this.lblNumGen.TabIndex = 10;
            this.lblNumGen.Text = "Количество генераций:";
            // 
            // cbNonRepiteMode
            // 
            this.cbNonRepiteMode.AutoSize = true;
            this.cbNonRepiteMode.Location = new System.Drawing.Point(13, 233);
            this.cbNonRepiteMode.Name = "cbNonRepiteMode";
            this.cbNonRepiteMode.Size = new System.Drawing.Size(132, 17);
            this.cbNonRepiteMode.TabIndex = 9;
            this.cbNonRepiteMode.Text = "Режим без повторов";
            this.cbNonRepiteMode.UseVisualStyleBackColor = true;
            this.cbNonRepiteMode.CheckedChanged += new System.EventHandler(this.cbNonRepite_CheckedChanged);
            // 
            // btRanCopy
            // 
            this.btRanCopy.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btRanCopy.Location = new System.Drawing.Point(230, 228);
            this.btRanCopy.Name = "btRanCopy";
            this.btRanCopy.Size = new System.Drawing.Size(100, 45);
            this.btRanCopy.TabIndex = 8;
            this.btRanCopy.Text = "Копировать";
            this.btRanCopy.UseVisualStyleBackColor = true;
            this.btRanCopy.Click += new System.EventHandler(this.btRanCopy_Click);
            // 
            // tbRanClear
            // 
            this.tbRanClear.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbRanClear.Location = new System.Drawing.Point(230, 178);
            this.tbRanClear.Name = "tbRanClear";
            this.tbRanClear.Size = new System.Drawing.Size(100, 45);
            this.tbRanClear.TabIndex = 7;
            this.tbRanClear.Text = "Очистить";
            this.tbRanClear.UseVisualStyleBackColor = true;
            this.tbRanClear.Click += new System.EventHandler(this.tbRanClear_Click);
            // 
            // tbRandom
            // 
            this.tbRandom.Location = new System.Drawing.Point(336, 20);
            this.tbRandom.Multiline = true;
            this.tbRandom.Name = "tbRandom";
            this.tbRandom.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbRandom.Size = new System.Drawing.Size(84, 253);
            this.tbRandom.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "До";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(8, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "От";
            // 
            // nudMax
            // 
            this.nudMax.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudMax.Location = new System.Drawing.Point(51, 135);
            this.nudMax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMax.Name = "nudMax";
            this.nudMax.Size = new System.Drawing.Size(59, 34);
            this.nudMax.TabIndex = 3;
            this.nudMax.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudMax.ValueChanged += new System.EventHandler(this.nudMax_ValueChanged);
            // 
            // nudMin
            // 
            this.nudMin.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudMin.Location = new System.Drawing.Point(50, 89);
            this.nudMin.Name = "nudMin";
            this.nudMin.Size = new System.Drawing.Size(60, 34);
            this.nudMin.TabIndex = 2;
            this.nudMin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMin.ValueChanged += new System.EventHandler(this.nudMin_ValueChanged);
            // 
            // lblRandom
            // 
            this.lblRandom.AutoSize = true;
            this.lblRandom.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRandom.Location = new System.Drawing.Point(266, 142);
            this.lblRandom.Name = "lblRandom";
            this.lblRandom.Size = new System.Drawing.Size(24, 27);
            this.lblRandom.TabIndex = 1;
            this.lblRandom.Text = "0";
            // 
            // btnRandom
            // 
            this.btnRandom.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRandom.Location = new System.Drawing.Point(230, 87);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(100, 40);
            this.btnRandom.TabIndex = 0;
            this.btnRandom.Text = "Начать";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.rtbNotepad);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(428, 354);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Блокнот";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // rtbNotepad
            // 
            this.rtbNotepad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbNotepad.Location = new System.Drawing.Point(0, 0);
            this.rtbNotepad.Name = "rtbNotepad";
            this.rtbNotepad.Size = new System.Drawing.Size(428, 354);
            this.rtbNotepad.TabIndex = 0;
            this.rtbNotepad.Text = "";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.tbPass);
            this.tabPage4.Controls.Add(this.btnCreatePass);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Controls.Add(this.nudPassLength);
            this.tabPage4.Controls.Add(this.clbPass);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(428, 354);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Пароли";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(28, 134);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(150, 20);
            this.tbPass.TabIndex = 4;
            // 
            // btnCreatePass
            // 
            this.btnCreatePass.Location = new System.Drawing.Point(28, 104);
            this.btnCreatePass.Name = "btnCreatePass";
            this.btnCreatePass.Size = new System.Drawing.Size(150, 23);
            this.btnCreatePass.TabIndex = 3;
            this.btnCreatePass.Text = "Создать пароль";
            this.btnCreatePass.UseVisualStyleBackColor = true;
            this.btnCreatePass.Click += new System.EventHandler(this.btnCreatePass_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Длина пароля";
            // 
            // nudPassLength
            // 
            this.nudPassLength.Location = new System.Drawing.Point(110, 74);
            this.nudPassLength.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudPassLength.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudPassLength.Name = "nudPassLength";
            this.nudPassLength.Size = new System.Drawing.Size(68, 20);
            this.nudPassLength.TabIndex = 1;
            this.nudPassLength.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // clbPass
            // 
            this.clbPass.CheckOnClick = true;
            this.clbPass.FormattingEnabled = true;
            this.clbPass.Items.AddRange(new object[] {
            "Цифры",
            "Прописные буквы",
            "Строчные буквы",
            "Спец. символы: %,*,),?,#,$,^,&,~"});
            this.clbPass.Location = new System.Drawing.Point(9, 4);
            this.clbPass.Name = "clbPass";
            this.clbPass.Size = new System.Drawing.Size(196, 64);
            this.clbPass.TabIndex = 0;
            // 
            // btnSwap
            // 
            this.btnSwap.Location = new System.Drawing.Point(127, 87);
            this.btnSwap.Name = "btnSwap";
            this.btnSwap.Size = new System.Drawing.Size(75, 23);
            this.btnSwap.TabIndex = 7;
            this.btnSwap.Text = "<->";
            this.btnSwap.UseVisualStyleBackColor = true;
            this.btnSwap.Click += new System.EventHandler(this.btnSwap_Click);
            // 
            // cbMertric
            // 
            this.cbMertric.FormattingEnabled = true;
            this.cbMertric.Items.AddRange(new object[] {
            "длина",
            "вес"});
            this.cbMertric.Location = new System.Drawing.Point(114, 38);
            this.cbMertric.Name = "cbMertric";
            this.cbMertric.Size = new System.Drawing.Size(99, 21);
            this.cbMertric.TabIndex = 8;
            this.cbMertric.Text = "длина";
            this.cbMertric.SelectedIndexChanged += new System.EventHandler(this.cbMertric_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 404);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Мои утилиты";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCheatLvl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCheatNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumGen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPassLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudMax;
        private System.Windows.Forms.NumericUpDown nudMin;
        private System.Windows.Forms.Label lblRandom;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.TextBox tbRandom;
        private System.Windows.Forms.Button tbRanClear;
        private System.Windows.Forms.Button btRanCopy;
        private System.Windows.Forms.CheckBox cbNonRepiteMode;
        private System.Windows.Forms.CheckBox cbAutoGen;
        private System.Windows.Forms.NumericUpDown nudNumGen;
        private System.Windows.Forms.Label lblNumGen;
        private System.Windows.Forms.Button btnAboutModes;
        private System.Windows.Forms.CheckBox cbBalanceMode;
        private System.Windows.Forms.CheckBox cbCheatMode;
        private System.Windows.Forms.NumericUpDown nudCheatNum;
        private System.Windows.Forms.Label lblCheatNum;
        private System.Windows.Forms.Label lblCheatLvl;
        private System.Windows.Forms.NumericUpDown nudCheatLvl;
        private System.Windows.Forms.CheckBox cbAutoCopy;
        private System.Windows.Forms.CheckBox cbAutoClear;
        private System.Windows.Forms.Button btnAddCountToList;
        private System.Windows.Forms.ListBox lbCountList;
        private System.Windows.Forms.TextBox tbAddToList;
        private System.Windows.Forms.Button btnAddToList;
        private System.Windows.Forms.ToolStripMenuItem блокнотToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiInsertDate;
        private System.Windows.Forms.ToolStripMenuItem tsmiInsertTime;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RichTextBox rtbNotepad;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmiSave;
        private System.Windows.Forms.ToolStripMenuItem tsmiLoad;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Button btnCreatePass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudPassLength;
        private System.Windows.Forms.CheckedListBox clbPass;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TextBox tbTo;
        private System.Windows.Forms.TextBox tbFrom;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.ComboBox cbTo;
        private System.Windows.Forms.ComboBox cbFrom;
        private System.Windows.Forms.Button btnSwap;
        private System.Windows.Forms.ComboBox cbMertric;
    }
}

