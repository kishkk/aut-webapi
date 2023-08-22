using Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Infrastructure.Respositories
{
    public class UsageTracker : IUsageTracker
    {
        private readonly IValidateRequest _validate;

        public UsageTracker(IValidateRequest validate)
        {
            _validate = validate;
        }

        public string CreateTrackingRecord(string jsonData, string type, string batchNumber)
        {
            throw new NotImplementedException();
        }

        public Task<XmlDocument> ErrorDoc(string strErrorMessage)
        {
            throw new NotImplementedException();
        }

        public Task<XmlDocument> GetCurrentVersion(string strXmlData)
        {
            throw new NotImplementedException();
        }

        public Task<XmlDocument> GetCurrentVersionGroup(string strXmlData)
        {
            throw new NotImplementedException();
        }

        public Task<XmlDocument> GetStoredForm(string strXmlData)
        {
            throw new NotImplementedException();
        }

        public Task<XmlDocument> PostEngCodeValidation(string strXmlData)
        {
            throw new NotImplementedException();
        }

        public Task<XmlDocument> PostEngCodeValidationServiceCode(string strXmlData)
        {
            throw new NotImplementedException();
        }

        public Task<XmlDocument> PostLocatorValidation(string strXmlData)
        {
            throw new NotImplementedException();
        }

        public Task<XmlDocument> PostNewEntity(string strXmlData)
        {
            throw new NotImplementedException();
        }

        public Task<XmlDocument> PostSelectEngEntity(string strXmlData)
        {
            throw new NotImplementedException();
        }

        public Task<XmlDocument> PostUsageStatistics(string strXmlData)
        {
            throw new NotImplementedException();
        }
    }
}
