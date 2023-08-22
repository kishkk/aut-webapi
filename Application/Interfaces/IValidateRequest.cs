using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IValidateRequest
    {
        public bool ValidateXml(string strXML, string strXSD);
    }
}
