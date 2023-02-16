using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace ConsoleDriveInfo1
{
    class Program
    {
        static void Main(string[] args)
        {
              DriveInfo[] allDrives = DriveInfo.GetDrives();

              foreach (DriveInfo d in allDrives)
              {
                      Console.WriteLine("\n 1. 磁碟名稱 {0}", d.Name);
                      Console.WriteLine(" 2. 磁碟類型: {0}", d.DriveType);
                      if (d.IsReady == true)
                      {
                              Console.WriteLine(" 3. 檔案系統名稱: {0}",  d.DriveFormat);
                              Console.WriteLine(" 4. 目前可用空間量: \t{0, 15} bytes",  d.AvailableFreeSpace);
                              Console.WriteLine(" 5.可用空間總量: \t{0, 15} bytes", d.TotalFreeSpace);
                              Console.WriteLine(" 6.可儲存空間總量: \t{0, 15} bytes ", d.TotalSize);
                              Console.WriteLine(" --------------------------------------------------");

                }               
            }
            Console.WriteLine(" --------------------------------------------------");
            Console.Read();

        }
    }
}
