using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tao.OpenGl;
using Tao.FreeGlut;
using Tao.Platform.Windows;

using GlmNet;

namespace Diplom
{
    
    public partial class Form1 : Form
    {
        // Объект - модель
        private Model _model = new Model();

        // Что будем контроллировать
        private enum WhatControlled { Camera, Model };

        // По умолчанию мы управляем камерой
        private WhatControlled _currentControl = WhatControlled.Camera;

        private bool _isGlutInitialized = false;

        // Для пояснения, как управлять объектами 
        private string[] _readme = new string[] 
        {
            "Q/W A/S Z/X - Translate by X/Y/Z",
            "E/R D/F C/V - Rotate by X/Y/Z"
        };

        private SimpleOpenGlControl[] OpenGlControls = new SimpleOpenGlControl[2];

        #region Инициализация формы

        public Form1()
        {
            InitializeComponent();

            // Инициализация положения камеры
            _model.CameraX = 0;
            _model.CameraY = 0;
            _model.CameraZ = 10;

            UpdateMatrices();
            UpdateSettings();

            // Наши контроллеры ( так как у нас два окна, в котором идет прорисовка) 
            OpenGlControls[0] = _viewSimpleOpenGlControl;
            OpenGlControls[1] = _cameraSimpleOpenGlControl;

            // Для каждого контроллера : установка соответствующих размеров
            foreach (var openGlControl in OpenGlControls)
            {
                openGlControl.InitializeContexts();
                openGlControl.MakeCurrent();
                ResizeWindow(openGlControl.Width, openGlControl.Height);
            }
        }

        #endregion

        // Изменение размеров окна
        private void ResizeWindow(int width, int height)
        {
            _model.setWindowSize(width, height);
        }

        #region Рендеринг

        // Перерисовка
        private void Render()
        {
            // Модель
            {
                OpenGlControls[0].MakeCurrent();
                _model.drawSub1();
            }
            
            // Камера
            {
                OpenGlControls[1].MakeCurrent();
                _model.drawSub2();
            }

            _viewSimpleOpenGlControl.Invalidate();
            _cameraSimpleOpenGlControl.Invalidate();
        }

        #endregion

        private void InitializeOpenGL()
        {
            if (!_isGlutInitialized)
            {
                Glut.glutInit();
                _isGlutInitialized = true;
            }

            _model.init();
        }

        // Загрузка формы
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var openGlControl in OpenGlControls)
            {
                openGlControl.MakeCurrent();
                InitializeOpenGL();
            }
            Render();
        }

        #region Матрицы

        // Создание матриц, которые выводятся под окошками с объектами
        private string CreatePrintableMatrixFromArray(float[] arr)
        {
            StringBuilder sb = new StringBuilder();
            if (arr.Length != 16)
                return "ERROR";

            for (int i = 0; i < 4; ++i)
            {
                for (int j = 0; j < 4; ++j)
                {
                    sb.Append(Math.Round(arr[j * 4 + i], 2).ToString().PadLeft(8))
                      .Append(" ");
                }
                sb.AppendLine();
            }

            return sb.ToString();
        }

        // Обновление матриц
        private void UpdateMatrices()
        {
            _viewMatrixLabel.Text = CreatePrintableMatrixFromArray(_model.getViewMatrixElements());
            _modelMatrixLabel.Text = CreatePrintableMatrixFromArray(_model.getModelMatrixElements());
            _modelViewMatrixLabel.Text = CreatePrintableMatrixFromArray(_model.getModelViewMatrixElements());
        }

        #endregion

        // Перевод из радианов в градусы
        private float ConvertRadian2Degree(float x)
        {
            return x * (float)Math.PI / 180.0f;
        }

        #region Обновление данных о камере и модели

        // Обновление данных о камере и модели
        private void UpdateSettings()
        {
            _cameraSettingsPositionXTextBox.Text = _model.CameraX.ToString();
            _cameraSettingsPositionYTextBox.Text = _model.CameraY.ToString();
            _cameraSettingsPositionZTextBox.Text = _model.CameraZ.ToString();

            _cameraSettingsRotateXTextBox.Text = _model.CameraAngleX.ToString();
            _cameraSettingsRotateYTextBox.Text = _model.CameraAngleY.ToString();
            _cameraSettingsRotateZTextBox.Text = _model.CameraAngleZ.ToString();

            _modelSettingsPositionXTextBox.Text = _model.ModelX.ToString();
            _modelSettingsPositionYTextBox.Text = _model.ModelY.ToString();
            _modelSettingsPositionZTextBox.Text = _model.ModelZ.ToString();

            _modelSettingsRotateXTextBox.Text = _model.ModelAngleX.ToString();
            _modelSettingsRotateYTextBox.Text = _model.ModelAngleY.ToString();
            _modelSettingsRotateZTextBox.Text = _model.ModelAngleZ.ToString();
        }

        #endregion

        #region Управление клавиатурой

        // Управление клавиатурой
        private void _simpleOpenGlControl_KeyDown(object sender, KeyEventArgs e)
        {
            float cameraDelta = 0.1f;
            float modelDelta = 0.2f;

            switch (e.KeyCode)
            {
                case Keys.Q:
                    if (_currentControl == WhatControlled.Camera)
                        _model.CameraX += cameraDelta;
                    else
                        _model.ModelX += modelDelta;
                    break;
                case Keys.W:
                    if (_currentControl == WhatControlled.Camera)
                        _model.CameraX -= cameraDelta;
                    else
                        _model.ModelX -= modelDelta;
                    break;
                case Keys.A:
                    if (_currentControl == WhatControlled.Camera)
                        _model.CameraY += cameraDelta;
                    else
                        _model.ModelY += modelDelta;
                    break;
                case Keys.S:
                    if (_currentControl == WhatControlled.Camera)
                        _model.CameraY -= cameraDelta;
                    else
                        _model.ModelY -= modelDelta;
                    break;
                case Keys.Z:
                    if (_currentControl == WhatControlled.Camera)
                        _model.CameraZ += cameraDelta;
                    else
                        _model.ModelZ += modelDelta;
                    break;
                case Keys.X:
                    if (_currentControl == WhatControlled.Camera)
                        _model.CameraZ -= cameraDelta;
                    else
                        _model.ModelZ -= modelDelta;
                    break;

                case Keys.E:
                    if (_currentControl == WhatControlled.Camera)
                        _model.CameraAngleX += cameraDelta;
                    else
                        _model.ModelAngleX += modelDelta;
                    break;
                case Keys.R:
                    if (_currentControl == WhatControlled.Camera)
                        _model.CameraAngleX -= cameraDelta;
                    else
                        _model.ModelAngleX -= modelDelta;
                    break;
                case Keys.D:
                    if (_currentControl == WhatControlled.Camera)
                        _model.CameraAngleY += cameraDelta;
                    else
                        _model.ModelAngleY += modelDelta;
                    break;
                case Keys.F:
                    if (_currentControl == WhatControlled.Camera)
                        _model.CameraAngleY -= cameraDelta;
                    else
                        _model.ModelAngleY -= modelDelta;
                    break;
                case Keys.C:
                    if (_currentControl == WhatControlled.Camera)
                        _model.CameraAngleZ += cameraDelta;
                    else
                        _model.ModelAngleZ += modelDelta;
                    break;
                case Keys.V:
                    if (_currentControl == WhatControlled.Camera)
                        _model.CameraAngleZ -= cameraDelta;
                    else
                        _model.ModelAngleZ -= modelDelta;
                    break;
            }
            //foreach (var openGlControl in OpenGlControls)
            {
                //openGlControl.MakeCurrent();
                Render();
            }

            UpdateMatrices();
            UpdateSettings();
        }

        #endregion

        #region Управление радиокнопкой

        // Управление радиокнопкой
        private void _cameraRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked)
                _currentControl = WhatControlled.Camera;

            _cameraSimpleOpenGlControl.Focus();
        }

        private void _modelRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked)
                _currentControl = WhatControlled.Model;

            _viewSimpleOpenGlControl.Focus();
        }

        #endregion
        
        //////////////////////////////////////////////////////////////////////////////
        private void _viewMatrixGroupBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
