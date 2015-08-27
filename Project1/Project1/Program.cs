using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Project1
{
    // Класс объекты, которого мы будет серериализовывать в xml-файл
    [Serializable]
    public class DataInput
    {
        public string Field1 { get; set; }
        public string Field2 { get; set; }
        public string Field3 { get; set; }
    }
    // Класс с необходимой функциональностью для получения данных и их обработки
    class GetData
    {
        public string FilePath { get; set; }
        public Encoding TextEncoding { get; set; }
        public GetData(string path, Encoding encoding)
        {
            FilePath = path;
            TextEncoding = encoding;
        }
        // Считываем данные с файла и преобразуем их в массив строк.
        public string[] ConvertFileData()
        {
            String[] strokes = File.ReadAllLines(FilePath, TextEncoding);
            return strokes; // выводим массив каждый элемент которого строка из файла
        }
        // преобразуем данные из массива строк в объекты
        public List<DataInput> GetObjects(string[] arrayInput)
        {
            List<DataInput> objects = new List<DataInput>(); // коллекция для хранения объектов
            foreach (var s in arrayInput)
            {
                string[] substrokes = s.Split(',').ToArray(); // форматируем каждый элемент входного массива
                var dataInput = new DataInput() // и создаем на его основе объект
                {
                    Field1 = substrokes[0],
                    Field2 = substrokes[1],
                    Field3 = substrokes[2]
                };
                objects.Add(dataInput);
            }
            return objects;
        }
        // Сериализация объектов
        public void ObjectSerializer(List<DataInput> input) // метод принимает коллекцию объектов и преобразовывает их в xml-документ
        {
            XmlSerializer formatter = new XmlSerializer(typeof(List<DataInput>));
            using (FileStream fs = new FileStream(@"C:\Users\User_Name\Desktop\ObjectData.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, input);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            GetData file = new GetData(@"C:\Users\User_Name\Desktop\text.txt", Encoding.Default);
            string[] array = file.ConvertFileData();
            List<DataInput> list = new List<DataInput>();
            list = file.GetObjects(array);
            file.ObjectSerializer(list);
            Console.WriteLine("All Done");
            Console.ReadLine();
        }
    }
}

