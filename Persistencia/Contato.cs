using System;                               
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Persistencia
{
    public class Contato
    {
        private string arquivo = "c:\\temp\\agenda.xml";

        public void Insert(Modelo.Contato c)
        {
            List<Modelo.Contato> agenda = abrirArquivo();
            agenda.Add(c);
            salvarArquivo(agenda);
        }

        public List<Modelo.Contato> Select()
        {
            return abrirArquivo();
        }

        private List<Modelo.Contato> abrirArquivo()
        {
           
            List<Modelo.Contato> contatos = null;
            try
            {
                using (StreamReader sr = new StreamReader(arquivo))
                {
                    XmlSerializer xml = new XmlSerializer(typeof(List<Modelo.Contato>));
                    contatos = (List<Modelo.Contato>)xml.Deserialize(sr);
                }
            }

            catch
            {
                contatos = new List<Modelo.Contato>();
            }

            return contatos;
        }

        private void salvarArquivo(List<Modelo.Contato> agenda)
        {
            StreamWriter sw = new StreamWriter(arquivo);
            XmlSerializer xml = new XmlSerializer(typeof(List<Modelo.Contato>));
            xml.Serialize(sw, agenda);
            sw.Close();
        }

    }
}
