using System.Xml;
using XmlFirstProject;


XmlDocument xmlDocument = Main.main();
Employee employee = new Employee(xmlDocument);
employee.GetAllEmployees();
