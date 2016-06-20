using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tao.OpenGl;
using Tao.FreeGlut;
using Tao.Platform.Windows;
using GlmNet;

namespace Diplom
{
    // Модель
    public class Model
    {
        #region Переменные и константы

        // Константы
        private const float DEG2RAD = 3.141593f / 180; // Градусы в радианы
        private const float FOV_Y = 60.0f;              
        private const float NEAR_PLANE = 1.0f;
        private const float FAR_PLANE = 100.0f;

        // Для камеры 
        private const float CAMERA_ANGLE_X = 45.0f;     
        private const float CAMERA_ANGLE_Y = -45.0f;    
        private const float CAMERA_DISTANCE = 25.0f;    // Расстояние камеры до модели

        private int windowWidth = 0;
        private int windowHeight = 0;
        private bool windowSizeChanged = false;
        private bool drawModeChanged = false;
        private int drawMode = 0;

        private float[] cameraPosition = new float[3] { 0.0f, 0.0f, 10.0f };
        private float[] cameraAngle = new float[3] { 0.0f, 0.0f, 0.0f };
        private float[] modelPosition = new float[3] { 0.0f, 0.0f, 0.0f };
        private float[] modelAngle = new float[3] { 0.0f, 0.0f, 0.0f };

        private float cameraAngleX = CAMERA_ANGLE_X;
        private float cameraAngleY = CAMERA_ANGLE_Y;
        private float cameraDistance = CAMERA_DISTANCE;
        private float[] bgColor = new float[4] { 0.0f, 0.0f, 0.0f, 0.0f };

        // Матрицы 
        private mat4 matrixView = new mat4(1.0f);
        private mat4 matrixModel = new mat4(1.0f);
        private mat4 matrixModelView = new mat4(1.0f);
        private mat4 matrixProjection = new mat4(1.0f);

        #endregion

        #region Методы для получения и установки данных

        public float CameraX
        {
            get { return cameraPosition[0]; }
            set { cameraPosition[0] = value; updateViewMatrix(); }
        }

        public float CameraY
        {
            get { return cameraPosition[1]; }
            set { cameraPosition[1] = value; updateViewMatrix(); }
        }

        public float CameraZ
        {
            get { return cameraPosition[2]; }
            set { cameraPosition[2] = value; updateViewMatrix(); }
        }

        public float CameraAngleX
        {
            get { return cameraAngle[0]; }
            set { cameraAngle[0] = value; updateViewMatrix(); }
        }

        public float CameraAngleY
        {
            get { return cameraAngle[1]; }
            set { cameraAngle[1] = value; updateViewMatrix(); }
        }

        public float CameraAngleZ
        {
            get { return cameraAngle[2]; }
            set { cameraAngle[2] = value; updateViewMatrix(); }
        }

        public float ModelX
        {
            get { return modelPosition[0]; }
            set { modelPosition[0] = value; updateModelMatrix(); }
        }

        public float ModelY
        {
            get { return modelPosition[1]; }
            set { modelPosition[1] = value; updateModelMatrix(); }
        }

        public float ModelZ
        {
            get { return modelPosition[1]; }
            set { modelPosition[1] = value; updateModelMatrix(); }
        }

        public float ModelAngleX
        {
            get { return modelAngle[0]; }
            set { modelAngle[0] = value; updateModelMatrix(); }
        }

        public float ModelAngleY
        {
            get { return modelAngle[1]; }
            set { modelAngle[1] = value; updateModelMatrix(); }
        }

        public float ModelAngleZ
        {
            get { return modelAngle[2]; }
            set { modelAngle[2] = value; updateModelMatrix(); }
        }

        #endregion

        #region Получение матриц

        public float[] getViewMatrixElements()
        {
            return matrixView.to_array();
        }

        public float[] getModelMatrixElements()
        {
            return matrixModel.to_array();
        }

        public float[] getModelViewMatrixElements()
        {
            return matrixModelView.to_array();
        }

        public float[] getProjectionMatrixElements()
        {
            return matrixProjection.to_array();
        }

        #endregion

        #region Инициализация OpenGL и сцены

        public void init()
        {
            Gl.glShadeModel(Gl.GL_SMOOTH);
            // Свойства распаковки
            Gl.glPixelStorei(Gl.GL_UNPACK_ALIGNMENT, 4);         

            // Работа со свойствами
            Gl.glHint(Gl.GL_PERSPECTIVE_CORRECTION_HINT, Gl.GL_NICEST);
           
            Gl.glEnable(Gl.GL_DEPTH_TEST);
            Gl.glEnable(Gl.GL_LIGHTING); // Освещение
            Gl.glEnable(Gl.GL_TEXTURE_2D);

            // Устранение спрятанных поверхностей
            Gl.glEnable(Gl.GL_CULL_FACE);
            Gl.glEnable(Gl.GL_BLEND);
            Gl.glEnable(Gl.GL_SCISSOR_TEST);

            // Свойства материала
            Gl.glColorMaterial(Gl.GL_FRONT_AND_BACK, Gl.GL_AMBIENT_AND_DIFFUSE);
            Gl.glEnable(Gl.GL_COLOR_MATERIAL);

            // Установка цвета окна
            Gl.glClearColor(bgColor[0], bgColor[1], bgColor[2], bgColor[3]);   
            // Значение, которым будет заполняться буффер трафарета при очистке:
            Gl.glClearStencil(0);                              
            Gl.glClearDepth(1.0f);                           
            Gl.glDepthFunc(Gl.GL_LEQUAL); // Функция глубины - рисуется все, что имеет глубину

            initLights();
        }

        #endregion

        #region Источники света

        public void initLights()
        {
            // Установка параметров освещения
            float[] lightKa = new float[] { .0f, .0f, .0f, 1.0f };      // фоновый свет
            float[] lightKd = new float[] { .9f, .9f, .9f, 1.0f };      // диффузный свет
            float[] lightKs = new float[] { 1, 1, 1, 1 };               // зеркальный свет

            Gl.glLightfv(Gl.GL_LIGHT0, Gl.GL_AMBIENT, lightKa);
            Gl.glLightfv(Gl.GL_LIGHT0, Gl.GL_DIFFUSE, lightKd);
            Gl.glLightfv(Gl.GL_LIGHT0, Gl.GL_SPECULAR, lightKs);

            // Позиция источника
            float[] lightPos = new float[] { 0, 1, 1, 0 };               // направленный свет
            Gl.glLightfv(Gl.GL_LIGHT0, Gl.GL_POSITION, lightPos);

            Gl.glEnable(Gl.GL_LIGHT0);                           
        }

        #endregion

        private vec4 CreateVec4FromArray(float[] arr)
        {
            return new vec4(arr[0], arr[1], arr[2], arr[3]);
        }

        #region Позиция камеры

        public void setCamera(float posX, float posY, float posZ, float targetX, float targetY, float targetZ)
        {
            float[] forward = new float[4];
            float[] up = new float[4];
            float[] left = new float[4];
            float[] position = new float[4];
            float invLength;

            forward[0] = posX - targetX;    // x
            forward[1] = posY - targetY;    // y
            forward[2] = posZ - targetZ;    // z
            forward[3] = 0.0f;              // w

            // Нормализация
            invLength = 1.0f / (float)Math.Sqrt(forward[0] * forward[0] + forward[1] * forward[1] + forward[2] * forward[2]);
            forward[0] *= invLength;
            forward[1] *= invLength;
            forward[2] *= invLength;

            up[0] = 0.0f;   // x
            up[1] = 1.0f;   // y
            up[2] = 0.0f;   // z
            up[3] = 0.0f;   // w

            left[0] = up[1] * forward[2] - up[2] * forward[1];  // x
            left[1] = up[2] * forward[0] - up[0] * forward[2];  // y
            left[2] = up[0] * forward[1] - up[1] * forward[0];  // z
            left[3] = 1.0f;                                 // w

            // Вычисление ортогонального вектора
            up[0] = forward[1] * left[2] - forward[2] * left[1];    // x
            up[1] = forward[2] * left[0] - forward[0] * left[2];    // y
            up[2] = forward[0] * left[1] - forward[1] * left[0];    // z
            up[3] = 0.0f;                                       // w

            // Позиция камеры
            position[0] = -posX;
            position[1] = -posY;
            position[2] = -posZ;
            position[3] = 1.0f;

            matrixView = new mat4(CreateVec4FromArray(left), CreateVec4FromArray(up), CreateVec4FromArray(forward), CreateVec4FromArray(position));
        }

        #endregion 

        // Размер окна
        public void setWindowSize(int width, int height)
        {
            windowWidth = width;
            windowHeight = height;
            windowSizeChanged = true;
        }

        private mat4 TransposeMatrix(mat4 matrix)
        {
            float[] tm = new float[16];
            float[] m = matrix.to_array();

            tm[0] = m[0]; tm[1] = m[4]; tm[2] = m[8]; tm[3] = m[12];
            tm[4] = m[1]; tm[5] = m[5]; tm[6] = m[9]; tm[7] = m[13];
            tm[8] = m[2]; tm[9] = m[6]; tm[10] = m[10]; tm[11] = m[14];
            tm[12] = m[3]; tm[13] = m[7]; tm[14] = m[11]; tm[15] = m[15];

            return CreateMat4FromArray(tm);
        }

        #region Проекции

        public void setFrustum(float fovY, float aspectRatio, float front, float back)
        {
            float tangent = (float)Math.Tan(fovY / 2 * DEG2RAD);  
            float height = front * tangent;           
            float width = height * aspectRatio;       

            setFrustum(-width, width, -height, height, front, back);
        }

        public void setFrustum(float l, float r, float b, float t, float n, float f)
        {
            matrixProjection = new mat4(1.0f);
            var arr = matrixProjection.to_array();

            arr[0] = 2 * n / (r - l);
            arr[2] = (r + l) / (r - l);
            arr[5] = 2 * n / (t - b);
            arr[6] = (t + b) / (t - b);
            arr[10] = -(f + n) / (f - n);
            arr[11] = -(2 * f * n) / (f - n);
            arr[14] = -1;
            arr[15] = 0;

            matrixProjection = CreateMat4FromArray(arr);
        }

        #endregion

        public void setViewport(int x, int y, int w, int h)
        {
            Gl.glViewport(x, y, w, h);

            setFrustum(FOV_Y, (float)(w) / h, NEAR_PLANE, FAR_PLANE); 

            Gl.glMatrixMode(Gl.GL_PROJECTION);
            
            Gl.glLoadMatrixf(TransposeMatrix(matrixProjection).to_array());
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();
        }

        public void setViewportSub(int x, int y, int width, int height, float nearPlane, float farPlane)
        {
            Gl.glViewport(x, y, width, height);
            Gl.glScissor(x, y, width, height);

            setFrustum(FOV_Y, (float)(width) / height, nearPlane, farPlane); 

            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadMatrixf(TransposeMatrix(matrixProjection).to_array());
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();
        }
       
        private mat4 CreateMat4FromArray(float[] arr)
        {
            return new mat4(new vec4(arr[0], arr[1], arr[2], arr[3]),
                new vec4(arr[4], arr[5], arr[6], arr[7]),
                new vec4(arr[8], arr[9], arr[10], arr[11]),
                new vec4(arr[12], arr[13], arr[14], arr[15]));
        }

        #region Сцена

        public void draw()
        {
            drawSub1();
            drawSub2();

            if (windowSizeChanged)
            {
                setViewport(0, 0, windowWidth, windowHeight);
                windowSizeChanged = false;
            }

            if (drawModeChanged)
            {
                if (drawMode == 0)           
                {
                    Gl.glPolygonMode(Gl.GL_FRONT_AND_BACK, Gl.GL_FILL);
                    Gl.glEnable(Gl.GL_DEPTH_TEST);
                    Gl.glEnable(Gl.GL_CULL_FACE);
                }
                else if (drawMode == 1)      
                {
                    Gl.glPolygonMode(Gl.GL_FRONT_AND_BACK, Gl.GL_LINE);
                    Gl.glDisable(Gl.GL_DEPTH_TEST);
                    Gl.glDisable(Gl.GL_CULL_FACE);
                }
                else if (drawMode == 2)      
                {
                    Gl.glPolygonMode(Gl.GL_FRONT_AND_BACK, Gl.GL_POINT);
                    Gl.glDisable(Gl.GL_DEPTH_TEST);
                    Gl.glDisable(Gl.GL_CULL_FACE);
                }
                drawModeChanged = false;
            }
        }

        #endregion

        #region Первое окно с объектом

        public void drawSub1()
        {
            int halfHeight = windowHeight / 2;

            // Чистка
            setViewportSub(0, 0, windowWidth, windowHeight, NEAR_PLANE, FAR_PLANE);
            
            Gl.glClearColor(0.2f, 0.2f, 0.2f, 1);
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT | Gl.GL_STENCIL_BUFFER_BIT);

            Gl.glPushMatrix();

            Gl.glLoadMatrixf(TransposeMatrix(matrixView).to_array());

            Gl.glLoadMatrixf(TransposeMatrix(matrixModelView).to_array());

            // Оси
            drawAxis(4);
            drawTeapot();

            Gl.glPopMatrix();
        }

        #endregion

        // Рисует чайник
        private void drawTeapot()
        {
            Glut.glutSolidTeapot(1.0f);
        }

        #region Рисуем второе окно OpenGL

        public void drawSub2()
        {
            setViewportSub(0, 0, windowWidth, windowHeight, NEAR_PLANE, FAR_PLANE);

            // Чистка буффера
            Gl.glClearColor(bgColor[0], bgColor[1], bgColor[2], bgColor[3]);   // background color
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT | Gl.GL_STENCIL_BUFFER_BIT);

            Gl.glPushMatrix();

            //Для камеры
            Gl.glTranslatef(0, 0, -cameraDistance);
            Gl.glRotatef(cameraAngleX, 1, 0, 0); 
            Gl.glRotatef(cameraAngleY, 0, 1, 0); 

            // Рисуем сетку
            drawGrid(10, 1);

            // Рисуем чайник
            Gl.glPushMatrix();
            Gl.glTranslatef(modelPosition[0], modelPosition[1], modelPosition[2]);
            Gl.glRotatef(modelAngle[0], 1, 0, 0);
            Gl.glRotatef(modelAngle[1], 0, 1, 0);
            Gl.glRotatef(modelAngle[2], 0, 0, 1);

            // Оси
            drawAxis(4);
            drawTeapot();
            Gl.glPopMatrix();

            // Камера
            Gl.glPushMatrix();
            Gl.glTranslatef(cameraPosition[0], cameraPosition[1], cameraPosition[2]);
            Gl.glRotatef(cameraAngle[0], 1, 0, 0);
            Gl.glRotatef(cameraAngle[1], 0, 1, 0);
            Gl.glRotatef(cameraAngle[2], 0, 0, 1);
            
            drawFrustum(FOV_Y, 1, 1, 10);
            Gl.glPopMatrix();

            Gl.glPopMatrix();
        }

        // Наша камера
        private void drawCamera()
        {
            Glut.glutSolidSphere(1.0f, 8, 8);
        }

        #endregion

        #region Сетка

        private void drawGrid(float size, float step)
        {
            Gl.glDisable(Gl.GL_LIGHTING);

            Gl.glBegin(Gl.GL_LINES);

            Gl.glColor3f(0.3f, 0.3f, 0.3f);
         
            for (float i = step; i <= size; i += step)
            {
                Gl.glVertex3f(-size, 0, i);   // параллельно X
                Gl.glVertex3f(size, 0, i);
                Gl.glVertex3f(-size, 0, -i);   // параллельно X
                Gl.glVertex3f(size, 0, -i);

                Gl.glVertex3f(i, 0, -size);   // параллельно Z
                Gl.glVertex3f(i, 0, size);
                Gl.glVertex3f(-i, 0, -size);   // параллельно Z
                Gl.glVertex3f(-i, 0, size);
            }

            // Ось х
            Gl.glColor3f(0.5f, 0, 0);
            Gl.glVertex3f(-size, 0, 0);
            Gl.glVertex3f(size, 0, 0);

            // Ось z
            Gl.glColor3f(0, 0, 0.5f);
            Gl.glVertex3f(0, 0, -size);
            Gl.glVertex3f(0, 0, size);

            Gl.glEnd();

            Gl.glEnable(Gl.GL_LIGHTING);
        }

        #endregion

        #region Оси

        private void drawAxis(float size)
        {
            Gl.glDepthFunc(Gl.GL_ALWAYS);     // для перерисовки
            Gl.glDisable(Gl.GL_LIGHTING);
            Gl.glPushMatrix();            

            // Рисуем оси
            Gl.glLineWidth(3);

            Gl.glBegin(Gl.GL_LINES);

            Gl.glColor3f(1, 0, 0);
            Gl.glVertex3f(0, 0, 0);
            Gl.glVertex3f(size, 0, 0);

            Gl.glColor3f(0, 1, 0);
            Gl.glVertex3f(0, 0, 0);
            Gl.glVertex3f(0, size, 0);

            Gl.glColor3f(0, 0, 1);
            Gl.glVertex3f(0, 0, 0);
            Gl.glVertex3f(0, 0, size);
        
            Gl.glEnd();
            Gl.glLineWidth(1);

            // Стрелки
            Gl.glPointSize(5);
            Gl.glBegin(Gl.GL_POINTS);
            
            Gl.glColor3f(1, 0, 0);
            Gl.glVertex3f(size, 0, 0);
            Gl.glColor3f(0, 1, 0);
            
            Gl.glVertex3f(0, size, 0);
            Gl.glColor3f(0, 0, 1);
            Gl.glVertex3f(0, 0, size);
            
            Gl.glEnd();
            Gl.glPointSize(1);

            Gl.glPopMatrix();
            Gl.glEnable(Gl.GL_LIGHTING);
            Gl.glDepthFunc(Gl.GL_LEQUAL);
        }

        #endregion 

        // Проекция
        private void drawFrustum(float fovY, float aspectRatio, float nearPlane, float farPlane)
        {
            float tangent = (float)Math.Tan(fovY / 2 * DEG2RAD);
            float nearHeight = nearPlane * tangent;
            float nearWidth = nearHeight * aspectRatio;
            float farHeight = farPlane * tangent;
            float farWidth = farHeight * aspectRatio;

            float[][] vertices = new float[8][] { new float[3], new float[3], new float[3],
            new float[3], new float[3], new float[3],
            new float[3], new float[3]};
            
            vertices[0][0] = nearWidth; vertices[0][1] = nearHeight; vertices[0][2] = -nearPlane;
            
            vertices[1][0] = -nearWidth; vertices[1][1] = nearHeight; vertices[1][2] = -nearPlane;
            
            vertices[2][0] = -nearWidth; vertices[2][1] = -nearHeight; vertices[2][2] = -nearPlane;
            
            vertices[3][0] = nearWidth; vertices[3][1] = -nearHeight; vertices[3][2] = -nearPlane;
            
            vertices[4][0] = farWidth; vertices[4][1] = farHeight; vertices[4][2] = -farPlane;
            
            vertices[5][0] = -farWidth; vertices[5][1] = farHeight; vertices[5][2] = -farPlane;
          
            vertices[6][0] = -farWidth; vertices[6][1] = -farHeight; vertices[6][2] = -farPlane;
           
            vertices[7][0] = farWidth; vertices[7][1] = -farHeight; vertices[7][2] = -farPlane;

            float[] colorLine1 = new float[] { 0.7f, 0.7f, 0.7f, 0.7f };
            float[] colorLine2 = new float[] { 0.2f, 0.2f, 0.2f, 0.7f };
            float[] colorPlane = new float[] { 0.5f, 0.5f, 0.5f, 0.5f };

            Gl.glDisable(Gl.GL_LIGHTING);
            Gl.glDisable(Gl.GL_CULL_FACE);
            Gl.glBlendFunc(Gl.GL_SRC_ALPHA, Gl.GL_ONE_MINUS_SRC_ALPHA);

            // Границы
            Gl.glBegin(Gl.GL_LINES);
            Gl.glColor4fv(colorLine2);
            Gl.glVertex3f(0, 0, 0);
            Gl.glColor4fv(colorLine1);
            Gl.glVertex3fv(vertices[4]);

            Gl.glColor4fv(colorLine2);
            Gl.glVertex3f(0, 0, 0);
            Gl.glColor4fv(colorLine1);
            Gl.glVertex3fv(vertices[5]);

            Gl.glColor4fv(colorLine2);
            Gl.glVertex3f(0, 0, 0);
            Gl.glColor4fv(colorLine1);
            Gl.glVertex3fv(vertices[6]);

            Gl.glColor4fv(colorLine2);
            Gl.glVertex3f(0, 0, 0);
            Gl.glColor4fv(colorLine1);
            Gl.glVertex3fv(vertices[7]);
            Gl.glEnd();

            Gl.glColor4fv(colorLine1);
            Gl.glBegin(Gl.GL_LINE_LOOP);
            Gl.glVertex3fv(vertices[4]);
            Gl.glVertex3fv(vertices[5]);
            Gl.glVertex3fv(vertices[6]);
            Gl.glVertex3fv(vertices[7]);
            Gl.glEnd();

            Gl.glColor4fv(colorLine1);
            Gl.glBegin(Gl.GL_LINE_LOOP);
            Gl.glVertex3fv(vertices[0]);
            Gl.glVertex3fv(vertices[1]);
            Gl.glVertex3fv(vertices[2]);
            Gl.glVertex3fv(vertices[3]);
            Gl.glEnd();

            Gl.glColor4fv(colorPlane);
            Gl.glBegin(Gl.GL_QUADS);
            Gl.glVertex3fv(vertices[0]);
            Gl.glVertex3fv(vertices[1]);
            Gl.glVertex3fv(vertices[2]);
            Gl.glVertex3fv(vertices[3]);
            Gl.glVertex3fv(vertices[4]);
            Gl.glVertex3fv(vertices[5]);
            Gl.glVertex3fv(vertices[6]);
            Gl.glVertex3fv(vertices[7]);
            Gl.glEnd();

            Gl.glEnable(Gl.GL_CULL_FACE);
            Gl.glEnable(Gl.GL_LIGHTING);
        }

        #region Работа с матрицами

        #region Поворот камеры и объекта

        public void setViewMatrix(float x, float y, float z, float pitch, float heading, float roll)
        {
            cameraPosition[0] = x;
            cameraPosition[1] = y;
            cameraPosition[2] = z;

            cameraAngle[0] = pitch;
            cameraAngle[1] = heading;
            cameraAngle[2] = roll;

            updateViewMatrix();
        }

        public void setModelMatrix(float x, float y, float z, float rx, float ry, float rz)
        {
            modelPosition[0] = x;
            modelPosition[1] = y;
            modelPosition[2] = z;
            modelAngle[0] = rx;
            modelAngle[1] = ry;
            modelAngle[2] = rz;

            updateModelMatrix();
        }

        #endregion

        private void updateViewMatrix()
        {
            matrixView = new mat4(1.0f);

            matrixView = glm.rotate(matrixView, -cameraAngle[2], new vec3(0.0f, 0.0f, 1.0f));    
            matrixView = glm.rotate(matrixView, -cameraAngle[1], new vec3(0.0f, 1.0f, 0.0f));    
            matrixView = glm.rotate(matrixView, -cameraAngle[0], new vec3(1.0f, 0.0f, 0.0f));   

            matrixView = glm.translate(matrixView, new vec3(-cameraPosition[0], -cameraPosition[1], -cameraPosition[2]));

            matrixModelView = matrixView * matrixModel;
        }

        private void updateModelMatrix()
        {
            matrixModel = new mat4(1.0f);
            matrixModel = glm.translate(matrixModel, new vec3(modelPosition[0], modelPosition[1], modelPosition[2]));

            matrixModel = glm.rotate(matrixModel, modelAngle[2], new vec3(0.0f, 0.0f, 1.0f));
            matrixModel = glm.rotate(matrixModel, modelAngle[1], new vec3(0.0f, 1.0f, 0.0f));
            matrixModel = glm.rotate(matrixModel, modelAngle[0], new vec3(1.0f, 0.0f, 0.0f));

            matrixModelView = matrixView * matrixModel;
        }

        #endregion
    }
}
