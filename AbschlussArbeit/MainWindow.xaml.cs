using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using Microsoft.Win32;
using MatrixObj;

namespace AbschlussArbeit
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MatrixObj.MatrixObj matrix;
        String filePath;
        public MainWindow()
        {
            filePath = null;
            InitializeComponent();
        }

        private void OpenFileDialog_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = false;
            fileDialog.Filter = "CSV Files (*.csv) |*.csv";
            //fileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (fileDialog.ShowDialog() == true)
            {
                filePath = fileDialog.FileName;
                setFilePathInLineEdit(filePath);
            }
            matrix = new MatrixObj.MatrixObj(filePath);
            List<string> TestList = matrix.TestStringList;
            List<string> LearningList = matrix.LearningStringList;
            Console.Write(LearningList.Count);
            for (int i = 0; i < LearningList.Count; i++)
                Console.WriteLine("Line: "+ i.ToString() + " " + LearningList[i] + "\n");
            Console.Write("Header: " + matrix.header + "\n");
            for (int i = 0; i < TestList.Count; i++ )
                Console.WriteLine("TestLine: " + i.ToString() + " " + TestList[i] + "\n");
        }
        private void setFilePathInLineEdit(string path)
        {
            w_FileEdit.Text = path;
        }


    }
}
