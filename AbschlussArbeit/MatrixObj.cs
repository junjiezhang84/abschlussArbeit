using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace MatrixObj
{
    public class MatrixObj
    {
        public MatrixObj(string filePath)
        {
            List<string> stringList = new List<string>();
            StreamReader csvFileStream = new StreamReader(filePath);
            while (!csvFileStream.EndOfStream)
            {
                string line = csvFileStream.ReadLine();
                stringList.Add(line);
            }
            csvFileStream.Close();
            header = stringList[0];
            stringList.RemoveAt(0);
            int sperateIndex = (int)((float)stringList.Count * seprate);
            TestStringList = new List<string>();
            LearningStringList = new List<string>();
            for (int i = 0; i < sperateIndex; i++)
            {
                LearningStringList.Add(stringList[i]);
            }
            for (int i = sperateIndex; i < stringList.Count; i++)
            {
                TestStringList.Add(stringList[i]);
            }
        }
        public List<string> TestStringList { set;  get; }
        public List<string> LearningStringList { set; get; }
        public string header { set; get; }
        private const float seprate = 0.7f; 
    }
}
