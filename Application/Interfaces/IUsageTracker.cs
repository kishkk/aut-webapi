using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Application.Interfaces
{
    public interface IUsageTracker
    {
        public Task<XmlDocument> GetCurrentVersion(string strXmlData);
        public Task<XmlDocument> PostUsageStatistics(string strXmlData);
        public Task<XmlDocument> PostEngCodeValidation(string strXmlData);
        public Task<XmlDocument> PostEngCodeValidationServiceCode(string strXmlData);
        public Task<XmlDocument> PostLocatorValidation(string strXmlData);
        public Task<XmlDocument> GetStoredForm(string strXmlData);
        public Task<XmlDocument> GetCurrentVersionGroup(string strXmlData);
        public Task<XmlDocument> PostNewEntity(string strXmlData);
        public Task<XmlDocument> PostSelectEngEntity(string strXmlData);
        public Task<XmlDocument> ErrorDoc(string strErrorMessage);
        public string CreateTrackingRecord(string jsonData, string type, string batchNumber);
    }
}
