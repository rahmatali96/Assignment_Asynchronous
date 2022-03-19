using System;
using System.IO;
namespace Assignment_Asynchronous
{
    public class Program
    {
        static async Task <string[]> Read(string Filename)
        {
            var ReadData = await File.ReadAllLinesAsync(Filename);
            return ReadData; 
        }
        static async Task Write(string[] WriteData,string Filename)
        {
            await File.WriteAllLinesAsync(Filename, WriteData);
            System.Console.WriteLine("File A.txt content coppied in File B.txt");
        }
        public static async Task CopyContent()
        {
            var Content = Read("A.txt");
            await Write(Content.Result,"B.txt");
        }
        public static void Main(string[] args)
        {
            CopyContent();
        }        
    }
}