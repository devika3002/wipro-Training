//creating a file using File.Create() method in default directory
using System;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.IO.Pipelines;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.VisualBasic;
using FileHandling;

namespace FileHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "demo.txt";
            using (FileStream fs = File.Create(filePath))
            {
                // File created successfully
                if (File.Exists(filePath))
                {
                    Console.WriteLine("File created successfully: " + filePath);
                }
                
            }
            //Writing to the file using StreamWriter class
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.WriteLine("Hello, this is a demo file created today.");
                sw.WriteLine("This file is created to demonstrate file handling in C#.");
            }
            //Reading from the file using streamReader class
            using (StreamReader sr =new StreamReader(filePath))
            {
                string content = sr.ReadToEnd();
                Console.WriteLine("here are the File content:");
                Console.WriteLine(content);
            }
                //Deleting the file using File.Delete
        }
    }
}

