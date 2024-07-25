using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DrinksVendingMachine
{
    internal class MainProject
    {
        public MainProject() { }
        private static string _pathString = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\.." + "\\Drinks.xml"));

        public static XmlDocument Main()
        {
            if (File.Exists(_pathString))
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(_pathString);
                return xmlDoc;
            }
            else
            {
                Console.WriteLine("file not found");
            }
            return null;
        }
        public static void Save(XmlDocument xmlDocument)
        {
            xmlDocument.Save(_pathString);
        }
    }
}
