using OpenTK;

namespace OpenTKSample03
{
    class ViewPointParam
    {
        /// <summary>目の位置</summary>
        public Vector3 Eye { get; set; }

        /// <summary>注視点</summary>
        public Vector3 Target { get; set; }

        /// <summary>目の向き</summary>
        public Vector3 Up { get; set; }

        /// <summary>フォビー(視野角)</summary>
        public int Fovy { get; set; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public ViewPointParam()
        {
            ResetParameters();
        }

        /// <summary>
        /// パラメータの初期化
        /// </summary>
        public void ResetParameters()
        {
            Eye = new Vector3(0, 0, 5);
            Target = new Vector3(0, 0, 0);
            Up = new Vector3(0, 1, 0);
            Fovy = 45;
        }
    }
}
