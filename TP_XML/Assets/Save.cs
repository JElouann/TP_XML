using System.Xml;
using UnityEngine;

public class Save : MonoBehaviour
{
    static void WriteXML(XmlWriter writer, string key, string value)
    {
        writer.WriteStartElement(key);
        writer.WriteString(value);
        writer.WriteEndElement();
    }
}
