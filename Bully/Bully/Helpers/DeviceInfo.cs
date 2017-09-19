using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bully.Helper
{
    public class DeviceInfo
    {
        protected static DeviceInfo instance;
        double width;
        double height;

        static DeviceInfo()
        {
            instance = new DeviceInfo();
        }
        protected DeviceInfo()
        {
        }

        public static bool IsOrientationPortrait()
        {
            return instance.height > instance.width;
        }

        public static void SetSize(double width, double height)
        {
            instance.width = width;
            instance.height = height;
        }
    }
}
