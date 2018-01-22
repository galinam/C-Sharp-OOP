using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DefiningClassesPart2
{
    public static class PathStorage
    {
        private static int pathID;
        private static StreamWriter sWriter;
        private const string filePath = "../../PathStorage.txt";
        static PathStorage()
        {
            sWriter = new StreamWriter(filePath);
            sWriter.Close();
            pathID = 1;
        }

        private static int GetPathID()
        {
            return pathID++;
        }
        public static void SavePath(Path path)
        {
            var writer = new StreamWriter(filePath, true);
            using (writer)
            {
                writer.WriteLine("{0}-{1}: {2}\n",path.GetType().Name, GetPathID(), path.ToString());
                //writer.WriteLine("");
            }
        }
        public static void LoadPath()
        {
            var reader = new StreamReader(filePath);
            using (reader)
            {
                string paths = reader.ReadToEnd();
                Console.WriteLine(paths);
            }
        }
    }
}
