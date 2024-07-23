using System.Configuration;
using System.Text.Json;
using ListOfObjectSerializeDeserialize.Models;

namespace ListOfObjectSerializeDeserialize
{
    internal class Program
    {
        static string path = ConfigurationManager.AppSettings["filePath"]!.ToString();
        static List<Person> persons = new List<Person>()
            {
            new Person(1, "Ashish", 18),
            new Person(2, "Ajay", 19),
            new Person(3, "Binod", 20),
            new Person(4, "Vijay", 25),
            new Person(5, "Surya", 21)
            };

        static void Main(string[] args)
        {
            //Write();
            if (File.Exists(path))
            {
                Read();
            }
            else
            {
                Console.WriteLine("Creating a Json File");
                Write();
            }
            
        }

        static void Write()
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                foreach (Person person in persons)
                {

                    sw.WriteLine(JsonSerializer.Serialize(person));
                }
            }

        }

        static void Read()
        {
            using (StreamReader sr = new StreamReader(path))
            {
                int count = 0;
                while (!sr.EndOfStream)
                {
                    Person person = JsonSerializer.Deserialize<Person>(sr.ReadLine());
                    count++;
                    Console.Write(person);
                    Console.WriteLine("Person Number = " +count+"\n");
                }
            }
        }
    }
}
