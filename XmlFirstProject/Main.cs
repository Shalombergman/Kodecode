// See https://aka.ms/new-console-template for more information
using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml;

namespace XmlFirstProject
{
    public class Main
    {
        public static XmlDocument main()
        {
            //--xml --
            //classes we are dealing with:
            //Directory ,path --> Services for Directory and file accses
            //xmldocument --> Class that the xml file
            //XmlNode --> class that represents a single (attributes, inner Nodse)
            Console.WriteLine("Hello, World!");
            //1. Read the xml file from system
            //defin  the location of the file in the file system
            string pathString = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\.." + "\\Employees.xml"));
            Console.WriteLine("Project Directory :" + pathString);
            //string pathString = "Employees.xml";
            //Ceack if file exists
            if (File.Exists(pathString))
            {
                //1.3 create a new instans of type  XmlDocument
                XmlDocument xmlDoc = new XmlDocument();
                //1.4 try and load the xml content XmlDocument object
                xmlDoc.Load(pathString);
                return xmlDoc;               
            }
            else
            {
                Console.WriteLine("file not found");
            }
            return null;

            //2. search for employee2


            //3.search for all employees

            //xmlDoc.SelectNodes()

            //xmlDoc.GetElementsByTagName();
            //try
            //{

            //}

            //2. search for employee2

            //3.search for all employees

            //4.search for new employee - ...


        }
    }


}