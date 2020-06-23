using System;
using System.IO;

namespace ex_fixacao_arquivos
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Source path: ");
            string sourcePath = @Console.ReadLine();
            try
            {
                string sourceFolderPath = Path.GetDirectoryName(sourcePath);
                string targetFolderPath = sourceFolderPath + @"\out";
                string targetFilePath = targetFolderPath + @"\summary.csv";
                Directory.CreateDirectory(targetFolderPath);

                string[] lines = File.ReadAllLines(sourcePath);

                foreach(String x in lines)
                {
                    string[] conteudos = x.Split(",");
                    String final = conteudos[0] + ", " + (Double.Parse(conteudos[1]) * Double.Parse(conteudos[2]));
                    using (StreamWriter sw = File.AppendText(targetFolderPath + @"\sumamary.csv"))
                    {
                        sw.WriteLine(final);
                    }
                }

            }catch(IOException e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
