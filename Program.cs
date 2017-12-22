using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;


/*1.	С помощью класса XDocument прочитать XML файл
 * и вывести название всех его тегов с сохранением иерархии. В качестве отступов для иерархии использовать 2 пробела.*/


namespace XMLPractise
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("Users.xml");
            XDocument documentNew = new XDocument();

            XmlElement xRoot = xDoc.DocumentElement;
            documentNew.Tags.Add(xRoot.Name);
            documentNew.Tags.Add("  ");
            foreach (XmlNode xnode in xRoot)
            {
                documentNew.Tags.Add(xnode.Name);
                documentNew.Tags.Add(" ");
                // обходим все дочерние узлы элемента user
                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    documentNew.Tags.Add(childnode.Name);
                    documentNew.Tags.Add(" ");
                }
                documentNew.Tags.Add("  ");
            }


            for (int i = 0; i < documentNew.Tags.Count; i++)
            {
                Console.Write(documentNew.Tags[i]);
            }
            Console.ReadLine();

        }
    }
}
