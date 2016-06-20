namespace Diplom
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._viewSimpleOpenGlControl = new Tao.Platform.Windows.SimpleOpenGlControl();
            this._fillColor1Dialog = new System.Windows.Forms.ColorDialog();
            this._fillColor2Dialog = new System.Windows.Forms.ColorDialog();
            this._cameraSimpleOpenGlControl = new Tao.Platform.Windows.SimpleOpenGlControl();
            this._movingGroupBox = new System.Windows.Forms.GroupBox();
            this._cameraRadioButton = new System.Windows.Forms.RadioButton();
            this._modelRadioButton = new System.Windows.Forms.RadioButton();
            this._viewMatrixLabel = new System.Windows.Forms.Label();
            this._readmeGroupBox = new System.Windows.Forms.GroupBox();
            this._readmeLabel2 = new System.Windows.Forms.Label();
            this._readmeLabel1 = new System.Windows.Forms.Label();
            this._glSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this._modelSettingsRotateGroupBox = new System.Windows.Forms.GroupBox();
            this._modelSettingsRotateZTextBox = new System.Windows.Forms.TextBox();
            this._modelSettingsRotateZLabel = new System.Windows.Forms.Label();
            this._modelSettingsRotateYTextBox = new System.Windows.Forms.TextBox();
            this._modelSettingsRotateYLabel = new System.Windows.Forms.Label();
            this._modelSettingsRotateXTextBox = new System.Windows.Forms.TextBox();
            this._modelSettingsRotateXLabel = new System.Windows.Forms.Label();
            this._modelSettingsPositionGroupBox = new System.Windows.Forms.GroupBox();
            this._modelSettingsPositionZTextBox = new System.Windows.Forms.TextBox();
            this._modelSettingsPositionZLabel = new System.Windows.Forms.Label();
            this._modelSettingsPositionYTextBox = new System.Windows.Forms.TextBox();
            this._modelSettingsPositionYLabel = new System.Windows.Forms.Label();
            this._modelSettingsPositionXTextBox = new System.Windows.Forms.TextBox();
            this._modelSettingsPositionXLabel = new System.Windows.Forms.Label();
            this._cameraSettingsRotateGroupBox = new System.Windows.Forms.GroupBox();
            this._cameraSettingsRotateZTextBox = new System.Windows.Forms.TextBox();
            this._cameraSettingsRotateZLabel = new System.Windows.Forms.Label();
            this._cameraSettingsRotateYTextBox = new System.Windows.Forms.TextBox();
            this._cameraSettingsRotateYLabel = new System.Windows.Forms.Label();
            this._cameraSettingsRotateXTextBox = new System.Windows.Forms.TextBox();
            this._cameraSettingsRotateXLabel = new System.Windows.Forms.Label();
            this._cameraSettingsPositionGroupBox = new System.Windows.Forms.GroupBox();
            this._cameraSettingsPositionZTextBox = new System.Windows.Forms.TextBox();
            this._cameraSettingsPositionZLabel = new System.Windows.Forms.Label();
            this._cameraSettingsPositionYTextBox = new System.Windows.Forms.TextBox();
            this._cameraSettingsPositionYLabel = new System.Windows.Forms.Label();
            this._cameraSettingsPositionXTextBox = new System.Windows.Forms.TextBox();
            this._cameraSettingsPositionXLabel = new System.Windows.Forms.Label();
            this._modelMatrixLabel = new System.Windows.Forms.Label();
            this._viewMatrixGroupBox = new System.Windows.Forms.GroupBox();
            this._modelMatrixGroupBox = new System.Windows.Forms.GroupBox();
            this._modelViewMatrixGroupBox = new System.Windows.Forms.GroupBox();
            this._modelViewMatrixLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._movingGroupBox.SuspendLayout();
            this._readmeGroupBox.SuspendLayout();
            this._glSettingsGroupBox.SuspendLayout();
            this._modelSettingsRotateGroupBox.SuspendLayout();
            this._modelSettingsPositionGroupBox.SuspendLayout();
            this._cameraSettingsRotateGroupBox.SuspendLayout();
            this._cameraSettingsPositionGroupBox.SuspendLayout();
            this._viewMatrixGroupBox.SuspendLayout();
            this._modelMatrixGroupBox.SuspendLayout();
            this._modelViewMatrixGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // _viewSimpleOpenGlControl
            // 
            this._viewSimpleOpenGlControl.AccumBits = ((byte)(0));
            this._viewSimpleOpenGlControl.AutoCheckErrors = false;
            this._viewSimpleOpenGlControl.AutoFinish = false;
            this._viewSimpleOpenGlControl.AutoMakeCurrent = true;
            this._viewSimpleOpenGlControl.AutoSwapBuffers = true;
            this._viewSimpleOpenGlControl.BackColor = System.Drawing.Color.Black;
            this._viewSimpleOpenGlControl.ColorBits = ((byte)(32));
            this._viewSimpleOpenGlControl.DepthBits = ((byte)(16));
            this._viewSimpleOpenGlControl.Location = new System.Drawing.Point(12, 34);
            this._viewSimpleOpenGlControl.Name = "_viewSimpleOpenGlControl";
            this._viewSimpleOpenGlControl.Size = new System.Drawing.Size(300, 300);
            this._viewSimpleOpenGlControl.StencilBits = ((byte)(0));
            this._viewSimpleOpenGlControl.TabIndex = 0;
            this._viewSimpleOpenGlControl.KeyDown += new System.Windows.Forms.KeyEventHandler(this._simpleOpenGlControl_KeyDown);
            // 
            // _cameraSimpleOpenGlControl
            // 
            this._cameraSimpleOpenGlControl.AccumBits = ((byte)(0));
            this._cameraSimpleOpenGlControl.AutoCheckErrors = false;
            this._cameraSimpleOpenGlControl.AutoFinish = false;
            this._cameraSimpleOpenGlControl.AutoMakeCurrent = false;
            this._cameraSimpleOpenGlControl.AutoSwapBuffers = true;
            this._cameraSimpleOpenGlControl.BackColor = System.Drawing.Color.Black;
            this._cameraSimpleOpenGlControl.ColorBits = ((byte)(32));
            this._cameraSimpleOpenGlControl.DepthBits = ((byte)(16));
            this._cameraSimpleOpenGlControl.Location = new System.Drawing.Point(318, 34);
            this._cameraSimpleOpenGlControl.Name = "_cameraSimpleOpenGlControl";
            this._cameraSimpleOpenGlControl.Size = new System.Drawing.Size(300, 300);
            this._cameraSimpleOpenGlControl.StencilBits = ((byte)(0));
            this._cameraSimpleOpenGlControl.TabIndex = 1;
            this._cameraSimpleOpenGlControl.KeyDown += new System.Windows.Forms.KeyEventHandler(this._simpleOpenGlControl_KeyDown);
            // 
            // _movingGroupBox
            // 
            this._movingGroupBox.BackColor = System.Drawing.Color.PeachPuff;
            this._movingGroupBox.Controls.Add(this._cameraRadioButton);
            this._movingGroupBox.Controls.Add(this._modelRadioButton);
            this._movingGroupBox.Location = new System.Drawing.Point(630, 105);
            this._movingGroupBox.Name = "_movingGroupBox";
            this._movingGroupBox.Size = new System.Drawing.Size(388, 68);
            this._movingGroupBox.TabIndex = 2;
            this._movingGroupBox.TabStop = false;
            this._movingGroupBox.Text = "Чем управлять?";
            // 
            // _cameraRadioButton
            // 
            this._cameraRadioButton.AutoSize = true;
            this._cameraRadioButton.Checked = true;
            this._cameraRadioButton.Location = new System.Drawing.Point(6, 19);
            this._cameraRadioButton.Name = "_cameraRadioButton";
            this._cameraRadioButton.Size = new System.Drawing.Size(64, 17);
            this._cameraRadioButton.TabIndex = 1;
            this._cameraRadioButton.TabStop = true;
            this._cameraRadioButton.Text = "Камера";
            this._cameraRadioButton.UseVisualStyleBackColor = true;
            this._cameraRadioButton.CheckedChanged += new System.EventHandler(this._cameraRadioButton_CheckedChanged);
            // 
            // _modelRadioButton
            // 
            this._modelRadioButton.AutoSize = true;
            this._modelRadioButton.Location = new System.Drawing.Point(6, 42);
            this._modelRadioButton.Name = "_modelRadioButton";
            this._modelRadioButton.Size = new System.Drawing.Size(64, 17);
            this._modelRadioButton.TabIndex = 0;
            this._modelRadioButton.Text = "Модель";
            this._modelRadioButton.UseVisualStyleBackColor = true;
            this._modelRadioButton.CheckedChanged += new System.EventHandler(this._modelRadioButton_CheckedChanged);
            // 
            // _viewMatrixLabel
            // 
            this._viewMatrixLabel.Location = new System.Drawing.Point(16, 22);
            this._viewMatrixLabel.Name = "_viewMatrixLabel";
            this._viewMatrixLabel.Size = new System.Drawing.Size(189, 100);
            this._viewMatrixLabel.TabIndex = 3;
            // 
            // _readmeGroupBox
            // 
            this._readmeGroupBox.BackColor = System.Drawing.Color.MistyRose;
            this._readmeGroupBox.Controls.Add(this._readmeLabel2);
            this._readmeGroupBox.Controls.Add(this._readmeLabel1);
            this._readmeGroupBox.Location = new System.Drawing.Point(630, 34);
            this._readmeGroupBox.Name = "_readmeGroupBox";
            this._readmeGroupBox.Size = new System.Drawing.Size(388, 65);
            this._readmeGroupBox.TabIndex = 5;
            this._readmeGroupBox.TabStop = false;
            this._readmeGroupBox.Text = "Управление";
            // 
            // _readmeLabel2
            // 
            this._readmeLabel2.AutoSize = true;
            this._readmeLabel2.Location = new System.Drawing.Point(7, 42);
            this._readmeLabel2.Name = "_readmeLabel2";
            this._readmeLabel2.Size = new System.Drawing.Size(163, 13);
            this._readmeLabel2.TabIndex = 1;
            this._readmeLabel2.Text = "E/R D/F C/V  - Rotate by X/Y/Z";
            // 
            // _readmeLabel1
            // 
            this._readmeLabel1.AutoSize = true;
            this._readmeLabel1.Location = new System.Drawing.Point(7, 20);
            this._readmeLabel1.Name = "_readmeLabel1";
            this._readmeLabel1.Size = new System.Drawing.Size(176, 13);
            this._readmeLabel1.TabIndex = 0;
            this._readmeLabel1.Text = "Q/W A/S Z/X - Translate by X/Y/Z";
            // 
            // _glSettingsGroupBox
            // 
            this._glSettingsGroupBox.BackColor = System.Drawing.Color.Moccasin;
            this._glSettingsGroupBox.Controls.Add(this._modelSettingsRotateGroupBox);
            this._glSettingsGroupBox.Controls.Add(this._modelSettingsPositionGroupBox);
            this._glSettingsGroupBox.Controls.Add(this._cameraSettingsRotateGroupBox);
            this._glSettingsGroupBox.Controls.Add(this._cameraSettingsPositionGroupBox);
            this._glSettingsGroupBox.Location = new System.Drawing.Point(630, 179);
            this._glSettingsGroupBox.Name = "_glSettingsGroupBox";
            this._glSettingsGroupBox.Size = new System.Drawing.Size(388, 155);
            this._glSettingsGroupBox.TabIndex = 6;
            this._glSettingsGroupBox.TabStop = false;
            this._glSettingsGroupBox.Text = "Параметры";
            // 
            // _modelSettingsRotateGroupBox
            // 
            this._modelSettingsRotateGroupBox.Controls.Add(this._modelSettingsRotateZTextBox);
            this._modelSettingsRotateGroupBox.Controls.Add(this._modelSettingsRotateZLabel);
            this._modelSettingsRotateGroupBox.Controls.Add(this._modelSettingsRotateYTextBox);
            this._modelSettingsRotateGroupBox.Controls.Add(this._modelSettingsRotateYLabel);
            this._modelSettingsRotateGroupBox.Controls.Add(this._modelSettingsRotateXTextBox);
            this._modelSettingsRotateGroupBox.Controls.Add(this._modelSettingsRotateXLabel);
            this._modelSettingsRotateGroupBox.Location = new System.Drawing.Point(292, 20);
            this._modelSettingsRotateGroupBox.Name = "_modelSettingsRotateGroupBox";
            this._modelSettingsRotateGroupBox.Size = new System.Drawing.Size(88, 112);
            this._modelSettingsRotateGroupBox.TabIndex = 3;
            this._modelSettingsRotateGroupBox.TabStop = false;
            this._modelSettingsRotateGroupBox.Text = "Поворот модели";
            // 
            // _modelSettingsRotateZTextBox
            // 
            this._modelSettingsRotateZTextBox.Location = new System.Drawing.Point(30, 81);
            this._modelSettingsRotateZTextBox.Name = "_modelSettingsRotateZTextBox";
            this._modelSettingsRotateZTextBox.ReadOnly = true;
            this._modelSettingsRotateZTextBox.Size = new System.Drawing.Size(40, 20);
            this._modelSettingsRotateZTextBox.TabIndex = 5;
            // 
            // _modelSettingsRotateZLabel
            // 
            this._modelSettingsRotateZLabel.AutoSize = true;
            this._modelSettingsRotateZLabel.Location = new System.Drawing.Point(10, 84);
            this._modelSettingsRotateZLabel.Name = "_modelSettingsRotateZLabel";
            this._modelSettingsRotateZLabel.Size = new System.Drawing.Size(14, 13);
            this._modelSettingsRotateZLabel.TabIndex = 4;
            this._modelSettingsRotateZLabel.Text = "Z";
            // 
            // _modelSettingsRotateYTextBox
            // 
            this._modelSettingsRotateYTextBox.Location = new System.Drawing.Point(30, 55);
            this._modelSettingsRotateYTextBox.Name = "_modelSettingsRotateYTextBox";
            this._modelSettingsRotateYTextBox.ReadOnly = true;
            this._modelSettingsRotateYTextBox.Size = new System.Drawing.Size(40, 20);
            this._modelSettingsRotateYTextBox.TabIndex = 3;
            // 
            // _modelSettingsRotateYLabel
            // 
            this._modelSettingsRotateYLabel.AutoSize = true;
            this._modelSettingsRotateYLabel.Location = new System.Drawing.Point(10, 58);
            this._modelSettingsRotateYLabel.Name = "_modelSettingsRotateYLabel";
            this._modelSettingsRotateYLabel.Size = new System.Drawing.Size(14, 13);
            this._modelSettingsRotateYLabel.TabIndex = 2;
            this._modelSettingsRotateYLabel.Text = "Y";
            // 
            // _modelSettingsRotateXTextBox
            // 
            this._modelSettingsRotateXTextBox.Location = new System.Drawing.Point(30, 29);
            this._modelSettingsRotateXTextBox.Name = "_modelSettingsRotateXTextBox";
            this._modelSettingsRotateXTextBox.ReadOnly = true;
            this._modelSettingsRotateXTextBox.Size = new System.Drawing.Size(40, 20);
            this._modelSettingsRotateXTextBox.TabIndex = 1;
            // 
            // _modelSettingsRotateXLabel
            // 
            this._modelSettingsRotateXLabel.AutoSize = true;
            this._modelSettingsRotateXLabel.Location = new System.Drawing.Point(10, 32);
            this._modelSettingsRotateXLabel.Name = "_modelSettingsRotateXLabel";
            this._modelSettingsRotateXLabel.Size = new System.Drawing.Size(14, 13);
            this._modelSettingsRotateXLabel.TabIndex = 0;
            this._modelSettingsRotateXLabel.Text = "X";
            // 
            // _modelSettingsPositionGroupBox
            // 
            this._modelSettingsPositionGroupBox.Controls.Add(this._modelSettingsPositionZTextBox);
            this._modelSettingsPositionGroupBox.Controls.Add(this._modelSettingsPositionZLabel);
            this._modelSettingsPositionGroupBox.Controls.Add(this._modelSettingsPositionYTextBox);
            this._modelSettingsPositionGroupBox.Controls.Add(this._modelSettingsPositionYLabel);
            this._modelSettingsPositionGroupBox.Controls.Add(this._modelSettingsPositionXTextBox);
            this._modelSettingsPositionGroupBox.Controls.Add(this._modelSettingsPositionXLabel);
            this._modelSettingsPositionGroupBox.Location = new System.Drawing.Point(198, 20);
            this._modelSettingsPositionGroupBox.Name = "_modelSettingsPositionGroupBox";
            this._modelSettingsPositionGroupBox.Size = new System.Drawing.Size(88, 112);
            this._modelSettingsPositionGroupBox.TabIndex = 2;
            this._modelSettingsPositionGroupBox.TabStop = false;
            this._modelSettingsPositionGroupBox.Text = "Положение модели";
            // 
            // _modelSettingsPositionZTextBox
            // 
            this._modelSettingsPositionZTextBox.Location = new System.Drawing.Point(30, 81);
            this._modelSettingsPositionZTextBox.Name = "_modelSettingsPositionZTextBox";
            this._modelSettingsPositionZTextBox.ReadOnly = true;
            this._modelSettingsPositionZTextBox.Size = new System.Drawing.Size(40, 20);
            this._modelSettingsPositionZTextBox.TabIndex = 5;
            // 
            // _modelSettingsPositionZLabel
            // 
            this._modelSettingsPositionZLabel.AutoSize = true;
            this._modelSettingsPositionZLabel.Location = new System.Drawing.Point(10, 84);
            this._modelSettingsPositionZLabel.Name = "_modelSettingsPositionZLabel";
            this._modelSettingsPositionZLabel.Size = new System.Drawing.Size(14, 13);
            this._modelSettingsPositionZLabel.TabIndex = 4;
            this._modelSettingsPositionZLabel.Text = "Z";
            // 
            // _modelSettingsPositionYTextBox
            // 
            this._modelSettingsPositionYTextBox.Location = new System.Drawing.Point(30, 55);
            this._modelSettingsPositionYTextBox.Name = "_modelSettingsPositionYTextBox";
            this._modelSettingsPositionYTextBox.ReadOnly = true;
            this._modelSettingsPositionYTextBox.Size = new System.Drawing.Size(40, 20);
            this._modelSettingsPositionYTextBox.TabIndex = 3;
            // 
            // _modelSettingsPositionYLabel
            // 
            this._modelSettingsPositionYLabel.AutoSize = true;
            this._modelSettingsPositionYLabel.Location = new System.Drawing.Point(10, 58);
            this._modelSettingsPositionYLabel.Name = "_modelSettingsPositionYLabel";
            this._modelSettingsPositionYLabel.Size = new System.Drawing.Size(14, 13);
            this._modelSettingsPositionYLabel.TabIndex = 2;
            this._modelSettingsPositionYLabel.Text = "Y";
            // 
            // _modelSettingsPositionXTextBox
            // 
            this._modelSettingsPositionXTextBox.Location = new System.Drawing.Point(30, 29);
            this._modelSettingsPositionXTextBox.Name = "_modelSettingsPositionXTextBox";
            this._modelSettingsPositionXTextBox.ReadOnly = true;
            this._modelSettingsPositionXTextBox.Size = new System.Drawing.Size(40, 20);
            this._modelSettingsPositionXTextBox.TabIndex = 1;
            // 
            // _modelSettingsPositionXLabel
            // 
            this._modelSettingsPositionXLabel.AutoSize = true;
            this._modelSettingsPositionXLabel.Location = new System.Drawing.Point(10, 32);
            this._modelSettingsPositionXLabel.Name = "_modelSettingsPositionXLabel";
            this._modelSettingsPositionXLabel.Size = new System.Drawing.Size(14, 13);
            this._modelSettingsPositionXLabel.TabIndex = 0;
            this._modelSettingsPositionXLabel.Text = "X";
            // 
            // _cameraSettingsRotateGroupBox
            // 
            this._cameraSettingsRotateGroupBox.Controls.Add(this._cameraSettingsRotateZTextBox);
            this._cameraSettingsRotateGroupBox.Controls.Add(this._cameraSettingsRotateZLabel);
            this._cameraSettingsRotateGroupBox.Controls.Add(this._cameraSettingsRotateYTextBox);
            this._cameraSettingsRotateGroupBox.Controls.Add(this._cameraSettingsRotateYLabel);
            this._cameraSettingsRotateGroupBox.Controls.Add(this._cameraSettingsRotateXTextBox);
            this._cameraSettingsRotateGroupBox.Controls.Add(this._cameraSettingsRotateXLabel);
            this._cameraSettingsRotateGroupBox.Location = new System.Drawing.Point(104, 20);
            this._cameraSettingsRotateGroupBox.Name = "_cameraSettingsRotateGroupBox";
            this._cameraSettingsRotateGroupBox.Size = new System.Drawing.Size(88, 112);
            this._cameraSettingsRotateGroupBox.TabIndex = 1;
            this._cameraSettingsRotateGroupBox.TabStop = false;
            this._cameraSettingsRotateGroupBox.Text = "Поворот камеры";
            // 
            // _cameraSettingsRotateZTextBox
            // 
            this._cameraSettingsRotateZTextBox.Location = new System.Drawing.Point(30, 81);
            this._cameraSettingsRotateZTextBox.Name = "_cameraSettingsRotateZTextBox";
            this._cameraSettingsRotateZTextBox.ReadOnly = true;
            this._cameraSettingsRotateZTextBox.Size = new System.Drawing.Size(40, 20);
            this._cameraSettingsRotateZTextBox.TabIndex = 5;
            // 
            // _cameraSettingsRotateZLabel
            // 
            this._cameraSettingsRotateZLabel.AutoSize = true;
            this._cameraSettingsRotateZLabel.Location = new System.Drawing.Point(10, 84);
            this._cameraSettingsRotateZLabel.Name = "_cameraSettingsRotateZLabel";
            this._cameraSettingsRotateZLabel.Size = new System.Drawing.Size(14, 13);
            this._cameraSettingsRotateZLabel.TabIndex = 4;
            this._cameraSettingsRotateZLabel.Text = "Z";
            // 
            // _cameraSettingsRotateYTextBox
            // 
            this._cameraSettingsRotateYTextBox.Location = new System.Drawing.Point(30, 55);
            this._cameraSettingsRotateYTextBox.Name = "_cameraSettingsRotateYTextBox";
            this._cameraSettingsRotateYTextBox.ReadOnly = true;
            this._cameraSettingsRotateYTextBox.Size = new System.Drawing.Size(40, 20);
            this._cameraSettingsRotateYTextBox.TabIndex = 3;
            // 
            // _cameraSettingsRotateYLabel
            // 
            this._cameraSettingsRotateYLabel.AutoSize = true;
            this._cameraSettingsRotateYLabel.Location = new System.Drawing.Point(10, 58);
            this._cameraSettingsRotateYLabel.Name = "_cameraSettingsRotateYLabel";
            this._cameraSettingsRotateYLabel.Size = new System.Drawing.Size(14, 13);
            this._cameraSettingsRotateYLabel.TabIndex = 2;
            this._cameraSettingsRotateYLabel.Text = "Y";
            // 
            // _cameraSettingsRotateXTextBox
            // 
            this._cameraSettingsRotateXTextBox.Location = new System.Drawing.Point(30, 29);
            this._cameraSettingsRotateXTextBox.Name = "_cameraSettingsRotateXTextBox";
            this._cameraSettingsRotateXTextBox.ReadOnly = true;
            this._cameraSettingsRotateXTextBox.Size = new System.Drawing.Size(40, 20);
            this._cameraSettingsRotateXTextBox.TabIndex = 1;
            // 
            // _cameraSettingsRotateXLabel
            // 
            this._cameraSettingsRotateXLabel.AutoSize = true;
            this._cameraSettingsRotateXLabel.Location = new System.Drawing.Point(10, 32);
            this._cameraSettingsRotateXLabel.Name = "_cameraSettingsRotateXLabel";
            this._cameraSettingsRotateXLabel.Size = new System.Drawing.Size(14, 13);
            this._cameraSettingsRotateXLabel.TabIndex = 0;
            this._cameraSettingsRotateXLabel.Text = "X";
            // 
            // _cameraSettingsPositionGroupBox
            // 
            this._cameraSettingsPositionGroupBox.Controls.Add(this._cameraSettingsPositionZTextBox);
            this._cameraSettingsPositionGroupBox.Controls.Add(this._cameraSettingsPositionZLabel);
            this._cameraSettingsPositionGroupBox.Controls.Add(this._cameraSettingsPositionYTextBox);
            this._cameraSettingsPositionGroupBox.Controls.Add(this._cameraSettingsPositionYLabel);
            this._cameraSettingsPositionGroupBox.Controls.Add(this._cameraSettingsPositionXTextBox);
            this._cameraSettingsPositionGroupBox.Controls.Add(this._cameraSettingsPositionXLabel);
            this._cameraSettingsPositionGroupBox.Location = new System.Drawing.Point(10, 20);
            this._cameraSettingsPositionGroupBox.Name = "_cameraSettingsPositionGroupBox";
            this._cameraSettingsPositionGroupBox.Size = new System.Drawing.Size(88, 112);
            this._cameraSettingsPositionGroupBox.TabIndex = 0;
            this._cameraSettingsPositionGroupBox.TabStop = false;
            this._cameraSettingsPositionGroupBox.Text = "Положение камеры";
            // 
            // _cameraSettingsPositionZTextBox
            // 
            this._cameraSettingsPositionZTextBox.Location = new System.Drawing.Point(30, 81);
            this._cameraSettingsPositionZTextBox.Name = "_cameraSettingsPositionZTextBox";
            this._cameraSettingsPositionZTextBox.ReadOnly = true;
            this._cameraSettingsPositionZTextBox.Size = new System.Drawing.Size(40, 20);
            this._cameraSettingsPositionZTextBox.TabIndex = 5;
            // 
            // _cameraSettingsPositionZLabel
            // 
            this._cameraSettingsPositionZLabel.AutoSize = true;
            this._cameraSettingsPositionZLabel.Location = new System.Drawing.Point(10, 84);
            this._cameraSettingsPositionZLabel.Name = "_cameraSettingsPositionZLabel";
            this._cameraSettingsPositionZLabel.Size = new System.Drawing.Size(14, 13);
            this._cameraSettingsPositionZLabel.TabIndex = 4;
            this._cameraSettingsPositionZLabel.Text = "Z";
            // 
            // _cameraSettingsPositionYTextBox
            // 
            this._cameraSettingsPositionYTextBox.Location = new System.Drawing.Point(30, 55);
            this._cameraSettingsPositionYTextBox.Name = "_cameraSettingsPositionYTextBox";
            this._cameraSettingsPositionYTextBox.ReadOnly = true;
            this._cameraSettingsPositionYTextBox.Size = new System.Drawing.Size(40, 20);
            this._cameraSettingsPositionYTextBox.TabIndex = 3;
            // 
            // _cameraSettingsPositionYLabel
            // 
            this._cameraSettingsPositionYLabel.AutoSize = true;
            this._cameraSettingsPositionYLabel.Location = new System.Drawing.Point(10, 58);
            this._cameraSettingsPositionYLabel.Name = "_cameraSettingsPositionYLabel";
            this._cameraSettingsPositionYLabel.Size = new System.Drawing.Size(14, 13);
            this._cameraSettingsPositionYLabel.TabIndex = 2;
            this._cameraSettingsPositionYLabel.Text = "Y";
            // 
            // _cameraSettingsPositionXTextBox
            // 
            this._cameraSettingsPositionXTextBox.Location = new System.Drawing.Point(30, 29);
            this._cameraSettingsPositionXTextBox.Name = "_cameraSettingsPositionXTextBox";
            this._cameraSettingsPositionXTextBox.ReadOnly = true;
            this._cameraSettingsPositionXTextBox.Size = new System.Drawing.Size(40, 20);
            this._cameraSettingsPositionXTextBox.TabIndex = 1;
            // 
            // _cameraSettingsPositionXLabel
            // 
            this._cameraSettingsPositionXLabel.AutoSize = true;
            this._cameraSettingsPositionXLabel.Location = new System.Drawing.Point(10, 32);
            this._cameraSettingsPositionXLabel.Name = "_cameraSettingsPositionXLabel";
            this._cameraSettingsPositionXLabel.Size = new System.Drawing.Size(14, 13);
            this._cameraSettingsPositionXLabel.TabIndex = 0;
            this._cameraSettingsPositionXLabel.Text = "X";
            // 
            // _modelMatrixLabel
            // 
            this._modelMatrixLabel.Location = new System.Drawing.Point(21, 22);
            this._modelMatrixLabel.Name = "_modelMatrixLabel";
            this._modelMatrixLabel.Size = new System.Drawing.Size(189, 100);
            this._modelMatrixLabel.TabIndex = 4;
            // 
            // _viewMatrixGroupBox
            // 
            this._viewMatrixGroupBox.BackColor = System.Drawing.Color.Bisque;
            this._viewMatrixGroupBox.Controls.Add(this._viewMatrixLabel);
            this._viewMatrixGroupBox.Location = new System.Drawing.Point(107, 375);
            this._viewMatrixGroupBox.Name = "_viewMatrixGroupBox";
            this._viewMatrixGroupBox.Size = new System.Drawing.Size(205, 122);
            this._viewMatrixGroupBox.TabIndex = 7;
            this._viewMatrixGroupBox.TabStop = false;
            this._viewMatrixGroupBox.Text = "Видовая матрица";
            this._viewMatrixGroupBox.Enter += new System.EventHandler(this._viewMatrixGroupBox_Enter);
            // 
            // _modelMatrixGroupBox
            // 
            this._modelMatrixGroupBox.BackColor = System.Drawing.Color.Bisque;
            this._modelMatrixGroupBox.Controls.Add(this._modelMatrixLabel);
            this._modelMatrixGroupBox.Location = new System.Drawing.Point(408, 375);
            this._modelMatrixGroupBox.Name = "_modelMatrixGroupBox";
            this._modelMatrixGroupBox.Size = new System.Drawing.Size(210, 122);
            this._modelMatrixGroupBox.TabIndex = 8;
            this._modelMatrixGroupBox.TabStop = false;
            this._modelMatrixGroupBox.Text = "Мировая матрица";
            // 
            // _modelViewMatrixGroupBox
            // 
            this._modelViewMatrixGroupBox.BackColor = System.Drawing.Color.Bisque;
            this._modelViewMatrixGroupBox.Controls.Add(this._modelViewMatrixLabel);
            this._modelViewMatrixGroupBox.Location = new System.Drawing.Point(706, 375);
            this._modelViewMatrixGroupBox.Name = "_modelViewMatrixGroupBox";
            this._modelViewMatrixGroupBox.Size = new System.Drawing.Size(210, 122);
            this._modelViewMatrixGroupBox.TabIndex = 9;
            this._modelViewMatrixGroupBox.TabStop = false;
            this._modelViewMatrixGroupBox.Text = "Результирующая видовая матрица";
            // 
            // _modelViewMatrixLabel
            // 
            this._modelViewMatrixLabel.Location = new System.Drawing.Point(6, 22);
            this._modelViewMatrixLabel.Name = "_modelViewMatrixLabel";
            this._modelViewMatrixLabel.Size = new System.Drawing.Size(189, 100);
            this._modelViewMatrixLabel.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(353, 425);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "X";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(650, 425);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "=";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1025, 533);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._modelViewMatrixGroupBox);
            this.Controls.Add(this._modelMatrixGroupBox);
            this.Controls.Add(this._viewMatrixGroupBox);
            this.Controls.Add(this._glSettingsGroupBox);
            this.Controls.Add(this._readmeGroupBox);
            this.Controls.Add(this._movingGroupBox);
            this.Controls.Add(this._cameraSimpleOpenGlControl);
            this.Controls.Add(this._viewSimpleOpenGlControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "OpenGL Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this._movingGroupBox.ResumeLayout(false);
            this._movingGroupBox.PerformLayout();
            this._readmeGroupBox.ResumeLayout(false);
            this._readmeGroupBox.PerformLayout();
            this._glSettingsGroupBox.ResumeLayout(false);
            this._modelSettingsRotateGroupBox.ResumeLayout(false);
            this._modelSettingsRotateGroupBox.PerformLayout();
            this._modelSettingsPositionGroupBox.ResumeLayout(false);
            this._modelSettingsPositionGroupBox.PerformLayout();
            this._cameraSettingsRotateGroupBox.ResumeLayout(false);
            this._cameraSettingsRotateGroupBox.PerformLayout();
            this._cameraSettingsPositionGroupBox.ResumeLayout(false);
            this._cameraSettingsPositionGroupBox.PerformLayout();
            this._viewMatrixGroupBox.ResumeLayout(false);
            this._modelMatrixGroupBox.ResumeLayout(false);
            this._modelViewMatrixGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Tao.Platform.Windows.SimpleOpenGlControl _viewSimpleOpenGlControl;
        private System.Windows.Forms.ColorDialog _fillColor1Dialog;
        private System.Windows.Forms.ColorDialog _fillColor2Dialog;
        private Tao.Platform.Windows.SimpleOpenGlControl _cameraSimpleOpenGlControl;
        private System.Windows.Forms.GroupBox _movingGroupBox;
        private System.Windows.Forms.RadioButton _cameraRadioButton;
        private System.Windows.Forms.RadioButton _modelRadioButton;
        private System.Windows.Forms.Label _viewMatrixLabel;
        private System.Windows.Forms.GroupBox _readmeGroupBox;
        private System.Windows.Forms.Label _readmeLabel1;
        private System.Windows.Forms.Label _readmeLabel2;
        private System.Windows.Forms.GroupBox _glSettingsGroupBox;
        private System.Windows.Forms.GroupBox _cameraSettingsPositionGroupBox;
        private System.Windows.Forms.TextBox _cameraSettingsPositionZTextBox;
        private System.Windows.Forms.Label _cameraSettingsPositionZLabel;
        private System.Windows.Forms.TextBox _cameraSettingsPositionYTextBox;
        private System.Windows.Forms.Label _cameraSettingsPositionYLabel;
        private System.Windows.Forms.TextBox _cameraSettingsPositionXTextBox;
        private System.Windows.Forms.Label _cameraSettingsPositionXLabel;
        private System.Windows.Forms.GroupBox _cameraSettingsRotateGroupBox;
        private System.Windows.Forms.TextBox _cameraSettingsRotateZTextBox;
        private System.Windows.Forms.Label _cameraSettingsRotateZLabel;
        private System.Windows.Forms.TextBox _cameraSettingsRotateYTextBox;
        private System.Windows.Forms.Label _cameraSettingsRotateYLabel;
        private System.Windows.Forms.TextBox _cameraSettingsRotateXTextBox;
        private System.Windows.Forms.Label _cameraSettingsRotateXLabel;
        private System.Windows.Forms.GroupBox _modelSettingsRotateGroupBox;
        private System.Windows.Forms.TextBox _modelSettingsRotateZTextBox;
        private System.Windows.Forms.Label _modelSettingsRotateZLabel;
        private System.Windows.Forms.TextBox _modelSettingsRotateYTextBox;
        private System.Windows.Forms.Label _modelSettingsRotateYLabel;
        private System.Windows.Forms.TextBox _modelSettingsRotateXTextBox;
        private System.Windows.Forms.Label _modelSettingsRotateXLabel;
        private System.Windows.Forms.GroupBox _modelSettingsPositionGroupBox;
        private System.Windows.Forms.TextBox _modelSettingsPositionZTextBox;
        private System.Windows.Forms.Label _modelSettingsPositionZLabel;
        private System.Windows.Forms.TextBox _modelSettingsPositionYTextBox;
        private System.Windows.Forms.Label _modelSettingsPositionYLabel;
        private System.Windows.Forms.TextBox _modelSettingsPositionXTextBox;
        private System.Windows.Forms.Label _modelSettingsPositionXLabel;
        private System.Windows.Forms.Label _modelMatrixLabel;
        private System.Windows.Forms.GroupBox _viewMatrixGroupBox;
        private System.Windows.Forms.GroupBox _modelMatrixGroupBox;
        private System.Windows.Forms.GroupBox _modelViewMatrixGroupBox;
        private System.Windows.Forms.Label _modelViewMatrixLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

