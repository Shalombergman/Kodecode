// See https://aka.ms/new-console-template for more information
using System.Xml;

Console.WriteLine("Hello, World!");

namespace XmlSimpleProject
{
    public class Program
    {

        public static void Main()
        {
            //הגדרת קובץ לעבודה
                string _pathString = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\.." + "\\Macabi.xml"));
                XmlDocument xmlDoc;

                //קריאת קובץ במידה וקיים
                if (File.Exists(_pathString))
                {
                    xmlDoc = new XmlDocument();
                    xmlDoc.Load(_pathString);
                    
                }
                else //אם הקובץ לא קיים נייצר אותו עם נוד ראשון
                {
                    xmlDoc = new XmlDocument();
                    XmlNode MacabiPlayer = xmlDoc.CreateElement("Macabi");
                    xmlDoc.AppendChild(MacabiPlayer);
                    
                }
                //הוספת מספר שחקנים למכבי
                // נייצר את המבנה
                XmlNode onePlayerNode = xmlDoc.CreateElement("Player");
                XmlNode playerFirstName = xmlDoc.CreateElement("FirstName");
                XmlNode playerLastName = xmlDoc.CreateElement("LastName");

                playerFirstName.InnerText = "Eran";
                playerLastName.InnerText = "Zeavi";
                XmlNode? rootNode = xmlDoc.FirstChild;
                if (rootNode != null)
                {
                    rootNode.AppendChild(onePlayerNode);
                }
                xmlDoc.Save(_pathString);

                

               
           


        }
    }
}
