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
            stringList = new List<string>();
            csvFileStream = new StreamReader(filePath);
            while (!csvFileStream.EndOfStream)
            {
                string line = csvFileStream.ReadLine();
                stringList.Add(line);
            }
        }
        public void setcsvFile(string filePath)
        { 
            
        }
        public StreamReader csvFileStream;
        public List<string> stringList { set;  get; }
    }
}
