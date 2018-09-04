using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.XPath;

namespace HW_XML_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        public static void Menu()
        {
            bool inProgress = true;

            while (inProgress)
            {
                Console.WriteLine(new string('-', 80));
                Console.WriteLine("\t\t\t\tОсновы XML.");              
                Console.WriteLine(new string('-', 80));

                Console.WriteLine("" +
                    "1. Задание 1. \n" +
                    "2. Задание 2. \n" +
                    "3. Выход\n");
                Console.WriteLine(new string('-', 80));
                Console.Write("> ");

                int ch = 0;
                Int32.TryParse(Console.ReadLine(), out ch);

                switch (ch)
                {
                    case 1:
                        {
                            ///<summary>
                            ///<rootLevel>
                            ///  <!-- Глубина влеженности 1 --> 
                            ///  <level1 id="1"> 
                            ///    <!-- Глубина влеженности 2 --> 
                            ///    <level2 id="2"> 
                            ///      <!-- Глубина влеженности 3 --> 
                            ///      <level3 id="3"> 
                            ///        <!-- Глубина влеженности 4 --> 
                            ///        <level4 id="4"> 
                            ///          <levelLast id="5">Element_1</levelLast> 
                            ///          <!-- Дочерний элемент 1 --> 
                            ///          <levelLast id="5">Element_2</levelLast> 
                            ///          <!-- Дочерний элемент 2--> 
                            ///          <levelLast id="5">Element_3</levelLast> 
                            ///          <!-- Дочерний элемент 3 --> 
                            ///          <levelLast id="5">Element_4</levelLast> 
                            ///          <!-- Дочерний элемент 4 -->
                            ///          <levelLast id="5">Element_5</levelLast>
                            ///          <!-- Дочерний элемент 5 -->          
                            ///        </level4>
                            ///      </level3> 
                            ///    </level2> 
                            ///  </level1> 
                            ///</rootLevel>  
                            /// </summary>
                            
                            Task1();
                        }
                        break;
                    case 2:
                        {
                            ///<summary>
                            ///<?xml version="1.0" encoding="windows-1251" ?>
                            ///<tovar> 
                            ///  <naim>Бензин</naim> 
                            ///  <price>20</price> 
                            ///</tovar>
                            ///</summary>
                            Task2();
                        }
                        break;
                    case 3:
                        {
                            inProgress = false;
                        }
                        break;
                    default:
                        Console.WriteLine("Повторите ввод");
                        break;
                }

            }

        }

        static void Task1()
        {
            
            XmlDocument doc = new XmlDocument();
            doc.Load("Task1.xml");

            // Получаем корневой элемент
            XmlElement xRoot = doc.DocumentElement;

            // выбор всех дочерних узлов
            XmlNodeList childnodes = xRoot.SelectNodes("*");

            Console.WriteLine(new string('-', 50));
            Console.WriteLine("Исходный файл: ");
            Console.WriteLine(new string('-', 50));

            foreach (XmlNode n in childnodes)
            {
                Console.WriteLine(n.OuterXml);
                Console.WriteLine();
            }

            XmlNodeList childnodes2 = xRoot.SelectNodes("//levelLast");

            Console.WriteLine(new string('-', 50));
            Console.WriteLine("Вывод информации: ");
            Console.WriteLine(new string('-', 50));

            foreach (XmlNode n in childnodes2)
            {
                Console.WriteLine(n.InnerText);
            }

            Console.WriteLine();
            
        }

        static void Task2()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("1.xml");

            // Получаем корневой элемент
            XmlElement xRoot = doc.DocumentElement;

            // выбор всех дочерних узлов
            XmlNodeList childnodes = xRoot.SelectNodes("*");

            Console.WriteLine(new string('-', 50));
            Console.WriteLine("Исходный файл: ");
            Console.WriteLine(new string('-', 50));

            foreach (XmlNode n in childnodes)
            {
                Console.WriteLine(n.OuterXml);
            }

            XmlNodeList childnodes2 = xRoot.SelectNodes("*");

            Console.WriteLine(new string('-', 50));
            Console.WriteLine("Вывод информации: ");
            Console.WriteLine(new string('-', 50));

            foreach (XmlNode n in childnodes2)
            {
                Console.WriteLine(n.InnerText);
            }

            Console.WriteLine();


        }
    }
}
