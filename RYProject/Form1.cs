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
        public Form1()
        {
            InitializeComponent();
            UserLog.AddRunMsg("今天天气很好");
            MsgBox.ShowInfo("Hello world!");
        }
    }
}
