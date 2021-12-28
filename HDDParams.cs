using System.IO;

/// <summary>
/// Параметры жестких дисков
/// </summary>
namespace WindowsFormsApp1.HDDParams
{
    public class Info
    {
        private static DriveInfo[] _info = null;

        public static int Count
        {
            get
            {
                if (_info == null)
                {
                    _info = DriveInfo.GetDrives();
                }
                return _info.Length;
            }
        }

        /// <summary>
        /// Возвращает жесткий диск по индексу
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public static DriveInfo GetDrive(int index)
        {
            return _info[index];
        }
    }
}
