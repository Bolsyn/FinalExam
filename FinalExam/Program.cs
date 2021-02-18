using System;
using System.IO;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace FinalExam
{
    class Program
    {
        static void Main(string[] args)
        {
            string text;

            Logger log = new Logger();

            // Должно поддерживаться логирование в форматах XML и JSON,

            //var serial = new XmlSerializer(log.GetType());
            //using (var stream = File.OpenRead("Logger.xml"))
            //{
            //    var result = serial.Deserialize(stream) as Logger;
            //}
            //string json;
            //using (StreamReader stream = new StreamReader("Logger.json"))
            //{
            //    json = stream.ReadLine();
            //}
            //var jsonResult = JsonConvert.DeserializeObject<Logger>(json);

            //string message = "hi";

            //text = $"{DateTime.Now},{log.TypeOfObject} ,{log.TypeOfMessage}, {message}";

            try
            {
                throw new NotImplementedException();
            }
            catch(Exception msg)
            {
                Write(msg);
            }
        }

        public static void Write(Exception ex)
        {
            string fullText = string.Format($"[{DateTime.Now}] [{ex.TargetSite.DeclaringType}.{ex.TargetSite.Name}({ex.GetType()})] {ex.Message}");

            using (var stream = File.AppendText($"{DateTime.Now.ToShortDateString()}.log"))
            {
                stream.WriteLine(fullText);
            }
        }
    }
}
