namespace FormBorderStyles
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_forceMaxi = new System.Windows.Forms.Button();
            this.btn_forceNormal = new System.Windows.Forms.Button();
            this.gb_BorderStyle = new System.Windows.Forms.GroupBox();
            this.rb_SizableTool = new System.Windows.Forms.RadioButton();
            this.rb_Sizable = new System.Windows.Forms.RadioButton();
            this.rb_FixedTool = new System.Windows.Forms.RadioButton();
            this.rb_FixedDialog = new System.Windows.Forms.RadioButton();
            this.rb_Fixed3D = new System.Windows.Forms.RadioButton();
            this.rb_FixedSingle = new System.Windows.Forms.RadioButton();
            this.rb_None = new System.Windows.Forms.RadioButton();
            this.cb_MaximizeBtn = new System.Windows.Forms.CheckBox();
            this.cb_MinimizeBtn = new System.Windows.Forms.CheckBox();
            this.cb_ControlBox = new System.Windows.Forms.CheckBox();
            this.cb_ShowIcon = new System.Windows.Forms.CheckBox();
            this.gb_FormSettings = new System.Windows.Forms.GroupBox();
            this.cb_ShowInTaskbar = new System.Windows.Forms.CheckBox();
            this.cb_VisualStyles = new System.Windows.Forms.CheckBox();
            this.pbar_demo = new System.Windows.Forms.ProgressBar();
            this.tmr_progress = new System.Windows.Forms.Timer(this.components);
            this.gb_ProgressBar = new System.Windows.Forms.GroupBox();
            this.rb_Marq = new System.Windows.Forms.RadioButton();
            this.rb_Cont = new System.Windows.Forms.RadioButton();
            this.rb_Blocks = new System.Windows.Forms.RadioButton();
            this.pan_container = new System.Windows.Forms.Panel();
            this.gb_SampleControls = new System.Windows.Forms.GroupBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.pbar_demo2 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.comboBox1 = new WindowsFormsAero.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            // this.comboBox3 = new WindowsFormsAero.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gb_BorderStyle.SuspendLayout();
            this.gb_FormSettings.SuspendLayout();
            this.gb_ProgressBar.SuspendLayout();
            this.gb_SampleControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_forceMaxi
            // 
            this.btn_forceMaxi.Location = new System.Drawing.Point(12, 12);
            this.btn_forceMaxi.Name = "btn_forceMaxi";
            this.btn_forceMaxi.Size = new System.Drawing.Size(153, 23);
            this.btn_forceMaxi.TabIndex = 0;
            this.btn_forceMaxi.Text = "Force Maximize";
            this.btn_forceMaxi.UseVisualStyleBackColor = true;
            this.btn_forceMaxi.Click += new System.EventHandler(this.btn_forceMaxi_Click);
            // 
            // btn_forceNormal
            // 
            this.btn_forceNormal.Location = new System.Drawing.Point(12, 41);
            this.btn_forceNormal.Name = "btn_forceNormal";
            this.btn_forceNormal.Size = new System.Drawing.Size(153, 23);
            this.btn_forceNormal.TabIndex = 1;
            this.btn_forceNormal.Text = "Force Restore";
            this.btn_forceNormal.UseVisualStyleBackColor = true;
            this.btn_forceNormal.Click += new System.EventHandler(this.btn_forceNormal_Click);
            // 
            // gb_BorderStyle
            // 
            this.gb_BorderStyle.Controls.Add(this.rb_SizableTool);
            this.gb_BorderStyle.Controls.Add(this.rb_Sizable);
            this.gb_BorderStyle.Controls.Add(this.rb_FixedTool);
            this.gb_BorderStyle.Controls.Add(this.rb_FixedDialog);
            this.gb_BorderStyle.Controls.Add(this.rb_Fixed3D);
            this.gb_BorderStyle.Controls.Add(this.rb_FixedSingle);
            this.gb_BorderStyle.Controls.Add(this.rb_None);
            this.gb_BorderStyle.Location = new System.Drawing.Point(12, 70);
            this.gb_BorderStyle.Name = "gb_BorderStyle";
            this.gb_BorderStyle.Size = new System.Drawing.Size(153, 185);
            this.gb_BorderStyle.TabIndex = 2;
            this.gb_BorderStyle.TabStop = false;
            this.gb_BorderStyle.Text = "Form Border Styles";
            // 
            // rb_SizableTool
            // 
            this.rb_SizableTool.AutoSize = true;
            this.rb_SizableTool.Location = new System.Drawing.Point(6, 157);
            this.rb_SizableTool.Name = "rb_SizableTool";
            this.rb_SizableTool.Size = new System.Drawing.Size(125, 17);
            this.rb_SizableTool.TabIndex = 6;
            this.rb_SizableTool.Text = "Sizable Tool Window";
            this.rb_SizableTool.UseVisualStyleBackColor = true;
            this.rb_SizableTool.CheckedChanged += new System.EventHandler(this.rb_SizableTool_CheckedChanged);
            // 
            // rb_Sizable
            // 
            this.rb_Sizable.AutoSize = true;
            this.rb_Sizable.Checked = true;
            this.rb_Sizable.Location = new System.Drawing.Point(6, 111);
            this.rb_Sizable.Name = "rb_Sizable";
            this.rb_Sizable.Size = new System.Drawing.Size(59, 17);
            this.rb_Sizable.TabIndex = 5;
            this.rb_Sizable.TabStop = true;
            this.rb_Sizable.Text = "Sizable";
            this.rb_Sizable.UseVisualStyleBackColor = true;
            this.rb_Sizable.CheckedChanged += new System.EventHandler(this.rb_Sizable_CheckedChanged);
            // 
            // rb_FixedTool
            // 
            this.rb_FixedTool.AutoSize = true;
            this.rb_FixedTool.Location = new System.Drawing.Point(6, 134);
            this.rb_FixedTool.Name = "rb_FixedTool";
            this.rb_FixedTool.Size = new System.Drawing.Size(116, 17);
            this.rb_FixedTool.TabIndex = 4;
            this.rb_FixedTool.Text = "Fixed Tool Window";
            this.rb_FixedTool.UseVisualStyleBackColor = true;
            this.rb_FixedTool.CheckedChanged += new System.EventHandler(this.rb_FixedTool_CheckedChanged);
            // 
            // rb_FixedDialog
            // 
            this.rb_FixedDialog.AutoSize = true;
            this.rb_FixedDialog.Location = new System.Drawing.Point(6, 88);
            this.rb_FixedDialog.Name = "rb_FixedDialog";
            this.rb_FixedDialog.Size = new System.Drawing.Size(83, 17);
            this.rb_FixedDialog.TabIndex = 3;
            this.rb_FixedDialog.Text = "Fixed Dialog";
            this.rb_FixedDialog.UseVisualStyleBackColor = true;
            this.rb_FixedDialog.CheckedChanged += new System.EventHandler(this.rb_FixedDialog_CheckedChanged);
            // 
            // rb_Fixed3D
            // 
            this.rb_Fixed3D.AutoSize = true;
            this.rb_Fixed3D.Location = new System.Drawing.Point(6, 65);
            this.rb_Fixed3D.Name = "rb_Fixed3D";
            this.rb_Fixed3D.Size = new System.Drawing.Size(67, 17);
            this.rb_Fixed3D.TabIndex = 2;
            this.rb_Fixed3D.Text = "Fixed 3D";
            this.rb_Fixed3D.UseVisualStyleBackColor = true;
            this.rb_Fixed3D.CheckedChanged += new System.EventHandler(this.rb_Fixed3D_CheckedChanged);
            // 
            // rb_FixedSingle
            // 
            this.rb_FixedSingle.AutoSize = true;
            this.rb_FixedSingle.Location = new System.Drawing.Point(6, 42);
            this.rb_FixedSingle.Name = "rb_FixedSingle";
            this.rb_FixedSingle.Size = new System.Drawing.Size(82, 17);
            this.rb_FixedSingle.TabIndex = 1;
            this.rb_FixedSingle.Text = "Fixed Single";
            this.rb_FixedSingle.UseVisualStyleBackColor = true;
            this.rb_FixedSingle.CheckedChanged += new System.EventHandler(this.rb_FixedSingle_CheckedChanged);
            // 
            // rb_None
            // 
            this.rb_None.AutoSize = true;
            this.rb_None.Location = new System.Drawing.Point(6, 19);
            this.rb_None.Name = "rb_None";
            this.rb_None.Size = new System.Drawing.Size(51, 17);
            this.rb_None.TabIndex = 0;
            this.rb_None.Text = "None";
            this.rb_None.UseVisualStyleBackColor = true;
            this.rb_None.CheckedChanged += new System.EventHandler(this.rb_None_CheckedChanged);
            // 
            // cb_MaximizeBtn
            // 
            this.cb_MaximizeBtn.AutoSize = true;
            this.cb_MaximizeBtn.Checked = true;
            this.cb_MaximizeBtn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_MaximizeBtn.Location = new System.Drawing.Point(6, 19);
            this.cb_MaximizeBtn.Name = "cb_MaximizeBtn";
            this.cb_MaximizeBtn.Size = new System.Drawing.Size(90, 17);
            this.cb_MaximizeBtn.TabIndex = 3;
            this.cb_MaximizeBtn.Text = "Maximize Box";
            this.cb_MaximizeBtn.UseVisualStyleBackColor = true;
            this.cb_MaximizeBtn.CheckedChanged += new System.EventHandler(this.cb_MaximizeBtn_CheckedChanged);
            // 
            // cb_MinimizeBtn
            // 
            this.cb_MinimizeBtn.AutoSize = true;
            this.cb_MinimizeBtn.Checked = true;
            this.cb_MinimizeBtn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_MinimizeBtn.Location = new System.Drawing.Point(6, 42);
            this.cb_MinimizeBtn.Name = "cb_MinimizeBtn";
            this.cb_MinimizeBtn.Size = new System.Drawing.Size(87, 17);
            this.cb_MinimizeBtn.TabIndex = 4;
            this.cb_MinimizeBtn.Text = "Minimize Box";
            this.cb_MinimizeBtn.UseVisualStyleBackColor = true;
            this.cb_MinimizeBtn.CheckedChanged += new System.EventHandler(this.cb_MinimizeBtn_CheckedChanged);
            // 
            // cb_ControlBox
            // 
            this.cb_ControlBox.AutoSize = true;
            this.cb_ControlBox.Checked = true;
            this.cb_ControlBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_ControlBox.Location = new System.Drawing.Point(6, 65);
            this.cb_ControlBox.Name = "cb_ControlBox";
            this.cb_ControlBox.Size = new System.Drawing.Size(80, 17);
            this.cb_ControlBox.TabIndex = 5;
            this.cb_ControlBox.Text = "Control Box";
            this.cb_ControlBox.UseVisualStyleBackColor = true;
            this.cb_ControlBox.CheckedChanged += new System.EventHandler(this.cb_ControlBox_CheckedChanged);
            // 
            // cb_ShowIcon
            // 
            this.cb_ShowIcon.AutoSize = true;
            this.cb_ShowIcon.Checked = true;
            this.cb_ShowIcon.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_ShowIcon.Location = new System.Drawing.Point(6, 88);
            this.cb_ShowIcon.Name = "cb_ShowIcon";
            this.cb_ShowIcon.Size = new System.Drawing.Size(77, 17);
            this.cb_ShowIcon.TabIndex = 6;
            this.cb_ShowIcon.Text = "Show Icon";
            this.cb_ShowIcon.UseVisualStyleBackColor = true;
            this.cb_ShowIcon.CheckedChanged += new System.EventHandler(this.cb_ShowIcon_CheckedChanged);
            // 
            // gb_FormSettings
            // 
            this.gb_FormSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gb_FormSettings.Controls.Add(this.cb_ShowInTaskbar);
            this.gb_FormSettings.Controls.Add(this.cb_MaximizeBtn);
            this.gb_FormSettings.Controls.Add(this.cb_ShowIcon);
            this.gb_FormSettings.Controls.Add(this.cb_MinimizeBtn);
            this.gb_FormSettings.Controls.Add(this.cb_ControlBox);
            this.gb_FormSettings.Location = new System.Drawing.Point(12, 261);
            this.gb_FormSettings.Name = "gb_FormSettings";
            this.gb_FormSettings.Size = new System.Drawing.Size(153, 346);
            this.gb_FormSettings.TabIndex = 7;
            this.gb_FormSettings.TabStop = false;
            this.gb_FormSettings.Text = "Form Settings";
            // 
            // cb_ShowInTaskbar
            // 
            this.cb_ShowInTaskbar.AutoSize = true;
            this.cb_ShowInTaskbar.Checked = true;
            this.cb_ShowInTaskbar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_ShowInTaskbar.Location = new System.Drawing.Point(6, 111);
            this.cb_ShowInTaskbar.Name = "cb_ShowInTaskbar";
            this.cb_ShowInTaskbar.Size = new System.Drawing.Size(107, 17);
            this.cb_ShowInTaskbar.TabIndex = 7;
            this.cb_ShowInTaskbar.Text = "Show In Taskbar";
            this.cb_ShowInTaskbar.UseVisualStyleBackColor = true;
            this.cb_ShowInTaskbar.CheckedChanged += new System.EventHandler(this.cb_ShowInTaskbar_CheckedChanged);
            // 
            // cb_VisualStyles
            // 
            this.cb_VisualStyles.AutoSize = true;
            this.cb_VisualStyles.Location = new System.Drawing.Point(184, 16);
            this.cb_VisualStyles.Name = "cb_VisualStyles";
            this.cb_VisualStyles.Size = new System.Drawing.Size(132, 17);
            this.cb_VisualStyles.TabIndex = 8;
            this.cb_VisualStyles.Text = "Windows Visual Styles";
            this.cb_VisualStyles.UseVisualStyleBackColor = true;
            this.cb_VisualStyles.CheckedChanged += new System.EventHandler(this.cb_VisualStyles_CheckedChanged);
            // 
            // pbar_demo
            // 
            this.pbar_demo.Location = new System.Drawing.Point(184, 175);
            this.pbar_demo.Name = "pbar_demo";
            this.pbar_demo.Size = new System.Drawing.Size(247, 23);
            this.pbar_demo.TabIndex = 9;
            // 
            // tmr_progress
            // 
            this.tmr_progress.Enabled = true;
            this.tmr_progress.Tick += new System.EventHandler(this.tmr_progress_Tick);
            // 
            // gb_ProgressBar
            // 
            this.gb_ProgressBar.Controls.Add(this.rb_Marq);
            this.gb_ProgressBar.Controls.Add(this.rb_Cont);
            this.gb_ProgressBar.Controls.Add(this.rb_Blocks);
            this.gb_ProgressBar.Location = new System.Drawing.Point(184, 70);
            this.gb_ProgressBar.Name = "gb_ProgressBar";
            this.gb_ProgressBar.Size = new System.Drawing.Size(247, 99);
            this.gb_ProgressBar.TabIndex = 7;
            this.gb_ProgressBar.TabStop = false;
            this.gb_ProgressBar.Text = "Progress Bar Settings";
            // 
            // rb_Marq
            // 
            this.rb_Marq.AutoSize = true;
            this.rb_Marq.Location = new System.Drawing.Point(6, 65);
            this.rb_Marq.Name = "rb_Marq";
            this.rb_Marq.Size = new System.Drawing.Size(67, 17);
            this.rb_Marq.TabIndex = 2;
            this.rb_Marq.Text = "Marquee";
            this.rb_Marq.UseVisualStyleBackColor = true;
            this.rb_Marq.CheckedChanged += new System.EventHandler(this.rb_Marq_CheckedChanged);
            // 
            // rb_Cont
            // 
            this.rb_Cont.AutoSize = true;
            this.rb_Cont.Location = new System.Drawing.Point(6, 42);
            this.rb_Cont.Name = "rb_Cont";
            this.rb_Cont.Size = new System.Drawing.Size(78, 17);
            this.rb_Cont.TabIndex = 1;
            this.rb_Cont.Text = "Continuous";
            this.rb_Cont.UseVisualStyleBackColor = true;
            this.rb_Cont.CheckedChanged += new System.EventHandler(this.rb_Cont_CheckedChanged);
            // 
            // rb_Blocks
            // 
            this.rb_Blocks.AutoSize = true;
            this.rb_Blocks.Checked = true;
            this.rb_Blocks.Location = new System.Drawing.Point(6, 19);
            this.rb_Blocks.Name = "rb_Blocks";
            this.rb_Blocks.Size = new System.Drawing.Size(57, 17);
            this.rb_Blocks.TabIndex = 0;
            this.rb_Blocks.TabStop = true;
            this.rb_Blocks.Text = "Blocks";
            this.rb_Blocks.UseVisualStyleBackColor = true;
            this.rb_Blocks.CheckedChanged += new System.EventHandler(this.rb_Blocks_CheckedChanged);
            // 
            // pan_container
            // 
            this.pan_container.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pan_container.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pan_container.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pan_container.Location = new System.Drawing.Point(184, 217);
            this.pan_container.Name = "pan_container";
            this.pan_container.Size = new System.Drawing.Size(662, 390);
            this.pan_container.TabIndex = 10;
            // 
            // gb_SampleControls
            // 
            this.gb_SampleControls.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_SampleControls.Controls.Add(this.button1);
            this.gb_SampleControls.Controls.Add(this.comboBox3);
            this.gb_SampleControls.Controls.Add(this.comboBox2);
            this.gb_SampleControls.Controls.Add(this.comboBox1);
            this.gb_SampleControls.Controls.Add(this.listBox1);
            this.gb_SampleControls.Controls.Add(this.statusStrip1);
            this.gb_SampleControls.Controls.Add(this.trackBar1);
            this.gb_SampleControls.Location = new System.Drawing.Point(437, 12);
            this.gb_SampleControls.Name = "gb_SampleControls";
            this.gb_SampleControls.Size = new System.Drawing.Size(409, 186);
            this.gb_SampleControls.TabIndex = 11;
            this.gb_SampleControls.TabStop = false;
            this.gb_SampleControls.Text = "Controls Preview";
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(21, 29);
            this.trackBar1.Maximum = 30;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(343, 45);
            this.trackBar1.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pbar_demo2,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(3, 161);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(403, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // pbar_demo2
            // 
            this.pbar_demo2.Name = "pbar_demo2";
            this.pbar_demo2.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Windows 10",
            "Windows 8.1",
            "Windows 8",
            "Windows 7",
            "Windows Vista",
            "Windows XP",
            "Windows ME",
            "Windows 2000",
            "Windows 98SE",
            "Windows 98",
            "Windows NT 4.0",
            "Windows 95",
            "Windows NT 3.51",
            "Windows NT 3.5",
            "Windows 3.11",
            "Windows NT 3.1",
            "Windows 3.1",
            "Windows 3.0",
            "Windows 2.0/386",
            "Windows 2.0/286",
            "Windows 1.0"});
            this.listBox1.Location = new System.Drawing.Point(21, 71);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 82);
            this.listBox1.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Windows 10",
            "Windows 8.1",
            "Windows 8",
            "Windows 7",
            "Windows Vista",
            "Windows XP",
            "Windows ME",
            "Windows 2000",
            "Windows 98SE",
            "Windows 98",
            "Windows NT 4.0",
            "Windows 95",
            "Windows NT 3.51",
            "Windows NT 3.5",
            "Windows 3.11",
            "Windows NT 3.1",
            "Windows 3.1",
            "Windows 3.0",
            "Windows 2.0/386",
            "Windows 2.0/286",
            "Windows 1.0"});
            this.comboBox1.Location = new System.Drawing.Point(147, 71);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Windows 10",
            "Windows 8.1",
            "Windows 8",
            "Windows 7",
            "Windows Vista",
            "Windows XP",
            "Windows ME",
            "Windows 2000",
            "Windows 98SE",
            "Windows 98",
            "Windows NT 4.0",
            "Windows 95",
            "Windows NT 3.51",
            "Windows NT 3.5",
            "Windows 3.11",
            "Windows NT 3.1",
            "Windows 3.1",
            "Windows 3.0",
            "Windows 2.0/386",
            "Windows 2.0/286",
            "Windows 1.0"});
            this.comboBox2.Location = new System.Drawing.Point(274, 71);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 85);
            this.comboBox2.TabIndex = 4;
            // 
            // comboBox3
            // 
            this.comboBox3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Windows 10",
            "Windows 8.1",
            "Windows 8",
            "Windows 7",
            "Windows Vista",
            "Windows XP",
            "Windows ME",
            "Windows 2000",
            "Windows 98SE",
            "Windows 98",
            "Windows NT 4.0",
            "Windows 95",
            "Windows NT 3.51",
            "Windows NT 3.5",
            "Windows 3.11",
            "Windows NT 3.1",
            "Windows 3.1",
            "Windows 3.0",
            "Windows 2.0/386",
            "Windows 2.0/286",
            "Windows 1.0"});
            this.comboBox3.Location = new System.Drawing.Point(147, 100);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(148, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 25);
            this.button1.TabIndex = 6;
            this.button1.Text = "BUTTON";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 620);
            this.Controls.Add(this.gb_SampleControls);
            this.Controls.Add(this.pan_container);
            this.Controls.Add(this.gb_ProgressBar);
            this.Controls.Add(this.pbar_demo);
            this.Controls.Add(this.cb_VisualStyles);
            this.Controls.Add(this.gb_FormSettings);
            this.Controls.Add(this.gb_BorderStyle);
            this.Controls.Add(this.btn_forceNormal);
            this.Controls.Add(this.btn_forceMaxi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(478, 471);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Windows UI Tester";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb_BorderStyle.ResumeLayout(false);
            this.gb_BorderStyle.PerformLayout();
            this.gb_FormSettings.ResumeLayout(false);
            this.gb_FormSettings.PerformLayout();
            this.gb_ProgressBar.ResumeLayout(false);
            this.gb_ProgressBar.PerformLayout();
            this.gb_SampleControls.ResumeLayout(false);
            this.gb_SampleControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_forceMaxi;
        private System.Windows.Forms.Button btn_forceNormal;
        private System.Windows.Forms.GroupBox gb_BorderStyle;
        private System.Windows.Forms.RadioButton rb_SizableTool;
        private System.Windows.Forms.RadioButton rb_Sizable;
        private System.Windows.Forms.RadioButton rb_FixedTool;
        private System.Windows.Forms.RadioButton rb_FixedDialog;
        private System.Windows.Forms.RadioButton rb_Fixed3D;
        private System.Windows.Forms.RadioButton rb_FixedSingle;
        private System.Windows.Forms.RadioButton rb_None;
        private System.Windows.Forms.CheckBox cb_MaximizeBtn;
        private System.Windows.Forms.CheckBox cb_MinimizeBtn;
        private System.Windows.Forms.CheckBox cb_ControlBox;
        private System.Windows.Forms.CheckBox cb_ShowIcon;
        private System.Windows.Forms.GroupBox gb_FormSettings;
        private System.Windows.Forms.CheckBox cb_ShowInTaskbar;
        private System.Windows.Forms.CheckBox cb_VisualStyles;
        private System.Windows.Forms.ProgressBar pbar_demo;
        private System.Windows.Forms.Timer tmr_progress;
        private System.Windows.Forms.GroupBox gb_ProgressBar;
        private System.Windows.Forms.RadioButton rb_Marq;
        private System.Windows.Forms.RadioButton rb_Cont;
        private System.Windows.Forms.RadioButton rb_Blocks;
        private System.Windows.Forms.Panel pan_container;
        private System.Windows.Forms.GroupBox gb_SampleControls;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar pbar_demo2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ListBox listBox1;
        // private WindowsFormsAero.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private WindowsFormsAero.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
    }
}

