using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace RY.Base
{
    public class SerializationFile
    {
        /// <summary>
        /// 将对象序列化并保存为二进制文件
        /// </summary>
        /// <param name="filePath">保存路径</param>
        /// <param name="obj">要保存的对象</param>
        /// <returns>是否成功</returns>
        public static bool SerializeObject(string filePath, object obj)
        {
            try
            {
                // 检查并创建文件夹
                string directory = Path.GetDirectoryName(filePath);
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }
                // 安全写入策略：先写入临时文件，成功后再更名
                string tempFile = filePath + ".tmp";
                using (FileStream fs = new FileStream(tempFile, FileMode.Create))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(fs, obj);
                }
                //覆盖正式文件并删除临时文件
                if(File.Exists(filePath)) File.Delete(filePath);
                File.Move(tempFile, filePath);
                return true;
            }
            catch (Exception ex)
            {
                //调用我们的UserLog记录异常
                UserLog.AddExceptionMsg(ex);
                return false;
            }
        }

        /// <summary>
        /// 从二进制文件反序列化为对象
        /// </summary>
        /// <typeparam name="T">对象类型</typeparam>
        /// <param name="filePath">文件路径</param>
        /// <returns>加载的对象，失败返回空</returns>
        public static T DeserializeObject<T>(string filePath) where T : class
        {
            try
            {
                if (!File.Exists(filePath)) return null;
                using (FileStream fs = new FileStream(filePath, FileMode.Open))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    return bf.Deserialize(fs) as T;
                }
            }
            catch (Exception ex)
            {
                UserLog.AddExceptionMsg(ex);
                return null;
            }
        }

    }
}