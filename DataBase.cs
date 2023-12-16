using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace LabWork_1
{
    public class DataBase
    {
        public static string[] WriteDB()
        { 
        string path = @"C:\ULSTU\1 course\A_SD\LabWork_1\Shopping list.txt";
        string[] db = File.ReadAllLines(path);            
            return db;
        }
    }
}
