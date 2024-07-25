using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XmlFirstProject
{
    internal class Employee
    {
        private string Path = "/Employees/Employee";
        public XmlDocument XmlDocument { get; set; }
        public Employee (XmlDocument xmlDocument)
        {
            XmlDocument =  xmlDocument;
        }
        public void GetAllEmployees(XmlNodeList  xmlNodeList = null)
        {
            if (xmlNodeList == null)
            {
                xmlNodeList = XmlDocument.SelectNodes(Path);

            }
            foreach (XmlNode children in xmlNodeList)
            {
                if (children.Attributes != null)
                {
                    foreach (XmlAttribute attribute in children.Attributes)
                    {
                        
                        Console.WriteLine(attribute.Name + "=" + attribute.Value);
                    }
                }
                if (children.ChildNodes != null)
                {
                    GetAllEmployees(children.ChildNodes);
                }
            }           
        }
        private XmlNode FindEmployeeById(string employeeId, XmlNode parentNode)
        {
            // Search for Employee node with matching ID
            foreach (XmlNode node in parentNode.ChildNodes)
            {
                if (node.Name == "Employee" && node.Attributes != null && node.Attributes["id"]?.Value == employeeId)
                {
                    return node;
                }
                else
                {
                    // Recursively search in child nodes
                    XmlNode foundNode = FindEmployeeById(employeeId, node);
                    if (foundNode != null)
                    {
                        return foundNode; // Found in child nodes
                    }
                }
            }return null;
        }
        private void PrintEmployeeDetails(XmlNode employeeNode)
        {
            //foreach()
        }
        public void GetONeEmployeeId(string id )
        {
            XmlNode employee = XmlDocument.SelectSingleNode(Path+"[@id=" + id + "]");
            if (employee == null)
            {
                return;
            }
            if (employee.Attributes != null)
                foreach (XmlAttribute attribute in employee.Attributes)
                {
                    Console.WriteLine(attribute.Name + " : " + attribute.Value);
                }
                if (employee.ChildNodes != null)
                {
                    GetAllEmployees(employee.ChildNodes);
                }

        }
    }
}
