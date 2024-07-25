using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using static System.Windows.Forms.LinkLabel;

namespace DrinksVendingMachine
{
    internal class DrinksController
    {
        private string Path = "/drinks/drink";
        private XmlDocument _document;
        private XmlNodeList _nodes;
        public DrinksController(XmlDocument doc)
        {
            _document = doc;
        }
        public List<List<string>> GetDrinksData(XmlNodeList xmlDrinkList = null)
        {
            List<List<string>> allDrink = new List<List<string>>();
            xmlDrinkList = _document.SelectNodes(Path);
            if (xmlDrinkList.Count > 0)
            {
                foreach (XmlNode drink in xmlDrinkList)
                {
                    List<string> drinkList = new List<string>();
                    if (drink.ChildNodes != null)
                    {
                        foreach (XmlNode drinkData in drink.ChildNodes)
                        {
                            drinkList.Add(drinkData.InnerText);
                        }
                    }
                    allDrink.Add(drinkList);

                }
                return allDrink;
            }
            return null;
        }
        //מחזירה את האלמנט הראשי
        private XmlNode GetRoot()
        {
            return _document.GetElementsByTagName("drinks")[0];
        }
        public void AddDrinks(List<string> drinks)
        {
            XmlElement drinkElement = _document.CreateElement("drink");
            List<string> tagsName = new List<string>();
            tagsName.Add("price");
            tagsName.Add("sugar");
            tagsName.Add("coffee");
            tagsName.Add("cacao");
            tagsName.Add("milk");
            tagsName.Add("name");
            for (int i = 0; i < tagsName.Count; i++)
            {
                XmlElement child = _document.CreateElement(tagsName[i]);
                child.InnerText = drinks[i];
                drinkElement.AppendChild(child);
            }
            GetRoot().AppendChild(drinkElement);
        }
        public void UpdateDrink(int index, List<string> updatedDrink)
        {
            XmlNodeList drinkNodes = _document.SelectNodes("drink");
            if (index >= 0 && index < drinkNodes.Count)
            {
                XmlNode drinkNode = drinkNodes[index];
                List<string> tagsName = new List<string>();
                {
                    tagsName.Add("price");
                    tagsName.Add("sugar");
                    tagsName.Add("coffee");
                    tagsName.Add("cacao");
                    tagsName.Add("milk");
                    tagsName.Add("name");
                    for (int i = 0; i < tagsName.Count(); i++)
                    {
                        XmlNode childNode = drinkNode.SelectSingleNode(tagsName[i]);
                        if (childNode != null)
                        {
                            childNode.InnerText = updatedDrink[i];
                        }
                        else
                        {
                            XmlElement newChild = _document.CreateElement(tagsName[i]);
                            newChild.InnerText = updatedDrink[i];
                            drinkNode.AppendChild(newChild);
                        }

                    }
                }
            }
            else
            {
                throw new IndexOutOfRangeException("Index is out of range.");
            }

            // XmlNode drinkNode = drinkNodes[index];
        }


        //List<string> tagsName = new List<string>();
        public List<string> GetDrinksByName(string name)
        {
            List<string> list = null;
            XmlNodeList drinkList = _document.GetElementsByTagName("name");
            if (drinkList == null) return null;
            foreach (XmlNode drink in drinkList)
            {
                if (drink.InnerText == name)
                {
                    list = GetAllData(drink.ParentNode);
                    return list;
                    
                }
            }
            return list;
        }
        private List<string> GetAllData(XmlNode drink)
        {
            List<string> list = new List<string>();
            foreach (XmlNode child in drink.ChildNodes)
            {
                list.Add(child.InnerText);
            }
            return list;
        }


        public void Save()
        {
            MainProject.Save(_document);
        }
        public void UpdateDrink(List<string> drinks)
        {
            XmlNodeList drinkList = _document.GetElementsByTagName("name");
            
            if (drinkList == null) return;
            foreach (XmlNode drink in drinkList)
            {
                if (drink.InnerText == drinks[drinks.Count - 1])
                {
                    int i = 0;
                    foreach (XmlNode child in drink.ParentNode)
                    {
                        child.InnerText = drinks[i++];
                    }
                }
            }
        }
        public void DeleteDrink(List<string> drink)
        {
            XmlNodeList drinkList = _document.GetElementsByTagName("name");

            if (drinkList == null) return;
            foreach (XmlNode drinkName in drinkList)
            {
                if (drinkName.InnerText == drink[drink.Count - 1])
                {
                    XmlNode fullDrink= drinkName.ParentNode;
                    fullDrink.ParentNode.RemoveChild(fullDrink);
                    break;
                }
            }
        }


    }
}
