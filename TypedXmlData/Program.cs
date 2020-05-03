using System;
using System.Xml;

namespace TypedXmlData
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "Items.xml";
            WriteXmlFile(fileName);
            ReadXmlFile(fileName);
        }

        static void WriteXmlFile(string fileName)
        {
            XmlWriterSettings settings =
           new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = "  ";
            settings.NewLineOnAttributes = true;

            using (XmlWriter writer =
                XmlWriter.Create(fileName, settings))
            {
                writer.WriteStartElement("Items");
                writer.WriteStartElement("Item");
                writer.WriteStartElement("Id");
                writer.WriteValue(10);
                writer.WriteEndElement();
                writer.WriteElementString(
                        "Name", "Rye Bread");
                writer.WriteStartElement("Price");
                writer.WriteValue((double)5.50);
                writer.WriteEndElement();
                writer.WriteEndElement();
                writer.WriteEndElement();
                writer.Flush();
            }
        }

        static void ReadXmlFile(string fileName)
        {
            using (XmlReader reader =
                        XmlReader.Create(fileName))
            {
                while (reader.Read())
                {
                    if (reader.IsStartElement())
                    {
                        switch (reader.Name)
                        {
                            case "Id":
                                Console.WriteLine(
                                                  "Id: {0}", reader.
                                                  ReadElementContentAsInt());
                                break;
                            case "Name":
                                Console.WriteLine(
                                "Name: {0}", reader.
              ReadElementContentAsString());
                                break;
                            case "Price":
                                Console.WriteLine(
                                "Price: {0}", reader.
                                ReadElementContentAsDouble());
                                break;
                        }
                    }
                }
            }
        }

    }
}
