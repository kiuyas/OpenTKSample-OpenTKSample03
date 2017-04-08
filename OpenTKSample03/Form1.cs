using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace OpenTKSample03
{
    public partial class Form1 : Form
    {
        #region 定数フィールド

        /// <summary>Fovy以外の各パラメータに指定できる最大値</summary>
        private const float MAX = 65;

        /// <summary>Fovy以外の各パラメータの精度</summary>
        private const float TICK = 0.01F;

        /// <summary>Fovy以外の各パラメータのトラックバーの最大値</summary>
        private const float TRACKBAR_MAX = MAX * (1 / TICK);

        /// <summary>飛行するZ座標</summary>
        private const float Z = 0.5F;

        #endregion

        #region フィールド

        /// <summary>描画パラメータ1(上から俯瞰)</summary>
        private ViewPointParam param1;

        /// <summary>描画パラメータ2(コックピット視点)</summary>
        private ViewPointParam param2;

        /// <summary>飛行軌道データ</summary>
        private List<Vector3> pointList;

        /// <summary>時間</summary>
        private int t = 1;

        /// <summary>ビューモード(0=俯瞰、1=コックピット)</summary>
        private int viewMode = 0;

        /// <summary>旋回角(Z軸周りの回転角)</summary>
        private int alpha = 0;

        /// <summary>仰俯角(X軸周りの回転角)</summary>
        private int beta = 0;

        /// <summary>マウスドラッグ開始点X座標</summary>
        private int startX = -1;

        /// <summary>マウスドラッグ開始点Y座標</summary>
        private int startY = -1;

        /// <summary>マウスドラッグ開始時EyeX</summary>
        private float startEyeX = 0;

        /// <summary>マウスドラッグ開始時EyeY</summary>
        private float startEyeY = 0;

        /// <summary>マウスドラッグ開始時Alpha</summary>
        private float startAlpha = 0;

        /// <summary>マウスドラッグ開始時Beta</summary>
        private float startBeta = 0;

        /// <summary>トラックバーオブジェクト群</summary>
        private TrackBar[] trackbars;

        /// <summary>値表示ラベルオブジェクト群</summary>
        private Label[] labels;

        #endregion

        #region 初期処理

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Form1()
        {
            InitializeComponent();

            trackbars = new TrackBar[] { trbEyeX, trbEyeY, trbEyeZ,
                trbTargetX, trbTargetY, trbTargetZ, trbUpX, trbUpY, trbUpZ };
            labels = new Label[] { lblEyeX, lblEyeY, lblEyeZ,
                lblTargetX, lblTargetY, lblTargetZ, lblUpX, lblUpY, lblUpZ };

            for (int i = 0; i < trackbars.Length - 1; i++)
            {
                trackbars[i].Minimum = -(int)TRACKBAR_MAX;
                trackbars[i].Maximum = (int)TRACKBAR_MAX;
            }

            pointList = MakePointList2();

            param1 = new ViewPointParam();
            param2 = new ViewPointParam();

            glControl1.MouseWheel += new MouseEventHandler(glControl1_MouseWheel);
            MouseWheel += new MouseEventHandler(glControl1_MouseWheel);

            timer1.Start();
        }

        #endregion

        #region イベントメソッド

        /// <summary>
        /// リセットボタン押下時処理
        /// </summary>
        /// <param name="sender">イベント発生オブジェクト</param>
        /// <param name="e">イベント引数</param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            param1.ResetParameters();
            alpha = 0;
            beta = 0;
            glControl1.Invalidate();
        }

        /// <summary>
        /// 視点変更ボタン押下時処理
        /// </summary>
        /// <param name="sender">イベント発生オブジェクト</param>
        /// <param name="e">イベント引数</param>
        private void btnChange_Click(object sender, EventArgs e)
        {
            viewMode = 1 - viewMode;
            glControl1.Invalidate();
        }

        /// <summary>
        /// タイマーTICK時処理
        /// </summary>
        /// <param name="sender">イベント発生オブジェクト</param>
        /// <param name="e">イベント引数</param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            t++;
            if (t >= pointList.Count)
            {
                t = 1;
            }

            param2.Eye = GetMiddlePoint(pointList[t], pointList[t - 1]);
            param2.Target = GetTargetPoint(param2.Eye, pointList[t]);
            param2.Up = GetUp(param2.Eye, param2.Target);

            SetTrackBars();
            ShowParameters();

            glControl1.Invalidate();
        }

        #endregion

        #region コックピット視点情報計算処理

        /// <summary>
        /// 中点の計算
        /// </summary>
        /// <param name="p1">座標点1</param>
        /// <param name="p2">座標点2</param>
        /// <returns>計算された中点</returns>
        private Vector3 GetMiddlePoint(Vector3 p1, Vector3 p2)
        {
            float x = (p1.X + p2.X) / 2F;
            float y = (p1.Y + p2.Y) / 2F;
            float z = (p1.Z + p2.Z) / 2F;
            return new Vector3(x, y, z);
        }

        /// <summary>
        /// 注視点の計算
        /// </summary>
        /// <param name="eyePoint">目の座標</param>
        /// <param name="p">進行方向の座標</param>
        /// <returns>注視点</returns>
        private Vector3 GetTargetPoint(Vector3 eyePoint, Vector3 p)
        {
            float x = (p.X - eyePoint.X) * 10F;
            float y = (p.Y - eyePoint.Y) * 10F;
            float z = eyePoint.Z;
            return new Vector3(x, y, z);
        }

        /// <summary>
        /// 目の上方向の計算
        /// </summary>
        /// <param name="eyePoint">目の座標</param>
        /// <param name="targetPoint">注視点座標</param>
        /// <returns>計算されたベクトル</returns>
        private Vector3 GetUp(Vector3 eyePoint, Vector3 targetPoint)
        {
            //float x = (targetPoint.X - eyePoint.X);
            //float y = (targetPoint.Y - eyePoint.Y);
            float x = 0;
            float y = 0;
            float z = 1F;
            return new Vector3(x, y, z);
        }

        #endregion

        #region 軌道データ作成

        /// <summary>
        /// 軌道データ作成処理1「円」
        /// </summary>
        /// <returns></returns>
        private List<Vector3> MakePointList()
        {
            List<Vector3> list = new List<Vector3>();

            double A = 1.6;
            double B = 1.6;

            for (double theta = 0; theta < Math.PI * 2; theta += 0.05)
            {
                double x = A * Math.Cos(theta);
                double y = B * Math.Sin(theta);
                double z = Z;
                list.Add(new Vector3((float)x, (float)y, (float)z));
            }

            return list;
        }

        /// <summary>
        /// 軌道データ作成処理2「リサージュ曲線」
        /// </summary>
        /// <returns></returns>
        private List<Vector3> MakePointList2()
        {
            List<Vector3> list = new List<Vector3>();

            double A = 1.5;
            double B = 1.5;
            double a = 1;
            double b = 2;
            double delta = -Math.PI / 4;

            for(double theta = 0; theta < Math.PI * 2; theta += 0.05)
            {
                double x = A * Math.Cos(a * theta);
                double y = B * Math.Sin(b * theta + delta);
                double z = Z;
                list.Add(new Vector3((float)x, (float)y, (float)z));
            }

            return list;
        }

        #endregion

        #region 描画処理

        /// <summary>
        /// キャンバス描画処理
        /// </summary>
        /// <param name="sender">イベント発生オブジェクト</param>
        /// <param name="e">イベント引数</param>
        private void glControl1_Paint(object sender, PaintEventArgs e)
        {
            GLControl canvas = sender as GLControl;

            // 初期化
            InitFor3D(canvas.Width, canvas.Height);

            // 平面を描く
            DrawSurface();

            // 立体を描く
            DrawCube();

            // 飛行機を描く
            DrawPlane();

            // 描画結果を反映させる
            canvas.SwapBuffers();
        }

        /// <summary>
        /// 三次元描画用に初期化する
        /// </summary>
        /// <param name="width">描画領域幅</param>
        /// <param name="height">描画領域高さ</param>
        private void InitFor3D(float width, float height)
        {
            // クリア
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            // ビューポートの設定
            GL.Viewport(0, 0, (int)width, (int)height);

            // 視点の設定
            ViewPointParam param = viewMode == 0 ? param1 : param2;
            Matrix4 modelView = Matrix4.LookAt(param.Eye, param.Target, param.Up);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadMatrix(ref modelView);

            // 射影の設定
            Matrix4 projection = Matrix4.CreatePerspectiveFieldOfView(MathHelper.PiOver4, width / height, 1.0f, 64.0f);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadMatrix(ref projection);

            // 陰面処理をONにする
            GL.Enable(EnableCap.DepthTest);

            // 物体の回転
            if (viewMode == 0)
            {
                GL.Translate(-param.Eye.X, -param.Eye.Y, -param.Eye.Z);
                GL.Rotate(beta, new Vector3d(1, 0, 0));
                GL.Rotate(alpha, new Vector3d(0, 0, 1));
                GL.Translate(param.Eye.X, param.Eye.Y, param.Eye.Z);
            }
        }

        /// <summary>
        /// 平面を描く
        /// </summary>
        private void DrawSurface()
        {
            GL.Color3(Color.Green);
            GL.Begin(PrimitiveType.Lines);

            for (float i = -2; i <= 2.1; i += 0.1F)
            {
                GL.Vertex3(-2, i, 0);
                GL.Vertex3(2, i, 0);

                GL.Vertex3(i, -2, 0);
                GL.Vertex3(i, 2, 0);
            }

            GL.End();

            GL.Begin(PrimitiveType.TriangleFan);

            GL.Vertex3(0, 1.95, 0);
            GL.Vertex3(-0.05, 1.85, 0);
            GL.Vertex3(0.05, 1.85, 0);

            GL.End();
        }

        /// <summary>
        /// 立体を描く
        /// </summary>
        private void DrawCube()
        {
            float x1 = -0.2F;
            float y1 = -0.2F;
            float z1 = 0F;

            float x2 = 0.2F;
            float y2 = 0.2F;
            float z2 = 0.4F;

            Color[] colors = { Color.Blue , Color.Red, Color.Green, Color.Yellow };
            float[] points = {
                x1, y1, z1, x2, y1, z1, x2, y2, z1, x1, y2, z1,
                x1, y1, z2, x2, y1, z2, x2, y2, z2, x1, y2, z2,
                x1, y1, z1, x1, y1, z2, x1, y2, z2, x1, y2, z1,
                x2, y1, z1, x2, y1, z2, x2, y2, z2, x2, y2, z1,
                x1, y1, z1, x1, y1, z2, x2, y1, z2, x2, y1, z1,
                x1, y2, z1, x1, y2, z2, x2, y2, z2, x2, y2, z1,
            };

            GL.Begin(PrimitiveType.Quads);

            int j = 0;
            for (int i = 0; i < points.Length; i += 3)
            {
                GL.Color3(colors[j % 4]);
                j++;
                GL.Vertex3(points[i], points[i + 1], points[i + 2]);
            }

            GL.End();
        }

        /// <summary>
        /// 飛行機(?)を描く
        /// </summary>
        private void DrawPlane()
        {
            Vector3 p0 = pointList[t - 1];
            Vector3 p1 = pointList[t];

            GL.Color3(Color.Cyan);
            GL.Begin(PrimitiveType.Lines);

            GL.Vertex3(p0);
            GL.Vertex3(p1);

            GL.End();
        }

        #endregion

        #region イベント処理

        private void glControl1_SizeChanged(object sender, EventArgs e)
        {
            glControl1.Invalidate();
        }

        private void glControl1_MouseWheel(object sender, MouseEventArgs e)
        {
            float eyeZ = param1.Eye.Z;
            eyeZ+= e.Delta * 0.01F;
            if (eyeZ < trbEyeZ.Minimum * TICK)
            {
                eyeZ = trbEyeZ.Minimum * TICK;
            }
            else if (eyeZ > trbEyeZ.Maximum * TICK)
            {
                eyeZ = trbEyeZ.Maximum * TICK;
            }

            param2.Eye = new Vector3(param2.Eye.X, param2.Eye.Y, eyeZ);

            SetTrackBars();
            ShowParameters();
            glControl1.Invalidate();
        }

        private void glControl1_MouseDown(object sender, MouseEventArgs e)
        {
            startX = e.X;
            startY = e.Y;

            if (e.Button == MouseButtons.Left)
            {
                startEyeX = param1.Eye.X;
                startEyeY = param1.Eye.Y;
            }
            else if (e.Button == MouseButtons.Right)
            {
                startAlpha = alpha;
                startBeta = beta;
            }
        }

        private void glControl1_MouseMove(object sender, MouseEventArgs e)
        {
            int vx = e.X - startX;
            int vy = e.Y - startY;

            if (e.Button == MouseButtons.Left)
            {
                MoveEye(vx, vy);
            }
            else if (e.Button == MouseButtons.Right)
            {
                RotateObj(vx, vy);
                startX = e.X;
                startY = e.Y;
            }
        }

        private void MoveEye(int vx, int vy)
        {
            param1.Eye = new Vector3(startEyeX - vx * 0.01F, startEyeY + vy * 0.01F, param1.Eye.Z);
            param1.Target = new Vector3(param1.Eye.X, param1.Eye.Y, param1.Target.Z);
            glControl1.Invalidate();
        }

        private void RotateObj(int vx, int vy)
        {
            //if (Math.Abs(vx) < 8)
            //{
            //    vx = 0;
            //}
            //if (Math.Abs(vy) < 8)
            //{
            //    vy = 0;
            //}

            //alpha = (int)(startAlpha + vx);
            //beta = (int)(startBeta + vy);
            alpha += vx;
            beta += vy;

            glControl1.Invalidate();
        }

        #endregion

        #region パラメータ表示処理

        /// <summary>
        /// トラックバーに値を設定する
        /// </summary>
        private void SetTrackBars()
        {
            float[] values = { param2.Eye.X, param2.Eye.Y, param2.Eye.Z,
                param2.Target.X, param2.Target.Y, param2.Target.Z,
                param2.Up.X, param2.Up.Y, param2.Up.Z };

            for (int i = 0; i < trackbars.Length; i++)
            {

                if (i < trackbars.Length - 1)
                {
                    trackbars[i].Value = (int)(values[i] / TICK);
                }
                else
                {
                    trackbars[i].Value = (int)(values[i]);
                }

            }
        }

        /// <summary>
        /// パラメータの値をラベルに表示する
        /// </summary>
        private void ShowParameters()
        {
            float[] values = { param2.Eye.X, param2.Eye.Y, param2.Eye.Z,
                param2.Target.X, param2.Target.Y, param2.Target.Z,
                param2.Up.X, param2.Up.Y, param2.Up.Z };

            for (int i = 0; i < labels.Length; i++)
            {
                if (i < trackbars.Length - 1)
                {
                    labels[i].Text = values[i].ToString("F2");
                }
                else
                {
                    labels[i].Text = values[i].ToString();
                }
            }
        }

        #endregion
    }
}
