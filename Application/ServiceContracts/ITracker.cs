using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Application.Interfaces
{
    public interface ITracker
    {
        public Task<string> GetPackageType(string strXmlData);

    }
}
