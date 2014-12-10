using System.Management;

namespace Wampi
{
    public static class ServiceHelper
    {
        public static ManagementObject FindServiceByClosestName(string targetName)
        {
            ManagementClass mc = new ManagementClass("Win32_Service");
            foreach (ManagementObject mo in mc.GetInstances())
            {
                if (mo.GetPropertyValue("Name").ToString().Contains(targetName))
                    return mo;
            }
            return null;
        }
    }
}