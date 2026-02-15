using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SunnyUI;
using RY.Base;
namespace RYProject
{
    public partial class Form1 : UIForm
    {
        // 定义数据文件的存储路径
        private string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Config", "Dispenser.dat");
        public Form1()
        {
            InitializeComponent();
            //UserLog.AddRunMsg("今天天气很好");
            //MsgBox.ShowInfo("Hello world!");
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {

        }

        private void btGenEx_Click(object sender, EventArgs e)
        {
            int a = 100;
            int b = 0;
            int c = a / b;
            int d = b / c;
        }

        private void uiGroupBox1_Click(object sender, EventArgs e)
        {

        }
        //“保存”按钮
        private void btnSave_Click(object sender, EventArgs e)
        {
            //创建对象并从界面取值
            DispenserData data = new DispenserData();
            try
            {
                data.DispenseSpeed = double.Parse(txtSpeed.Text);
                data.Pressure = double.Parse(txtPressure.Text);
                data.Position = txtPosition.Text;
                data.PlcIpAddress = txtIp.Text;
                data.PlcPort = int.Parse(txtPort.Text);
                //调用底层序列化方法
                if (SerializationFile.SerializeObject(filePath, data))
                {
                    UIMessageBox.ShowSuccess("参数已成功加密保存至二进制文件！");
                }
            }
            catch(Exception ex) 
            {
                // 这里如果报错，会触发你在 Program.cs 里写的全局捕获，或者在这里单独处理
                UIMessageBox.ShowError("输入数据格式有误，请输入数字！");
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            //调用底层反序列化方法
            DispenserData data = SerializationFile.DeserializeObject<DispenserData>(filePath);
            if(data != null)
            {
                // 2. 将数据还原到界面
                txtSpeed.Text = data.DispenseSpeed.ToString();
                txtPressure.Text = data.Pressure.ToString();
                txtPosition.Text = data.Position;
                txtIp.Text = data.PlcIpAddress;
                txtPort.Text = data.PlcPort.ToString();

                UIMessageBox.ShowInfo("历史参数加载成功！");
            }
            else
            {
                UIMessageBox.ShowWarning("未找到配置文件，请先保存。");
            }
        }
    }
}
