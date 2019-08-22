using static System.Console;
using System.IO;

namespace DataProcessor
{
    internal class FileProcessor
    {
        public static readonly string BackupDirectoryName = "backup";
        public static readonly string InProgressDirectoryName = "processing";
        public static readonly string CompletedDirectoryName = "complete";

        public string InputFilePath { get; }
        

        public FileProcessor(string filePath)
        {
            InputFilePath = filePath;
        }

        public void Process()
        {
            WriteLine($"Begin process of {InputFilePath}");

            if (!File.Exists(InputFilePath))
            {
                WriteLine($"ERROR: file {InputFilePath} does not exist");
                return;
            }

            else
            { WriteLine("100% exist"); }

            //Check the parent directory name
            string rootDirectoryPath = new DirectoryInfo(InputFilePath).Parent.Parent.FullName;
            WriteLine($"The Paret Root data path is {rootDirectoryPath}");


            //Check if backup dir exists
            string inputFieldDirectoryPath = Path.GetDirectoryName(InputFilePath);
            string backupDirectoryPath = Path.Combine(rootDirectoryPath, BackupDirectoryName);

            if (!Directory.Exists(backupDirectoryPath))
            {
                WriteLine($"Creating {backupDirectoryPath}");
                Directory.CreateDirectory(backupDirectoryPath);
            }


        }

        
    }
}