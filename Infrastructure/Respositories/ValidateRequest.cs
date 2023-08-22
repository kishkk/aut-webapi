using Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using System.Xml;

namespace Infrastructure.Respositories
{
    public class ValidateRequest : IValidateRequest
    {
        public bool ValidateXml(string strXML, string strXSD)
        {
            try
            {
                XmlReaderSettings ReadSet = new XmlReaderSettings();
                ReadSet.Schemas.Add(null, strXSD);
                ReadSet.ValidationType = ValidationType.Schema;
                ReadSet.ValidationFlags = XmlSchemaValidationFlags.ReportValidationWarnings;
                ReadSet.ValidationEventHandler += new ValidationEventHandler(ValidationCallBack);

                StringReader xmlStream = new StringReader(strXML);
                XmlReader xlrReader = XmlReader.Create(xmlStream, ReadSet);
                while (xlrReader.Read()) ;

                Console.WriteLine("XML Loaded.");
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: ");
                Console.WriteLine(e.Message);
                return false;
            }
        }

        private static void ValidationCallBack(object sender, ValidationEventArgs args)
        {
            if (args.Severity == XmlSeverityType.Warning)
            {
                throw new Exception("\tWarning: Matching schema not found.  No validation occurred." + args.Message);
            }
            else
            {
                throw new Exception("\tValidation error: " + args.Message);
            }
        }
    }
}
