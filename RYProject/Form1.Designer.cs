namespace RYProject
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btGenEx = new SunnyUI.UISymbolButton();
            this.uiGroupBox1 = new SunnyUI.UIGroupBox();
            this.txtPosition = new SunnyUI.UITextBox();
            this.txtPressure = new SunnyUI.UITextBox();
            this.txtSpeed = new SunnyUI.UITextBox();
            this.uiGroupBox2 = new SunnyUI.UIGroupBox();
            this.txtPort = new SunnyUI.UITextBox();
            this.txtIp = new SunnyUI.UITextBox();
            this.btnSave = new SunnyUI.UIButton();
            this.btnLoad = new SunnyUI.UIButton();
            this.uiGroupBox1.SuspendLayout();
            this.uiGroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btGenEx
            // 
            this.btGenEx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btGenEx.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btGenEx.Location = new System.Drawing.Point(651, 572);
            this.btGenEx.MinimumSize = new System.Drawing.Size(1, 1);
            this.btGenEx.Name = "btGenEx";
            this.btGenEx.Size = new System.Drawing.Size(177, 49);
            this.btGenEx.Symbol = 61738;
            this.btGenEx.TabIndex = 2;
            this.btGenEx.Text = "异常测试";
            this.btGenEx.Click += new System.EventHandler(this.btGenEx_Click);
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.txtPosition);
            this.uiGroupBox1.Controls.Add(this.txtPressure);
            this.uiGroupBox1.Controls.Add(this.txtSpeed);
            this.uiGroupBox1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiGroupBox1.Location = new System.Drawing.Point(23, 69);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox1.Size = new System.Drawing.Size(277, 333);
            this.uiGroupBox1.TabIndex = 3;
            this.uiGroupBox1.Text = "点胶参数";
            this.uiGroupBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiGroupBox1.Click += new System.EventHandler(this.uiGroupBox1_Click);
            // 
            // txtPosition
            // 
            this.txtPosition.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPosition.FillColor = System.Drawing.Color.White;
            this.txtPosition.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtPosition.Location = new System.Drawing.Point(33, 235);
            this.txtPosition.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPosition.Maximum = 2147483647D;
            this.txtPosition.Minimum = -2147483648D;
            this.txtPosition.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(196, 50);
            this.txtPosition.TabIndex = 2;
            this.txtPosition.Text = "uiTextBox3";
            this.txtPosition.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPressure
            // 
            this.txtPressure.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPressure.FillColor = System.Drawing.Color.White;
            this.txtPressure.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtPressure.Location = new System.Drawing.Point(33, 150);
            this.txtPressure.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPressure.Maximum = 2147483647D;
            this.txtPressure.Minimum = -2147483648D;
            this.txtPressure.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtPressure.Name = "txtPressure";
            this.txtPressure.Size = new System.Drawing.Size(196, 50);
            this.txtPressure.TabIndex = 2;
            this.txtPressure.Text = "uiTextBox2";
            this.txtPressure.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSpeed
            // 
            this.txtSpeed.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSpeed.FillColor = System.Drawing.Color.White;
            this.txtSpeed.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtSpeed.Location = new System.Drawing.Point(33, 67);
            this.txtSpeed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSpeed.Maximum = 2147483647D;
            this.txtSpeed.Minimum = -2147483648D;
            this.txtSpeed.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtSpeed.Name = "txtSpeed";
            this.txtSpeed.Size = new System.Drawing.Size(196, 50);
            this.txtSpeed.TabIndex = 0;
            this.txtSpeed.Text = "uiTextBox1";
            this.txtSpeed.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiGroupBox2
            // 
            this.uiGroupBox2.Controls.Add(this.txtPort);
            this.uiGroupBox2.Controls.Add(this.txtIp);
            this.uiGroupBox2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiGroupBox2.Location = new System.Drawing.Point(320, 69);
            this.uiGroupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox2.Name = "uiGroupBox2";
            this.uiGroupBox2.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox2.Size = new System.Drawing.Size(277, 333);
            this.uiGroupBox2.TabIndex = 4;
            this.uiGroupBox2.Text = "系统设置";
            this.uiGroupBox2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPort
            // 
            this.txtPort.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPort.FillColor = System.Drawing.Color.White;
            this.txtPort.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtPort.Location = new System.Drawing.Point(26, 150);
            this.txtPort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPort.Maximum = 2147483647D;
            this.txtPort.Minimum = -2147483648D;
            this.txtPort.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(196, 50);
            this.txtPort.TabIndex = 2;
            this.txtPort.Text = "uiTextBox5";
            this.txtPort.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtIp
            // 
            this.txtIp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIp.FillColor = System.Drawing.Color.White;
            this.txtIp.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtIp.Location = new System.Drawing.Point(26, 67);
            this.txtIp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIp.Maximum = 2147483647D;
            this.txtIp.Minimum = -2147483648D;
            this.txtIp.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(196, 50);
            this.txtIp.TabIndex = 2;
            this.txtIp.Text = "uiTextBox4";
            this.txtIp.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnSave.Location = new System.Drawing.Point(654, 136);
            this.btnSave.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(174, 58);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "保存参数";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoad.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnLoad.Location = new System.Drawing.Point(654, 219);
            this.btnLoad.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(174, 58);
            this.btnLoad.TabIndex = 6;
            this.btnLoad.Text = "读取参数";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 681);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.uiGroupBox2);
            this.Controls.Add(this.uiGroupBox1);
            this.Controls.Add(this.btGenEx);
            this.Name = "Form1";
            this.Text = " ";
            this.uiGroupBox1.ResumeLayout(false);
            this.uiGroupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private SunnyUI.UISymbolButton btGenEx;
        private SunnyUI.UIGroupBox uiGroupBox1;
        private SunnyUI.UITextBox txtPosition;
        private SunnyUI.UITextBox txtPressure;
        private SunnyUI.UITextBox txtSpeed;
        private SunnyUI.UIGroupBox uiGroupBox2;
        private SunnyUI.UITextBox txtPort;
        private SunnyUI.UITextBox txtIp;
        private SunnyUI.UIButton btnSave;
        private SunnyUI.UIButton btnLoad;
    }
}

