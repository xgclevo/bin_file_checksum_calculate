
namespace FileChecksumCalculate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_Select_File = new System.Windows.Forms.Button();
            this.toolStripLog = new System.Windows.Forms.ToolStrip();
            this.toolStripLabelLog = new System.Windows.Forms.ToolStripLabel();
            this.textBoxFilePath = new System.Windows.Forms.TextBox();
            this.textBoxCalcuRes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Copy = new System.Windows.Forms.Button();
            this.buttonLanSwitch = new System.Windows.Forms.Button();
            this.toolStripLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Select_File
            // 
            this.button_Select_File.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_Select_File.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Select_File.Location = new System.Drawing.Point(411, 98);
            this.button_Select_File.Name = "button_Select_File";
            this.button_Select_File.Size = new System.Drawing.Size(70, 26);
            this.button_Select_File.TabIndex = 0;
            this.button_Select_File.Text = "选择";
            this.button_Select_File.UseVisualStyleBackColor = false;
            this.button_Select_File.Click += new System.EventHandler(this.button_Select_File_Click);
            // 
            // toolStripLog
            // 
            this.toolStripLog.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.toolStripLog.AutoSize = false;
            this.toolStripLog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripLog.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelLog});
            this.toolStripLog.Location = new System.Drawing.Point(0, 304);
            this.toolStripLog.Name = "toolStripLog";
            this.toolStripLog.Size = new System.Drawing.Size(502, 25);
            this.toolStripLog.TabIndex = 1;
            this.toolStripLog.Text = "toolStripLog";
            // 
            // toolStripLabelLog
            // 
            this.toolStripLabelLog.Name = "toolStripLabelLog";
            this.toolStripLabelLog.Size = new System.Drawing.Size(0, 22);
            // 
            // textBoxFilePath
            // 
            this.textBoxFilePath.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxFilePath.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxFilePath.Location = new System.Drawing.Point(98, 98);
            this.textBoxFilePath.Name = "textBoxFilePath";
            this.textBoxFilePath.ReadOnly = true;
            this.textBoxFilePath.Size = new System.Drawing.Size(296, 26);
            this.textBoxFilePath.TabIndex = 2;
            // 
            // textBoxCalcuRes
            // 
            this.textBoxCalcuRes.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxCalcuRes.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxCalcuRes.Location = new System.Drawing.Point(98, 183);
            this.textBoxCalcuRes.Name = "textBoxCalcuRes";
            this.textBoxCalcuRes.ReadOnly = true;
            this.textBoxCalcuRes.Size = new System.Drawing.Size(296, 26);
            this.textBoxCalcuRes.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "文件路径:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(12, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "计算结果:";
            // 
            // button_Copy
            // 
            this.button_Copy.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Copy.Location = new System.Drawing.Point(411, 183);
            this.button_Copy.Name = "button_Copy";
            this.button_Copy.Size = new System.Drawing.Size(70, 26);
            this.button_Copy.TabIndex = 6;
            this.button_Copy.Text = "复制";
            this.button_Copy.UseVisualStyleBackColor = true;
            this.button_Copy.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonCopy_MouseClick);
            // 
            // buttonLanSwitch
            // 
            this.buttonLanSwitch.Location = new System.Drawing.Point(411, 12);
            this.buttonLanSwitch.Name = "buttonLanSwitch";
            this.buttonLanSwitch.Size = new System.Drawing.Size(75, 23);
            this.buttonLanSwitch.TabIndex = 7;
            this.buttonLanSwitch.Text = "中/EN";
            this.buttonLanSwitch.UseVisualStyleBackColor = true;
            this.buttonLanSwitch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonLanSwitch_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 329);
            this.Controls.Add(this.buttonLanSwitch);
            this.Controls.Add(this.button_Copy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCalcuRes);
            this.Controls.Add(this.textBoxFilePath);
            this.Controls.Add(this.toolStripLog);
            this.Controls.Add(this.button_Select_File);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = ".bin 文件校验和计算";
            this.toolStripLog.ResumeLayout(false);
            this.toolStripLog.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Select_File;
        private System.Windows.Forms.ToolStrip toolStripLog;
        private System.Windows.Forms.ToolStripLabel toolStripLabelLog;
        private System.Windows.Forms.TextBox textBoxFilePath;
        private System.Windows.Forms.TextBox textBoxCalcuRes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Copy;
        private System.Windows.Forms.Button buttonLanSwitch;
    }
}

