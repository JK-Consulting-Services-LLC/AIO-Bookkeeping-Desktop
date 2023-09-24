using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design;
using System.Xml;

namespace AIO_Bookkeeping
{
    public class Company
    {
        private string fileName;
        private Dictionary<string, object> company;
        public Company(string newFileName) {
            this.fileName = newFileName;
            this.LoadCompany();
        }

        public void SwitchCompany(string newFileName)
        {
            this.SaveCompany();
            this.fileName = newFileName;
            this.LoadCompany();
        }

        private void LoadCompany()
        {

        }

        public void SaveCompany()
        {
            Stream s = File.Open(this.fileName, FileMode.Create) as Stream;
            XmlWriter writer = XmlWriter.Create(s);
            writer.WriteStartDocument();
            writer.WriteStartElement("aiobkp", "root", "http://ns");
            writer.WriteStartElement("companyinfo");
            writer.WriteStartElement("name");
            writer.WriteString("");
            writer.WriteEndElement();
            writer.WriteEndElement();
            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Flush();
            writer.Close();
            s.Close();
        }
    }
}
