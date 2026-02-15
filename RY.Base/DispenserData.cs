using System;
using System.ComponentModel;

namespace RY.Base
{
    /// <summary>
    /// 点胶机完整参数类
    /// 特别注意：使用 BinaryFormatter 序列化时，类必须打上 [Serializable] 特性
    /// </summary>
    [Serializable]
    public class DispenserData
    {
        // === 1. 点胶配方 (Recipe) ===
        [Category("1-点胶配方"), DisplayName("点胶速度(mm/s)")]
        public double DispenseSpeed { get; set; } = 50.0;

        [Category("1-点胶配方"), DisplayName("出胶压力(Kpa)")]
        public double Pressure { get; set; } = 200.0;

        [Category("1-点胶配方"), DisplayName("胶水点位坐标")]
        public string Position { get; set; } = "0,0,0";


        // === 2. 系统设置 (System Settings) ===
        [Category("2-系统设置"), DisplayName("PLC IP地址")]
        public string PlcIpAddress { get; set; } = "192.168.0.1";

        [Category("2-系统设置"), DisplayName("通信端口")]
        public int PlcPort { get; set; } = 502;


        // === 3. 运行状态保存 (State Persistence) ===
        [Category("3-状态保存"), DisplayName("最后操作员")]
        public string LastOperator { get; set; } = "Admin";

        [Category("3-状态保存"), DisplayName("累计点胶次数")]
        public int TotalDispenseCount { get; set; } = 0;
    }
}
