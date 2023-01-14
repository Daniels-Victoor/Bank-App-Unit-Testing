using Core.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Core.Services
{
    public class FileWriteRead : IFileWriteRead
    {
        //this reads any file in the dataStorage and returns the file data in the list
        public List<string> ReadFile(string path)
        {
            try
            {
                List<string> lines = new List<string>();
                lines = File.ReadAllLines(path).ToList();
                return lines;
            }
            catch (System.IO.FileNotFoundException)
            {

                string message = "Wrong file path";
            }
            return new List<string>();
        }
        //this writes to the user data file

        public bool WriteToFile(string path, List<string> data)
        {
            string DataToSave = "";
            foreach (var item in data)
            {
                DataToSave += item + ",";
            }
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(DataToSave);
            file.Close();
            return true;
        }
    }
}
