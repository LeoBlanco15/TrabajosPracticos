using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using Exepciones;

namespace Archivos
{
    public class Xml<T> : IArchivo<T>
    {
        public bool Guardar(string archivo, T datos)
        {
            
            using (XmlTextWriter writer = new XmlTextWriter(archivo, Encoding.UTF8))
            {
                XmlSerializer ser = new XmlSerializer(typeof(T));
                ser.Serialize(writer, datos);
            }
            if (File.Exists(archivo))
            {
                return true;
            }
            else
            {
                throw new ArchivosException();
            }
        }
        public bool Leer(string archivo, out T datos)
        {
            using (XmlTextReader reader = new XmlTextReader(archivo))
            {
                XmlSerializer ser = new XmlSerializer(typeof(T));
                datos = (T)ser.Deserialize(reader);
            }
            if (File.Exists(archivo))
            {
                return true;
            }
            else
            {
                throw new ArchivosException();
            }
        }
    }
}
