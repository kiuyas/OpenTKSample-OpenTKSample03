namespace OpenTKSample03
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.glControl1 = new OpenTK.GLControl();
            this.btnChange = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTargetZ = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.trbTargetZ = new System.Windows.Forms.TrackBar();
            this.lblTargetY = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.trbTargetY = new System.Windows.Forms.TrackBar();
            this.lblTargetX = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.trbTargetX = new System.Windows.Forms.TrackBar();
            this.lblUpZ = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.trbUpZ = new System.Windows.Forms.TrackBar();
            this.lblUpY = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.trbUpY = new System.Windows.Forms.TrackBar();
            this.lblUpX = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.trbUpX = new System.Windows.Forms.TrackBar();
            this.lblEyeZ = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.trbEyeZ = new System.Windows.Forms.TrackBar();
            this.lblEyeY = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.trbEyeY = new System.Windows.Forms.TrackBar();
            this.lblEyeX = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trbEyeX = new System.Windows.Forms.TrackBar();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trbTargetZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbTargetY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbTargetX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbUpZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbUpY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbUpX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbEyeZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbEyeY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbEyeX)).BeginInit();
            this.SuspendLayout();
            // 
            // glControl1
            // 
            this.glControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.glControl1.AutoSize = true;
            this.glControl1.BackColor = System.Drawing.Color.Black;
            this.glControl1.Location = new System.Drawing.Point(0, 0);
            this.glControl1.Name = "glControl1";
            this.glControl1.Size = new System.Drawing.Size(624, 392);
            this.glControl1.TabIndex = 1;
            this.glControl1.VSync = false;
            this.glControl1.SizeChanged += new System.EventHandler(this.glControl1_SizeChanged);
            this.glControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.glControl1_Paint);
            this.glControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.glControl1_MouseDown);
            this.glControl1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.glControl1_MouseMove);
            // 
            // btnChange
            // 
            this.btnChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChange.Location = new System.Drawing.Point(544, 464);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 32;
            this.btnChange.Text = "視点変更";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTargetZ
            // 
            this.lblTargetZ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTargetZ.Location = new System.Drawing.Point(384, 440);
            this.lblTargetZ.Name = "lblTargetZ";
            this.lblTargetZ.Size = new System.Drawing.Size(32, 24);
            this.lblTargetZ.TabIndex = 59;
            this.lblTargetZ.Text = "000";
            this.lblTargetZ.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label14.Location = new System.Drawing.Point(208, 440);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 24);
            this.label14.TabIndex = 58;
            this.label14.Text = "TragetZ";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // trbTargetZ
            // 
            this.trbTargetZ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.trbTargetZ.AutoSize = false;
            this.trbTargetZ.Location = new System.Drawing.Point(256, 440);
            this.trbTargetZ.Maximum = 1000;
            this.trbTargetZ.Minimum = -1000;
            this.trbTargetZ.Name = "trbTargetZ";
            this.trbTargetZ.Size = new System.Drawing.Size(128, 24);
            this.trbTargetZ.TabIndex = 57;
            this.trbTargetZ.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // lblTargetY
            // 
            this.lblTargetY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTargetY.Location = new System.Drawing.Point(384, 416);
            this.lblTargetY.Name = "lblTargetY";
            this.lblTargetY.Size = new System.Drawing.Size(32, 24);
            this.lblTargetY.TabIndex = 56;
            this.lblTargetY.Text = "000";
            this.lblTargetY.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label16.Location = new System.Drawing.Point(208, 416);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 24);
            this.label16.TabIndex = 55;
            this.label16.Text = "TargetY";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // trbTargetY
            // 
            this.trbTargetY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.trbTargetY.AutoSize = false;
            this.trbTargetY.Location = new System.Drawing.Point(256, 416);
            this.trbTargetY.Maximum = 1000;
            this.trbTargetY.Minimum = -1000;
            this.trbTargetY.Name = "trbTargetY";
            this.trbTargetY.Size = new System.Drawing.Size(128, 24);
            this.trbTargetY.TabIndex = 54;
            this.trbTargetY.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // lblTargetX
            // 
            this.lblTargetX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTargetX.Location = new System.Drawing.Point(384, 392);
            this.lblTargetX.Name = "lblTargetX";
            this.lblTargetX.Size = new System.Drawing.Size(32, 24);
            this.lblTargetX.TabIndex = 53;
            this.lblTargetX.Text = "000";
            this.lblTargetX.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label18.Location = new System.Drawing.Point(208, 392);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(48, 24);
            this.label18.TabIndex = 52;
            this.label18.Text = "TargetX";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // trbTargetX
            // 
            this.trbTargetX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.trbTargetX.AutoSize = false;
            this.trbTargetX.Location = new System.Drawing.Point(256, 392);
            this.trbTargetX.Maximum = 1000;
            this.trbTargetX.Minimum = -1000;
            this.trbTargetX.Name = "trbTargetX";
            this.trbTargetX.Size = new System.Drawing.Size(128, 24);
            this.trbTargetX.TabIndex = 51;
            this.trbTargetX.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // lblUpZ
            // 
            this.lblUpZ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblUpZ.Location = new System.Drawing.Point(592, 440);
            this.lblUpZ.Name = "lblUpZ";
            this.lblUpZ.Size = new System.Drawing.Size(32, 24);
            this.lblUpZ.TabIndex = 50;
            this.lblUpZ.Text = "000";
            this.lblUpZ.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.Location = new System.Drawing.Point(424, 440);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 24);
            this.label8.TabIndex = 49;
            this.label8.Text = "UpZ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // trbUpZ
            // 
            this.trbUpZ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.trbUpZ.AutoSize = false;
            this.trbUpZ.Location = new System.Drawing.Point(464, 440);
            this.trbUpZ.Maximum = 1000;
            this.trbUpZ.Minimum = -1000;
            this.trbUpZ.Name = "trbUpZ";
            this.trbUpZ.Size = new System.Drawing.Size(128, 24);
            this.trbUpZ.TabIndex = 48;
            this.trbUpZ.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // lblUpY
            // 
            this.lblUpY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblUpY.Location = new System.Drawing.Point(592, 416);
            this.lblUpY.Name = "lblUpY";
            this.lblUpY.Size = new System.Drawing.Size(32, 24);
            this.lblUpY.TabIndex = 47;
            this.lblUpY.Text = "000";
            this.lblUpY.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.Location = new System.Drawing.Point(424, 416);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 24);
            this.label10.TabIndex = 46;
            this.label10.Text = "UpY";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // trbUpY
            // 
            this.trbUpY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.trbUpY.AutoSize = false;
            this.trbUpY.Location = new System.Drawing.Point(464, 416);
            this.trbUpY.Maximum = 1000;
            this.trbUpY.Minimum = -1000;
            this.trbUpY.Name = "trbUpY";
            this.trbUpY.Size = new System.Drawing.Size(128, 24);
            this.trbUpY.TabIndex = 45;
            this.trbUpY.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // lblUpX
            // 
            this.lblUpX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblUpX.Location = new System.Drawing.Point(592, 392);
            this.lblUpX.Name = "lblUpX";
            this.lblUpX.Size = new System.Drawing.Size(32, 24);
            this.lblUpX.TabIndex = 44;
            this.lblUpX.Text = "000";
            this.lblUpX.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label12.Location = new System.Drawing.Point(424, 392);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 24);
            this.label12.TabIndex = 43;
            this.label12.Text = "UpX";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // trbUpX
            // 
            this.trbUpX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.trbUpX.AutoSize = false;
            this.trbUpX.Location = new System.Drawing.Point(464, 392);
            this.trbUpX.Maximum = 1000;
            this.trbUpX.Minimum = -1000;
            this.trbUpX.Name = "trbUpX";
            this.trbUpX.Size = new System.Drawing.Size(128, 24);
            this.trbUpX.TabIndex = 42;
            this.trbUpX.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // lblEyeZ
            // 
            this.lblEyeZ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblEyeZ.Location = new System.Drawing.Point(168, 440);
            this.lblEyeZ.Name = "lblEyeZ";
            this.lblEyeZ.Size = new System.Drawing.Size(32, 24);
            this.lblEyeZ.TabIndex = 41;
            this.lblEyeZ.Text = "000";
            this.lblEyeZ.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.Location = new System.Drawing.Point(0, 440);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 24);
            this.label6.TabIndex = 40;
            this.label6.Text = "EyeZ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // trbEyeZ
            // 
            this.trbEyeZ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.trbEyeZ.AutoSize = false;
            this.trbEyeZ.Location = new System.Drawing.Point(40, 440);
            this.trbEyeZ.Maximum = 1000;
            this.trbEyeZ.Minimum = -1000;
            this.trbEyeZ.Name = "trbEyeZ";
            this.trbEyeZ.Size = new System.Drawing.Size(128, 24);
            this.trbEyeZ.TabIndex = 39;
            this.trbEyeZ.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // lblEyeY
            // 
            this.lblEyeY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblEyeY.Location = new System.Drawing.Point(168, 416);
            this.lblEyeY.Name = "lblEyeY";
            this.lblEyeY.Size = new System.Drawing.Size(32, 24);
            this.lblEyeY.TabIndex = 38;
            this.lblEyeY.Text = "000";
            this.lblEyeY.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.Location = new System.Drawing.Point(0, 416);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 24);
            this.label4.TabIndex = 37;
            this.label4.Text = "EyeY";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // trbEyeY
            // 
            this.trbEyeY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.trbEyeY.AutoSize = false;
            this.trbEyeY.Location = new System.Drawing.Point(40, 416);
            this.trbEyeY.Maximum = 1000;
            this.trbEyeY.Minimum = -1000;
            this.trbEyeY.Name = "trbEyeY";
            this.trbEyeY.Size = new System.Drawing.Size(128, 24);
            this.trbEyeY.TabIndex = 36;
            this.trbEyeY.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // lblEyeX
            // 
            this.lblEyeX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblEyeX.Location = new System.Drawing.Point(168, 392);
            this.lblEyeX.Name = "lblEyeX";
            this.lblEyeX.Size = new System.Drawing.Size(32, 24);
            this.lblEyeX.TabIndex = 35;
            this.lblEyeX.Text = "000";
            this.lblEyeX.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.Location = new System.Drawing.Point(0, 392);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 24);
            this.label1.TabIndex = 34;
            this.label1.Text = "EyeX";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // trbEyeX
            // 
            this.trbEyeX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.trbEyeX.AutoSize = false;
            this.trbEyeX.Location = new System.Drawing.Point(40, 392);
            this.trbEyeX.Maximum = 1000;
            this.trbEyeX.Minimum = -1000;
            this.trbEyeX.Name = "trbEyeX";
            this.trbEyeX.Size = new System.Drawing.Size(128, 24);
            this.trbEyeX.TabIndex = 33;
            this.trbEyeX.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReset.Location = new System.Drawing.Point(8, 464);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 61;
            this.btnReset.Text = "リセット";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 488);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblTargetZ);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.trbTargetZ);
            this.Controls.Add(this.lblTargetY);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.trbTargetY);
            this.Controls.Add(this.lblTargetX);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.trbTargetX);
            this.Controls.Add(this.lblUpZ);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.trbUpZ);
            this.Controls.Add(this.lblUpY);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.trbUpY);
            this.Controls.Add(this.lblUpX);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.trbUpX);
            this.Controls.Add(this.lblEyeZ);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.trbEyeZ);
            this.Controls.Add(this.lblEyeY);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.trbEyeY);
            this.Controls.Add(this.lblEyeX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trbEyeX);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.glControl1);
            this.Name = "Form1";
            this.Text = "OpenTKSample03";
            ((System.ComponentModel.ISupportInitialize)(this.trbTargetZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbTargetY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbTargetX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbUpZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbUpY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbUpX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbEyeZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbEyeY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbEyeX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenTK.GLControl glControl1;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTargetZ;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TrackBar trbTargetZ;
        private System.Windows.Forms.Label lblTargetY;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TrackBar trbTargetY;
        private System.Windows.Forms.Label lblTargetX;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TrackBar trbTargetX;
        private System.Windows.Forms.Label lblUpZ;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TrackBar trbUpZ;
        private System.Windows.Forms.Label lblUpY;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TrackBar trbUpY;
        private System.Windows.Forms.Label lblUpX;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TrackBar trbUpX;
        private System.Windows.Forms.Label lblEyeZ;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar trbEyeZ;
        private System.Windows.Forms.Label lblEyeY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trbEyeY;
        private System.Windows.Forms.Label lblEyeX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trbEyeX;
        private System.Windows.Forms.Button btnReset;
    }
}

