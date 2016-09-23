using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileCopy
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] fileNames = { "ShipLinx.Implementation.dll", "ShipLinx.Implementation.pdb", "ShipLinx.Integration.dll", "ShipLinx.Integration.pdb", "ShipSource.dll", "ShipSource.pdb" };

                Console.Write("Enter Project Path: ");
                string path = Console.ReadLine();
                string file = "";
                string sourcePath = string.Format(@"C:\Work\projects\{0}", path);
                string targetPath = @"C:\Program Files\LRMT\ShipLinxNet";

                for (int i = 0; i < 6; i++)
                {
                    file = fileNames[i];
                    Console.WriteLine("Copying file: " + file);
                    string sourceFile = System.IO.Path.Combine(sourcePath, file);
                    string destFile = System.IO.Path.Combine(targetPath, file);

                    System.IO.File.Copy(sourceFile, destFile, true);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
            }
        }
    }
}
