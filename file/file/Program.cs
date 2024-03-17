using System;
using System.IO;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            //string sourcePath = @"C:\Users\FernandoGamer\Desktop\Projeto C#\file\file1.txt";
            //string targetPath = @"C:\Users\FernandoGamer\Desktop\Projeto C#\file\file2.txt";

            // File

            //try
            //{
            //    File.Copy(sourcePath, targetPath);
            //    string[] lines = File.ReadAllLines(sourcePath);
            //    foreach (string line in lines)
            //    {
            //        Console.WriteLine(line);
            //    }
            //} catch (IOException e) {
            //    Console.WriteLine("An error occurred");
            //    Console.WriteLine(e.Message);
            //}

            // FileInfo

            //try
            //{
            //    FileInfo fileInfo = new FileInfo(sourcePath);
            //    fileInfo.CopyTo(targetPath);
            //    string[] lines = File.ReadAllLines(sourcePath);
            //    foreach (string line in lines)
            //    {
            //        Console.WriteLine(line);
            //    }
            //} catch (IOException e) {
            //    Console.WriteLine("An error occurred");
            //    Console.WriteLine(e.Message);
            //}

            // StreamReader
            // Demo 1

            //string  path = @"C:\Users\FernandoGamer\Desktop\Projeto C#\file\file1.txt";
            //FileStream fs = null;
            //StreamReader sr = null;

            //try
            //{
            //    fs = new FileStream(path, FileMode.Open);
            //    sr = new StreamReader(fs);
            //    string line = sr.ReadLine();
            //    Console.WriteLine(line);
            //} 
            //catch (IOException e)
            //{
            //    Console.WriteLine("An error occurred");
            //    Console.WriteLine(e.Message);
            //}
            //finally
            //{
            //    if(sr != null) sr.Close();
            //    if(fs != null) fs.Close();
            //}

            //Demo 2

            //StreamReader sr = null;
            //try
            //{
            //    sr = File.OpenText(path);
            //    while (!sr.EndOfStream)
            //    {
            //        string line = sr.ReadLine();
            //        Console.WriteLine(line);
            //    }
            //} catch (IOException e) {
            //    Console.WriteLine("An error occurred");
            //    Console.WriteLine(e.Message);
            //}
            //finally
            //{
            //    if (sr != null) sr.Close();
            //}

            //Using block
            //Demo 1

            //string  path = @"C:\Users\FernandoGamer\Desktop\Projeto C#\file\file1.txt";

            //try
            //{
            //    using (FileStream fs = new FileStream(path, FileMode.Open))
            //    {
            //        using(StreamReader sr = new StreamReader(fs))
            //        {
            //            string line = sr.ReadLine();
            //            Console.WriteLine(line);
            //        }
            //    }
            //} catch (IOException e) {
            //    Console.WriteLine("An error occurred");
            //    Console.WriteLine(e.Message);
            //}

            //Demo2

            //try
            //{
            //    using (StreamReader sr = File.OpenText(path))
            //    {
            //        while (!sr.EndOfStream)
            //        {
            //            string line = sr.ReadLine();
            //            Console.WriteLine(line);
            //        }
            //    }
            //} catch (IOException e) {
            //    Console.WriteLine("An error occurred");
            //    Console.WriteLine(e.Message);
            //}

            //StreamWriter
            //Demo

            //string sourcePath = @"C:\Users\FernandoGamer\Desktop\Projeto C#\file\file1.txt";
            //string targetPath = @"C:\Users\FernandoGamer\Desktop\Projeto C#\file\file2.txt";

            //try
            //{
            //    string[] lines = File.ReadAllLines(sourcePath);

            //    using (StreamWriter sw = File.AppendText(targetPath))
            //    {
            //        foreach (String line in lines)
            //        {
            //            sw.WriteLine(line.ToUpper());
            //        }
            //    }
            //} catch (IOException e) {
            //    Console.WriteLine("An error occurred");
            //    Console.WriteLine(e.Message);
            //}

            //Directory, DirectoryInfo
            //Demo

            //string  path = @"C:\Users\FernandoGamer\Desktop\Projeto C#\file";

            //try
            //{
            //    var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
            //    Console.WriteLine("FOLDERS:");
            //    foreach (var s in folders)
            //    {
            //        Console.WriteLine(s);
            //    }

            //    var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
            //    Console.WriteLine("FILES:");
            //    foreach (string s in files)
            //    {
            //        Console.WriteLine(s);
            //    }

            //    Directory.CreateDirectory(@"C:\Users\FernandoGamer\Desktop\Projeto C#\file\newFolder");

            //} catch (IOException e) {
            //    Console.WriteLine("An error occurred");
            //    Console.WriteLine(e.Message);
            //}

            //Path
            //Demo

            string  path = @"C:\Users\FernandoGamer\Desktop\Projeto C#\file\file1.txt";

            Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar);
            Console.WriteLine("PathSeparator: " + Path.PathSeparator);
            Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(path));
            Console.WriteLine("GetFileName: " + Path.GetFileName(path));
            Console.WriteLine("GetExtension: " + Path.GetExtension(path));
            Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("GetFullPath: " + Path.GetFullPath(path));
            Console.WriteLine("GetTempPath: " + Path.GetTempPath());

        }
    }
}