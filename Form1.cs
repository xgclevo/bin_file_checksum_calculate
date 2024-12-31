using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileChecksumCalculate
{
    public partial class Form1 : Form
    {

        private byte cur_lan;

        public Form1()
        {
            InitializeComponent();

            Control.CheckForIllegalCrossThreadCalls = false;

            cur_lan = 0;
        }

        private void Disable_operate()
        {
            button_Select_File.Enabled = false;       
        }

        private void Enable_operate()
        {
            Application.DoEvents();                 //清空消息队列

            button_Select_File.Enabled = true;
        }


        private void Start_calcu(object obj)
        {
            Disable_operate();                  //禁止操作

            textBoxFilePath.Text = obj.ToString();

            FileStream calcu_fs = new FileStream(obj.ToString(), FileMode.Open, FileAccess.Read);
            int temp;
            long check_sum = 0;

            temp = calcu_fs.ReadByte();

            while (temp != -1)
            {
                check_sum += temp;
                temp = calcu_fs.ReadByte();
            }

            calcu_fs.Close();
            calcu_fs.Dispose();

            if (cur_lan == 0) {
                toolStripLabelLog.Text = "计算完成！";
            }  else {
                toolStripLabelLog.Text = "Calculation Complete! ";
            }

            textBoxCalcuRes.Text = "" + check_sum;

            Enable_operate();      //允许操作
        }



        private void button_Select_File_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;                     //只能选择一个文件

            if (cur_lan == 0) {
                dialog.Title = "请选择文件";
                dialog.Filter = "二进制文件|*.bin";
            } else { 
                dialog.Title = "Please Select File";
                dialog.Filter = "Binary File|*.bin";
            }
            
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Thread calcu_thread = new Thread(new ParameterizedThreadStart(Start_calcu)) {
                    IsBackground = true
                };

                calcu_thread.Start(dialog.FileName);
            }
        }

        private void buttonCopy_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBoxCalcuRes.Text != "")
            {
                Clipboard.SetText(textBoxCalcuRes.Text);
            }
        }

        private void buttonLanSwitch_MouseClick(object sender, MouseEventArgs e)
        {
            if (cur_lan == 0) {
                cur_lan = 1;

                this.Text = ".bin File Checksum Calculate";

                label1.Text = "FilePath:";
                label2.Text = "Result:";

                button_Select_File.Text = "Select";
                button_Copy.Text = "Copy";
            } else {
                cur_lan = 0;

                this.Text = ".bin 文件校验和计算";

                label1.Text = "文件路径:";
                label2.Text = "计算结果:";

                button_Select_File.Text = "选择";
                button_Copy.Text = "复制";
            }
        }
    }
}
