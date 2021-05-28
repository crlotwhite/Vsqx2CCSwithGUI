using System.Windows.Forms;
using System.Xml;
using System.Xml.Schema;

namespace Vsqx2CCS
{
    class SchemaCheck
    {
        public static void XMLSchemaCheck(string vsqxXsd, string currentFileName)
        {
            XmlSchema schema = null;
            XmlSchemaSet schemaSet = new XmlSchemaSet();
            schemaSet.Add("http://www.yamaha.co.jp/vocaloid/schema/vsq3/", vsqxXsd);

            foreach (XmlSchema s in schemaSet.Schemas())
            {
                schema = s;
            }

            XmlDocument xdoc = new XmlDocument();
            xdoc.Schemas.Add(schema);
            xdoc.Load(currentFileName);
            xdoc.Validate(ValidationCallBack);
        }

        private static void ValidationCallBack(object sender, ValidationEventArgs args)
        {
            if (args.Severity == XmlSeverityType.Error)
            {
                //return false;
                MessageBox.Show("Error: " + args.Message);
            }
            //return true;
        }
    }
}
