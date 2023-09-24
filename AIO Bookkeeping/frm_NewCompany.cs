using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIO_Bookkeeping
{
    using System.IO;
    using System.Xml;

    public partial class frm_NewCompany : Form
    {
        public frm_NewCompany()
        {
            InitializeComponent();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_SaveNewCompany_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "AIO Bookkeeping Files (*.aiobkp)|*.aiobkp";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
                Stream s = File.Open(FileName, FileMode.Create) as Stream;
                XmlWriter writer = XmlWriter.Create(s);
                writer.WriteStartDocument();
                writer.WriteStartElement("aiobkp", "root", "http://ns");
                writer.WriteStartElement("companyinfo");
                writer.WriteStartElement("name");
                writer.WriteString(txt_CompanyName.Text);
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
}
